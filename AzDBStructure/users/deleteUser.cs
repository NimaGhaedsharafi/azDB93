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

namespace AzDBStructure.users
{
    public partial class deleteUser : Form
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("لطفاْ اطلاعات را کامل وارد کنید.");
                return;
            }

            User um = new User();
            um.addField("id", textBox1.Text.Trim());

            try
            {
                um.delete();
            }
            catch
            {

            }

            new artist.showArtists().ShowDialog();
            this.Close();
        }
    }
}
