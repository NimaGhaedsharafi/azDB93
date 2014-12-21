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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().CompareTo("") == 0 || textBox2.Text.Trim().CompareTo("") == 0) {
                MessageBox.Show("لطفاْ اطلاعات را کامل وارد کنید.");
                return ;
            }

            string role = "n";
            if (checkBox1.Checked)
            {
                role = "a";
            }

            User um = new User();
            um.addField("username", textBox1.Text.Trim());
            um.addField("password", textBox2.Text.Trim());
            um.addField("role", role);

            um.insert();

            new users.showUsers().ShowDialog();
            this.Close();
        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }
    }
}
