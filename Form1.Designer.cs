﻿
namespace musicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.songList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.shuffleBox = new System.Windows.Forms.CheckBox();
            this.repeat = new System.Windows.Forms.CheckBox();
            this.loop = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextBtn = new System.Windows.Forms.Button();
            this.prvBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.duration = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(5, 13);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(288, 160);
            this.songList.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(24, 264);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(105, 264);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // shuffleBox
            // 
            this.shuffleBox.AutoSize = true;
            this.shuffleBox.Location = new System.Drawing.Point(217, 270);
            this.shuffleBox.Name = "shuffleBox";
            this.shuffleBox.Size = new System.Drawing.Size(59, 17);
            this.shuffleBox.TabIndex = 8;
            this.shuffleBox.Text = "Shuffle";
            this.shuffleBox.UseVisualStyleBackColor = true;
            this.shuffleBox.CheckedChanged += new System.EventHandler(this.shuffleBox_CheckedChanged);
            // 
            // repeat
            // 
            this.repeat.AutoSize = true;
            this.repeat.Location = new System.Drawing.Point(217, 247);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(61, 17);
            this.repeat.TabIndex = 10;
            this.repeat.Text = "Repeat";
            this.repeat.UseVisualStyleBackColor = true;
            // 
            // loop
            // 
            this.loop.AutoSize = true;
            this.loop.Location = new System.Drawing.Point(217, 224);
            this.loop.Name = "loop";
            this.loop.Size = new System.Drawing.Size(50, 17);
            this.loop.TabIndex = 11;
            this.loop.Text = "Loop";
            this.loop.UseVisualStyleBackColor = true;
            this.loop.CheckedChanged += new System.EventHandler(this.loop_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(105, 293);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 13;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prvBtn
            // 
            this.prvBtn.Location = new System.Drawing.Point(24, 293);
            this.prvBtn.Name = "prvBtn";
            this.prvBtn.Size = new System.Drawing.Size(75, 23);
            this.prvBtn.TabIndex = 14;
            this.prvBtn.Text = "Previous";
            this.prvBtn.UseVisualStyleBackColor = true;
            this.prvBtn.Click += new System.EventHandler(this.prvBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(212, 293);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(64, 23);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear list";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(21, 194);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(81, 13);
            this.duration.TabIndex = 16;
            this.duration.Text = "Song Duration: ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(209, 194);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(36, 13);
            this.time.TabIndex = 17;
            this.time.Text = "Time: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(111, 110);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 20;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // resumeBtn
            // 
            this.resumeBtn.BackgroundImage = global::musicPlayer.Properties.Resources.resumebtn;
            this.resumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resumeBtn.Location = new System.Drawing.Point(131, 222);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(49, 36);
            this.resumeBtn.TabIndex = 12;
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = global::musicPlayer.Properties.Resources.pausebtn;
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseBtn.Location = new System.Drawing.Point(24, 222);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(49, 36);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.Location = new System.Drawing.Point(76, 222);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(49, 36);
            this.playBtn.TabIndex = 1;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 326);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.prvBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.loop);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.shuffleBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.CheckBox shuffleBox;
        private System.Windows.Forms.CheckBox repeat;
        private System.Windows.Forms.CheckBox loop;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prvBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

