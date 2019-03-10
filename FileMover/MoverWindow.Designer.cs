namespace FileMover
{
    partial class moverWindow
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
            System.Windows.Forms.Label fileNameLabel;
            this.directoryLocation = new System.Windows.Forms.TextBox();
            this.availableList = new System.Windows.Forms.ListBox();
            this.foldersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addFolder = new System.Windows.Forms.Button();
            this.fileMode = new System.Windows.Forms.RadioButton();
            this.directoryMode = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileName = new System.Windows.Forms.Label();
            this.previousElementButton = new System.Windows.Forms.Button();
            this.nextElementButton = new System.Windows.Forms.Button();
            this.actionLog = new System.Windows.Forms.TextBox();
            fileNameLabel = new System.Windows.Forms.Label();
            this.foldersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new System.Drawing.Point(189, 91);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new System.Drawing.Size(52, 13);
            fileNameLabel.TabIndex = 7;
            fileNameLabel.Text = "File name";
            // 
            // directoryLocation
            // 
            this.directoryLocation.Location = new System.Drawing.Point(192, 11);
            this.directoryLocation.Name = "directoryLocation";
            this.directoryLocation.ReadOnly = true;
            this.directoryLocation.Size = new System.Drawing.Size(945, 20);
            this.directoryLocation.TabIndex = 2;
            this.directoryLocation.Text = "Click to select directory.";
            this.directoryLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.directoryLocation_MouseDoubleClick);
            this.directoryLocation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.directoryLocation_MouseDoubleClick);
            // 
            // availableList
            // 
            this.availableList.FormattingEnabled = true;
            this.availableList.Location = new System.Drawing.Point(12, 36);
            this.availableList.Name = "availableList";
            this.availableList.Size = new System.Drawing.Size(174, 550);
            this.availableList.TabIndex = 4;
            this.availableList.SelectedValueChanged += new System.EventHandler(this.availableList_SelectedValueChanged);
            // 
            // foldersPanel
            // 
            this.foldersPanel.Controls.Add(this.addFolder);
            this.foldersPanel.Location = new System.Drawing.Point(192, 405);
            this.foldersPanel.Name = "foldersPanel";
            this.foldersPanel.Size = new System.Drawing.Size(945, 155);
            this.foldersPanel.TabIndex = 5;
            // 
            // addFolder
            // 
            this.addFolder.Location = new System.Drawing.Point(3, 3);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(75, 23);
            this.addFolder.TabIndex = 0;
            this.addFolder.Text = "Add new";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // fileMode
            // 
            this.fileMode.AutoSize = true;
            this.fileMode.Location = new System.Drawing.Point(12, 12);
            this.fileMode.Name = "fileMode";
            this.fileMode.Size = new System.Drawing.Size(71, 17);
            this.fileMode.TabIndex = 0;
            this.fileMode.Text = "File Mode";
            this.fileMode.UseVisualStyleBackColor = true;
            this.fileMode.CheckedChanged += new System.EventHandler(this.fileMode_CheckedChanged);
            // 
            // directoryMode
            // 
            this.directoryMode.AutoSize = true;
            this.directoryMode.Location = new System.Drawing.Point(89, 12);
            this.directoryMode.Name = "directoryMode";
            this.directoryMode.Size = new System.Drawing.Size(97, 17);
            this.directoryMode.TabIndex = 1;
            this.directoryMode.Text = "Directory Mode";
            this.directoryMode.UseVisualStyleBackColor = true;
            this.directoryMode.CheckedChanged += new System.EventHandler(this.directoryMode_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(455, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(189, 116);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(52, 13);
            this.fileName.TabIndex = 8;
            this.fileName.Text = "File name";
            // 
            // previousElementButton
            // 
            this.previousElementButton.Location = new System.Drawing.Point(195, 281);
            this.previousElementButton.Name = "previousElementButton";
            this.previousElementButton.Size = new System.Drawing.Size(124, 101);
            this.previousElementButton.TabIndex = 9;
            this.previousElementButton.Text = "<";
            this.previousElementButton.UseVisualStyleBackColor = true;
            this.previousElementButton.Click += new System.EventHandler(this.previousElementButton_Click);
            // 
            // nextElementButton
            // 
            this.nextElementButton.Location = new System.Drawing.Point(325, 281);
            this.nextElementButton.Name = "nextElementButton";
            this.nextElementButton.Size = new System.Drawing.Size(124, 101);
            this.nextElementButton.TabIndex = 10;
            this.nextElementButton.Text = ">";
            this.nextElementButton.UseVisualStyleBackColor = true;
            this.nextElementButton.Click += new System.EventHandler(this.nextElementButton_Click);
            // 
            // actionLog
            // 
            this.actionLog.Location = new System.Drawing.Point(192, 566);
            this.actionLog.Name = "actionLog";
            this.actionLog.ReadOnly = true;
            this.actionLog.Size = new System.Drawing.Size(945, 20);
            this.actionLog.TabIndex = 11;
            this.actionLog.Text = "Select mode to begin.";
            // 
            // moverWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 596);
            this.Controls.Add(this.actionLog);
            this.Controls.Add(this.nextElementButton);
            this.Controls.Add(this.previousElementButton);
            this.Controls.Add(this.fileName);
            this.Controls.Add(fileNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.foldersPanel);
            this.Controls.Add(this.availableList);
            this.Controls.Add(this.directoryLocation);
            this.Controls.Add(this.directoryMode);
            this.Controls.Add(this.fileMode);
            this.Name = "moverWindow";
            this.Text = "FileMover";
            this.foldersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox directoryLocation;
        private System.Windows.Forms.ListBox availableList;
        private System.Windows.Forms.FlowLayoutPanel foldersPanel;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.RadioButton fileMode;
        private System.Windows.Forms.RadioButton directoryMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button previousElementButton;
        private System.Windows.Forms.Button nextElementButton;
        private System.Windows.Forms.TextBox actionLog;
    }
}

