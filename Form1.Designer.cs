
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.previousBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.songList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.suffleBox = new System.Windows.Forms.CheckBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(5, 260);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 0;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(86, 260);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(167, 260);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(248, 260);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 196);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(318, 12);
            this.progressBar.TabIndex = 4;
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(5, 13);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(317, 160);
            this.songList.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(47, 231);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(209, 231);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // suffleBox
            // 
            this.suffleBox.AutoSize = true;
            this.suffleBox.Location = new System.Drawing.Point(12, 289);
            this.suffleBox.Name = "suffleBox";
            this.suffleBox.Size = new System.Drawing.Size(53, 17);
            this.suffleBox.TabIndex = 8;
            this.suffleBox.Text = "Suffle";
            this.suffleBox.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(25, 100);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(259, 58);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 313);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.suffleBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.previousBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.CheckBox suffleBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

