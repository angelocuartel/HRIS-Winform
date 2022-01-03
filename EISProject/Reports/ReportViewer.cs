using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace EISProject.Reports
{
    public partial class ReportViewer : Form
    {
        public ReportViewer(ReportDocument document)

        { 
            InitializeComponent();


            crystalReportViewer1.ReportSource = document;
            crystalReportViewer1.RefreshReport();
          
        }
    }
}
