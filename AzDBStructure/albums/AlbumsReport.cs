using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Model;

namespace AzDBStructure.albums
{
    public partial class AlbumsReport : Form
    {
        public AlbumsReport()
        {
            InitializeComponent();
        }

        private void AlbumsReport_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"E:\Programming\Windows Programming\C#\AzDBStructure\AzDBStructure\albums\Albums.rpt");

            Model.Album ma = new Model.Album();

            rd.SetDataSource(ma.getQuery());

            crystalReportViewer1.ReportSource = rd;            
            crystalReportViewer1.Refresh();
        }
    }
}
