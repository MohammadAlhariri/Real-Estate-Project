using RealEstateProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject.Reports
{
    public partial class RentersList : Form
    {
        Connection Connection = new Connection();
        private RealEstateModel realEstateModel;

        public RentersList()
        {
            InitializeComponent();
        }
        public RentersList(RealEstateModel realEstateModel) : this()
        {
            try
            {
                this.realEstateModel = realEstateModel;
                estate.Text += realEstateModel.ToString();

            }
            catch { }
        }

        private void RentersList_Load(object sender, EventArgs e)
        {
            //getAppartmentReportMonthly();

            renters.DataSource = Connection.getAppartmentReportMonthly().Select("buildingID =" + realEstateModel.RealEstateID).CopyToDataTable();
            
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "ShowInfo";
            uninstallButtonColumn.Text = "Show";
            int columnIndex = renters.Columns.Count;
            uninstallButtonColumn.UseColumnTextForButtonValue = true;

            if (renters.Columns["ShowInfo"] == null)
            {
                renters.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
            DataGridViewButtonColumn printButtonColumn = new DataGridViewButtonColumn();
            printButtonColumn.Name = "PrintInfo";
            printButtonColumn.Text = "Print";
            int columnIndex2 = renters.Columns.Count;
            printButtonColumn.UseColumnTextForButtonValue = true;

            if (renters.Columns["PrintInfo"] == null)
            {
                renters.Columns.Insert(columnIndex2, printButtonColumn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRental addRental = new AddRental(realEstateModel.RealEstateID);
            addRental.MdiParent = this.MdiParent;
            addRental.Show();
        }

        private void renters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
