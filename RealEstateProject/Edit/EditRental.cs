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
    public partial class EditRental : Form
    {
        Connection Connection = new Connection();

        public EditRental()
        {
            InitializeComponent();
            getRealEstates();
            getRenter();

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
        private void getRenter()
        {
            DataTable dataTable = Connection.getRenterPersons();
            renter.DataSource = dataTable;
            renter.DisplayMember = "name";
            renter.ValueMember = "idperson";
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
        public void getRealEstates()
        {
            DataTable dataTable = Connection.getRealEstates();
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "estateNumber";
            realestateNumber.ValueMember = "ID";
             dataTable = getAppartments(Convert.ToInt32(realestateNumber.SelectedValue.ToString()));
            appartmentNumber.DataSource = dataTable;
            appartmentNumber.DisplayMember = "appartmentNumber";
            appartmentNumber.ValueMember = "iddepartment";
        }
        private void EditRental_Load(object sender, EventArgs e)
        {

        }
        public DataTable getRentals(int id)
        {
            DataTable dataTable = Connection.getRentals().Clone();
            DataRow[] dataRows = Connection.getRentals().Select("appartmentNumber = " + id);
            for (int i = 0; i < dataRows.Length; i++)
            {
                dataTable.Rows.Add(dataRows[i].ItemArray);
            }
            return dataTable;

        }
        public DataTable getAppartments(int id)
        {
            DataTable dataTable = Connection.getAppartments().Clone();
            DataRow[] dataRows = Connection.getAppartments().Select("buildingID = " + id);
            for (int i = 0; i < dataRows.Length; i++)
            {

                dataTable.Rows.Add(dataRows[i].ItemArray);
            }
            return dataTable.Rows.Count == 0 ? null:dataTable ;

        }
        private void RealestateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = getAppartments(Convert.ToInt32(realestateNumber.SelectedValue.ToString()));
            appartmentNumber.DataSource = dataTable;
            appartmentNumber.DisplayMember = "appartmentNumber";
            appartmentNumber.ValueMember = "iddepartment";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                // get Rentel
                DataRow[] dataRows = Connection.getRentals().Select("idental = " + rentalNumber.SelectedValue.ToString());
                DataRow dataRow = dataRows[0];
                renter.SelectedValue = dataRow["renterID"].ToString();
                detail.Text = dataRow["details"].ToString();
                rentDuration.Text = dataRow["rentDuration"].ToString();
                rentalType.Text = dataRow["rentalType"].ToString();
                type.Text = dataRow["type"].ToString();
                paymentMethod.Text = dataRow["paymentMethod"].ToString();
                startDate.Value =  Convert.ToDateTime(dataRow["rentDate"]);

            }
            catch
            {
                Notification notification = new Notification("This Appartment have no rental", Color.Red);
                notification.Show();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //delete
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteRental(rentalNumber.SelectedValue.ToString());
                getRealEstates();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //update

            string message = "";
            Color color = Color.White;
            try
            {
                //(rentalID int,renterID int,  type varchar(45), rentDuration int, rentalType varchar(45),
               // details Text, rentDate varchar(45),paymentMethod varchar(45))
                int results = Connection.updateRental(rentalNumber.SelectedValue.ToString(),
                    renter.SelectedValue.ToString(),
                    type.Text, rentDuration.Value.ToString(), rentalType.Text, detail.Text,
                    startDate.Text, paymentMethod.Text);
                if (results == 0)
                {
                    message = "There are error";
                    color = Color.Red;
                }
                else if (results == 1)
                {
                    message = "Updated Succefully";
                    color = Color.Blue;


                }
                else
                {
                    message = "Please fill all Required fields";
                    color = Color.Blue;

                }


            }
            catch
            {
                message = "There are error, please correct it";
                color = Color.Red;
            }
            Notification notification = new Notification(message, color);
            notification.Show();
        }

        private void AppartmentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = getRentals(Convert.ToInt32(appartmentNumber.SelectedValue.ToString()));
            rentalNumber.DataSource = dataTable;
            rentalNumber.DisplayMember = "idental";
            rentalNumber.ValueMember = "idental";
        }
    }
}
