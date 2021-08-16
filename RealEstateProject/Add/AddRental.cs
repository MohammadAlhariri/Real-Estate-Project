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
    public partial class AddRental : Form
    {

        Connection Connection = new Connection();
        private string realEstateID;

        public AddRental()
        {
            InitializeComponent();
            getRenter();
            getRentalTypes();
            getRealestates();
            getPaymentMethods();
            rentals.DataSource = Connection.getRentals();
            getServices();
        }

        public AddRental(string realEstateID):this()
        {
            this.realEstateID = realEstateID;
            realestateNumber.SelectedValue = realEstateID;

        }

        private void getRentalTypes()
        {
            DataTable dataTable = Connection.getRentalTypes();
            DataRow dr = dataTable.NewRow();
            dr["idrental_type"] = "0";
            dr["rentalType"] = "Other";

            dataTable.Rows.Add(dr);
            rentalType.DataSource = dataTable;
            rentalType.DisplayMember = "rentalType";
            rentalType.ValueMember = "rentalType";
        }

        private void getPaymentMethods()
        {

            DataTable dataTable = Connection.getPaymetMethods();
            DataRow dr = dataTable.NewRow();
            dr["idpayment_method"] = "0";
            dr["paymentMethod"] = "Other";

            dataTable.Rows.Add(dr);
            paymentMethod.DataSource = dataTable;
            paymentMethod.DisplayMember = "paymentMethod";
            paymentMethod.ValueMember = "paymentMethod";

        }
        private void getServices()
        {
            try
            {
                DataTable dataTable = Connection.getRealestateServices().Select("ID ='" + realestateNumber.SelectedValue.ToString() + "'").CopyToDataTable();
                services.DataSource = dataTable;
                services.DisplayMember = "name";
                services.ValueMember = "idservices";
            }
            catch { services.DataSource = null; }
        }
        private void getAppartments()
        {
            DataTable dataTable = Connection.getAppartments();
            appartmentNumber.DataSource = dataTable;
            appartmentNumber.DisplayMember = "appartmentNumber";
            appartmentNumber.ValueMember = "iddepartment";
        }

        private void getRenter()
        {
            DataTable dataTable = Connection.getRenterPersons();
            renter.DataSource = dataTable;
            renter.DisplayMember = "name";
            renter.ValueMember = "idperson";
        }

        private void AddRental_Load(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Color color = Color.White;
            try
            {
                //public int insertRental(string renterID, string appartmentNumber, string type,
                //string rentDuration, string rentalType, string details, string rentDate,
                // string paymentMethod)
                int results = Connection.insertRental(renter.SelectedValue.ToString(), appartmentNumber.SelectedValue.ToString(),
                    rentDuration.Value.ToString(), rentalType.Text, detail.Text, startDate.Value.Date.ToString("yyyy-MM-dd HH:mm"), paymentMethod.Text,
                    rentPercentage.Value.ToString(), graceMonth.Value.ToString());

                if (results == 0)
                {
                    message = "There are error";
                    color = Color.Red;
                }
                else if (results == 1)
                {
                    message = "Added Succefully";
                    color = Color.Green;


                }
                else
                {
                    message = "Please fill all Required fields";
                    color = Color.Blue;

                }
                rentals.DataSource = Connection.getRentals();

                string id = Connection.getRentals().Select("appartmentNumber='" + appartmentNumber.SelectedValue.ToString()+"'").Last()[0].ToString();
            Console.WriteLine(id);
                Connection.addRentalService(id, services.CheckedItems);
            }
            catch
            {
                color = Color.Red;
                message = "There are error, please correct it";
            }

            Notification notification = new Notification(message, color);
            notification.Show();


        }

        private void RealestateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] dataTable = Connection.getAppartments(realestateNumber.SelectedValue.ToString()).Select("rented=0");
            DataTable data = Connection.getAppartments(realestateNumber.SelectedValue.ToString()).Clone();
            foreach (DataRow item in dataTable)
            {
                data.Rows.Add(item.ItemArray);
            }
            getServices();
            if (dataTable.Length == 0)
            {
                appartmentNumber.DataSource = null;
            }
            else
            {
                appartmentNumber.DataSource = data;
                appartmentNumber.DisplayMember = "appartmentNumber";
                appartmentNumber.ValueMember = "iddepartment";
            }
        }

        private void PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentMethod.Text.Equals("Other"))
            {
                PredefinedOptions predefinedOptions = new PredefinedOptions(3);
                DialogResult dr = predefinedOptions.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    predefinedOptions.Close();
                    getPaymentMethods();
                    paymentMethod.SelectedIndex = paymentMethod.Items.Count - 2;

                }
                else if (dr == DialogResult.OK)
                {
                    predefinedOptions.Close();
                }
            }
        }

        private void RentalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentalType.Text.Equals("Other"))
            {
                PredefinedOptions predefinedOptions = new PredefinedOptions(5);
                DialogResult dr = predefinedOptions.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    predefinedOptions.Close();
                    getRentalTypes();
                    rentalType.SelectedIndex = rentalType.Items.Count - 2;
                }
                else if (dr == DialogResult.OK)
                {
                    //predefinedOptions.Close();
                }
            }
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void services_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
