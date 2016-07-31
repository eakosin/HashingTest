using CryptSharp.Utility;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace HashTest
{
    public partial class HashingTest : Form
    {
        public HashingTest()
        {
            InitializeComponent();
        }

        private void scryptUpdateStatistics(object sender, EventArgs e)
        {
            scryptMemoryCostTextbox.Text = "";
            scryptBufferMixCoverageTextbox.Text = "";
            try
            {
                int cost = Int32.Parse(scryptCostTextbox.Text);
                int blockSize = Int32.Parse(scryptBlockSizeTextbox.Text);
                int memoryUsageBytes = (128 * cost * blockSize);
                string memoryUsageString;
                if (memoryUsageBytes >= 1073741824)
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

                if ((1024.0 * (double)blockSize) > ((double)cost * Math.Log((double)cost)))
                {
                    scryptBufferMixCoverageTextbox.Text = "Buffer is under mixed: 1024r > NlogN";
                }
                else
                {
                    scryptBufferMixCoverageTextbox.Text = "Good";
                }
            }
            catch
            {
                // Do nothing...
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            HashingTimeTextbox.Text = "";
            HashResultTextbox.Text = "";
            Stopwatch stopwatch = new Stopwatch();
            if (scryptOption.Checked)
            {
                int cost, blockSize, parallel, derivedKeyLength;
                try
                {
                    cost = Int32.Parse(scryptCostTextbox.Text);
                    blockSize = Int32.Parse(scryptBlockSizeTextbox.Text);
                    parallel = Int32.Parse(scryptParallelTextbox.Text);
                    derivedKeyLength = Int32.Parse(scryptDerivedKeyLengthTextbox.Text);
                }
                catch
                {
                    HashResultTextbox.Text = "Error - scrypt parameters failed to parse.";
                    StartButton.Enabled = true;
                    return;
                }
                byte[] hashResultBytes;
                byte[] passwordBytes = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
                byte[] saltBytes = Encoding.UTF8.GetBytes(SaltTextBox.Text);
                stopwatch.Start();
                hashResultBytes = SCrypt.ComputeDerivedKey(passwordBytes, saltBytes, cost, blockSize, parallel, null, derivedKeyLength);
                stopwatch.Stop();
                HashingTimeTextbox.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
                HashResultTextbox.Text = "SCRYPT:" + cost.ToString() + ":" + blockSize.ToString() + ":" + parallel.ToString() + ":" + Convert.ToBase64String(saltBytes) + ":" + Convert.ToBase64String(hashResultBytes);
            }
            else
            {
                int rounds;
                try
                {
                    rounds = Int32.Parse(bcryptRoundsTextbox.Text);
                }
                catch
                {
                    HashResultTextbox.Text = "Error - bcrypt parameters failed to parse.";
                    StartButton.Enabled = true;
                    return;
                }
                string hashResult;
                string salt = (SaltTextBox.Text.Length > 22) ? SaltTextBox.Text.Substring(0, 22) : SaltTextBox.Text;
                byte[] saltBytes = new byte[22];
                Encoding.UTF8.GetBytes(salt).CopyTo(saltBytes, 0);
                string prefixSalt = "$2a$" + rounds.ToString("00") + "$" + Convert.ToBase64String(saltBytes);
                stopwatch.Start();
                hashResult = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text, prefixSalt);
                stopwatch.Stop();
                HashingTimeTextbox.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
                HashResultTextbox.Text = hashResult;
            }
            StartButton.Enabled = true;
        }

    }
}
