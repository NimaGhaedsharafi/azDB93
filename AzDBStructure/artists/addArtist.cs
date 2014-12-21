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

namespace AzDBStructure.artist
{
    public partial class addArtist : Form
    {
        public addArtist()
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

            string type = "0";
            if (radioButton2.Checked)
            {
                type = "1";
            }
            else if (radioButton3.Checked)
            {
                type = "2";
            }

            Artist am = new Artist();
            am.addField("name", textBox1.Text.Trim());
            am.addField("type", type);

            am.insert();

            new artist.showArtists().ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
