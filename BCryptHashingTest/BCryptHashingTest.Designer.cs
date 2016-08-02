namespace HashTest
{
    partial class BCryptHashingTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCryptHashingTest));
			this.PasswordSaltLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.SaltLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SaltTextBox = new System.Windows.Forms.TextBox();
			this.FormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.HashingProcessLayout = new System.Windows.Forms.TableLayoutPanel();
			this.HashingTimeLabel = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			this.HashingTimeTextbox = new System.Windows.Forms.TextBox();
			this.HashResultTextbox = new System.Windows.Forms.TextBox();
			this.bcryptConfigurationContainer = new System.Windows.Forms.GroupBox();
			this.bcryptConfigurationLayout = new System.Windows.Forms.TableLayoutPanel();
			this.bcryptRoundsLabel = new System.Windows.Forms.Label();
			this.bcryptRoundsValue = new System.Windows.Forms.NumericUpDown();
			this.PasswordSaltLayoutTable.SuspendLayout();
			this.FormLayoutTable.SuspendLayout();
			this.HashingProcessLayout.SuspendLayout();
			this.bcryptConfigurationContainer.SuspendLayout();
			this.bcryptConfigurationLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bcryptRoundsValue)).BeginInit();
			this.SuspendLayout();
			// 
			// PasswordSaltLayoutTable
			// 
			this.PasswordSaltLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.PasswordSaltLayoutTable.ColumnCount = 4;
			this.PasswordSaltLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.PasswordSaltLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.PasswordSaltLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.PasswordSaltLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.PasswordSaltLayoutTable.Controls.Add(this.PasswordLabel, 0, 0);
			this.PasswordSaltLayoutTable.Controls.Add(this.SaltLabel, 2, 0);
			this.PasswordSaltLayoutTable.Controls.Add(this.PasswordTextBox, 1, 0);
			this.PasswordSaltLayoutTable.Controls.Add(this.SaltTextBox, 3, 0);
			this.PasswordSaltLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PasswordSaltLayoutTable.Location = new System.Drawing.Point(10, 10);
			this.PasswordSaltLayoutTable.Margin = new System.Windows.Forms.Padding(9);
			this.PasswordSaltLayoutTable.Name = "PasswordSaltLayoutTable";
			this.PasswordSaltLayoutTable.RowCount = 1;
			this.PasswordSaltLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PasswordSaltLayoutTable.Size = new System.Drawing.Size(568, 28);
			this.PasswordSaltLayoutTable.TabIndex = 0;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PasswordLabel.Location = new System.Drawing.Point(4, 1);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(53, 26);
			this.PasswordLabel.TabIndex = 0;
			this.PasswordLabel.Text = "Password";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SaltLabel
			// 
			this.SaltLabel.AutoSize = true;
			this.SaltLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SaltLabel.Location = new System.Drawing.Point(301, 1);
			this.SaltLabel.Name = "SaltLabel";
			this.SaltLabel.Size = new System.Drawing.Size(25, 26);
			this.SaltLabel.TabIndex = 1;
			this.SaltLabel.Text = "Salt";
			this.SaltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PasswordTextBox.Location = new System.Drawing.Point(64, 4);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(230, 20);
			this.PasswordTextBox.TabIndex = 2;
			this.PasswordTextBox.Text = "Password";
			// 
			// SaltTextBox
			// 
			this.SaltTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SaltTextBox.Location = new System.Drawing.Point(333, 4);
			this.SaltTextBox.Name = "SaltTextBox";
			this.SaltTextBox.Size = new System.Drawing.Size(231, 20);
			this.SaltTextBox.TabIndex = 3;
			this.SaltTextBox.Text = "Salt";
			// 
			// FormLayoutTable
			// 
			this.FormLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.FormLayoutTable.ColumnCount = 1;
			this.FormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormLayoutTable.Controls.Add(this.PasswordSaltLayoutTable, 0, 0);
			this.FormLayoutTable.Controls.Add(this.HashingProcessLayout, 0, 2);
			this.FormLayoutTable.Controls.Add(this.bcryptConfigurationContainer, 0, 1);
			this.FormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormLayoutTable.Location = new System.Drawing.Point(0, 0);
			this.FormLayoutTable.Name = "FormLayoutTable";
			this.FormLayoutTable.RowCount = 3;
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.FormLayoutTable.Size = new System.Drawing.Size(588, 226);
			this.FormLayoutTable.TabIndex = 1;
			// 
			// HashingProcessLayout
			// 
			this.HashingProcessLayout.ColumnCount = 3;
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Controls.Add(this.HashingTimeLabel, 1, 0);
			this.HashingProcessLayout.Controls.Add(this.StartButton, 0, 0);
			this.HashingProcessLayout.Controls.Add(this.HashingTimeTextbox, 2, 0);
			this.HashingProcessLayout.Controls.Add(this.HashResultTextbox, 0, 1);
			this.HashingProcessLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingProcessLayout.Location = new System.Drawing.Point(4, 100);
			this.HashingProcessLayout.Name = "HashingProcessLayout";
			this.HashingProcessLayout.RowCount = 2;
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Size = new System.Drawing.Size(580, 122);
			this.HashingProcessLayout.TabIndex = 2;
			// 
			// HashingTimeLabel
			// 
			this.HashingTimeLabel.AutoSize = true;
			this.HashingTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingTimeLabel.Location = new System.Drawing.Point(164, 0);
			this.HashingTimeLabel.Name = "HashingTimeLabel";
			this.HashingTimeLabel.Size = new System.Drawing.Size(94, 33);
			this.HashingTimeLabel.TabIndex = 1;
			this.HashingTimeLabel.Text = "Hashing Time [ms]";
			this.HashingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StartButton
			// 
			this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StartButton.Location = new System.Drawing.Point(3, 3);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(155, 27);
			this.StartButton.TabIndex = 2;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// HashingTimeTextbox
			// 
			this.HashingTimeTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingTimeTextbox.Location = new System.Drawing.Point(264, 7);
			this.HashingTimeTextbox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.HashingTimeTextbox.Name = "HashingTimeTextbox";
			this.HashingTimeTextbox.ReadOnly = true;
			this.HashingTimeTextbox.Size = new System.Drawing.Size(313, 20);
			this.HashingTimeTextbox.TabIndex = 3;
			// 
			// HashResultTextbox
			// 
			this.HashResultTextbox.BackColor = System.Drawing.SystemColors.Window;
			this.HashingProcessLayout.SetColumnSpan(this.HashResultTextbox, 3);
			this.HashResultTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashResultTextbox.Location = new System.Drawing.Point(3, 36);
			this.HashResultTextbox.Multiline = true;
			this.HashResultTextbox.Name = "HashResultTextbox";
			this.HashResultTextbox.ReadOnly = true;
			this.HashResultTextbox.Size = new System.Drawing.Size(574, 83);
			this.HashResultTextbox.TabIndex = 0;
			// 
			// bcryptConfigurationContainer
			// 
			this.bcryptConfigurationContainer.Controls.Add(this.bcryptConfigurationLayout);
			this.bcryptConfigurationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bcryptConfigurationContainer.Location = new System.Drawing.Point(4, 48);
			this.bcryptConfigurationContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.bcryptConfigurationContainer.Name = "bcryptConfigurationContainer";
			this.bcryptConfigurationContainer.Size = new System.Drawing.Size(580, 45);
			this.bcryptConfigurationContainer.TabIndex = 1;
			this.bcryptConfigurationContainer.TabStop = false;
			this.bcryptConfigurationContainer.Text = "bcrypt";
			// 
			// bcryptConfigurationLayout
			// 
			this.bcryptConfigurationLayout.ColumnCount = 2;
			this.bcryptConfigurationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.bcryptConfigurationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bcryptConfigurationLayout.Controls.Add(this.bcryptRoundsLabel, 0, 0);
			this.bcryptConfigurationLayout.Controls.Add(this.bcryptRoundsValue, 1, 0);
			this.bcryptConfigurationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bcryptConfigurationLayout.Location = new System.Drawing.Point(3, 16);
			this.bcryptConfigurationLayout.Name = "bcryptConfigurationLayout";
			this.bcryptConfigurationLayout.RowCount = 1;
			this.bcryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.bcryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.bcryptConfigurationLayout.Size = new System.Drawing.Size(574, 26);
			this.bcryptConfigurationLayout.TabIndex = 0;
			// 
			// bcryptRoundsLabel
			// 
			this.bcryptRoundsLabel.AutoSize = true;
			this.bcryptRoundsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bcryptRoundsLabel.Location = new System.Drawing.Point(3, 0);
			this.bcryptRoundsLabel.Name = "bcryptRoundsLabel";
			this.bcryptRoundsLabel.Size = new System.Drawing.Size(71, 26);
			this.bcryptRoundsLabel.TabIndex = 0;
			this.bcryptRoundsLabel.Text = "Rounds [2^n]";
			this.bcryptRoundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bcryptRoundsValue
			// 
			this.bcryptRoundsValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bcryptRoundsValue.Location = new System.Drawing.Point(80, 3);
			this.bcryptRoundsValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.bcryptRoundsValue.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.bcryptRoundsValue.Name = "bcryptRoundsValue";
			this.bcryptRoundsValue.Size = new System.Drawing.Size(491, 20);
			this.bcryptRoundsValue.TabIndex = 1;
			this.bcryptRoundsValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// BCryptHashingTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 226);
			this.Controls.Add(this.FormLayoutTable);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BCryptHashingTest";
			this.Text = "BCrypt Hashing Test";
			this.PasswordSaltLayoutTable.ResumeLayout(false);
			this.PasswordSaltLayoutTable.PerformLayout();
			this.FormLayoutTable.ResumeLayout(false);
			this.HashingProcessLayout.ResumeLayout(false);
			this.HashingProcessLayout.PerformLayout();
			this.bcryptConfigurationContainer.ResumeLayout(false);
			this.bcryptConfigurationLayout.ResumeLayout(false);
			this.bcryptConfigurationLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bcryptRoundsValue)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PasswordSaltLayoutTable;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SaltLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox SaltTextBox;
        private System.Windows.Forms.TableLayoutPanel FormLayoutTable;
        private System.Windows.Forms.GroupBox bcryptConfigurationContainer;
        private System.Windows.Forms.TableLayoutPanel HashingProcessLayout;
        private System.Windows.Forms.TableLayoutPanel bcryptConfigurationLayout;
        private System.Windows.Forms.Label bcryptRoundsLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox HashResultTextbox;
        private System.Windows.Forms.Label HashingTimeLabel;
        private System.Windows.Forms.TextBox HashingTimeTextbox;
        private System.Windows.Forms.NumericUpDown bcryptRoundsValue;
    }
}

