using AzDBStructure.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure.albums
{
    public partial class addAlbum : Form
    {
        public addAlbum()
        {
            InitializeComponent();
        }

        private void addAlbum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicStore.artists);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().CompareTo("") == 0 || textBox2.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("لطفاْ اطلاعات را کامل وارد کنید.");
                return;
            }

            
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] arrPic = ms.GetBuffer();
            ms.Close();

            SqlParameter sp = new SqlParameter("@albumArt", SqlDbType.VarBinary);
            SqlParameter sp2 = new SqlParameter("@created_at", SqlDbType.DateTime);
            sp.Value = arrPic;
            sp2.Value = DateTime.Today;


            Album um = new Album();
            um.addField("name", textBox1.Text.Trim());
            um.addField("price", textBox2.Text.Trim());
            um.addField("artist", comboBox1.SelectedValue);
            um.addField("created_at", sp2);
            um.addField("image", sp);
            um.insert();

            this.Close();
            new showAlbums().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                dlgOpen.Title = "انتخاب تصوير";
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
