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
            DataTable dataTable1 = connection.getRealEstateAppartmentsServices(realEstateModel.RealEstateID);
            DataTable dataTable2 =connection.getMonthlyAppartmentServicesPaymentsReport(realEstateModel.RealEstateID);
            DataTable dataTable3 = connection.getRealestateServicesExpencesReport().Select("realestateID = " + realEstateModel.RealEstateID).CopyToDataTable();
            aServices.DataSource =dataTable1 ;
            aServicesPayments.DataSource = dataTable2;
            rServices.DataSource = dataTable3;
            double payments_total =  checkNull(dataTable1.Compute("SUM(total)", "").ToString());
            paymentsTotal.Text = payments_total+"";
            double to_be_paid= checkNull(dataTable2.Compute("SUM(total)", "").ToString());
            toBePaid.Text += to_be_paid;
            appartmentsResult.Text =(payments_total-to_be_paid)+"";
            double total_real_estate= checkNull(dataTable3.Compute("SUM(total)", "" ).ToString());
            totalRealEstate.Text = total_real_estate+"";


        }

        public void getYears()
        {
            DataTable dataTable = connection.getYears(realEstateModel.RealEstateID).DefaultView.ToTable(true, "year");
            year.DataSource = dataTable;
            year.DisplayMember = "year";
            year.ValueMember = "year";
        }

        private void getData()

        {
            DataTable dataTable = connection.monthly_rental_payment_report(realEstateModel.RealEstateID);
            DataTable dataTable1= connection.monthly_expense_report(realEstateModel.RealEstateID);
            if (month.SelectedItem == null || month.SelectedItem.ToString().Equals("All") || String.IsNullOrEmpty(month.SelectedItem.ToString()))
            {
                monthlyRental.DataSource = dataTable.Select("year = " + year.Text).CopyToDataTable();
                monthlyExpences.DataSource = dataTable1.Select("year = " + year.Text).CopyToDataTable();
                double totalAmount = checkNull(dataTable.Compute("SUM(amount)", "year = " + year.Text).ToString());
                total.Text = totalAmount + "";
                vendor.Text = (totalAmount * 0.1) + "";
                net.Text = totalMontlyRentals.Text = (totalAmount - (totalAmount * 0.1)) + "";
                numberOfRenters.Text = dataTable.Select("year = " + year.Text).CopyToDataTable().DefaultView.ToTable(true, "Name").Rows.Count + "";
                double totalExpences = checkNull(dataTable1.Compute("SUM(amount)", "year = " + year.Text + " AND ExpenseType <> 'Payed by owner'"));
                double totalExpencesByOwner = checkNull(dataTable1.Compute("SUM(amount)", "year = " + year.Text + " AND ExpenseType = 'Payed by owner'"));
                totalMonthleExpencess.Text = (totalExpences + totalExpencesByOwner) + "";
                totalMonthlyExpences.Text = (totalExpences + totalExpencesByOwner) + "";
                current.Text = ((totalExpences + totalExpencesByOwner) + (totalAmount - (totalAmount * 0.1))) + "";
                /*                aServices.DataSource = connection.getRealEstateAppartmentsServices(realEstateModel.RealEstateID).Select("year="+year.Text).CopyToDataTable();
                                rServices.DataSource = connection.getRealestateServicesExpencesReport().Select("realestateID = " + realEstateModel.RealEstateID+ " AND year = "+year.Text).CopyToDataTable();
                                aServicesPayments.DataSource = connection.getMonthlyAppartmentServicesPaymentsReport(realEstateModel.RealEstateID).Select("year=" + year.Text).CopyToDataTable();
                */
                dataTable1 = connection.getRealEstateAppartmentsServices(realEstateModel.RealEstateID).Select("year=" + year.Text).CopyToDataTable();
                DataTable dataTable2 = connection.getMonthlyAppartmentServicesPaymentsReport(realEstateModel.RealEstateID);
                DataTable dataTable3 = connection.getRealestateServicesExpencesReport().Select("realestateID = " + realEstateModel.RealEstateID+ " AND year = "+year.Text).CopyToDataTable();
                aServices.DataSource = dataTable1;
                aServicesPayments.DataSource = dataTable2;
                rServices.DataSource = dataTable3;
                double payments_total = checkNull(dataTable1.Compute("SUM(total)", "year = " + year.Text).ToString());
                paymentsTotal.Text = payments_total+"";
                double to_be_paid = checkNull(dataTable2.Compute("SUM(total)", "year = " + year.Text).ToString());
                toBePaid.Text = to_be_paid+"";
                appartmentsResult.Text += (payments_total - to_be_paid) + "";
                double total_real_estate = checkNull(dataTable3.Compute("SUM(total)", "year = " + year.Text).ToString());
                totalRealEstate.Text = total_real_estate+"";
            }
            else
            {
                try
                {
                    monthlyRental.DataSource = dataTable.Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();
                    monthlyExpences.DataSource = dataTable1.Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();

                }
                catch { }
                double totalAmount = checkNull(dataTable.Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "'").ToString());
                total.Text = totalAmount + "";
                vendor.Text = (totalAmount * 0.1) + "";
                net.Text = totalMontlyRentals.Text = (totalAmount - (totalAmount * 0.1)) + "";
                numberOfRenters.Text = dataTable.Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable().DefaultView.ToTable(true, "Name").Rows.Count + "";
                double totalExpences = checkNull(dataTable1.Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "' AND ExpenseType <> 'Payed by owner'"));
                double totalExpencesByOwner = checkNull(dataTable1.Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "' AND ExpenseType = 'Payed by owner'"));
                totalMonthleExpencess.Text = (totalExpences + totalExpencesByOwner) + "";
                totalMonthlyExpences.Text = (totalExpences + totalExpencesByOwner) + "";
                current.Text = ((totalExpences + totalExpencesByOwner) + (totalAmount - (totalAmount * 0.1))) + "";
                /*aServices.DataSource = connection.getRealEstateAppartmentsServices(realEstateModel.RealEstateID).Select("year=" + year.Text+" AND month='"+month.SelectedItem.ToString()+"'").CopyToDataTable();
                rServices.DataSource = connection.getRealestateServicesExpencesReport().Select("realestateID = " + realEstateModel.RealEstateID + " AND year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").CopyToDataTable();
                aServicesPayments.DataSource = connection.getMonthlyAppartmentServicesPaymentsReport(realEstateModel.RealEstateID).Select("year=" + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").CopyToDataTable();
*/
                dataTable1 = connection.getRealEstateAppartmentsServices(realEstateModel.RealEstateID).Select("year=" + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").CopyToDataTable();
                DataTable dataTable2 = connection.getMonthlyAppartmentServicesPaymentsReport(realEstateModel.RealEstateID).Select("year=" + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").CopyToDataTable();
                DataTable dataTable3 = connection.getRealestateServicesExpencesReport().Select("realestateID = " + realEstateModel.RealEstateID + " AND year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").CopyToDataTable();
                aServices.DataSource = dataTable1;
                aServicesPayments.DataSource = dataTable2;
                rServices.DataSource = dataTable3;
                double payments_total = checkNull(dataTable1.Compute("SUM(total)", "year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").ToString());
                paymentsTotal.Text = payments_total+"";
                double to_be_paid = checkNull(dataTable2.Compute("SUM(total)", "year = " + year.Text+ " AND month='" + month.SelectedItem.ToString() + "'").ToString());
                toBePaid.Text = to_be_paid+"";
                appartmentsResult.Text = (payments_total - to_be_paid) + "";
                double total_real_estate = checkNull(dataTable3.Compute("SUM(total)", "year = " + year.Text+ " AND month='" + month.SelectedItem.ToString() + "'").ToString());
                totalRealEstate.Text += total_real_estate;
            }
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
            DataTable dataTable = connection.monthly_rental_payment_report(realEstateModel.RealEstateID).Select("year = " + year.Text + " AND month= '" + month.Text + "'").CopyToDataTable();
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

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
