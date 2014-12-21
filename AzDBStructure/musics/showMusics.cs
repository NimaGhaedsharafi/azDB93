using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure.musics
{
    public partial class showMusics : Form
    {
        public showMusics()
        {
            InitializeComponent();
        }

        private void musicsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.musicStore);

        }

        private void showMusics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.MusicsTable' table. You can move, or remove it, as needed.
            this.musicsTableTableAdapter.Fill(this.musicStore.MusicsTable);

        }
    }
}
