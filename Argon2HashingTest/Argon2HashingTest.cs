using System;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Liphsoft.Crypto.Argon2;

namespace HashTest
{
	public partial class Argon2HashingTest : Form
	{
		private Thread hashingThread;

		public Argon2HashingTest()
		{
			InitializeComponent();
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			if (StartButton.Text == "Start")
			{
				// Start thread
				hashingThread = new Thread(new ThreadStart(DoTheHashing));
				hashingThread.Start();
			}
			else
			{
				// Abort thread
				hashingThread.Abort();

				// Cleanup
				hashingThread = null;
				GC.Collect();

				// Reset UI elements
				StartButton.Text = "Start";
				PasswordSaltLayoutTable.Enabled = true;
				argon2ConfigurationContainer.Enabled = true;
			}
		}

		private void DoTheHashing()
		{
			// Disable and clear UI elements
			StartButton.Text = "Cancel";
			PasswordSaltLayoutTable.Enabled = false;
			argon2ConfigurationContainer.Enabled = false;
			HashingTimeTextbox.Text = "";
			HashResultTextbox.Text = "";

			Stopwatch stopwatch = new Stopwatch();

			// Get scrypt parameters
			uint timeCost, memoryCost, parallelism, hashLength;
			timeCost = (uint)argon2TimeCostValue.Value;
			memoryCost = (uint)argon2MemoryCostValue.Value;
			parallelism = (uint)argon2ParallelismValue.Value;
			hashLength = (uint)argon2HashLengthValue.Value;

			Argon2Type argon2TypeSetting = argon2Argon2iOption.Checked ? Argon2Type.Argon2i : Argon2Type.Argon2d;

			string hashResult;

			// Build UTF8 byte arrays from password and salt
			byte[] passwordBytes = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
			byte[] saltBytes = Encoding.UTF8.GetBytes(SaltTextBox.Text);

			var hasher = new PasswordHasher(timeCost, memoryCost, parallelism, argon2TypeSetting, hashLength);

			// Do the hashing
			stopwatch.Start();
			hashResult = hasher.Hash(passwordBytes, saltBytes);
			stopwatch.Stop();

			// Display results
			HashingTimeTextbox.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
			HashResultTextbox.Text = hashResult;

			// Cleanup
			GC.Collect();

			// Reset UI elements
			StartButton.Text = "Start";
			PasswordSaltLayoutTable.Enabled = true;
			argon2ConfigurationContainer.Enabled = true;
		}

	}
}
