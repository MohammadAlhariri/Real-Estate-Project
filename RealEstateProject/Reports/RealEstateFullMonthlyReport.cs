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
        DataTable aServicesDataTable, aServicesPaymentsDataTable, rServicesDataTable;
        public RealEstateFullMonthlyReport()
        {

            InitializeComponent();
        }
        public RealEstateFullMonthlyReport(RealEstateModel realEstateModel) : this()
        {
            aServicesDataTable = connection.getRealEstateAppartmentsServices(realEstateModel.RealEstateID);
            aServicesPaymentsDataTable = connection.getMonthlyAppartmentServicesPaymentsReport(realEstateModel.RealEstateID);
            rServicesDataTable = connection.getRealestateServicesExpencesReport();
            this.realEstateModel = realEstateModel;
            realEstate.Text = realEstateModel.RealEstateNumber;
            ownerID.Text = realEstateModel.Owner;
            getYears();



            rServicesDataTable = connection.Table(rServicesDataTable, rServicesDataTable.Select("realestateID = " + realEstateModel.RealEstateID));
            aServices.DataSource = aServicesDataTable;
            aServicesPayments.DataSource = aServicesPaymentsDataTable;
            rServices.DataSource = rServicesDataTable;
            double payments_total = checkNull(aServicesDataTable.Compute("SUM(total)", "").ToString());
            dues1.Text = payments_total + "";
            double to_be_paid = checkNull(aServicesPaymentsDataTable.Compute("SUM(total)", "").ToString());
            payments1.Text += to_be_paid;
            appartmentsResult.Text = (payments_total - to_be_paid) + "";
            double total_real_estate = checkNull(rServicesDataTable.Compute("SUM(total)", "").ToString());
            totalRealEstate.Text = total_real_estate + "";
            getServices();
        }
        private void getServices()
        {
            DataTable dataTable = connection.getRealestateServices().Select("ID =" + realEstateModel.RealEstateID).CopyToDataTable();
            services.DataSource = dataTable;
            services.DisplayMember = "name";
            services.ValueMember = "idservices";
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
            DataTable monthlyRentalDataTable = connection.monthly_rental_payment_report(realEstateModel.RealEstateID);
            DataTable monthlyExpencesDataTable = connection.monthly_expense_report(realEstateModel.RealEstateID);
            if (month.SelectedItem == null || month.SelectedItem.ToString().Equals("All") || String.IsNullOrEmpty(month.SelectedItem.ToString()))
            {
                monthlyRental.DataSource = monthlyRentalDataTable.Select("year = " + year.Text).CopyToDataTable();
                monthlyExpences.DataSource = monthlyExpencesDataTable.Select("year = " + year.Text).CopyToDataTable();
                double totalAmount = checkNull(monthlyRentalDataTable.Compute("SUM(amount)", "year = " + year.Text).ToString());
                total.Text = totalMontlyRentals.Text = totalAmount + "";

                numberOfRenters.Text = monthlyRentalDataTable.Select("year = " + year.Text).CopyToDataTable().DefaultView.ToTable(true, "Name").Rows.Count + "";
                double totalExpences = checkNull(monthlyExpencesDataTable.Compute("SUM(amount)", "year = " + year.Text + " AND ExpenseType <> 'Payed by owner'"));
                double totalExpencesByOwner = checkNull(monthlyExpencesDataTable.Compute("SUM(amount)", "year = " + year.Text + " AND ExpenseType = 'Payed by owner'"));
                totalMonthleExpencess.Text = (totalExpences + totalExpencesByOwner) + "";
                totalMonthlyExpences.Text = (totalExpences + totalExpencesByOwner) + "";
                current.Text = ((totalExpences + totalExpencesByOwner) + (totalAmount)) + "";
                //////////////////////////////////////////////
                aServices.DataSource = connection.Table(aServicesDataTable, aServicesDataTable.Select("year=" + year.Text));
                aServicesPayments.DataSource = connection.Table(aServicesPaymentsDataTable, aServicesPaymentsDataTable.Select("year=" + year.Text));
                rServices.DataSource = connection.Table(rServicesDataTable, rServicesDataTable.Select("realestateID = " + realEstateModel.RealEstateID + " AND year = " + year.Text));
                //aServices.DataSource = aServicesDataTable;
                //aServicesPayments.DataSource = aServicesPaymentsDataTable;
                //rServices.DataSource = rServicesDataTable;
                double payments_total = checkNull(aServicesDataTable.Compute("SUM(total)", "year = " + year.Text).ToString());
                dues1.Text = payments_total + "";
                dues2.Text = payments_total + "";
                double to_be_paid = checkNull(aServicesPaymentsDataTable.Compute("SUM(total)", "year = " + year.Text).ToString());
                payments1.Text = to_be_paid + "";
                payments2.Text = to_be_paid + "";
                appartmentsResult.Text = (-payments_total + to_be_paid) + "";
                double total_real_estate = checkNull(rServicesDataTable.Compute("SUM(total)", "year = " + year.Text).ToString());
                totalRealEstate.Text = total_real_estate + "";

            }
            else
            {

                monthlyRental.DataSource = connection.Table(monthlyRentalDataTable, monthlyRentalDataTable.Select("year = " + year.Text + " AND month= '" + month.Text + "'"));
                monthlyExpences.DataSource = connection.Table(monthlyExpencesDataTable, monthlyExpencesDataTable.Select("year = " + year.Text + " AND month= '" + month.Text + "'"));

                double totalAmount = checkNull(monthlyRentalDataTable.Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "'").ToString());
                total.Text = totalMontlyRentals.Text  = totalAmount + "";

                numberOfRenters.Text = connection.Table(monthlyRentalDataTable, monthlyRentalDataTable.Select("year = " + year.Text + " AND month= '" + month.Text + "'")).DefaultView.ToTable(true, "Name").Rows.Count + "";
                double totalExpences = checkNull(monthlyExpencesDataTable.Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "' AND ExpenseType <> 'Payed by owner'"));
                double totalExpencesByOwner = checkNull(monthlyExpencesDataTable.Compute("SUM(amount)", "year = " + year.Text + " AND month= '" + month.Text + "' AND ExpenseType = 'Payed by owner'"));
                totalMonthleExpencess.Text = (totalExpences + totalExpencesByOwner) + "";
                totalMonthlyExpences.Text = (totalExpences + totalExpencesByOwner) + "";
                current.Text = ((totalExpences + totalExpencesByOwner) + (totalAmount)) + "";

                aServices.DataSource = connection.Table(aServicesDataTable, aServicesDataTable.Select("year=" + year.Text + " AND month='" + month.SelectedItem.ToString() + "'"));

                aServicesPayments.DataSource = connection.Table(aServicesPaymentsDataTable, aServicesPaymentsDataTable.Select("year=" + year.Text + " AND month='" + month.SelectedItem.ToString() + "'"));

                rServices.DataSource = connection.Table(rServicesDataTable, rServicesDataTable.Select("realestateID = " + realEstateModel.RealEstateID + " AND year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'"));
                //aServices.DataSource = aServicesDataTable;
                //aServicesPayments.DataSource = aServicesPaymentsDataTable;
                //rServices.DataSource = rServicesDataTable;
                double payments_total = checkNull(aServicesDataTable.Compute("SUM(total)", "year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").ToString());
                dues1.Text = payments_total + "";
                dues2.Text = payments_total + "";
                double to_be_paid = checkNull(aServicesPaymentsDataTable.Compute("SUM(total)", "year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").ToString());
                payments1.Text = to_be_paid + "";
                payments2.Text = to_be_paid + "";
                appartmentsResult.Text = (-payments_total + to_be_paid) + "";
                double total_real_estate = checkNull(rServicesDataTable.Compute("SUM(total)", "year = " + year.Text + " AND month='" + month.SelectedItem.ToString() + "'").ToString());
                totalRealEstate.Text = total_real_estate + "";
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
            string query = "";
            for (int i = 0; i < services.CheckedItems.Count; i++)
            {
                if (i != 0)
                    query += " OR ";
                query += "name = '" + services.GetItemText(services.CheckedItems[i]) + "' ";
            }
            Console.WriteLine(query);
            aServicesPayments.DataSource = connection.Table((DataTable)aServicesPayments.DataSource, ((DataTable)aServicesPayments.DataSource).Select(query));
            aServices.DataSource = connection.Table((DataTable)aServices.DataSource, ((DataTable)aServices.DataSource).Select(query));
            rServices.DataSource = connection.Table((DataTable)rServices.DataSource, ((DataTable)rServices.DataSource).Select(query));


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

        private void aServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDataGrid viewDataGrid = new ViewDataGrid((DataTable)aServices.DataSource);
            viewDataGrid.ShowDialog();
        }

        private void aServicesPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDataGrid viewDataGrid = new ViewDataGrid((DataTable)aServicesPayments.DataSource);
            viewDataGrid.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < services.Items.Count; i++)
            {
                services.SetItemChecked(i, true);
            }
        }

        private void services_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*            string query = ((CheckedListBox)sender).GetItemText();
                    *//*    for (int i = 0; i < services.CheckedItems.Count; i++)
                        {
                            if (i != 0)
                                query += " OR ";
                            query += "name = '" + services.CheckedItems[i].ToString() + "' ";
                        }*//*
                        aServicesPayments.DataSource = connection.Table((DataTable)aServicesPayments.DataSource, ((DataTable)aServicesPayments.DataSource).Select(query));
            */
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void rServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ViewDataGrid viewDataGrid = new ViewDataGrid((DataTable)rServices.DataSource);
            viewDataGrid.ShowDialog();
        }

        private void services_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
    }
}
