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

namespace RealEstateProject.Edit
{
    public partial class EditMonthlyRentalPayment : Form
    {
        Connection Connection = new Connection();
        private string realEstateID;

        public EditMonthlyRentalPayment()
        {
            InitializeComponent();
            getRenters();
            getRealestates();
            getBanks();
            getReceiptNumber();
        }

        public EditMonthlyRentalPayment(string realEstateID) : this()
        {
            this.realEstateID = realEstateID;
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

        private void getReceiptNumber()
        {
            DataTable dataTable = Connection.getMonthlyRentalpayments();
            receiptNumber.DataSource = dataTable;
            receiptNumber.DisplayMember = "receiptNumber";
            receiptNumber.ValueMember = "ID";
        }

        private void getRenters()
        {
            DataTable dataTable = Connection.getRenterPersons();
            renterName.DataSource = dataTable;
            renterName.DisplayMember = "name";
            renterName.ValueMember = "idperson";
        }
        private void getRealestates()
        {
            //realestateNumber
            DataTable dataTable = Connection.getRealEstates();
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "estateNumber";
            realestateNumber.ValueMember = "ID";
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

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

        private void Button3_Click(object sender, EventArgs e)
        {
            //get
            DataRow[] dataRows = Connection.getMonthlyRentalpayments().Select("ID = " + receiptNumber.SelectedValue.ToString());
            DataRow dataRow = dataRows[0];
            renterName.SelectedValue = dataRow["renterID"].ToString();
            realestateNumber.SelectedValue = getRealEstate(dataRow["appartmentID"].ToString());
            AppartmentNumber.SelectedValue = dataRow["appartmentID"].ToString();
            amount.Text = dataRow["amount"].ToString();
            details.Text = dataRow["details"].ToString();
            payDate.Value = Convert.ToDateTime(dataRow["date"]);
            payMethod.Text = dataRow["payMethod"].ToString();
            bank.Text = dataRow["bank"].ToString();
            checkNumber.Text = dataRow["checkNumber"].ToString();
            month.Text = dataRow["month"].ToString();
            year.Value = Convert.ToInt32(dataRow["year"].ToString());
           



        }
        public string getRealEstate(string appartmentid)
        {
            DataRow dataRows = Connection.getAppartments().Select("iddepartment = " + appartmentid)[0];
            return dataRows["buildingID"].ToString();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            //delete
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteMonthlyRentalPayment(receiptNumber.SelectedValue.ToString());
                getReceiptNumber();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //update
            string message = "";
            Color color = Color.White;
            try
            {
                

                int results = Connection.updateMonthlyRentalPayments(
                                    renterName.SelectedValue.ToString(),
                                    AppartmentNumber.SelectedValue.ToString(),
                                    amount.Text, payDate.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                                    details.Text, payMethod.Text, checkNumber.Text, bank.Text, receiptNumber.SelectedValue.ToString(), month.Text, year.Value.ToString());

                if (results == 0)
                {
                    message = "There are error";
                    color = Color.Red;
                }
                else if (results == 1)
                {
                    message = "Updated Succefully";
                    color = Color.Green;


                }
                else
                {
                    message = "Please fill all Required fields";
                    color = Color.Blue;

                }


            }
            catch
            {
                color = Color.Red;
                message = "There are error, please correct it";
            }
            Notification notification = new Notification(message, color);
            notification.Show();
        }

        private void EditMonthlyRentalPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
