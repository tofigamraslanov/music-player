using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Creating global variables of string type array to save the name of the tracks and path of the tracks
        string[] path, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                path = openFileDialog.FileNames;

                // Dislay the music name in listbox
                foreach (var file in files)
                {
                    Songs.Items.Add(file);
                }
            }
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play music
            WindowsMediaPlayerMusic.URL = path[Songs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close();
        }
    }
}
