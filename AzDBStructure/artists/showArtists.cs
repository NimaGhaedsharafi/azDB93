using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure.artist
{
    public partial class showArtists : Form
    {
        public showArtists()
        {
            InitializeComponent();
        }

        private void artistsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artistsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicStore);

        }

        private void showArtist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicStore.artists);

        }
    }
}
