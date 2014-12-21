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
using System.Data.SqlClient;

namespace AzDBStructure.musics
{
    public partial class addMusic : Form
    {
        public addMusic()
        {
            InitializeComponent();
        }

        private void addMusic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStore.artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicStore.artists);
            // TODO: This line of code loads data into the 'musicStore.albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicStore.albums);
            // TODO: This line of code loads data into the 'musicStore.geners' table. You can move, or remove it, as needed.
            this.genersTableAdapter.Fill(this.musicStore.geners);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.artistsTableAdapter.FillBy(this.musicStore.artists);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.artistsTableAdapter.FillBy1(this.musicStore.artists);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("لطفاْ اطلاعات را کامل وارد کنید.");
                return;
            }

            SqlParameter ca = new SqlParameter("@created_at", SqlDbType.DateTime);
            ca.Value = DateTime.Today;


            Music mda = new Music();
            mda.addField("name", textBox1.Text.Trim());
            mda.addField("album", album.SelectedValue);
            mda.addField("poet", poet.SelectedValue);
            mda.addField("composer", composer.SelectedValue);
            mda.addField("gener", gener.SelectedValue.ToString());
            mda.addField("lyrics", lyric.Text.Trim());
            mda.addField("price", price.Text.Trim());
            mda.addField("created_at", ca);

            mda.insert();

            new musics.showMusics().ShowDialog();
            this.Close();
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.artistsTableAdapter.FillBy2(this.musicStore.artists);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.artistsTableAdapter.FillBy3(this.musicStore.artists);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.artistsTableAdapter.FillBy1(this.musicStore.artists);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void poet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.artistsTableAdapter.a(this.musicStore.artists);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
