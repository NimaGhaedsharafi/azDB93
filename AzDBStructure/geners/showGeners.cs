using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure.geners
{
    public partial class showGeners : Form
    {
        public showGeners()
        {
            InitializeComponent();
        }

        private void genersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicStore);

        }

        private void showGeners_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.geners' table. You can move, or remove it, as needed.
            this.genersTableAdapter.Fill(this.musicStore.geners);

        }
    }
}
