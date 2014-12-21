using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzDBStructure.Model;

namespace AzDBStructure
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi, @" + Program.username;
            Music mm = new Music();
            musicCount.Text = "Music: " + mm.getQuery().Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new users.showUsers().ShowDialog();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              new users.addUser().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new users.deleteUser().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new geners.showGeners().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new artist.showArtists().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new artist.addArtist().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new artist.deleteArtists().ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new geners.addGener().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new geners.deleteGener().ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new albums.showAlbums().ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new albums.addAlbum().ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            new musics.showMusics().ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new musics.addMusic().ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new musics.deleteMusic().ShowDialog();
        }
    }
}
