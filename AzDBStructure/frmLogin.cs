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

namespace AzDBStructure
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User um = new User();
            DataTable dt = um.getQuery("username = '" + textBox1.Text + "' and password='" + textBox2.Text + "'");
            if (dt.Rows.Count == 1)
            {
                Program.access = dt.Rows[0]["role"].ToString();
                this.Close();
            }
            else
            {
                error.Text = "Invalid Username or Password";
            }
        }
    }
}
