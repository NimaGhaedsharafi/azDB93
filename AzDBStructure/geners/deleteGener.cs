using AzDBStructure.Model;
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
    public partial class deleteGener : Form
    {
        public deleteGener()
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

            Gener um = new Gener();
            um.addField("id", textBox1.Text.Trim());

            try
            {
                um.delete();
            }
            catch
            {

            }

            new geners.showGeners().ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
