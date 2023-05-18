using System;
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
        //previous
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            wPlayer.controls.stop();
        }

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
                string title = "Error";
                MessageBox.Show(msg, title);
            }
            
        }

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

        private void removeBtn_Click(object sender, EventArgs e)
        {           
                songList.Items.RemoveAt(songList.SelectedIndex);        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my MusicPlayer!","Hello there!");
        }       
    }
}
