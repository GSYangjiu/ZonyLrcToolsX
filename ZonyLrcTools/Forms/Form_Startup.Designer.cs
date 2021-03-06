﻿namespace ZonyLrcTools.Forms
{
    partial class Form_Startup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_BuildInLyric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Ablum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MusicArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MusicTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_AlbumImg = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_SearchFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_DownloadLyric = new System.Windows.Forms.ToolStripButton();
            this.button_StopDownload = new System.Windows.Forms.ToolStripButton();
            this.button_DownloadAlbumImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button_PluginsManager = new System.Windows.Forms.ToolStripButton();
            this.button_Setting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button_About = new System.Windows.Forms.ToolStripButton();
            this.button_Donate = new System.Windows.Forms.ToolStripButton();
            this.button_Feedback = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listView_SongItems = new Zony.Lib.UIComponents.ListViewNF();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlbumImg)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_BuildInLyric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Ablum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_MusicArtist);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_MusicTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox_AlbumImg);
            this.groupBox1.Location = new System.Drawing.Point(619, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "歌曲信息编辑";
            // 
            // textBox_BuildInLyric
            // 
            this.textBox_BuildInLyric.Location = new System.Drawing.Point(46, 284);
            this.textBox_BuildInLyric.Multiline = true;
            this.textBox_BuildInLyric.Name = "textBox_BuildInLyric";
            this.textBox_BuildInLyric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_BuildInLyric.Size = new System.Drawing.Size(163, 179);
            this.textBox_BuildInLyric.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "歌词:";
            // 
            // textBox_Ablum
            // 
            this.textBox_Ablum.Location = new System.Drawing.Point(46, 260);
            this.textBox_Ablum.Name = "textBox_Ablum";
            this.textBox_Ablum.Size = new System.Drawing.Size(163, 21);
            this.textBox_Ablum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "专辑:";
            // 
            // textBox_MusicArtist
            // 
            this.textBox_MusicArtist.Location = new System.Drawing.Point(46, 236);
            this.textBox_MusicArtist.Name = "textBox_MusicArtist";
            this.textBox_MusicArtist.Size = new System.Drawing.Size(163, 21);
            this.textBox_MusicArtist.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "歌手:";
            // 
            // textBox_MusicTitle
            // 
            this.textBox_MusicTitle.Location = new System.Drawing.Point(46, 212);
            this.textBox_MusicTitle.Name = "textBox_MusicTitle";
            this.textBox_MusicTitle.Size = new System.Drawing.Size(163, 21);
            this.textBox_MusicTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "标题:";
            // 
            // pictureBox_AlbumImg
            // 
            this.pictureBox_AlbumImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_AlbumImg.Location = new System.Drawing.Point(9, 20);
            this.pictureBox_AlbumImg.Name = "pictureBox_AlbumImg";
            this.pictureBox_AlbumImg.Size = new System.Drawing.Size(200, 185);
            this.pictureBox_AlbumImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_AlbumImg.TabIndex = 0;
            this.pictureBox_AlbumImg.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(550, 17);
            this.toolStripStatusLabel1.Text = "状态:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_SearchFile,
            this.toolStripSeparator1,
            this.button_DownloadLyric,
            this.button_StopDownload,
            this.button_DownloadAlbumImage,
            this.toolStripSeparator2,
            this.button_PluginsManager,
            this.button_Setting,
            this.toolStripSeparator3,
            this.button_About,
            this.button_Donate,
            this.button_Feedback,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_SearchFile
            // 
            this.button_SearchFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_SearchFile.Name = "button_SearchFile";
            this.button_SearchFile.Size = new System.Drawing.Size(60, 22);
            this.button_SearchFile.Text = "扫描歌曲";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_DownloadLyric
            // 
            this.button_DownloadLyric.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_DownloadLyric.Name = "button_DownloadLyric";
            this.button_DownloadLyric.Size = new System.Drawing.Size(60, 22);
            this.button_DownloadLyric.Text = "下载歌词";
            // 
            // button_StopDownload
            // 
            this.button_StopDownload.Enabled = false;
            this.button_StopDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_StopDownload.Name = "button_StopDownload";
            this.button_StopDownload.Size = new System.Drawing.Size(60, 22);
            this.button_StopDownload.Text = "停止下载";
            // 
            // button_DownloadAlbumImage
            // 
            this.button_DownloadAlbumImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_DownloadAlbumImage.Name = "button_DownloadAlbumImage";
            this.button_DownloadAlbumImage.Size = new System.Drawing.Size(84, 22);
            this.button_DownloadAlbumImage.Text = "下载专辑图像";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button_PluginsManager
            // 
            this.button_PluginsManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_PluginsManager.Name = "button_PluginsManager";
            this.button_PluginsManager.Size = new System.Drawing.Size(60, 22);
            this.button_PluginsManager.Text = "插件管理";
            // 
            // button_Setting
            // 
            this.button_Setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(36, 22);
            this.button_Setting.Text = "设置";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button_About
            // 
            this.button_About.Enabled = false;
            this.button_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(36, 22);
            this.button_About.Text = "帮助";
            // 
            // button_Donate
            // 
            this.button_Donate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Donate.Name = "button_Donate";
            this.button_Donate.Size = new System.Drawing.Size(36, 22);
            this.button_Donate.Text = "捐赠";
            // 
            // button_Feedback
            // 
            this.button_Feedback.Enabled = false;
            this.button_Feedback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Feedback.Name = "button_Feedback";
            this.button_Feedback.Size = new System.Drawing.Size(66, 22);
            this.button_Feedback.Text = "反馈 BUG";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // listView_SongItems
            // 
            this.listView_SongItems.AllowDrop = true;
            this.listView_SongItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_SongItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.listView_SongItems.Location = new System.Drawing.Point(14, 29);
            this.listView_SongItems.Name = "listView_SongItems";
            this.listView_SongItems.Size = new System.Drawing.Size(599, 493);
            this.listView_SongItems.TabIndex = 0;
            this.listView_SongItems.UseCompatibleStateImageBehavior = false;
            this.listView_SongItems.View = System.Windows.Forms.View.Details;
            this.listView_SongItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_SongItems_DragDrop);
            this.listView_SongItems.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_SongItems_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "标题";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手/艺术家";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专辑/唱片集";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "标签类型";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.Width = 65;
            // 
            // Form_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 553);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_SongItems);
            this.Name = "Form_Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZonyLrcTools X";
            this.Load += new System.EventHandler(this.Form_Startup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlbumImg)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zony.Lib.UIComponents.ListViewNF listView_SongItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_DownloadLyric;
        private System.Windows.Forms.ToolStripButton button_DownloadAlbumImage;
        private System.Windows.Forms.ToolStripButton button_SearchFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton button_Setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton button_About;
        private System.Windows.Forms.ToolStripButton button_Donate;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox_AlbumImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MusicTitle;
        private System.Windows.Forms.TextBox textBox_MusicArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Ablum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton button_StopDownload;
        private System.Windows.Forms.ToolStripButton button_PluginsManager;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBox_BuildInLyric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton button_Feedback;
    }
}