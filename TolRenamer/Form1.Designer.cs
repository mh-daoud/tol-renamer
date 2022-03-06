namespace TolRenamer
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
            this.selectSourceFolder = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceFolder = new System.Windows.Forms.TextBox();
            this.selectDestinationFolder = new System.Windows.Forms.Button();
            this.destinationFolder = new System.Windows.Forms.TextBox();
            this.startRename = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.convertMSG = new System.Windows.Forms.Label();
            this.pdfAPIButton = new System.Windows.Forms.Button();
            this.pdfReaderAPIs = new System.Windows.Forms.TextBox();
            this.namePattern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pdfOrderBy = new System.Windows.Forms.ListBox();
            this.pdfOrderLabel = new System.Windows.Forms.Label();
            this.pdfDestination = new System.Windows.Forms.TextBox();
            this.pdfTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openPdfFile = new System.Windows.Forms.OpenFileDialog();
            this.imagesNamePattern = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectSourceFolder
            // 
            this.selectSourceFolder.Location = new System.Drawing.Point(268, 16);
            this.selectSourceFolder.Name = "selectSourceFolder";
            this.selectSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.selectSourceFolder.TabIndex = 0;
            this.selectSourceFolder.Text = "Browse";
            this.selectSourceFolder.UseVisualStyleBackColor = true;
            this.selectSourceFolder.Click += new System.EventHandler(this.selectSourceFolder_Click);
            // 
            // sourceFolder
            // 
            this.sourceFolder.Location = new System.Drawing.Point(11, 16);
            this.sourceFolder.Name = "sourceFolder";
            this.sourceFolder.Size = new System.Drawing.Size(239, 20);
            this.sourceFolder.TabIndex = 1;
            this.sourceFolder.Text = "Select Source Folder";
            // 
            // selectDestinationFolder
            // 
            this.selectDestinationFolder.Location = new System.Drawing.Point(268, 59);
            this.selectDestinationFolder.Name = "selectDestinationFolder";
            this.selectDestinationFolder.Size = new System.Drawing.Size(75, 23);
            this.selectDestinationFolder.TabIndex = 2;
            this.selectDestinationFolder.Text = "Browser";
            this.selectDestinationFolder.UseVisualStyleBackColor = true;
            this.selectDestinationFolder.Click += new System.EventHandler(this.selectDestinationFolder_Click);
            // 
            // destinationFolder
            // 
            this.destinationFolder.Location = new System.Drawing.Point(11, 59);
            this.destinationFolder.Name = "destinationFolder";
            this.destinationFolder.Size = new System.Drawing.Size(239, 20);
            this.destinationFolder.TabIndex = 3;
            this.destinationFolder.Text = "Select Destination";
            // 
            // startRename
            // 
            this.startRename.Location = new System.Drawing.Point(14, 199);
            this.startRename.Name = "startRename";
            this.startRename.Size = new System.Drawing.Size(75, 29);
            this.startRename.TabIndex = 4;
            this.startRename.Text = "Rename";
            this.startRename.UseVisualStyleBackColor = true;
            this.startRename.Click += new System.EventHandler(this.startRename_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.BackColor = System.Drawing.SystemColors.Window;
            this.OrderBy.FormattingEnabled = true;
            this.OrderBy.Location = new System.Drawing.Point(96, 146);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(154, 30);
            this.OrderBy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name Order";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 449);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.convertMSG);
            this.tabPage1.Controls.Add(this.pdfAPIButton);
            this.tabPage1.Controls.Add(this.pdfReaderAPIs);
            this.tabPage1.Controls.Add(this.namePattern);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pdfOrderBy);
            this.tabPage1.Controls.Add(this.pdfOrderLabel);
            this.tabPage1.Controls.Add(this.pdfDestination);
            this.tabPage1.Controls.Add(this.pdfTextBox);
            this.tabPage1.Controls.Add(this.convertButton);
            this.tabPage1.Controls.Add(this.destinationButton);
            this.tabPage1.Controls.Add(this.pdfButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pdf";
            // 
            // convertMSG
            // 
            this.convertMSG.AutoSize = true;
            this.convertMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.convertMSG.ForeColor = System.Drawing.Color.Blue;
            this.convertMSG.Location = new System.Drawing.Point(108, 267);
            this.convertMSG.Name = "convertMSG";
            this.convertMSG.Size = new System.Drawing.Size(267, 40);
            this.convertMSG.TabIndex = 11;
            this.convertMSG.Text = "Please wait while the programe read \r\nand convert your pdf to images";
            // 
            // pdfAPIButton
            // 
            this.pdfAPIButton.Location = new System.Drawing.Point(249, 101);
            this.pdfAPIButton.Name = "pdfAPIButton";
            this.pdfAPIButton.Size = new System.Drawing.Size(75, 23);
            this.pdfAPIButton.TabIndex = 10;
            this.pdfAPIButton.Text = "Browse";
            this.pdfAPIButton.UseVisualStyleBackColor = true;
            this.pdfAPIButton.Click += new System.EventHandler(this.pdfAPIButton_Click);
            // 
            // pdfReaderAPIs
            // 
            this.pdfReaderAPIs.Enabled = false;
            this.pdfReaderAPIs.Location = new System.Drawing.Point(12, 102);
            this.pdfReaderAPIs.Name = "pdfReaderAPIs";
            this.pdfReaderAPIs.Size = new System.Drawing.Size(216, 20);
            this.pdfReaderAPIs.TabIndex = 9;
            // 
            // namePattern
            // 
            this.namePattern.Location = new System.Drawing.Point(154, 216);
            this.namePattern.Name = "namePattern";
            this.namePattern.Size = new System.Drawing.Size(246, 20);
            this.namePattern.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Optional: Name Pattern:";
            // 
            // pdfOrderBy
            // 
            this.pdfOrderBy.FormattingEnabled = true;
            this.pdfOrderBy.Location = new System.Drawing.Point(107, 164);
            this.pdfOrderBy.Name = "pdfOrderBy";
            this.pdfOrderBy.Size = new System.Drawing.Size(121, 30);
            this.pdfOrderBy.TabIndex = 6;
            // 
            // pdfOrderLabel
            // 
            this.pdfOrderLabel.AutoSize = true;
            this.pdfOrderLabel.Location = new System.Drawing.Point(21, 173);
            this.pdfOrderLabel.Name = "pdfOrderLabel";
            this.pdfOrderLabel.Size = new System.Drawing.Size(70, 13);
            this.pdfOrderLabel.TabIndex = 5;
            this.pdfOrderLabel.Text = "Order Images";
            // 
            // pdfDestination
            // 
            this.pdfDestination.Enabled = false;
            this.pdfDestination.Location = new System.Drawing.Point(11, 64);
            this.pdfDestination.Name = "pdfDestination";
            this.pdfDestination.Size = new System.Drawing.Size(218, 20);
            this.pdfDestination.TabIndex = 4;
            this.pdfDestination.Text = "Select destination folder";
            // 
            // pdfTextBox
            // 
            this.pdfTextBox.Enabled = false;
            this.pdfTextBox.Location = new System.Drawing.Point(11, 23);
            this.pdfTextBox.Name = "pdfTextBox";
            this.pdfTextBox.Size = new System.Drawing.Size(218, 20);
            this.pdfTextBox.TabIndex = 3;
            this.pdfTextBox.Text = "Select PDF file to convert into images";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(11, 271);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(83, 33);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(249, 61);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(75, 23);
            this.destinationButton.TabIndex = 1;
            this.destinationButton.Text = "Browse";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(249, 23);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(75, 23);
            this.pdfButton.TabIndex = 0;
            this.pdfButton.Text = "Browse";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.imagesNamePattern);
            this.tabPage2.Controls.Add(this.startRename);
            this.tabPage2.Controls.Add(this.sourceFolder);
            this.tabPage2.Controls.Add(this.selectDestinationFolder);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.OrderBy);
            this.tabPage2.Controls.Add(this.destinationFolder);
            this.tabPage2.Controls.Add(this.selectSourceFolder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Images";
            // 
            // openPdfFile
            // 
            this.openPdfFile.FileName = "Target File";
            this.openPdfFile.Filter = "PDF files|*.pdf";
            // 
            // imagesNamePattern
            // 
            this.imagesNamePattern.Location = new System.Drawing.Point(11, 99);
            this.imagesNamePattern.Name = "imagesNamePattern";
            this.imagesNamePattern.Size = new System.Drawing.Size(239, 20);
            this.imagesNamePattern.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 433);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TolRenamer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.TextBox sourceFolder;
        private System.Windows.Forms.Button selectDestinationFolder;
        private System.Windows.Forms.TextBox destinationFolder;
        private System.Windows.Forms.Button startRename;
        private System.Windows.Forms.ListBox OrderBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox pdfOrderBy;
        private System.Windows.Forms.Label pdfOrderLabel;
        private System.Windows.Forms.TextBox pdfDestination;
        private System.Windows.Forms.TextBox pdfTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openPdfFile;
        private System.Windows.Forms.TextBox namePattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pdfReaderAPIs;
        private System.Windows.Forms.Button pdfAPIButton;
        private System.Windows.Forms.Label convertMSG;
        private System.Windows.Forms.TextBox imagesNamePattern;
    }
}

