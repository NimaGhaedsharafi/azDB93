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

namespace AzDBStructure.musics
{
    public partial class deleteMusic : Form
    {
        public deleteMusic()
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

            Music um = new Music();
            um.addField("id", textBox1.Text.Trim());

            try
            {
                um.delete();
            }
            catch
            {

            }

            new musics.showMusics().ShowDialog();
            this.Close();
        }
    }
}
