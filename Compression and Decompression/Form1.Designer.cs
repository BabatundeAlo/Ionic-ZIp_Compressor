namespace Compression_and_Decompression
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFoldername = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnFilename = new System.Windows.Forms.Button();
            this.btnZipfile = new System.Windows.Forms.Button();
            this.btnZipfolder = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtExtractTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder : ";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(90, 30);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(301, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnFoldername
            // 
            this.btnFoldername.Location = new System.Drawing.Point(396, 30);
            this.btnFoldername.Name = "btnFoldername";
            this.btnFoldername.Size = new System.Drawing.Size(33, 20);
            this.btnFoldername.TabIndex = 2;
            this.btnFoldername.Text = "...";
            this.btnFoldername.UseVisualStyleBackColor = true;
            this.btnFoldername.Click += new System.EventHandler(this.btnFoldername_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File : ";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(90, 61);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(301, 20);
            this.txtFilename.TabIndex = 5;
            // 
            // btnFilename
            // 
            this.btnFilename.Location = new System.Drawing.Point(397, 61);
            this.btnFilename.Name = "btnFilename";
            this.btnFilename.Size = new System.Drawing.Size(33, 20);
            this.btnFilename.TabIndex = 6;
            this.btnFilename.Text = "...";
            this.btnFilename.UseVisualStyleBackColor = true;
            this.btnFilename.Click += new System.EventHandler(this.btnFilename_Click);
            // 
            // btnZipfile
            // 
            this.btnZipfile.Location = new System.Drawing.Point(437, 56);
            this.btnZipfile.Name = "btnZipfile";
            this.btnZipfile.Size = new System.Drawing.Size(94, 25);
            this.btnZipfile.TabIndex = 7;
            this.btnZipfile.Text = "Compress";
            this.btnZipfile.UseVisualStyleBackColor = true;
            this.btnZipfile.Click += new System.EventHandler(this.btnZipfile_Click);
            // 
            // btnZipfolder
            // 
            this.btnZipfolder.Location = new System.Drawing.Point(437, 25);
            this.btnZipfolder.Name = "btnZipfolder";
            this.btnZipfolder.Size = new System.Drawing.Size(94, 25);
            this.btnZipfolder.TabIndex = 8;
            this.btnZipfolder.Text = "Compress";
            this.btnZipfolder.UseVisualStyleBackColor = true;
            this.btnZipfolder.Click += new System.EventHandler(this.btnZipfolder_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(92, 97);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(301, 25);
            this.progressBar.TabIndex = 9;
            // 
            // txtExtractTo
            // 
            this.txtExtractTo.Location = new System.Drawing.Point(92, 170);
            this.txtExtractTo.Name = "txtExtractTo";
            this.txtExtractTo.Size = new System.Drawing.Size(301, 20);
            this.txtExtractTo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "File : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Decompress!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExtractTo);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnZipfolder);
            this.Controls.Add(this.btnZipfile);
            this.Controls.Add(this.btnFilename);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFoldername);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFoldername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnFilename;
        private System.Windows.Forms.Button btnZipfile;
        private System.Windows.Forms.Button btnZipfolder;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtExtractTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

