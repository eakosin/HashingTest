namespace HashTest
{
    partial class Argon2HashingTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Argon2HashingTest));
			this.PasswordSaltLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.SaltLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SaltTextBox = new System.Windows.Forms.TextBox();
			this.FormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.HashingProcessLayout = new System.Windows.Forms.TableLayoutPanel();
			this.StartButton = new System.Windows.Forms.Button();
			this.HashResultTextbox = new System.Windows.Forms.TextBox();
			this.HashingTimeLabel = new System.Windows.Forms.Label();
			this.HashingTimeTextbox = new System.Windows.Forms.TextBox();
			this.argon2ConfigurationContainer = new System.Windows.Forms.GroupBox();
			this.scryptConfigurationLayout = new System.Windows.Forms.TableLayoutPanel();
			this.argon2TimeCostLabel = new System.Windows.Forms.Label();
			this.argon2MemoryCostLabel = new System.Windows.Forms.Label();
			this.argon2ParallelismLabel = new System.Windows.Forms.Label();
			this.argon2HashLengthLabel = new System.Windows.Forms.Label();
			this.argon2TimeCostValue = new System.Windows.Forms.NumericUpDown();
			this.argon2MemoryCostValue = new System.Windows.Forms.NumericUpDown();
			this.argon2ParallelismValue = new System.Windows.Forms.NumericUpDown();
			this.argon2HashLengthValue = new System.Windows.Forms.NumericUpDown();
			this.argon2TypeLabel = new System.Windows.Forms.Label();
			this.argon2TypeLayout = new System.Windows.Forms.TableLayoutPanel();
			this.argon2Argon2iOption = new System.Windows.Forms.RadioButton();
			this.argon2Argon2dOption = new System.Windows.Forms.RadioButton();
			this.PasswordSaltLayoutTable.SuspendLayout();
			this.FormLayoutTable.SuspendLayout();
			this.HashingProcessLayout.SuspendLayout();
			this.argon2ConfigurationContainer.SuspendLayout();
			this.scryptConfigurationLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.argon2TimeCostValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.argon2MemoryCostValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.argon2ParallelismValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.argon2HashLengthValue)).BeginInit();
			this.argon2TypeLayout.SuspendLayout();
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
			this.FormLayoutTable.Controls.Add(this.argon2ConfigurationContainer, 0, 1);
			this.FormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormLayoutTable.Location = new System.Drawing.Point(0, 0);
			this.FormLayoutTable.Name = "FormLayoutTable";
			this.FormLayoutTable.RowCount = 3;
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.FormLayoutTable.Size = new System.Drawing.Size(588, 401);
			this.FormLayoutTable.TabIndex = 1;
			// 
			// HashingProcessLayout
			// 
			this.HashingProcessLayout.ColumnCount = 3;
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Controls.Add(this.StartButton, 0, 0);
			this.HashingProcessLayout.Controls.Add(this.HashResultTextbox, 0, 1);
			this.HashingProcessLayout.Controls.Add(this.HashingTimeLabel, 1, 0);
			this.HashingProcessLayout.Controls.Add(this.HashingTimeTextbox, 2, 0);
			this.HashingProcessLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingProcessLayout.Location = new System.Drawing.Point(4, 223);
			this.HashingProcessLayout.Name = "HashingProcessLayout";
			this.HashingProcessLayout.RowCount = 2;
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Size = new System.Drawing.Size(580, 174);
			this.HashingProcessLayout.TabIndex = 2;
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
			// HashResultTextbox
			// 
			this.HashResultTextbox.BackColor = System.Drawing.SystemColors.Window;
			this.HashingProcessLayout.SetColumnSpan(this.HashResultTextbox, 3);
			this.HashResultTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashResultTextbox.Location = new System.Drawing.Point(3, 36);
			this.HashResultTextbox.Multiline = true;
			this.HashResultTextbox.Name = "HashResultTextbox";
			this.HashResultTextbox.ReadOnly = true;
			this.HashResultTextbox.Size = new System.Drawing.Size(574, 135);
			this.HashResultTextbox.TabIndex = 0;
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
			// argon2ConfigurationContainer
			// 
			this.argon2ConfigurationContainer.Controls.Add(this.scryptConfigurationLayout);
			this.argon2ConfigurationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2ConfigurationContainer.Location = new System.Drawing.Point(4, 48);
			this.argon2ConfigurationContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.argon2ConfigurationContainer.Name = "argon2ConfigurationContainer";
			this.argon2ConfigurationContainer.Size = new System.Drawing.Size(580, 168);
			this.argon2ConfigurationContainer.TabIndex = 0;
			this.argon2ConfigurationContainer.TabStop = false;
			this.argon2ConfigurationContainer.Text = "Argon2";
			// 
			// scryptConfigurationLayout
			// 
			this.scryptConfigurationLayout.ColumnCount = 2;
			this.scryptConfigurationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.scryptConfigurationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.scryptConfigurationLayout.Controls.Add(this.argon2TimeCostLabel, 0, 0);
			this.scryptConfigurationLayout.Controls.Add(this.argon2MemoryCostLabel, 0, 1);
			this.scryptConfigurationLayout.Controls.Add(this.argon2ParallelismLabel, 0, 2);
			this.scryptConfigurationLayout.Controls.Add(this.argon2HashLengthLabel, 0, 3);
			this.scryptConfigurationLayout.Controls.Add(this.argon2TimeCostValue, 1, 0);
			this.scryptConfigurationLayout.Controls.Add(this.argon2MemoryCostValue, 1, 1);
			this.scryptConfigurationLayout.Controls.Add(this.argon2ParallelismValue, 1, 2);
			this.scryptConfigurationLayout.Controls.Add(this.argon2HashLengthValue, 1, 3);
			this.scryptConfigurationLayout.Controls.Add(this.argon2TypeLabel, 0, 4);
			this.scryptConfigurationLayout.Controls.Add(this.argon2TypeLayout, 1, 4);
			this.scryptConfigurationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptConfigurationLayout.Location = new System.Drawing.Point(3, 16);
			this.scryptConfigurationLayout.Name = "scryptConfigurationLayout";
			this.scryptConfigurationLayout.RowCount = 5;
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.scryptConfigurationLayout.Size = new System.Drawing.Size(574, 149);
			this.scryptConfigurationLayout.TabIndex = 0;
			// 
			// argon2TimeCostLabel
			// 
			this.argon2TimeCostLabel.AutoSize = true;
			this.argon2TimeCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2TimeCostLabel.Location = new System.Drawing.Point(3, 0);
			this.argon2TimeCostLabel.Name = "argon2TimeCostLabel";
			this.argon2TimeCostLabel.Size = new System.Drawing.Size(68, 26);
			this.argon2TimeCostLabel.TabIndex = 0;
			this.argon2TimeCostLabel.Text = "Time Cost";
			this.argon2TimeCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// argon2MemoryCostLabel
			// 
			this.argon2MemoryCostLabel.AutoSize = true;
			this.argon2MemoryCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2MemoryCostLabel.Location = new System.Drawing.Point(3, 26);
			this.argon2MemoryCostLabel.Name = "argon2MemoryCostLabel";
			this.argon2MemoryCostLabel.Size = new System.Drawing.Size(68, 26);
			this.argon2MemoryCostLabel.TabIndex = 5;
			this.argon2MemoryCostLabel.Text = "Memory Cost";
			this.argon2MemoryCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// argon2ParallelismLabel
			// 
			this.argon2ParallelismLabel.AutoSize = true;
			this.argon2ParallelismLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2ParallelismLabel.Location = new System.Drawing.Point(3, 52);
			this.argon2ParallelismLabel.Name = "argon2ParallelismLabel";
			this.argon2ParallelismLabel.Size = new System.Drawing.Size(68, 26);
			this.argon2ParallelismLabel.TabIndex = 6;
			this.argon2ParallelismLabel.Text = "Parallelism";
			this.argon2ParallelismLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// argon2HashLengthLabel
			// 
			this.argon2HashLengthLabel.AutoSize = true;
			this.argon2HashLengthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2HashLengthLabel.Location = new System.Drawing.Point(3, 78);
			this.argon2HashLengthLabel.Name = "argon2HashLengthLabel";
			this.argon2HashLengthLabel.Size = new System.Drawing.Size(68, 26);
			this.argon2HashLengthLabel.TabIndex = 7;
			this.argon2HashLengthLabel.Text = "Hash Length";
			this.argon2HashLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// argon2TimeCostValue
			// 
			this.argon2TimeCostValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2TimeCostValue.Location = new System.Drawing.Point(77, 3);
			this.argon2TimeCostValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.argon2TimeCostValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.argon2TimeCostValue.Name = "argon2TimeCostValue";
			this.argon2TimeCostValue.Size = new System.Drawing.Size(494, 20);
			this.argon2TimeCostValue.TabIndex = 12;
			this.argon2TimeCostValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// argon2MemoryCostValue
			// 
			this.argon2MemoryCostValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2MemoryCostValue.Location = new System.Drawing.Point(77, 29);
			this.argon2MemoryCostValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.argon2MemoryCostValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.argon2MemoryCostValue.Name = "argon2MemoryCostValue";
			this.argon2MemoryCostValue.Size = new System.Drawing.Size(494, 20);
			this.argon2MemoryCostValue.TabIndex = 13;
			this.argon2MemoryCostValue.Value = new decimal(new int[] {
            8192,
            0,
            0,
            0});
			// 
			// argon2ParallelismValue
			// 
			this.argon2ParallelismValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2ParallelismValue.Location = new System.Drawing.Point(77, 55);
			this.argon2ParallelismValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.argon2ParallelismValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.argon2ParallelismValue.Name = "argon2ParallelismValue";
			this.argon2ParallelismValue.Size = new System.Drawing.Size(494, 20);
			this.argon2ParallelismValue.TabIndex = 14;
			this.argon2ParallelismValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// argon2HashLengthValue
			// 
			this.argon2HashLengthValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2HashLengthValue.Location = new System.Drawing.Point(77, 81);
			this.argon2HashLengthValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.argon2HashLengthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.argon2HashLengthValue.Name = "argon2HashLengthValue";
			this.argon2HashLengthValue.Size = new System.Drawing.Size(494, 20);
			this.argon2HashLengthValue.TabIndex = 15;
			this.argon2HashLengthValue.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// argon2TypeLabel
			// 
			this.argon2TypeLabel.AutoSize = true;
			this.argon2TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2TypeLabel.Location = new System.Drawing.Point(3, 104);
			this.argon2TypeLabel.Name = "argon2TypeLabel";
			this.argon2TypeLabel.Size = new System.Drawing.Size(68, 45);
			this.argon2TypeLabel.TabIndex = 16;
			this.argon2TypeLabel.Text = "Type";
			this.argon2TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// argon2TypeLayout
			// 
			this.argon2TypeLayout.ColumnCount = 2;
			this.argon2TypeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.argon2TypeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.argon2TypeLayout.Controls.Add(this.argon2Argon2iOption, 0, 0);
			this.argon2TypeLayout.Controls.Add(this.argon2Argon2dOption, 1, 0);
			this.argon2TypeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2TypeLayout.Location = new System.Drawing.Point(77, 107);
			this.argon2TypeLayout.Name = "argon2TypeLayout";
			this.argon2TypeLayout.RowCount = 1;
			this.argon2TypeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.argon2TypeLayout.Size = new System.Drawing.Size(494, 39);
			this.argon2TypeLayout.TabIndex = 17;
			// 
			// argon2Argon2iOption
			// 
			this.argon2Argon2iOption.AutoSize = true;
			this.argon2Argon2iOption.Checked = true;
			this.argon2Argon2iOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2Argon2iOption.Location = new System.Drawing.Point(3, 3);
			this.argon2Argon2iOption.Name = "argon2Argon2iOption";
			this.argon2Argon2iOption.Size = new System.Drawing.Size(241, 33);
			this.argon2Argon2iOption.TabIndex = 0;
			this.argon2Argon2iOption.TabStop = true;
			this.argon2Argon2iOption.Text = "Argon2i";
			this.argon2Argon2iOption.UseVisualStyleBackColor = true;
			// 
			// argon2Argon2dOption
			// 
			this.argon2Argon2dOption.AutoSize = true;
			this.argon2Argon2dOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argon2Argon2dOption.Location = new System.Drawing.Point(250, 3);
			this.argon2Argon2dOption.Name = "argon2Argon2dOption";
			this.argon2Argon2dOption.Size = new System.Drawing.Size(241, 33);
			this.argon2Argon2dOption.TabIndex = 1;
			this.argon2Argon2dOption.Text = "Argon2d";
			this.argon2Argon2dOption.UseVisualStyleBackColor = true;
			// 
			// Argon2HashingTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 401);
			this.Controls.Add(this.FormLayoutTable);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Argon2HashingTest";
			this.Text = "Argon2 Hashing Test";
			this.PasswordSaltLayoutTable.ResumeLayout(false);
			this.PasswordSaltLayoutTable.PerformLayout();
			this.FormLayoutTable.ResumeLayout(false);
			this.HashingProcessLayout.ResumeLayout(false);
			this.HashingProcessLayout.PerformLayout();
			this.argon2ConfigurationContainer.ResumeLayout(false);
			this.scryptConfigurationLayout.ResumeLayout(false);
			this.scryptConfigurationLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.argon2TimeCostValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.argon2MemoryCostValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.argon2ParallelismValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.argon2HashLengthValue)).EndInit();
			this.argon2TypeLayout.ResumeLayout(false);
			this.argon2TypeLayout.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PasswordSaltLayoutTable;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SaltLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox SaltTextBox;
        private System.Windows.Forms.TableLayoutPanel FormLayoutTable;
        private System.Windows.Forms.GroupBox argon2ConfigurationContainer;
        private System.Windows.Forms.TableLayoutPanel scryptConfigurationLayout;
        private System.Windows.Forms.Label argon2TimeCostLabel;
        private System.Windows.Forms.Label argon2MemoryCostLabel;
        private System.Windows.Forms.Label argon2ParallelismLabel;
        private System.Windows.Forms.Label argon2HashLengthLabel;
        private System.Windows.Forms.TableLayoutPanel HashingProcessLayout;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox HashResultTextbox;
        private System.Windows.Forms.Label HashingTimeLabel;
        private System.Windows.Forms.TextBox HashingTimeTextbox;
        private System.Windows.Forms.NumericUpDown argon2TimeCostValue;
        private System.Windows.Forms.NumericUpDown argon2MemoryCostValue;
        private System.Windows.Forms.NumericUpDown argon2ParallelismValue;
        private System.Windows.Forms.NumericUpDown argon2HashLengthValue;
		private System.Windows.Forms.Label argon2TypeLabel;
		private System.Windows.Forms.TableLayoutPanel argon2TypeLayout;
		private System.Windows.Forms.RadioButton argon2Argon2iOption;
		private System.Windows.Forms.RadioButton argon2Argon2dOption;
	}
}

