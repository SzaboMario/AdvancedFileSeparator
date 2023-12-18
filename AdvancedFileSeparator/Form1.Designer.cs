
namespace AdvancedFileSeparator
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.checkedFileCounter = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outputFilePerFolderText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.deleteAfterSeparateChk = new System.Windows.Forms.CheckBox();
            this.selFileTypeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sepaFileNameTextBox = new System.Windows.Forms.TextBox();
            this.findedFileCounterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allFileCounter = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cropImgStartY = new System.Windows.Forms.TextBox();
            this.cropImgStartX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.imageConverterCounterLabel = new System.Windows.Forms.Label();
            this.cropImageChk = new System.Windows.Forms.CheckBox();
            this.imageNumberLabel = new System.Windows.Forms.Label();
            this.origDepthText = new System.Windows.Forms.TextBox();
            this.origColorText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.newHeightText = new System.Windows.Forms.TextBox();
            this.newWidtText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.origHeightText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.applySelectedBtn = new System.Windows.Forms.Button();
            this.origWidtText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newTypeCB = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDestinationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceFolderLabel = new System.Windows.Forms.Label();
            this.destinationFolderLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(290, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stopped";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkedFileCounter
            // 
            this.checkedFileCounter.AutoSize = true;
            this.checkedFileCounter.Location = new System.Drawing.Point(6, 35);
            this.checkedFileCounter.Name = "checkedFileCounter";
            this.checkedFileCounter.Size = new System.Drawing.Size(119, 13);
            this.checkedFileCounter.TabIndex = 3;
            this.checkedFileCounter.Text = "Checked file(s) counter:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 380);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputFilePerFolderText);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.deleteAfterSeparateChk);
            this.tabPage1.Controls.Add(this.selFileTypeText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.sepaFileNameTextBox);
            this.tabPage1.Controls.Add(this.findedFileCounterLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchPatternTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.allFileCounter);
            this.tabPage1.Controls.Add(this.checkedFileCounter);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File separation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputFilePerFolderText
            // 
            this.outputFilePerFolderText.Location = new System.Drawing.Point(119, 228);
            this.outputFilePerFolderText.Name = "outputFilePerFolderText";
            this.outputFilePerFolderText.Size = new System.Drawing.Size(63, 20);
            this.outputFilePerFolderText.TabIndex = 16;
            this.outputFilePerFolderText.Text = "0";
            this.outputFilePerFolderText.TextChanged += new System.EventHandler(this.outputFilePerFolderText_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Output file per folder:";
            // 
            // deleteAfterSeparateChk
            // 
            this.deleteAfterSeparateChk.AutoSize = true;
            this.deleteAfterSeparateChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAfterSeparateChk.Location = new System.Drawing.Point(252, 230);
            this.deleteAfterSeparateChk.Name = "deleteAfterSeparateChk";
            this.deleteAfterSeparateChk.Size = new System.Drawing.Size(124, 17);
            this.deleteAfterSeparateChk.TabIndex = 14;
            this.deleteAfterSeparateChk.Text = "Delete original image";
            this.deleteAfterSeparateChk.UseVisualStyleBackColor = true;
            this.deleteAfterSeparateChk.CheckedChanged += new System.EventHandler(this.deleteAfterSeparateChk_CheckedChanged);
            // 
            // selFileTypeText
            // 
            this.selFileTypeText.Location = new System.Drawing.Point(313, 253);
            this.selFileTypeText.Name = "selFileTypeText";
            this.selFileTypeText.Size = new System.Drawing.Size(63, 20);
            this.selFileTypeText.TabIndex = 13;
            this.selFileTypeText.Text = "*.*";
            this.selFileTypeText.TextChanged += new System.EventHandler(this.selFileTypeText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pattern file name:";
            // 
            // sepaFileNameTextBox
            // 
            this.sepaFileNameTextBox.Location = new System.Drawing.Point(9, 280);
            this.sepaFileNameTextBox.Name = "sepaFileNameTextBox";
            this.sepaFileNameTextBox.ReadOnly = true;
            this.sepaFileNameTextBox.Size = new System.Drawing.Size(367, 20);
            this.sepaFileNameTextBox.TabIndex = 11;
            this.sepaFileNameTextBox.TextChanged += new System.EventHandler(this.sepaFileNameTextBox_TextChanged);
            // 
            // findedFileCounterLabel
            // 
            this.findedFileCounterLabel.AutoSize = true;
            this.findedFileCounterLabel.Location = new System.Drawing.Point(6, 58);
            this.findedFileCounterLabel.Name = "findedFileCounterLabel";
            this.findedFileCounterLabel.Size = new System.Drawing.Size(100, 13);
            this.findedFileCounterLabel.TabIndex = 10;
            this.findedFileCounterLabel.Text = "Finded file counter: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search pattern:";
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Location = new System.Drawing.Point(9, 325);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(275, 20);
            this.searchPatternTextBox.TabIndex = 8;
            this.searchPatternTextBox.TextChanged += new System.EventHandler(this.searchPatternTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SelectedFileType:";
            // 
            // allFileCounter
            // 
            this.allFileCounter.AutoSize = true;
            this.allFileCounter.Location = new System.Drawing.Point(6, 13);
            this.allFileCounter.Name = "allFileCounter";
            this.allFileCounter.Size = new System.Drawing.Size(123, 13);
            this.allFileCounter.TabIndex = 5;
            this.allFileCounter.Text = "All file(s) in source folder:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.cropImgStartY);
            this.tabPage2.Controls.Add(this.cropImgStartX);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.imageConverterCounterLabel);
            this.tabPage2.Controls.Add(this.cropImageChk);
            this.tabPage2.Controls.Add(this.imageNumberLabel);
            this.tabPage2.Controls.Add(this.origDepthText);
            this.tabPage2.Controls.Add(this.origColorText);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.newHeightText);
            this.tabPage2.Controls.Add(this.newWidtText);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.origHeightText);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.applySelectedBtn);
            this.tabPage2.Controls.Add(this.origWidtText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.newTypeCB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image conversion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(235, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 58);
            this.label12.TabIndex = 41;
            this.label12.Text = "If the new width and the new height are equal to zero, the converter uses the ori" +
    "ginal size.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Start(y):";
            // 
            // cropImgStartY
            // 
            this.cropImgStartY.Location = new System.Drawing.Point(189, 225);
            this.cropImgStartY.Name = "cropImgStartY";
            this.cropImgStartY.Size = new System.Drawing.Size(40, 20);
            this.cropImgStartY.TabIndex = 39;
            this.cropImgStartY.Text = "0";
            // 
            // cropImgStartX
            // 
            this.cropImgStartX.Location = new System.Drawing.Point(189, 199);
            this.cropImgStartX.Name = "cropImgStartX";
            this.cropImgStartX.Size = new System.Drawing.Size(40, 20);
            this.cropImgStartX.TabIndex = 38;
            this.cropImgStartX.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Start(x):";
            // 
            // imageConverterCounterLabel
            // 
            this.imageConverterCounterLabel.AutoSize = true;
            this.imageConverterCounterLabel.Location = new System.Drawing.Point(6, 323);
            this.imageConverterCounterLabel.Name = "imageConverterCounterLabel";
            this.imageConverterCounterLabel.Size = new System.Drawing.Size(112, 13);
            this.imageConverterCounterLabel.TabIndex = 32;
            this.imageConverterCounterLabel.Text = "Converted fileCount: 0";
            // 
            // cropImageChk
            // 
            this.cropImageChk.AutoSize = true;
            this.cropImageChk.Location = new System.Drawing.Point(75, 177);
            this.cropImageChk.Name = "cropImageChk";
            this.cropImageChk.Size = new System.Drawing.Size(79, 17);
            this.cropImageChk.TabIndex = 29;
            this.cropImageChk.Text = "Crop image";
            this.cropImageChk.UseVisualStyleBackColor = true;
            // 
            // imageNumberLabel
            // 
            this.imageNumberLabel.AutoSize = true;
            this.imageNumberLabel.Location = new System.Drawing.Point(6, 299);
            this.imageNumberLabel.Name = "imageNumberLabel";
            this.imageNumberLabel.Size = new System.Drawing.Size(86, 13);
            this.imageNumberLabel.TabIndex = 28;
            this.imageNumberLabel.Text = "Image number: 0";
            // 
            // origDepthText
            // 
            this.origDepthText.Location = new System.Drawing.Point(71, 142);
            this.origDepthText.Name = "origDepthText";
            this.origDepthText.ReadOnly = true;
            this.origDepthText.Size = new System.Drawing.Size(40, 20);
            this.origDepthText.TabIndex = 27;
            // 
            // origColorText
            // 
            this.origColorText.Location = new System.Drawing.Point(71, 107);
            this.origColorText.Name = "origColorText";
            this.origColorText.ReadOnly = true;
            this.origColorText.Size = new System.Drawing.Size(83, 20);
            this.origColorText.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "New height:";
            // 
            // newHeightText
            // 
            this.newHeightText.Location = new System.Drawing.Point(94, 225);
            this.newHeightText.Name = "newHeightText";
            this.newHeightText.Size = new System.Drawing.Size(40, 20);
            this.newHeightText.TabIndex = 21;
            this.newHeightText.Text = "0";
            // 
            // newWidtText
            // 
            this.newWidtText.Location = new System.Drawing.Point(94, 199);
            this.newWidtText.Name = "newWidtText";
            this.newWidtText.Size = new System.Drawing.Size(40, 20);
            this.newWidtText.TabIndex = 20;
            this.newWidtText.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Orig width:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Orig height:";
            // 
            // origHeightText
            // 
            this.origHeightText.Location = new System.Drawing.Point(256, 142);
            this.origHeightText.Name = "origHeightText";
            this.origHeightText.ReadOnly = true;
            this.origHeightText.Size = new System.Drawing.Size(40, 20);
            this.origHeightText.TabIndex = 16;
            this.origHeightText.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "New width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Orig depth:";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 95);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // applySelectedBtn
            // 
            this.applySelectedBtn.Location = new System.Drawing.Point(303, 311);
            this.applySelectedBtn.Name = "applySelectedBtn";
            this.applySelectedBtn.Size = new System.Drawing.Size(75, 37);
            this.applySelectedBtn.TabIndex = 10;
            this.applySelectedBtn.Text = "Apply";
            this.applySelectedBtn.UseVisualStyleBackColor = true;
            this.applySelectedBtn.Click += new System.EventHandler(this.applySelectedBtn_Click);
            // 
            // origWidtText
            // 
            this.origWidtText.Location = new System.Drawing.Point(256, 108);
            this.origWidtText.Name = "origWidtText";
            this.origWidtText.ReadOnly = true;
            this.origWidtText.Size = new System.Drawing.Size(40, 20);
            this.origWidtText.TabIndex = 7;
            this.origWidtText.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Orig color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "New size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target type:";
            // 
            // newTypeCB
            // 
            this.newTypeCB.FormattingEnabled = true;
            this.newTypeCB.Items.AddRange(new object[] {
            "png",
            "bmp",
            "jpeg"});
            this.newTypeCB.Location = new System.Drawing.Point(75, 260);
            this.newTypeCB.Name = "newTypeCB";
            this.newTypeCB.Size = new System.Drawing.Size(79, 21);
            this.newTypeCB.TabIndex = 0;
            this.newTypeCB.SelectedIndexChanged += new System.EventHandler(this.newTypeCB_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSourceFolderToolStripMenuItem,
            this.setDestinationFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // setSourceFolderToolStripMenuItem
            // 
            this.setSourceFolderToolStripMenuItem.Name = "setSourceFolderToolStripMenuItem";
            this.setSourceFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.setSourceFolderToolStripMenuItem.Text = "Set source folder";
            this.setSourceFolderToolStripMenuItem.Click += new System.EventHandler(this.setSourceFolderToolStripMenuItem_Click);
            // 
            // setDestinationFolderToolStripMenuItem
            // 
            this.setDestinationFolderToolStripMenuItem.Enabled = false;
            this.setDestinationFolderToolStripMenuItem.Name = "setDestinationFolderToolStripMenuItem";
            this.setDestinationFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.setDestinationFolderToolStripMenuItem.Text = "Set destination folder";
            this.setDestinationFolderToolStripMenuItem.Click += new System.EventHandler(this.setDestinationFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceFolderToolStripMenuItem,
            this.destinationFolderToolStripMenuItem,
            this.logToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // sourceFolderToolStripMenuItem
            // 
            this.sourceFolderToolStripMenuItem.Name = "sourceFolderToolStripMenuItem";
            this.sourceFolderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sourceFolderToolStripMenuItem.Text = "Source folder";
            this.sourceFolderToolStripMenuItem.Click += new System.EventHandler(this.sourceFolderToolStripMenuItem_Click);
            // 
            // destinationFolderToolStripMenuItem
            // 
            this.destinationFolderToolStripMenuItem.Name = "destinationFolderToolStripMenuItem";
            this.destinationFolderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.destinationFolderToolStripMenuItem.Text = "Destination folder";
            this.destinationFolderToolStripMenuItem.Click += new System.EventHandler(this.destinationFolderToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logToolStripMenuItem.Text = "Log file";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // sourceFolderLabel
            // 
            this.sourceFolderLabel.AutoSize = true;
            this.sourceFolderLabel.Location = new System.Drawing.Point(12, 24);
            this.sourceFolderLabel.Name = "sourceFolderLabel";
            this.sourceFolderLabel.Size = new System.Drawing.Size(73, 13);
            this.sourceFolderLabel.TabIndex = 5;
            this.sourceFolderLabel.Text = "Source folder:";
            // 
            // destinationFolderLabel
            // 
            this.destinationFolderLabel.AutoSize = true;
            this.destinationFolderLabel.Location = new System.Drawing.Point(12, 37);
            this.destinationFolderLabel.Name = "destinationFolderLabel";
            this.destinationFolderLabel.Size = new System.Drawing.Size(92, 13);
            this.destinationFolderLabel.TabIndex = 7;
            this.destinationFolderLabel.Text = "Destination folder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 445);
            this.Controls.Add(this.destinationFolderLabel);
            this.Controls.Add(this.sourceFolderLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Advanced File Separator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label checkedFileCounter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSourceFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDestinationFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinationFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Label sourceFolderLabel;
        private System.Windows.Forms.Label destinationFolderLabel;
        private System.Windows.Forms.Label allFileCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Label findedFileCounterLabel;
        private System.Windows.Forms.TextBox sepaFileNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selFileTypeText;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button applySelectedBtn;
        private System.Windows.Forms.TextBox origWidtText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox newTypeCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox origHeightText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newHeightText;
        private System.Windows.Forms.TextBox newWidtText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox origDepthText;
        private System.Windows.Forms.TextBox origColorText;
        private System.Windows.Forms.Label imageNumberLabel;
        private System.Windows.Forms.CheckBox cropImageChk;
        private System.Windows.Forms.Label imageConverterCounterLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cropImgStartY;
        private System.Windows.Forms.TextBox cropImgStartX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox outputFilePerFolderText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox deleteAfterSeparateChk;
    }
}

