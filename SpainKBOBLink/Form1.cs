using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpainKBOBLink
{
    public partial class Form1 : Form
    {
        private DBConnect db = new DBConnect();

        public Form1()
        {
            InitializeComponent();

            kbobGrid.DataSource = db.SelectKBOB();
            ResizeKBOBColumns();
        }

        private void ResizeKBOBColumns()
        {
            kbobGrid.Columns["IdKBOB"].Visible = false;
            kbobGrid.Columns["KBOB"].Width = 50;
            kbobGrid.Columns["NameGerman"].Width = 300;
            kbobGrid.Columns["SurfaceMass"].Width = 55;
            kbobGrid.Columns["SurfaceMassUnit"].Width = 50;
            kbobGrid.Columns["Ubp13Manufacture"].Width = 70;
            kbobGrid.Columns["Ubp13Disposal"].Width = 70;
            kbobGrid.Columns["TotalProduction"].Width = 70;
            kbobGrid.Columns["TotalDisposal"].Width = 70;
            kbobGrid.Columns["RenewableProduction"].Width = 70;
            kbobGrid.Columns["RenewableDisposal"].Width = 70;
            kbobGrid.Columns["NonRenewableProduction"].Width = 70;
            kbobGrid.Columns["NonRenewableDisposal"].Width = 70;
            kbobGrid.Columns["GreenhouseGasEmissionsProduction"].Width = 70;
            kbobGrid.Columns["GreenhouseGasEmissionsDisposal"].Width = 70;
        }
    }
}
