using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateProject.Model;

namespace RealEstateProject.Reports
{
    public partial class RealEstateFullMonthlyReport : Form
    {
        private RealEstateModel realEstateModel;
        Connection connection = new Connection();
        public RealEstateFullMonthlyReport()
        {
            InitializeComponent();
        }
        public RealEstateFullMonthlyReport(RealEstateModel realEstateModel) : this()
        {
            this.realEstateModel = realEstateModel;
            realEstate.Text = realEstateModel.RealEstateNumber;
            ownerID.Text = realEstateModel.Owner;
            getData();
            getYears();

        }

        public void getYears()
        {
            DataTable dataTable = connection.getYears(realEstateModel.RealEstateID);
            year.DataSource = dataTable;
            year.DisplayMember = "year";
            year.ValueMember = "year";
        }

        private void getData()
        {
            monthlyRental.DataSource = connection.monthly_rental_payment_report(realEstateModel.RealEstateID);
        }



        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void RealEstateFullMonthlyReport_Load(object sender, EventArgs e)
        {

        }
    }
}
