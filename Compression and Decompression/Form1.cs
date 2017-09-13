using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;

namespace Compression_and_Decompression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFoldername_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path.";
            if (fbd.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbd.SelectedPath;
        }

        private void btnFilename_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() {Filter="All files|*.*",ValidateNames = true,Multiselect=false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtFilename.Text = ofd.FileName;
            }
        }

        private void btnZipfolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string path = txtFolder.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    zip.AddDirectory(path);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        //For Folder
        private void Zip_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
               {
                   progressBar.Maximum = e.EntriesTotal;
                   progressBar.Value = e.EntriesSaved + 1;
                   progressBar.Update();
               }));
            }
        }
        //For File
        private void Zip_SaveFileProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = 100;
                    progressBar.Value = (int)((e.BytesTransferred*100)/e.TotalBytesToTransfer);
                    progressBar.Update();
                }));
            }
        }

        private void btnZipfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilename.Text))
            {
                MessageBox.Show("Please select your filename.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFilename.Focus();
                return;
            }
            string filename = txtFilename.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(filename);
                    zip.AddFile(filename);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(filename);
                    zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, fi.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtExtractTo.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExtractTo.Text))
            {
                MessageBox.Show("Please select your filename.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExtractTo.Focus();
                return;
            }
            string ofile = txtExtractTo.Text;
            Thread thread = new Thread(t =>
            {
                try
                {
                    using (ZipFile zip = ZipFile.Read(txtExtractTo.Text))
                    {
                        // Loop through the archive's files.
                        foreach (ZipEntry zip_entry in zip)
                        {
                            zip_entry.Extract(txtExtractTo.Text);
                        }
                    }

                    MessageBox.Show("Done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error extracting archive.\n" +
                        ex.Message);
                }
            })
            { IsBackground = true };
            thread.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtExtractTo.Text = Path.GetFullPath(
               Path.Combine(Application.StartupPath, "..\\..\\ExtractedFiles\\"));
        }
        //{
        //    if (string.IsNullOrEmpty(txtFP.Text))
        //    {
        //        MessageBox.Show("Please select your filename.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtFP.Focus();
        //        return;
        //    }
        //    string ofile = txtFP.Text;
        //    Thread thread = new Thread(t =>
        //    {
        //        using (ZipFile unzip = ZipFile.Read(ofile))
        //        {
        //            FileInfo fi = new FileInfo(ofile);
        //            unzip.AddFile(ofile);
        //            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(ofile);
        //            unzip.ExtractAll(ofile);
        //        }
        //    })
        //    { IsBackground = true };
        //    thread.Start();
        //}
    }
}
