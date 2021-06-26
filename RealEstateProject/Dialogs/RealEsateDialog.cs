using RealEstateProject.Edit;
using RealEstateProject.Model;
using RealEstateProject.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RealEstateProject.Dialogs
{
    public partial class RealEsateDialog : Form
    {
 
        Connection Connection = new Connection();
        private RealEstateModel realEstateModel;

        public RealEsateDialog()
        {
            InitializeComponent();
        }



        public RealEsateDialog(RealEstateModel realEstateModel):this()
        {
            this.realEstateModel = realEstateModel;
            realEstate.Text = realEstateModel.ToString();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EditRealEstate editRealEstate = new EditRealEstate(realEstateModel.RealEstateID);
            editRealEstate.MdiParent = this.MdiParent;
            editRealEstate.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteRealEstate(realEstateModel.RealEstateID);

                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment(realEstateModel.RealEstateID);
            addDepartment.MdiParent = this.MdiParent;
            addDepartment.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EditAppartment editAppartment = new EditAppartment(realEstateModel.RealEstateID);
            editAppartment.MdiParent = this.MdiParent;
            editAppartment.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            AddRealstateExpense addRealstateExpense = new AddRealstateExpense(realEstateModel.RealEstateID);
            addRealstateExpense.MdiParent = this.MdiParent;
            addRealstateExpense.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            EditRealEstateExpense editRealEstateExpense = new EditRealEstateExpense(realEstateModel.RealEstateID);
            editRealEstateExpense.MdiParent = this.MdiParent;
            editRealEstateExpense.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            RealEstateFullMonthlyReport realEstateFullMonthlyReport = new RealEstateFullMonthlyReport(realEstateModel);
            realEstateFullMonthlyReport.MdiParent = this.MdiParent;
            realEstateFullMonthlyReport.Show();
        }

        private void RealEsateDialog_Load(object sender, EventArgs e)
        {

        }

        private void realEstate_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddMonthlyRentalPayments addMonthlyRentalPayments = new AddMonthlyRentalPayments(realEstateModel.RealEstateID);
            addMonthlyRentalPayments.MdiParent = this.MdiParent;
            addMonthlyRentalPayments.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EditMonthlyRentalPayment editMonthlyRentalPayment = new EditMonthlyRentalPayment(realEstateModel.RealEstateID);
            editMonthlyRentalPayment.MdiParent = this.MdiParent;
            editMonthlyRentalPayment.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddRental addRental = new AddRental(realEstateModel.RealEstateID);
            addRental.MdiParent = this.MdiParent;
            addRental.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EditRental editRental = new EditRental(realEstateModel.RealEstateID);
            editRental.MdiParent = this.MdiParent;
            editRental.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AppartmentList appartmentList = new AppartmentList(realEstateModel);
            appartmentList.MdiParent = this.MdiParent;
            appartmentList.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RentersList rentersList = new RentersList(realEstateModel);
            rentersList.MdiParent = this.MdiParent;
            rentersList.Show();
        }
    }
}
