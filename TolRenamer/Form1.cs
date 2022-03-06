using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TolSRC;

namespace TolRenamer
{
    public partial class Form1 : Form
    {
        public Renamer renamer = new Renamer();
        public PdfConverter converter = new PdfConverter() { succsessMessage = "200" };

        string _sourceFolder = "", _destinationFolder =  "", _sourcePdfFile = "" ;

        public Form1()
        {
            InitializeComponent();
            OrderBy.Items.Add(SortOrder.DES);
            OrderBy.Items.Add(SortOrder.ASD);
            OrderBy.SelectedItem = OrderBy.Items[0];
            pdfOrderBy.Items.Add(SortOrder.DES);
            pdfOrderBy.Items.Add(SortOrder.ASD);
            pdfOrderBy.SelectedItem = pdfOrderBy.Items[0];
            pdfReaderAPIs.Text = @"C:\pdfAPIs";
            convertMSG.Visible = false;
        }

        private void selectDestinationFolder_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowNewFolderButton = true;
           DialogResult choosResult =  FolderBrowser.ShowDialog();
            if(choosResult == DialogResult.OK)
            {
                _destinationFolder = FolderBrowser.SelectedPath;
                destinationFolder.Text = @"" + _destinationFolder;
            }
        }

        private void startRename_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_sourceFolder))
            {
                MessageBox.Show("Please at least select source folder to get the files for renaming","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (renamer.StartRenamer(_sourceFolder,_destinationFolder,(SortOrder)Enum.Parse(typeof(SortOrder),OrderBy.SelectedItem.ToString()),imagesNamePattern.Text))
            {
                DialogResult result = MessageBox.Show("Done Renaming would you like to open the final folder","TolRenamer",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe",_destinationFolder);
                }
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowNewFolderButton = true;
            
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                _destinationFolder = FolderBrowser.SelectedPath;
                pdfDestination.Text = @"" + _destinationFolder;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_sourcePdfFile))
            {
                MessageBox.Show("Please at least select source file to start converting into images", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string naming = Path.GetFileName(_sourcePdfFile).Split('.')[0];
            if(!string.IsNullOrEmpty(namePattern.Text))
            {
                naming = namePattern.Text;
            }
            convertButton.Enabled = false;
            convertMSG.Visible = true;
            string response = converter.PdfToImage(_sourcePdfFile, _destinationFolder, naming , (SortOrder)Enum.Parse(typeof(SortOrder), pdfOrderBy.SelectedItem.ToString()));
            if (response  == "200")
            {
                DialogResult result = MessageBox.Show("PDF has been converted successfully, would you like to view the final folder","TolRenamer",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", _destinationFolder);
                }
            }
            else
            {
              DialogResult   result =  MessageBox.Show(response + '\n' + "Would you like to update pdf reader APIs path?" ,"Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if(result == DialogResult.Yes)
                {
                    UpdatePdfApisPAth();
                }
            }
            convertButton.Enabled = true;
            convertMSG.Visible = false;
        }

        private void pdfAPIButton_Click(object sender, EventArgs e)
        {
            UpdatePdfApisPAth();
        }

        private void UpdatePdfApisPAth()
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                pdfReaderAPIs.Text = @"" + FolderBrowser.SelectedPath;
                if(!string.IsNullOrEmpty(pdfReaderAPIs.Text))
                {
                    converter.pdfAPIsPath = pdfReaderAPIs.Text;
                }
            }
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            if(openPdfFile.ShowDialog() == DialogResult.OK) {
                _sourcePdfFile = openPdfFile.FileName;
                pdfTextBox.Text = @"" + _sourcePdfFile;
                _destinationFolder = Path.Combine( Path.GetDirectoryName(_sourcePdfFile), "Done");
                pdfDestination.Text = _destinationFolder;

            }
        }

        private void selectSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowNewFolderButton = false;
            DialogResult choosResult = FolderBrowser.ShowDialog();
            if (choosResult == DialogResult.OK)
            {
                _sourceFolder = FolderBrowser.SelectedPath;
                sourceFolder.Text = @"" + _sourceFolder;
                _destinationFolder = _sourceFolder + @"\Done";
                destinationFolder.Text = _destinationFolder;
            }
        }












    }
}
