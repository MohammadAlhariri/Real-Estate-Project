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
            getYears();

        }

        public void getYears()
        {
            DataTable dataTable = connection.getYears(realEstateModel.RealEstateID).DefaultView.ToTable(true,"year");
            year.DataSource = dataTable;
            year.DisplayMember = "year";
            year.ValueMember = "year";
        }

        private void getData()

        {
            try
            {
                monthlyRental.DataSource = connection.monthly_rental_payment_report(realEstateModel.RealEstateID).Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();
                monthlyExpences.DataSource =  connection.monthly_expense_report(realEstateModel.RealEstateID).Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();

            }
            catch { }
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

        private void button6_Click(object sender, EventArgs e)
        {
            getData();
            double totalAmount = checkNull(connection.monthly_rental_payment_report(realEstateModel.RealEstateID).Compute("SUM(amount)","year = " + year.Text + " AND month= '" + month.Text + "'").ToString());
            total.Text =  totalAmount+"";
            vendor.Text = (totalAmount * 0.1) + "";
            net.Text = totalMontlyRentals.Text = (totalAmount - (totalAmount * 0.1)) + "";
            numberOfRenters.Text= connection.monthly_rental_payment_report(realEstateModel.RealEstateID).Select("year = " + year.Text + " AND month= '" + month.Text +"'").CopyToDataTable().DefaultView.ToTable(true,"renterID").Rows.Count+"";
            double totalExpences = checkNull(connection.monthly_expense_report(realEstateModel.RealEstateID).Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "' AND ExpenseType <> 'Payed by owner'"));
            double totalExpencesByOwner = checkNull(connection.monthly_expense_report(realEstateModel.RealEstateID).Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "' AND ExpenseType = 'Payed by owner'"));
            totalMonthleExpencess.Text = (totalExpences + totalExpencesByOwner) + "";
            totalMonthlyExpences.Text= (totalExpences + totalExpencesByOwner) + "";
            current.Text = ((totalExpences + totalExpencesByOwner) + (totalAmount - (totalAmount * 0.1)))+"";
        }

        private void realEstate_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
           DataTable dataTable= connection.monthly_rental_payment_report(realEstateModel.RealEstateID).Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();
            new PrintData(dataTable).export_pdf();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMonthlyRentalPayments addMonthlyRentalPayments = new AddMonthlyRentalPayments(realEstateModel.RealEstateID);
            addMonthlyRentalPayments.MdiParent = this.MdiParent;
            addMonthlyRentalPayments.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRealstateExpense addRealstateExpense = new AddRealstateExpense(realEstateModel.RealEstateID);
            addRealstateExpense.MdiParent = this.MdiParent;
            addRealstateExpense.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DataTable dataTable = connection.monthly_expense_report(realEstateModel.RealEstateID).Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();
            new PrintData(dataTable).export_pdf();
        }
        public double checkNull(object ob)
        {
            try
            {
                return Convert.ToDouble(ob);
            }
            catch { }
           
            return 0;
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
