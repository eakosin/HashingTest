﻿using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HashTest
{
	public partial class BCryptHashingTest : Form
	{
		private Thread hashingThread;

		public BCryptHashingTest()
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
				bcryptConfigurationContainer.Enabled = true;
			}
		}

		private void DoTheHashing()
		{
			// Disable and clear UI elements
			StartButton.Text = "Cancel";
			PasswordSaltLayoutTable.Enabled = false;
			bcryptConfigurationContainer.Enabled = false;
			HashingTimeTextbox.Text = "";
			HashResultTextbox.Text = "";

			Stopwatch stopwatch = new Stopwatch();

			// Get bcrypt parameters
			int rounds;
			rounds = (int)bcryptRoundsValue.Value;

			string hashResult;

			// Trim or pad salt to 22 bytes, base64 encode, and prefix parameters
			string salt = (SaltTextBox.Text.Length > 22) ? SaltTextBox.Text.Substring(0, 22) : SaltTextBox.Text;
			byte[] saltBytes = new byte[22];
			Encoding.UTF8.GetBytes(salt).CopyTo(saltBytes, 0);
			string prefixSalt = "$2a$" + rounds.ToString("00") + "$" + Convert.ToBase64String(saltBytes);

			// Do the hashing
			stopwatch.Start();
			hashResult = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text, prefixSalt);
			stopwatch.Stop();

			// Display results
			HashingTimeTextbox.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
			HashResultTextbox.Text = hashResult;

			// Cleanup
			GC.Collect();

			// Reset UI elements
			StartButton.Text = "Start";
			PasswordSaltLayoutTable.Enabled = true;
			bcryptConfigurationContainer.Enabled = true;
		}

	}
}
