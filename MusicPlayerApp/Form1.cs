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
    public partial class musicPlayerApp : Form
    {
        public musicPlayerApp()
        {
            InitializeComponent();
        }

        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Music (.mp3)|*.mp3";
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i=0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            } 
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void windowsMediaPlayerMusic_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
