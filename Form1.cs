using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace musicPlayer
{
    public partial class Form1 : Form
    {
        string[] files, paths;
        WMPLib.WindowsMediaPlayer wPlayer = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        //previous song button
        private void previousBtn_Click(object sender, EventArgs e)
        {

        }

        //pause song
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            wPlayer.controls.stop();
        }

        //play song button - throw error when user clicked Play with no song selected
        private void playBtn_Click(object sender, EventArgs e)
        {                  
            try
            {
                wPlayer.URL = paths[songList.SelectedIndex];
                wPlayer.controls.play();
            }
            catch
            {
                string msg = "Please choose a song";
                string title = "Error playing song";
                MessageBox.Show(msg, title);
            }
            
        }

        //add song button - can add multiple song - all files accepted
        private void addBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog addSong = new OpenFileDialog();
            addSong.Multiselect = true;
            addSong.Filter = "All Files|*.*";
                if(addSong.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = addSong.SafeFileNames;
                paths = addSong.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                   songList.Items.Add(files[i]);
                }
            }
        }

        //remove song button - throw error when user clicked Remove with no song selected
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                songList.Items.RemoveAt(songList.SelectedIndex);
            }
            catch
            {
                string msg = "No song selected";
                string title = "Error removing song";
                MessageBox.Show(msg, title);
            }
        }

        private void loop_CheckedChanged(object sender, EventArgs e)
        {           
            if (loop.Checked)
            {
                wPlayer.settings.setMode("Loop", true);
            }
            else
            {
                wPlayer.settings.setMode("Loop", false);
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (songList.SelectedIndex < files.Length - 1)
            {
                songList.SelectedIndex++;
                timer1.Enabled = false;
            }
            else
            {
                songList.SelectedIndex = 0;
                timer1.Enabled = false;
            }
        }

        private void shuffleBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        //what the form will do when user opens the program
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to my MusicPlayer!","Hello there!");
            //hide windows media player UI
            //axWindowsMediaPlayer1.uiMode = "Invisible";
        }

        
    }
}
