using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            /*public int insertMonthlyRentalPayments(string renterID, string appartmentID, string amount,
            string date, string  details, string  payMethod, string checkNumber,string bank)

        {*/
            Notification notification = new Notification("Added Successfully", Color.RoyalBlue);
            try
            {
                string moneyType = (leb.Checked) ? leb.Text : dollar.Text;
                int results = Connection.insertMonthlyRentalPayments(
                    renterName.SelectedValue.ToString(), AppartmentNumber.SelectedValue.ToString(), amount.Text, payDate.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    details.Text, payMethod.Text, checkNumber.Text, bank.Text, receiptNumber.Text,month.Text,year.Value.ToString(), moneyType);
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
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "estateNumber";
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
    }
}
