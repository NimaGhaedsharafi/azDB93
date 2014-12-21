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
    public partial class addGener : Form
    {
        public addGener()
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

            Gener gm = new Gener();
            gm.addField("name", textBox1.Text.Trim());

            gm.insert();

            new geners.showGeners().ShowDialog();
            this.Close();
        }
    }
}
