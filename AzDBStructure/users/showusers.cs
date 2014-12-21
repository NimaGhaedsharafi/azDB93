using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure.users
{
    public partial class showUsers : Form
    {
        public showUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicStore);

        }

        private void show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.musicStore.users);

        }
    }
}
