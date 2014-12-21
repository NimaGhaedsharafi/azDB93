using CrystalDecisions.CrystalReports.Engine;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure.albums
{
    public partial class showAlbums : Form
    {
        public showAlbums()
        {
            InitializeComponent();
        }

        private void showAlbums_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.AlbumsAndArtistView' table. You can move, or remove it, as needed.
            this.albumsAndArtistViewTableAdapter.Fill(this.musicStore.AlbumsAndArtistView);

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            new AlbumsReport().ShowDialog();
        }
    }
}
