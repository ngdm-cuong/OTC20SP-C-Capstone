using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuttingEdgeInvMgmtSystem
{
    public partial class FrmCurrentInventory : Form
    {
        private dbCounterTopsDataContext dbContext = new dbCounterTopsDataContext();
        private Form parent;
        public FrmCurrentInventory(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FrmCurrentInventory_Load(object sender, EventArgs e)
        {
            dataGridColors.DataSource = dbContext.Colors;
            dataGridColors.Columns[0].ReadOnly = true; // User should not be able to edit ID
            LoadBarTops();
            LoadKitchenTops();
            LoadVanityTops();
        }

        private void LoadBarTops()
        {
            dataGridBarTops.DataSource = dbContext.BarTops;
            dataGridBarTops.Columns[1].Visible = false;
            dataGridBarTops.Columns[2].Visible = false;
            dataGridBarTops.Columns[5].Visible = false;
            dataGridBarTops.Columns[0].ReadOnly = true; // User should not be able to edit this since there's a constrain on color and color iD


            foreach (DataGridViewRow row in dataGridBarTops.Rows)
            {

                if (row.Cells[2].Value != null)
                {
                    row.Cells[0].Value = DataAccess.DataAdapter.GetColor((int)row.Cells[2].Value);
                }
            }
        }

        private void LoadKitchenTops()
        {
            dataGridKitchenTops.DataSource = dbContext.Kitchens;
            dataGridKitchenTops.Columns[1].Visible = false;
            dataGridKitchenTops.Columns[2].Visible = false;
            dataGridKitchenTops.Columns[4].Visible = false;
            dataGridKitchenTops.Columns[0].ReadOnly = true; // User should not be able to edit this since there's a constrain on color and color iD


            foreach (DataGridViewRow row in dataGridKitchenTops.Rows)
            {

                if (row.Cells[2].Value != null)
                {
                    row.Cells[0].Value = DataAccess.DataAdapter.GetColor((int)row.Cells[2].Value);
                }
            }
        }

        private void LoadVanityTops()
        {
            dataGridVanityTops.DataSource = dbContext.Vanities;

            dataGridVanityTops.Columns[1].Visible = false;
            dataGridVanityTops.Columns[2].Visible = false;
            dataGridVanityTops.Columns[4].Visible = false;
            dataGridVanityTops.Columns[0].ReadOnly = true; // User should not be able to edit this since there's a constrain on color and color iD


            foreach (DataGridViewRow row in dataGridVanityTops.Rows)
            {

                if (row.Cells[2].Value != null)
                {
                    row.Cells[0].Value = DataAccess.DataAdapter.GetColor((int)row.Cells[2].Value);
                }
            }
        }

        private void FrmCurrentInventory_FormClosing(object sender, FormClosingEventArgs e)
        {            
            parent.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbContext.SubmitChanges();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            dbContext.Dispose();            
        }

        private void dataGridVanityTops_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
