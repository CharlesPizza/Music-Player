using System.Media;
using System.Runtime.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;
namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mp3Player()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowPlaying.Text != null)
            {
               
                try
                {
                    SoundPlayer sp = new SoundPlayer(nowPlaying.Text);
                    sp.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing track...");
                }
            }
        }


        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an audio file...";
            ofd.Filter = "Audio files (*.wav)|*.wav|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                nowPlaying.Text = filename;
            }
        }


    }
}
