/*
 * Copyright (c) 2013, Darren Horrocks
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 * 
 * Redistributions of source code must retain the above copyright notice, this list 
 * of conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, this 
 * list of conditions and the following disclaimer in the documentation and/or 
 * other materials provided with the distribution.
 * Neither the name of Darren Horrocks/www.bizzeh.com nor the names of its 
 * contributors may be used to endorse or promote products derived from this software 
 * without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY 
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES 
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT 
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF 
 * THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
namespace OKResizer
{
  partial class frmMain
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
      this.txtSource = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTarget = new System.Windows.Forms.TextBox();
      this.cmdSource = new System.Windows.Forms.Button();
      this.cmdTarget = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.chkEnableCaptions = new System.Windows.Forms.CheckBox();
      this.chkDoNotCrop = new System.Windows.Forms.CheckBox();
      this.txtHtmlClass = new System.Windows.Forms.TextBox();
      this.txtHtmlFilePrefix = new System.Windows.Forms.TextBox();
      this.numJpegQuality = new System.Windows.Forms.NumericUpDown();
      this.txtMax = new System.Windows.Forms.TextBox();
      this.chkRenameOriginal = new System.Windows.Forms.CheckBox();
      this.progMain = new System.Windows.Forms.ProgressBar();
      this.cmdGo = new System.Windows.Forms.Button();
      this.txtHtmlOut = new System.Windows.Forms.TextBox();
      this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
      this.mnuMain = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSelect = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileCrop = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuAboutAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.chkSaveAllJpg = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.numJpegQuality)).BeginInit();
      this.mnuMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtSource
      // 
      this.txtSource.Location = new System.Drawing.Point(104, 32);
      this.txtSource.Name = "txtSource";
      this.txtSource.Size = new System.Drawing.Size(518, 20);
      this.txtSource.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Source Directory";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Target Directory";
      // 
      // txtTarget
      // 
      this.txtTarget.Location = new System.Drawing.Point(104, 58);
      this.txtTarget.Name = "txtTarget";
      this.txtTarget.Size = new System.Drawing.Size(518, 20);
      this.txtTarget.TabIndex = 2;
      // 
      // cmdSource
      // 
      this.cmdSource.Location = new System.Drawing.Point(628, 32);
      this.cmdSource.Name = "cmdSource";
      this.cmdSource.Size = new System.Drawing.Size(44, 20);
      this.cmdSource.TabIndex = 4;
      this.cmdSource.Text = "...";
      this.cmdSource.UseVisualStyleBackColor = true;
      this.cmdSource.Click += new System.EventHandler(this.cmdSource_Click);
      // 
      // cmdTarget
      // 
      this.cmdTarget.Location = new System.Drawing.Point(628, 58);
      this.cmdTarget.Name = "cmdTarget";
      this.cmdTarget.Size = new System.Drawing.Size(44, 20);
      this.cmdTarget.TabIndex = 5;
      this.cmdTarget.Text = "...";
      this.cmdTarget.UseVisualStyleBackColor = true;
      this.cmdTarget.Click += new System.EventHandler(this.cmdTarget_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 87);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Maximum Size";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(161, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(288, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Maximum Size = H and W for crop, Longest side for no crop";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(548, 86);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "JPEG Quality";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 113);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(85, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "HTML File Prefix";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(198, 113);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(65, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "HTML Class";
      // 
      // chkEnableCaptions
      // 
      this.chkEnableCaptions.AutoSize = true;
      this.chkEnableCaptions.Checked = global::OKResizer.Properties.Settings.Default.captionHtml;
      this.chkEnableCaptions.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OKResizer.Properties.Settings.Default, "captionHtml", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkEnableCaptions.Location = new System.Drawing.Point(456, 112);
      this.chkEnableCaptions.Name = "chkEnableCaptions";
      this.chkEnableCaptions.Size = new System.Drawing.Size(95, 17);
      this.chkEnableCaptions.TabIndex = 16;
      this.chkEnableCaptions.Text = "Caption HTML";
      this.chkEnableCaptions.UseVisualStyleBackColor = true;
      // 
      // chkDoNotCrop
      // 
      this.chkDoNotCrop.AutoSize = true;
      this.chkDoNotCrop.Checked = global::OKResizer.Properties.Settings.Default.doNotCrop;
      this.chkDoNotCrop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OKResizer.Properties.Settings.Default, "doNotCrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkDoNotCrop.Location = new System.Drawing.Point(369, 112);
      this.chkDoNotCrop.Name = "chkDoNotCrop";
      this.chkDoNotCrop.Size = new System.Drawing.Size(85, 17);
      this.chkDoNotCrop.TabIndex = 15;
      this.chkDoNotCrop.Text = "Do Not Crop";
      this.chkDoNotCrop.UseVisualStyleBackColor = true;
      // 
      // txtHtmlClass
      // 
      this.txtHtmlClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OKResizer.Properties.Settings.Default, "htmlClass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtHtmlClass.Location = new System.Drawing.Point(269, 110);
      this.txtHtmlClass.Name = "txtHtmlClass";
      this.txtHtmlClass.Size = new System.Drawing.Size(94, 20);
      this.txtHtmlClass.TabIndex = 13;
      this.txtHtmlClass.Text = global::OKResizer.Properties.Settings.Default.htmlClass;
      // 
      // txtHtmlFilePrefix
      // 
      this.txtHtmlFilePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OKResizer.Properties.Settings.Default, "htmlFilePrefix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtHtmlFilePrefix.Location = new System.Drawing.Point(104, 110);
      this.txtHtmlFilePrefix.Name = "txtHtmlFilePrefix";
      this.txtHtmlFilePrefix.Size = new System.Drawing.Size(88, 20);
      this.txtHtmlFilePrefix.TabIndex = 11;
      this.txtHtmlFilePrefix.Text = global::OKResizer.Properties.Settings.Default.htmlFilePrefix;
      // 
      // numJpegQuality
      // 
      this.numJpegQuality.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::OKResizer.Properties.Settings.Default, "jpegQuality", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numJpegQuality.Location = new System.Drawing.Point(621, 84);
      this.numJpegQuality.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numJpegQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numJpegQuality.Name = "numJpegQuality";
      this.numJpegQuality.Size = new System.Drawing.Size(51, 20);
      this.numJpegQuality.TabIndex = 9;
      this.numJpegQuality.Value = global::OKResizer.Properties.Settings.Default.jpegQuality;
      this.numJpegQuality.ValueChanged += new System.EventHandler(this.numJpegQuality_ValueChanged);
      // 
      // txtMax
      // 
      this.txtMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OKResizer.Properties.Settings.Default, "maximumSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtMax.Location = new System.Drawing.Point(104, 84);
      this.txtMax.Name = "txtMax";
      this.txtMax.Size = new System.Drawing.Size(55, 20);
      this.txtMax.TabIndex = 7;
      this.txtMax.Text = global::OKResizer.Properties.Settings.Default.maximumSize;
      // 
      // chkRenameOriginal
      // 
      this.chkRenameOriginal.AutoSize = true;
      this.chkRenameOriginal.Checked = global::OKResizer.Properties.Settings.Default.renameOriginal;
      this.chkRenameOriginal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OKResizer.Properties.Settings.Default, "renameOriginal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkRenameOriginal.Location = new System.Drawing.Point(552, 112);
      this.chkRenameOriginal.Name = "chkRenameOriginal";
      this.chkRenameOriginal.Size = new System.Drawing.Size(104, 17);
      this.chkRenameOriginal.TabIndex = 17;
      this.chkRenameOriginal.Text = "Rename Original";
      this.chkRenameOriginal.UseVisualStyleBackColor = true;
      // 
      // progMain
      // 
      this.progMain.Location = new System.Drawing.Point(15, 136);
      this.progMain.Name = "progMain";
      this.progMain.Size = new System.Drawing.Size(607, 23);
      this.progMain.Step = 1;
      this.progMain.TabIndex = 18;
      // 
      // cmdGo
      // 
      this.cmdGo.Location = new System.Drawing.Point(628, 136);
      this.cmdGo.Name = "cmdGo";
      this.cmdGo.Size = new System.Drawing.Size(44, 23);
      this.cmdGo.TabIndex = 19;
      this.cmdGo.Text = "Go";
      this.cmdGo.UseVisualStyleBackColor = true;
      this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
      // 
      // txtHtmlOut
      // 
      this.txtHtmlOut.Location = new System.Drawing.Point(15, 165);
      this.txtHtmlOut.Multiline = true;
      this.txtHtmlOut.Name = "txtHtmlOut";
      this.txtHtmlOut.ReadOnly = true;
      this.txtHtmlOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtHtmlOut.Size = new System.Drawing.Size(657, 204);
      this.txtHtmlOut.TabIndex = 20;
      // 
      // fbdMain
      // 
      this.fbdMain.ShowNewFolderButton = false;
      // 
      // mnuMain
      // 
      this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout});
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Size = new System.Drawing.Size(684, 24);
      this.mnuMain.TabIndex = 21;
      this.mnuMain.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSelect,
            this.toolStripMenuItem1,
            this.mnuFileCrop,
            this.toolStripMenuItem2,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(37, 20);
      this.mnuFile.Text = "File";
      // 
      // mnuFileSelect
      // 
      this.mnuFileSelect.Name = "mnuFileSelect";
      this.mnuFileSelect.Size = new System.Drawing.Size(178, 22);
      this.mnuFileSelect.Text = "Select Source";
      this.mnuFileSelect.Click += new System.EventHandler(this.mnuFileSelect_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
      // 
      // mnuFileCrop
      // 
      this.mnuFileCrop.Name = "mnuFileCrop";
      this.mnuFileCrop.Size = new System.Drawing.Size(178, 22);
      this.mnuFileCrop.Text = "Crop/Resize Images";
      this.mnuFileCrop.Click += new System.EventHandler(this.mnuFileCrop_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(178, 22);
      this.mnuFileExit.Text = "Exit";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // mnuAbout
      // 
      this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutAbout});
      this.mnuAbout.Name = "mnuAbout";
      this.mnuAbout.Size = new System.Drawing.Size(52, 20);
      this.mnuAbout.Text = "About";
      // 
      // mnuAboutAbout
      // 
      this.mnuAboutAbout.Name = "mnuAboutAbout";
      this.mnuAboutAbout.Size = new System.Drawing.Size(107, 22);
      this.mnuAboutAbout.Text = "About";
      this.mnuAboutAbout.Click += new System.EventHandler(this.mnuAboutAbout_Click);
      // 
      // chkSaveAllJpg
      // 
      this.chkSaveAllJpg.AutoSize = true;
      this.chkSaveAllJpg.Checked = global::OKResizer.Properties.Settings.Default.saveAllJpg;
      this.chkSaveAllJpg.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OKResizer.Properties.Settings.Default, "saveAllJpg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chkSaveAllJpg.Location = new System.Drawing.Point(456, 85);
      this.chkSaveAllJpg.Name = "chkSaveAllJpg";
      this.chkSaveAllJpg.Size = new System.Drawing.Size(95, 17);
      this.chkSaveAllJpg.TabIndex = 22;
      this.chkSaveAllJpg.Text = "Save all as jpg";
      this.chkSaveAllJpg.UseVisualStyleBackColor = true;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 381);
      this.Controls.Add(this.chkSaveAllJpg);
      this.Controls.Add(this.txtHtmlOut);
      this.Controls.Add(this.cmdGo);
      this.Controls.Add(this.progMain);
      this.Controls.Add(this.chkRenameOriginal);
      this.Controls.Add(this.chkEnableCaptions);
      this.Controls.Add(this.chkDoNotCrop);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtHtmlClass);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtHtmlFilePrefix);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.numJpegQuality);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtMax);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cmdTarget);
      this.Controls.Add(this.cmdSource);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtTarget);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSource);
      this.Controls.Add(this.mnuMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmMain";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "OK Resizer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.numJpegQuality)).EndInit();
      this.mnuMain.ResumeLayout(false);
      this.mnuMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSource;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTarget;
    private System.Windows.Forms.Button cmdSource;
    private System.Windows.Forms.Button cmdTarget;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMax;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numJpegQuality;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtHtmlFilePrefix;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtHtmlClass;
    private System.Windows.Forms.CheckBox chkDoNotCrop;
    private System.Windows.Forms.CheckBox chkEnableCaptions;
    private System.Windows.Forms.CheckBox chkRenameOriginal;
    private System.Windows.Forms.ProgressBar progMain;
    private System.Windows.Forms.Button cmdGo;
    private System.Windows.Forms.TextBox txtHtmlOut;
    private System.Windows.Forms.FolderBrowserDialog fbdMain;
    private System.Windows.Forms.MenuStrip mnuMain;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSelect;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuFileCrop;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    private System.Windows.Forms.ToolStripMenuItem mnuAboutAbout;
    private System.Windows.Forms.CheckBox chkSaveAllJpg;
  }
}

