using CryptSharp.Utility;
using System;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HashTest
{
	public partial class SCryptHashingTest : Form
	{
		private Thread hashingThread;

		public SCryptHashingTest()
		{
			InitializeComponent();
			scryptUpdateStatistics(null, null);
		}

		private void scryptUpdateStatistics(object sender, EventArgs e)
		{
			// Get scrypt parameters
			long cost = (long)scryptCostValue.Value;
			long blockSize = (long)scryptBlockSizeValue.Value;
			long parallel = (long)scryptParallelValue.Value;

			// Calculate scrypt memory usage: 128 * N * r * p
			long memoryUsageBytes = (128 * cost * blockSize * parallel);
			string memoryUsageString;

			// Make the value pretty.
			if ((Convert.ToString(cost, 2).Count(x => x == '1') != 1))
			{
				memoryUsageString = "Cost is not a power of 2.";
			}
			else if (memoryUsageBytes >= 1073741824)
			{
				memoryUsageString = ((double)memoryUsageBytes / 1073741824.0).ToString() + " GB";
			}
			else if (memoryUsageBytes >= 1048576)
			{
				memoryUsageString = ((double)memoryUsageBytes / 1048576.0).ToString() + " MB";
			}
			else if (memoryUsageBytes >= 1024)
			{
				memoryUsageString = ((double)memoryUsageBytes / 1024.0).ToString() + " KB";
			}
			else
			{
				memoryUsageString = memoryUsageBytes.ToString() + " bytes";
			}
			scryptMemoryCostTextbox.Text = memoryUsageString;

			// Check if the buffer is under-mixed:
			// http://stackoverflow.com/questions/11126315/what-are-optimal-scrypt-work-factors/33297994#33297994
			if ((1024.0 * (double)blockSize) > ((double)cost * Math.Log((double)cost)))
			{
				scryptBufferMixCoverageTextbox.Text = "Buffer is under mixed: 1024r > NlogN";
			}
			else
			{
				scryptBufferMixCoverageTextbox.Text = "Good";
			}
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
				scryptConfigurationContainer.Enabled = true;
			}
		}

		private void DoTheHashing()
		{
			// Validate Parameters
			if (Convert.ToString((int)scryptCostValue.Value, 2).Count(x => x == '1') != 1)
			{
				HashResultTextbox.Text = "Error(scrypt): Cost is not a power of 2.";
				return;
			}

			// Disable and clear UI elements
			StartButton.Text = "Cancel";
			PasswordSaltLayoutTable.Enabled = false;
			scryptConfigurationContainer.Enabled = false;
			HashingTimeTextbox.Text = "";
			HashResultTextbox.Text = "";

			Stopwatch stopwatch = new Stopwatch();

			// Get scrypt parameters
			int cost, blockSize, parallel, derivedKeyLength;
			cost = (int)scryptCostValue.Value;
			blockSize = (int)scryptBlockSizeValue.Value;
			parallel = (int)scryptParallelValue.Value;
			derivedKeyLength = (int)scryptDerivedKeyLengthValue.Value;

			byte[] hashResultBytes;

			// Build UTF8 byte arrays from password and salt
			byte[] passwordBytes = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
			byte[] saltBytes = Encoding.UTF8.GetBytes(SaltTextBox.Text);

			// Do the hashing
			stopwatch.Start();
			hashResultBytes = SCrypt.ComputeDerivedKey(passwordBytes, saltBytes, cost, blockSize, parallel, null, derivedKeyLength);
			stopwatch.Stop();

			// Display results
			HashingTimeTextbox.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
			HashResultTextbox.Text = "SCRYPT:" + cost.ToString() + ":" + blockSize.ToString() + ":" + parallel.ToString() + ":" + Convert.ToBase64String(saltBytes) + ":" + Convert.ToBase64String(hashResultBytes);

			// Cleanup
			GC.Collect();

			// Reset UI elements
			StartButton.Text = "Start";
			PasswordSaltLayoutTable.Enabled = true;
			scryptConfigurationContainer.Enabled = true;
		}

	}
}
