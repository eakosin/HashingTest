namespace HashTest
{
    partial class SCryptNativeHashingTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCryptNativeHashingTest));
			this.PasswordSaltLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.SaltLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SaltTextBox = new System.Windows.Forms.TextBox();
			this.FormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.HashingProcessLayout = new System.Windows.Forms.TableLayoutPanel();
			this.StartButton = new System.Windows.Forms.Button();
			this.HashingTimeTextbox = new System.Windows.Forms.TextBox();
			this.HashResultTextbox = new System.Windows.Forms.TextBox();
			this.HashingTimeLabel = new System.Windows.Forms.Label();
			this.scryptConfigurationContainer = new System.Windows.Forms.GroupBox();
			this.scryptConfigurationLayout = new System.Windows.Forms.TableLayoutPanel();
			this.scryptCostLabel = new System.Windows.Forms.Label();
			this.scryptBlockSizeLabel = new System.Windows.Forms.Label();
			this.scryptParallelLabel = new System.Windows.Forms.Label();
			this.scryptDerivedKeyLengthLabel = new System.Windows.Forms.Label();
			this.scryptMemoryCostLabel = new System.Windows.Forms.Label();
			this.scryptMemoryCostTextbox = new System.Windows.Forms.TextBox();
			this.scryptBufferMixCoverageLabel = new System.Windows.Forms.Label();
			this.scryptBufferMixCoverageTextbox = new System.Windows.Forms.TextBox();
			this.scryptCostValue = new System.Windows.Forms.NumericUpDown();
			this.scryptBlockSizeValue = new System.Windows.Forms.NumericUpDown();
			this.scryptParallelValue = new System.Windows.Forms.NumericUpDown();
			this.scryptDerivedKeyLengthValue = new System.Windows.Forms.NumericUpDown();
			this.PasswordSaltLayoutTable.SuspendLayout();
			this.FormLayoutTable.SuspendLayout();
			this.HashingProcessLayout.SuspendLayout();
			this.scryptConfigurationContainer.SuspendLayout();
			this.scryptConfigurationLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scryptCostValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptBlockSizeValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptParallelValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptDerivedKeyLengthValue)).BeginInit();
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
			this.FormLayoutTable.Controls.Add(this.scryptConfigurationContainer, 0, 1);
			this.FormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormLayoutTable.Location = new System.Drawing.Point(0, 0);
			this.FormLayoutTable.Name = "FormLayoutTable";
			this.FormLayoutTable.RowCount = 3;
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
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
			this.HashingProcessLayout.Controls.Add(this.HashingTimeTextbox, 2, 0);
			this.HashingProcessLayout.Controls.Add(this.HashResultTextbox, 0, 1);
			this.HashingProcessLayout.Controls.Add(this.HashingTimeLabel, 1, 0);
			this.HashingProcessLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingProcessLayout.Location = new System.Drawing.Point(4, 231);
			this.HashingProcessLayout.Name = "HashingProcessLayout";
			this.HashingProcessLayout.RowCount = 2;
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Size = new System.Drawing.Size(580, 166);
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
			this.HashResultTextbox.Size = new System.Drawing.Size(574, 127);
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
			// scryptConfigurationContainer
			// 
			this.scryptConfigurationContainer.Controls.Add(this.scryptConfigurationLayout);
			this.scryptConfigurationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptConfigurationContainer.Location = new System.Drawing.Point(4, 48);
			this.scryptConfigurationContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.scryptConfigurationContainer.Name = "scryptConfigurationContainer";
			this.scryptConfigurationContainer.Size = new System.Drawing.Size(580, 176);
			this.scryptConfigurationContainer.TabIndex = 0;
			this.scryptConfigurationContainer.TabStop = false;
			this.scryptConfigurationContainer.Text = "SCrypt";
			// 
			// scryptConfigurationLayout
			// 
			this.scryptConfigurationLayout.ColumnCount = 2;
			this.scryptConfigurationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.scryptConfigurationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.scryptConfigurationLayout.Controls.Add(this.scryptCostLabel, 0, 0);
			this.scryptConfigurationLayout.Controls.Add(this.scryptBlockSizeLabel, 0, 1);
			this.scryptConfigurationLayout.Controls.Add(this.scryptParallelLabel, 0, 2);
			this.scryptConfigurationLayout.Controls.Add(this.scryptDerivedKeyLengthLabel, 0, 3);
			this.scryptConfigurationLayout.Controls.Add(this.scryptMemoryCostLabel, 0, 4);
			this.scryptConfigurationLayout.Controls.Add(this.scryptMemoryCostTextbox, 1, 4);
			this.scryptConfigurationLayout.Controls.Add(this.scryptBufferMixCoverageLabel, 0, 5);
			this.scryptConfigurationLayout.Controls.Add(this.scryptBufferMixCoverageTextbox, 1, 5);
			this.scryptConfigurationLayout.Controls.Add(this.scryptCostValue, 1, 0);
			this.scryptConfigurationLayout.Controls.Add(this.scryptBlockSizeValue, 1, 1);
			this.scryptConfigurationLayout.Controls.Add(this.scryptParallelValue, 1, 2);
			this.scryptConfigurationLayout.Controls.Add(this.scryptDerivedKeyLengthValue, 1, 3);
			this.scryptConfigurationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptConfigurationLayout.Location = new System.Drawing.Point(3, 16);
			this.scryptConfigurationLayout.Name = "scryptConfigurationLayout";
			this.scryptConfigurationLayout.RowCount = 6;
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.scryptConfigurationLayout.Size = new System.Drawing.Size(574, 157);
			this.scryptConfigurationLayout.TabIndex = 0;
			// 
			// scryptCostLabel
			// 
			this.scryptCostLabel.AutoSize = true;
			this.scryptCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptCostLabel.Location = new System.Drawing.Point(3, 0);
			this.scryptCostLabel.Name = "scryptCostLabel";
			this.scryptCostLabel.Size = new System.Drawing.Size(103, 26);
			this.scryptCostLabel.TabIndex = 0;
			this.scryptCostLabel.Text = "Cost [N]";
			this.scryptCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scryptBlockSizeLabel
			// 
			this.scryptBlockSizeLabel.AutoSize = true;
			this.scryptBlockSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptBlockSizeLabel.Location = new System.Drawing.Point(3, 26);
			this.scryptBlockSizeLabel.Name = "scryptBlockSizeLabel";
			this.scryptBlockSizeLabel.Size = new System.Drawing.Size(103, 26);
			this.scryptBlockSizeLabel.TabIndex = 5;
			this.scryptBlockSizeLabel.Text = "Block Size [r]";
			this.scryptBlockSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scryptParallelLabel
			// 
			this.scryptParallelLabel.AutoSize = true;
			this.scryptParallelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptParallelLabel.Location = new System.Drawing.Point(3, 52);
			this.scryptParallelLabel.Name = "scryptParallelLabel";
			this.scryptParallelLabel.Size = new System.Drawing.Size(103, 26);
			this.scryptParallelLabel.TabIndex = 6;
			this.scryptParallelLabel.Text = "Parallel [p]";
			this.scryptParallelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scryptDerivedKeyLengthLabel
			// 
			this.scryptDerivedKeyLengthLabel.AutoSize = true;
			this.scryptDerivedKeyLengthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptDerivedKeyLengthLabel.Location = new System.Drawing.Point(3, 78);
			this.scryptDerivedKeyLengthLabel.Name = "scryptDerivedKeyLengthLabel";
			this.scryptDerivedKeyLengthLabel.Size = new System.Drawing.Size(103, 26);
			this.scryptDerivedKeyLengthLabel.TabIndex = 7;
			this.scryptDerivedKeyLengthLabel.Text = "Derived Key Length";
			this.scryptDerivedKeyLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scryptMemoryCostLabel
			// 
			this.scryptMemoryCostLabel.AutoSize = true;
			this.scryptMemoryCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptMemoryCostLabel.Location = new System.Drawing.Point(3, 104);
			this.scryptMemoryCostLabel.Name = "scryptMemoryCostLabel";
			this.scryptMemoryCostLabel.Size = new System.Drawing.Size(103, 26);
			this.scryptMemoryCostLabel.TabIndex = 8;
			this.scryptMemoryCostLabel.Text = "Memory Cost";
			this.scryptMemoryCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scryptMemoryCostTextbox
			// 
			this.scryptMemoryCostTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptMemoryCostTextbox.Location = new System.Drawing.Point(112, 107);
			this.scryptMemoryCostTextbox.Name = "scryptMemoryCostTextbox";
			this.scryptMemoryCostTextbox.ReadOnly = true;
			this.scryptMemoryCostTextbox.Size = new System.Drawing.Size(459, 20);
			this.scryptMemoryCostTextbox.TabIndex = 9;
			// 
			// scryptBufferMixCoverageLabel
			// 
			this.scryptBufferMixCoverageLabel.AutoSize = true;
			this.scryptBufferMixCoverageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptBufferMixCoverageLabel.Location = new System.Drawing.Point(3, 130);
			this.scryptBufferMixCoverageLabel.Name = "scryptBufferMixCoverageLabel";
			this.scryptBufferMixCoverageLabel.Size = new System.Drawing.Size(103, 27);
			this.scryptBufferMixCoverageLabel.TabIndex = 10;
			this.scryptBufferMixCoverageLabel.Text = "Buffer Mix Coverage";
			this.scryptBufferMixCoverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scryptBufferMixCoverageTextbox
			// 
			this.scryptBufferMixCoverageTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptBufferMixCoverageTextbox.Location = new System.Drawing.Point(112, 133);
			this.scryptBufferMixCoverageTextbox.Name = "scryptBufferMixCoverageTextbox";
			this.scryptBufferMixCoverageTextbox.ReadOnly = true;
			this.scryptBufferMixCoverageTextbox.Size = new System.Drawing.Size(459, 20);
			this.scryptBufferMixCoverageTextbox.TabIndex = 11;
			// 
			// scryptCostValue
			// 
			this.scryptCostValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptCostValue.Location = new System.Drawing.Point(112, 3);
			this.scryptCostValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.scryptCostValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.scryptCostValue.Name = "scryptCostValue";
			this.scryptCostValue.Size = new System.Drawing.Size(459, 20);
			this.scryptCostValue.TabIndex = 12;
			this.scryptCostValue.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
			this.scryptCostValue.ValueChanged += new System.EventHandler(this.scryptUpdateStatistics);
			// 
			// scryptBlockSizeValue
			// 
			this.scryptBlockSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptBlockSizeValue.Location = new System.Drawing.Point(112, 29);
			this.scryptBlockSizeValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.scryptBlockSizeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.scryptBlockSizeValue.Name = "scryptBlockSizeValue";
			this.scryptBlockSizeValue.Size = new System.Drawing.Size(459, 20);
			this.scryptBlockSizeValue.TabIndex = 13;
			this.scryptBlockSizeValue.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.scryptBlockSizeValue.ValueChanged += new System.EventHandler(this.scryptUpdateStatistics);
			// 
			// scryptParallelValue
			// 
			this.scryptParallelValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptParallelValue.Location = new System.Drawing.Point(112, 55);
			this.scryptParallelValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.scryptParallelValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.scryptParallelValue.Name = "scryptParallelValue";
			this.scryptParallelValue.Size = new System.Drawing.Size(459, 20);
			this.scryptParallelValue.TabIndex = 14;
			this.scryptParallelValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.scryptParallelValue.ValueChanged += new System.EventHandler(this.scryptUpdateStatistics);
			// 
			// scryptDerivedKeyLengthValue
			// 
			this.scryptDerivedKeyLengthValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptDerivedKeyLengthValue.Location = new System.Drawing.Point(112, 81);
			this.scryptDerivedKeyLengthValue.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
			this.scryptDerivedKeyLengthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.scryptDerivedKeyLengthValue.Name = "scryptDerivedKeyLengthValue";
			this.scryptDerivedKeyLengthValue.Size = new System.Drawing.Size(459, 20);
			this.scryptDerivedKeyLengthValue.TabIndex = 15;
			this.scryptDerivedKeyLengthValue.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// SCryptNativeHashingTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 401);
			this.Controls.Add(this.FormLayoutTable);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SCryptNativeHashingTest";
			this.Text = "SCrypt Native Hashing Test";
			this.PasswordSaltLayoutTable.ResumeLayout(false);
			this.PasswordSaltLayoutTable.PerformLayout();
			this.FormLayoutTable.ResumeLayout(false);
			this.HashingProcessLayout.ResumeLayout(false);
			this.HashingProcessLayout.PerformLayout();
			this.scryptConfigurationContainer.ResumeLayout(false);
			this.scryptConfigurationLayout.ResumeLayout(false);
			this.scryptConfigurationLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scryptCostValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptBlockSizeValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptParallelValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptDerivedKeyLengthValue)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PasswordSaltLayoutTable;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SaltLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox SaltTextBox;
        private System.Windows.Forms.TableLayoutPanel FormLayoutTable;
		private System.Windows.Forms.GroupBox scryptConfigurationContainer;
        private System.Windows.Forms.TableLayoutPanel scryptConfigurationLayout;
        private System.Windows.Forms.Label scryptCostLabel;
        private System.Windows.Forms.Label scryptBlockSizeLabel;
        private System.Windows.Forms.Label scryptParallelLabel;
        private System.Windows.Forms.Label scryptDerivedKeyLengthLabel;
		private System.Windows.Forms.TableLayoutPanel HashingProcessLayout;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox HashResultTextbox;
        private System.Windows.Forms.Label scryptMemoryCostLabel;
		private System.Windows.Forms.TextBox scryptMemoryCostTextbox;
        private System.Windows.Forms.Label HashingTimeLabel;
        private System.Windows.Forms.TextBox HashingTimeTextbox;
        private System.Windows.Forms.Label scryptBufferMixCoverageLabel;
        private System.Windows.Forms.TextBox scryptBufferMixCoverageTextbox;
        private System.Windows.Forms.NumericUpDown scryptCostValue;
        private System.Windows.Forms.NumericUpDown scryptBlockSizeValue;
        private System.Windows.Forms.NumericUpDown scryptParallelValue;
		private System.Windows.Forms.NumericUpDown scryptDerivedKeyLengthValue;
    }
}

