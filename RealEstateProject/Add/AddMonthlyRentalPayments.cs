using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject
{
    public partial class AddMonthlyRentalPayments : Form
    {
        Connection Connection = new Connection();

        public AddMonthlyRentalPayments()
        {
            InitializeComponent();
            getRenters();
            getRealestates();
            getBanks();
            monthlyRentalPayments.DataSource = Connection.getMonthlyRentalpayments();

        }
        public AddMonthlyRentalPayments(string realEstateID) : this()
        {

            realestateNumber.SelectedValue = realEstateID;

        }
        private void getBanks()
        {
            DataTable dataTable = Connection.getBanks();
            DataRow dr = dataTable.NewRow();
            dr["idbanks"] = "0";
            dr["bank"] = "Other";
            dataTable.Rows.Add(dr);
            bank.DataSource = dataTable;
            bank.DisplayMember = "bank";
            bank.ValueMember = "bank";
        }

        private void getAppartments()
        {
            DataTable dataTable = Connection.getAppartments();
            AppartmentNumber.DataSource = dataTable;
            AppartmentNumber.DisplayMember = "appartmentNumber";
            AppartmentNumber.ValueMember = "iddepartment";
        }

        private void getRenters()
        {
            DataTable dataTable = Connection.getRenterPersons();
            renterName.DataSource = dataTable;
            renterName.DisplayMember = "name";
            renterName.ValueMember = "idperson";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification("Added Successfully", Color.RoyalBlue);

            DateTime rentalD = Convert.ToDateTime(Connection.getRentals().Select("idental =" + rentalNumber.SelectedValue.ToString())[0]["rentDate"].ToString());
            if (rentalD.Year > year.Value && rentalD.Month > month.SelectedIndex + 1)
            {
                notification = new Notification("You cant Add Payment before person rent", Color.Orange);
                notification.Show();

                return;
            }
            try
            {
                int results = 0;
                if (mMonth.Checked)
                {
                    var dat = new DateTime((int)year.Value, month.SelectedIndex, 1);

                    for (int ctr = 1; ctr <= numberOfMonths.Value; ctr++)
                    {
                        dat = dat.AddMonths(1);
                        //Console.WriteLine(dat.Year);
                        // Console.WriteLine(dat.ToString("MMMM"));
                        results = Connection.insertMonthlyRentalPayments(
                    rentalNumber.SelectedValue.ToString(), ((Convert.ToInt32(amount.Text))/numberOfMonths.Value)+"", payDate.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    details.Text, payMethod.Text, checkNumber.Text, bank.Text, receiptNumber.Text, dat.ToString("MMMM"), dat.Year + "");
                    }
                }

                else
                    results = Connection.insertMonthlyRentalPayments(
                    rentalNumber.SelectedValue.ToString(), amount.Text, payDate.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    details.Text, payMethod.Text, checkNumber.Text, bank.Text, receiptNumber.Text, month.Text, year.Value.ToString());
                if (results == 0)
                {

                    notification = new Notification("There are error", Color.Red);
                }
                else if (results == 1)
                {

                    notification = new Notification("Added Successfully", Color.Green);

                }
                else
                {

                    notification = new Notification("Please fill all Required fields", Color.Yellow);

                }
                monthlyRentalPayments.DataSource = Connection.getMonthlyRentalpayments();

            }
            catch
            {

                notification = new Notification("There are error, please correct it", Color.Red);
            }

            notification.Show();
        }

        private void PayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payMethod.SelectedItem.ToString().Equals("Check"))
            {
                payRequirments.Visible = true;
            }


            else
            {
                payRequirments.Visible = false;

            }
        }

        private void AddMonthlyRentalPayments_Load(object sender, EventArgs e)
        {

        }
        private void getRealestates()
        {
            //realestateNumber
            DataTable dataTable = Connection.getRealEstates();
            dataTable.Columns.Add("realestate", typeof(string), "estateNumber + ' -> ' + Owner");

            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "realestate";
            realestateNumber.ValueMember = "ID";
        }

        private void RealestateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getAppartments(realestateNumber.SelectedValue.ToString());
            if (dataTable.Rows.Count == 0)
            {
                AppartmentNumber.DataSource = null;
            }
            else
            {
                AppartmentNumber.DataSource = dataTable;
                AppartmentNumber.DisplayMember = "appartmentNumber";
                AppartmentNumber.ValueMember = "iddepartment";
            }
        }

        private void Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bank.Text.Equals("Other"))
            {
                PredefinedOptions predefinedOptions = new PredefinedOptions(0);
                DialogResult dr = predefinedOptions.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    predefinedOptions.Close();
                    getBanks();
                    bank.SelectedIndex = bank.Items.Count - 2;
                }
                else if (dr == DialogResult.OK)
                {
                    //predefinedOptions.Close();
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void AppartmentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (AppartmentNumber.SelectedValue != null && !String.IsNullOrEmpty(AppartmentNumber.SelectedValue.ToString()))
                {
                    DataRow[] dataTable = Connection.getRentals().Select("appartmentNumber = " + AppartmentNumber.SelectedValue.ToString());
                    if (dataTable.Length != 0)
                    {

                        DataTable dataTable1 = dataTable.CopyToDataTable();
                        dataTable1.Columns.Add("rental", typeof(string), "idental+' -> '+ name+ ' -> ' + rentDate");

                        rentalNumber.DataSource = dataTable1;
                        rentalNumber.DisplayMember = "rental";
                        rentalNumber.ValueMember = "idental";
                    }
                    else
                    {
                        rentalNumber.DataSource = null;


                    }
                }
                else
                {
                    rentalNumber.DataSource = null;

                }
            }
            catch { }
        }

        private void mMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                numberOfMonths.Visible = true;
                startMonth.Text = "Start Month";
                startYear.Text = "Start Year";
            }
            else
            {
                numberOfMonths.Visible = false;
                startMonth.Text = "Month";
                startYear.Text = "Year";
            }
        }

        private void rentalNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
