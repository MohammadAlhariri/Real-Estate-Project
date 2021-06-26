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
    public partial class AppartmentList : Form
    {
        Connection Connection = new Connection();
        private RealEstateModel realEstateModel;

        public AppartmentList()
        {
            InitializeComponent();
        }
        public AppartmentList(RealEstateModel realEstateModel) : this()
        {
            try
            {
                this.realEstateModel = realEstateModel;
                estate.Text += realEstateModel.ToString();
                NOA.Text += Connection.getAppartments().Select("buildingID=" + realEstateModel.RealEstateID).CopyToDataTable().Rows.Count;
                getAppartments();

                NOAA.Text += Connection.getAppartments().Select("buildingID=" + realEstateModel.RealEstateID + " AND rented = 0").CopyToDataTable().Rows.Count;
            }
            catch { }
        }

        

        private void AppartmentList_Load(object sender, EventArgs e)
        {

        }
        public void getAppartments()
        {
            DataTable dt = Connection.getAppartments().Select("buildingID=" + realEstateModel.RealEstateID).CopyToDataTable();

            DataTable dt1 = new DataTable();

            dt1 = dt.DefaultView.ToTable(false, "appartmentNumber", "details", "rented");

            appartments.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment(realEstateModel.RealEstateID);
            addDepartment.MdiParent = this.MdiParent;
            addDepartment.Show();
        }
    }
}
