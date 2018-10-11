using System;
using System.Windows.Forms;

namespace SpainKBOBLink
{
    public partial class Form1 : Form
    {
        private DBConnect db = new DBConnect();

        public Form1()
        {
            InitializeComponent();

            groupSelectComboBox.DataSource = db.SelectGroups();
            spanishGrid.DataSource = db.SelectSpanishMaterials(groupSelectComboBox.SelectedItem.ToString());
            kbobGrid.DataSource = db.SelectKBOB();
            RefreshJoinedTable(spanishGrid.Rows[0].Cells["ShortDescription"].Value.ToString());
            ResizeSpanishColumns();
            ResizeKBOBColumns();
        }

        private void ResizeSpanishColumns()
        {
            spanishGrid.Columns["IdMaterial"].Visible = false;
            spanishGrid.Columns["MaterialGroup"].Visible = false;
            spanishGrid.Columns["ShortDescription"].Width = 290;
            spanishGrid.Columns["CO2"].Width = 60;
            spanishGrid.Columns["EnergyConsumption"].Width = 60;
            spanishGrid.Columns["RawMaterial"].Width = 60;
            spanishGrid.Columns["PostRecycling"].Width = 60;
            spanishGrid.Columns["PreRecycling"].Width = 50;
        }

        private void ResizeKBOBColumns()
        {
            kbobGrid.Columns["IdKBOB"].Visible = false;
            kbobGrid.Columns["KBOB"].Width = 50;
            kbobGrid.Columns["NameGerman"].Width = 250;
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

        private void RefreshJoinedTable(string param)
        {
            joinedGrid.DataSource = null;
            joinedGrid.DataSource = db.SelectJoin(param);           
        }

        private void UpdateJoinedTable()
        {
            if (spanishGrid.SelectedRows.Count != 0)
            {
                RefreshJoinedTable(spanishGrid.SelectedRows[0].Cells["ShortDescription"].Value.ToString());
            }
        }

        private void groupSelectComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            spanishGrid.DataSource = null;
            spanishGrid.DataSource = db.SelectSpanishMaterials(groupSelectComboBox.SelectedItem.ToString());
            ResizeSpanishColumns();
            UpdateJoinedTable();
        }

        private void makeLink_Click(object sender, EventArgs e)
        {
            if (spanishGrid.SelectedRows.Count != 0 && kbobGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow bauRow = spanishGrid.SelectedRows[0];
                var x = bauRow.Cells["IdMaterial"].Value;

                DataGridViewRow kbobRow = kbobGrid.SelectedRows[0];
                var y = kbobRow.Cells["IdKBOB"].Value;

                db.InsertLink((int)x, (int)y);
                UpdateJoinedTable();
            }
        }

        private void deleteLink_Click(object sender, EventArgs e)
        {
            if (joinedGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow joinedRow = joinedGrid.SelectedRows[0];
                var x = joinedRow.Cells["Id"].Value;

                db.DeleteLink((int)x);
                UpdateJoinedTable();
            }
        }

        private void spanishGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateJoinedTable();
        }
    }
}
