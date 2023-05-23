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
        //WindowsMediaPlayer wPlayer = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        //pause song
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        //play song button - throw error when user clicked Play with no song selected
        private void playBtn_Click(object sender, EventArgs e)
        {                  
            try
            {
                axWindowsMediaPlayer1.URL = paths[songList.SelectedIndex];
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

        //remove song button - throw error when user clicked Remove with no song is selected
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
    
        private void shuffleBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            songList.Items.Clear();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if(songList.SelectedIndex < songList.Items.Count - 1)
            {
                songList.SelectedIndex = songList.SelectedIndex + 1;
            }
            else
            {
                songList.SelectedIndex = 0;
            }
        }

        private void prvBtn_Click(object sender, EventArgs e)
        {
            if (songList.SelectedIndex > 0)
            {
                songList.SelectedIndex = songList.SelectedIndex - 1;
            }
            else
            {
                songList.SelectedIndex = 0;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        { 
            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }
        
       
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            label1.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            if (e.newState == 3)
            {
                label3.Text = "Playing: " + axWindowsMediaPlayer1.Ctlcontrols.currentItem.name;
            }

            if (loop.Checked)
            {
                axWindowsMediaPlayer1.settings.setMode("Loop", true);
            }
            else
            {
                axWindowsMediaPlayer1.settings.setMode("Loop", false);
            }

            if (e.newState == 8)
            {
                if (repeat.Checked)
                {
                    BeginInvoke(new Action(() =>
                    {
                        if (songList.SelectedIndex >= songList.Items.Count - 1)
                        {
                            songList.SelectedIndex = 0;
                        }
                        else
                        {
                            songList.SelectedIndex = songList.SelectedIndex + 1;
                        }
                        axWindowsMediaPlayer1.URL = paths[songList.SelectedIndex];
                    }));
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
            }

        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[songList.SelectedIndex];
        }

        //what the form will do when user opens the program
        private void Form1_Load(object sender, EventArgs e)
        {
            //hide windows media player UI
            axWindowsMediaPlayer1.uiMode = "Invisible";
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }      
    }
}
