using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Model.Album da = new Model.Album();
            ReportDocument rc = new ReportDocument();
            rc.FileName = "albums.rpt";
            rc.SetDataSource(da.getQuery());
            crystalReportViewer1.ReportSource = rc;
        }
    }
}
