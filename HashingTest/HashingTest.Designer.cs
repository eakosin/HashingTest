namespace HashTest
{
    partial class HashingTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashingTest));
			this.PasswordSaltLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.SaltLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SaltTextBox = new System.Windows.Forms.TextBox();
			this.FormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.HashingOptions = new System.Windows.Forms.TableLayoutPanel();
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
			this.bcryptConfigurationContainer = new System.Windows.Forms.GroupBox();
			this.bcryptConfigurationLayout = new System.Windows.Forms.TableLayoutPanel();
			this.bcryptRoundsLabel = new System.Windows.Forms.Label();
			this.HashingProcessLayout = new System.Windows.Forms.TableLayoutPanel();
			this.OptionStartLayout = new System.Windows.Forms.TableLayoutPanel();
			this.bcryptOption = new System.Windows.Forms.RadioButton();
			this.scryptOption = new System.Windows.Forms.RadioButton();
			this.StartButton = new System.Windows.Forms.Button();
			this.HashResultTextbox = new System.Windows.Forms.TextBox();
			this.StatisticsLayout = new System.Windows.Forms.TableLayoutPanel();
			this.HashingTimeLabel = new System.Windows.Forms.Label();
			this.HashingTimeTextbox = new System.Windows.Forms.TextBox();
			this.scryptCostValue = new System.Windows.Forms.NumericUpDown();
			this.scryptBlockSizeValue = new System.Windows.Forms.NumericUpDown();
			this.scryptParallelValue = new System.Windows.Forms.NumericUpDown();
			this.scryptDerivedKeyLengthValue = new System.Windows.Forms.NumericUpDown();
			this.bcryptRoundsValue = new System.Windows.Forms.NumericUpDown();
			this.PasswordSaltLayoutTable.SuspendLayout();
			this.FormLayoutTable.SuspendLayout();
			this.HashingOptions.SuspendLayout();
			this.scryptConfigurationContainer.SuspendLayout();
			this.scryptConfigurationLayout.SuspendLayout();
			this.bcryptConfigurationContainer.SuspendLayout();
			this.bcryptConfigurationLayout.SuspendLayout();
			this.HashingProcessLayout.SuspendLayout();
			this.OptionStartLayout.SuspendLayout();
			this.StatisticsLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scryptCostValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptBlockSizeValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptParallelValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptDerivedKeyLengthValue)).BeginInit();
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
			this.PasswordSaltLayoutTable.Size = new System.Drawing.Size(605, 28);
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
			this.SaltLabel.Location = new System.Drawing.Point(320, 1);
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
			this.PasswordTextBox.Size = new System.Drawing.Size(249, 20);
			this.PasswordTextBox.TabIndex = 2;
			this.PasswordTextBox.Text = "Password";
			// 
			// SaltTextBox
			// 
			this.SaltTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SaltTextBox.Location = new System.Drawing.Point(352, 4);
			this.SaltTextBox.Name = "SaltTextBox";
			this.SaltTextBox.Size = new System.Drawing.Size(249, 20);
			this.SaltTextBox.TabIndex = 3;
			this.SaltTextBox.Text = "Salt";
			// 
			// FormLayoutTable
			// 
			this.FormLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.FormLayoutTable.ColumnCount = 1;
			this.FormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormLayoutTable.Controls.Add(this.PasswordSaltLayoutTable, 0, 0);
			this.FormLayoutTable.Controls.Add(this.HashingOptions, 0, 1);
			this.FormLayoutTable.Controls.Add(this.HashingProcessLayout, 0, 2);
			this.FormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormLayoutTable.Location = new System.Drawing.Point(0, 0);
			this.FormLayoutTable.Name = "FormLayoutTable";
			this.FormLayoutTable.RowCount = 3;
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
			this.FormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormLayoutTable.Size = new System.Drawing.Size(625, 477);
			this.FormLayoutTable.TabIndex = 1;
			// 
			// HashingOptions
			// 
			this.HashingOptions.ColumnCount = 2;
			this.HashingOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.HashingOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.HashingOptions.Controls.Add(this.scryptConfigurationContainer, 0, 0);
			this.HashingOptions.Controls.Add(this.bcryptConfigurationContainer, 1, 0);
			this.HashingOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingOptions.Location = new System.Drawing.Point(4, 51);
			this.HashingOptions.Name = "HashingOptions";
			this.HashingOptions.RowCount = 1;
			this.HashingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.HashingOptions.Size = new System.Drawing.Size(617, 180);
			this.HashingOptions.TabIndex = 1;
			// 
			// scryptConfigurationContainer
			// 
			this.scryptConfigurationContainer.Controls.Add(this.scryptConfigurationLayout);
			this.scryptConfigurationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptConfigurationContainer.Location = new System.Drawing.Point(3, 0);
			this.scryptConfigurationContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.scryptConfigurationContainer.Name = "scryptConfigurationContainer";
			this.scryptConfigurationContainer.Size = new System.Drawing.Size(302, 177);
			this.scryptConfigurationContainer.TabIndex = 0;
			this.scryptConfigurationContainer.TabStop = false;
			this.scryptConfigurationContainer.Text = "scrypt";
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
			this.scryptConfigurationLayout.Size = new System.Drawing.Size(296, 158);
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
			this.scryptMemoryCostTextbox.Size = new System.Drawing.Size(181, 20);
			this.scryptMemoryCostTextbox.TabIndex = 9;
			// 
			// scryptBufferMixCoverageLabel
			// 
			this.scryptBufferMixCoverageLabel.AutoSize = true;
			this.scryptBufferMixCoverageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptBufferMixCoverageLabel.Location = new System.Drawing.Point(3, 130);
			this.scryptBufferMixCoverageLabel.Name = "scryptBufferMixCoverageLabel";
			this.scryptBufferMixCoverageLabel.Size = new System.Drawing.Size(103, 28);
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
			this.scryptBufferMixCoverageTextbox.Size = new System.Drawing.Size(181, 20);
			this.scryptBufferMixCoverageTextbox.TabIndex = 11;
			// 
			// bcryptConfigurationContainer
			// 
			this.bcryptConfigurationContainer.Controls.Add(this.bcryptConfigurationLayout);
			this.bcryptConfigurationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bcryptConfigurationContainer.Location = new System.Drawing.Point(311, 0);
			this.bcryptConfigurationContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.bcryptConfigurationContainer.Name = "bcryptConfigurationContainer";
			this.bcryptConfigurationContainer.Size = new System.Drawing.Size(303, 177);
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
			this.bcryptConfigurationLayout.RowCount = 2;
			this.bcryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.bcryptConfigurationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bcryptConfigurationLayout.Size = new System.Drawing.Size(297, 158);
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
			// HashingProcessLayout
			// 
			this.HashingProcessLayout.ColumnCount = 2;
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
			this.HashingProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Controls.Add(this.OptionStartLayout, 0, 0);
			this.HashingProcessLayout.Controls.Add(this.HashResultTextbox, 0, 1);
			this.HashingProcessLayout.Controls.Add(this.StatisticsLayout, 1, 0);
			this.HashingProcessLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingProcessLayout.Location = new System.Drawing.Point(4, 238);
			this.HashingProcessLayout.Name = "HashingProcessLayout";
			this.HashingProcessLayout.RowCount = 2;
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
			this.HashingProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.HashingProcessLayout.Size = new System.Drawing.Size(617, 235);
			this.HashingProcessLayout.TabIndex = 2;
			// 
			// OptionStartLayout
			// 
			this.OptionStartLayout.ColumnCount = 1;
			this.OptionStartLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.OptionStartLayout.Controls.Add(this.bcryptOption, 0, 1);
			this.OptionStartLayout.Controls.Add(this.scryptOption, 0, 0);
			this.OptionStartLayout.Controls.Add(this.StartButton, 0, 2);
			this.OptionStartLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OptionStartLayout.Location = new System.Drawing.Point(3, 3);
			this.OptionStartLayout.Name = "OptionStartLayout";
			this.OptionStartLayout.RowCount = 3;
			this.OptionStartLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.OptionStartLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.OptionStartLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.OptionStartLayout.Size = new System.Drawing.Size(155, 96);
			this.OptionStartLayout.TabIndex = 1;
			// 
			// bcryptOption
			// 
			this.bcryptOption.AutoSize = true;
			this.bcryptOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bcryptOption.Location = new System.Drawing.Point(3, 35);
			this.bcryptOption.Name = "bcryptOption";
			this.bcryptOption.Size = new System.Drawing.Size(149, 26);
			this.bcryptOption.TabIndex = 1;
			this.bcryptOption.Text = "bcrypt";
			this.bcryptOption.UseVisualStyleBackColor = true;
			// 
			// scryptOption
			// 
			this.scryptOption.AutoSize = true;
			this.scryptOption.Checked = true;
			this.scryptOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scryptOption.Location = new System.Drawing.Point(3, 3);
			this.scryptOption.Name = "scryptOption";
			this.scryptOption.Size = new System.Drawing.Size(149, 26);
			this.scryptOption.TabIndex = 0;
			this.scryptOption.TabStop = true;
			this.scryptOption.Text = "scrypt";
			this.scryptOption.UseVisualStyleBackColor = true;
			// 
			// StartButton
			// 
			this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StartButton.Location = new System.Drawing.Point(3, 67);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(149, 26);
			this.StartButton.TabIndex = 2;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// HashResultTextbox
			// 
			this.HashResultTextbox.BackColor = System.Drawing.SystemColors.Window;
			this.HashingProcessLayout.SetColumnSpan(this.HashResultTextbox, 2);
			this.HashResultTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashResultTextbox.Location = new System.Drawing.Point(3, 105);
			this.HashResultTextbox.Multiline = true;
			this.HashResultTextbox.Name = "HashResultTextbox";
			this.HashResultTextbox.ReadOnly = true;
			this.HashResultTextbox.Size = new System.Drawing.Size(611, 127);
			this.HashResultTextbox.TabIndex = 0;
			// 
			// StatisticsLayout
			// 
			this.StatisticsLayout.ColumnCount = 2;
			this.StatisticsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.StatisticsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.StatisticsLayout.Controls.Add(this.HashingTimeLabel, 0, 0);
			this.StatisticsLayout.Controls.Add(this.HashingTimeTextbox, 1, 0);
			this.StatisticsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatisticsLayout.Location = new System.Drawing.Point(164, 3);
			this.StatisticsLayout.Name = "StatisticsLayout";
			this.StatisticsLayout.RowCount = 2;
			this.StatisticsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.StatisticsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.StatisticsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.StatisticsLayout.Size = new System.Drawing.Size(450, 96);
			this.StatisticsLayout.TabIndex = 2;
			// 
			// HashingTimeLabel
			// 
			this.HashingTimeLabel.AutoSize = true;
			this.HashingTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingTimeLabel.Location = new System.Drawing.Point(3, 0);
			this.HashingTimeLabel.Name = "HashingTimeLabel";
			this.HashingTimeLabel.Size = new System.Drawing.Size(94, 26);
			this.HashingTimeLabel.TabIndex = 1;
			this.HashingTimeLabel.Text = "Hashing Time [ms]";
			this.HashingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashingTimeTextbox
			// 
			this.HashingTimeTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HashingTimeTextbox.Location = new System.Drawing.Point(103, 3);
			this.HashingTimeTextbox.Name = "HashingTimeTextbox";
			this.HashingTimeTextbox.ReadOnly = true;
			this.HashingTimeTextbox.Size = new System.Drawing.Size(344, 20);
			this.HashingTimeTextbox.TabIndex = 3;
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
			this.scryptCostValue.Size = new System.Drawing.Size(181, 20);
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
			this.scryptBlockSizeValue.Size = new System.Drawing.Size(181, 20);
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
			this.scryptParallelValue.Size = new System.Drawing.Size(181, 20);
			this.scryptParallelValue.TabIndex = 14;
			this.scryptParallelValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
			this.scryptDerivedKeyLengthValue.Size = new System.Drawing.Size(181, 20);
			this.scryptDerivedKeyLengthValue.TabIndex = 15;
			this.scryptDerivedKeyLengthValue.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
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
            1,
            0,
            0,
            0});
			this.bcryptRoundsValue.Name = "bcryptRoundsValue";
			this.bcryptRoundsValue.Size = new System.Drawing.Size(214, 20);
			this.bcryptRoundsValue.TabIndex = 1;
			this.bcryptRoundsValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// HashingTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 477);
			this.Controls.Add(this.FormLayoutTable);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HashingTest";
			this.Text = "Hashing Test";
			this.PasswordSaltLayoutTable.ResumeLayout(false);
			this.PasswordSaltLayoutTable.PerformLayout();
			this.FormLayoutTable.ResumeLayout(false);
			this.HashingOptions.ResumeLayout(false);
			this.scryptConfigurationContainer.ResumeLayout(false);
			this.scryptConfigurationLayout.ResumeLayout(false);
			this.scryptConfigurationLayout.PerformLayout();
			this.bcryptConfigurationContainer.ResumeLayout(false);
			this.bcryptConfigurationLayout.ResumeLayout(false);
			this.bcryptConfigurationLayout.PerformLayout();
			this.HashingProcessLayout.ResumeLayout(false);
			this.HashingProcessLayout.PerformLayout();
			this.OptionStartLayout.ResumeLayout(false);
			this.OptionStartLayout.PerformLayout();
			this.StatisticsLayout.ResumeLayout(false);
			this.StatisticsLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scryptCostValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptBlockSizeValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptParallelValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scryptDerivedKeyLengthValue)).EndInit();
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
        private System.Windows.Forms.GroupBox scryptConfigurationContainer;
        private System.Windows.Forms.TableLayoutPanel HashingOptions;
        private System.Windows.Forms.GroupBox bcryptConfigurationContainer;
        private System.Windows.Forms.TableLayoutPanel scryptConfigurationLayout;
        private System.Windows.Forms.Label scryptCostLabel;
        private System.Windows.Forms.Label scryptBlockSizeLabel;
        private System.Windows.Forms.Label scryptParallelLabel;
        private System.Windows.Forms.Label scryptDerivedKeyLengthLabel;
        private System.Windows.Forms.TableLayoutPanel HashingProcessLayout;
        private System.Windows.Forms.TableLayoutPanel bcryptConfigurationLayout;
        private System.Windows.Forms.Label bcryptRoundsLabel;
        private System.Windows.Forms.TableLayoutPanel OptionStartLayout;
        private System.Windows.Forms.RadioButton bcryptOption;
        private System.Windows.Forms.RadioButton scryptOption;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox HashResultTextbox;
        private System.Windows.Forms.Label scryptMemoryCostLabel;
        private System.Windows.Forms.TextBox scryptMemoryCostTextbox;
        private System.Windows.Forms.TableLayoutPanel StatisticsLayout;
        private System.Windows.Forms.Label HashingTimeLabel;
        private System.Windows.Forms.TextBox HashingTimeTextbox;
        private System.Windows.Forms.Label scryptBufferMixCoverageLabel;
        private System.Windows.Forms.TextBox scryptBufferMixCoverageTextbox;
        private System.Windows.Forms.NumericUpDown scryptCostValue;
        private System.Windows.Forms.NumericUpDown scryptBlockSizeValue;
        private System.Windows.Forms.NumericUpDown scryptParallelValue;
        private System.Windows.Forms.NumericUpDown scryptDerivedKeyLengthValue;
        private System.Windows.Forms.NumericUpDown bcryptRoundsValue;
    }
}

