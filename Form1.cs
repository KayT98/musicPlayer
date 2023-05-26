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
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
                    paths = (paths ?? Enumerable.Empty<string>()).Concat(addSong.FileNames).ToArray();

                    for (int i = 0; i < files.Length; i++)
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
        
        //shuffle files in listbox
        private void shuffleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (shuffleBox.Checked)
            {
                ListBox.ObjectCollection list = songList.Items;
                Random random = new Random();
                int song = list.Count;
                songList.BeginUpdate();
                while (song > 1)
                {
                    song--;
                    int randSong = random.Next(song + 1);
                    object value = list[randSong];
                    list[randSong] = list[song];
                    list[song] = value;
                }
                songList.EndUpdate();
                songList.Invalidate();
            }
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
            //display the song current position (time)
            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            
            //display song duration
            label1.Text = axWindowsMediaPlayer1.currentMedia.durationString;

            //display which song is playing         
            if (e.newState == 3) //3 is Playing state
            {
                label3.Text = "Now Playing: " + axWindowsMediaPlayer1.Ctlcontrols.currentItem.name;
            }


            //when user checked/unchecked repeat checkbox, the songs will loop through all songs in listbox
            //if uncheck, it will play only one song and then stop

            if (e.newState == 8) //8 is MediaEnded state -- when a song ended
            {
                    BeginInvoke(new Action(() =>
                    {
                        if (songList.SelectedIndex >= songList.Items.Count - 1)
                        {
                            songList.SelectedIndex = 0;
                        }
                        else if (loop.Checked)
                        {
                            axWindowsMediaPlayer1.settings.setMode("Loop", true);
                        }
                        else
                        {
                            songList.SelectedIndex = songList.SelectedIndex + 1;
                            axWindowsMediaPlayer1.settings.setMode("Loop", false);
                        }
                        axWindowsMediaPlayer1.URL = paths[songList.SelectedIndex];
                        timer1.Start();
                    }));  
            }
            else
            {
                songList.SelectedIndex = songList.SelectedIndex;
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused) 
            {
                timer1.Stop();
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }
        }

        //allows user to play songs by clicking them inside listbox 
        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[songList.SelectedIndex];
        }

        //volume btn
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        //mute song
        private void mute_CheckedChanged(object sender, EventArgs e)
        {
            if (mute.Checked)
            {
                axWindowsMediaPlayer1.settings.mute = true;
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
            }          
        }

        private void loop_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        //what the form will do when user opens the program
        private void Form1_Load(object sender, EventArgs e)
        {
            //hide windows media player UI
            axWindowsMediaPlayer1.uiMode = "Invisible";
        }      
    }
}
