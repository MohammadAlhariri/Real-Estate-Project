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
        private string realEstateID;

        public EditRental()
        {
            InitializeComponent();
            getRealEstates();
            getRenter();
            getRentalTypes();
            getServices();
            getPaymentMethods();
        }

        public EditRental(string realEstateID):this()
        {
            this.realEstateID = realEstateID;
            realestateNumber.SelectedValue = realEstateID;
        }

        private void getServices()
        {
            DataRow[] dataTable = Connection.getRealestateServices().Select("ID =" + realestateNumber.SelectedValue.ToString());
            DataTable dataTable1 = Connection.getRealestateServices().Clone();

            for (int i = 0; i < dataTable.Length; i++)
            {
                dataTable1.Rows.Add(dataTable[i].ItemArray);
            }
            services.DataSource = dataTable1;
            services.DisplayMember = "name";
            services.ValueMember = "idservices";
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

        public DataTable getAppartments(int id)
        {
            DataTable dataTable = Connection.getAppartments().Clone();
            DataRow[] dataRows = Connection.getAppartments().Select("buildingID = " + id + " AND rented = 1");
            for (int i = 0; i < dataRows.Length; i++)
            {

                dataTable.Rows.Add(dataRows[i].ItemArray);
            }
            return dataTable.Rows.Count == 0 ? null : dataTable;

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
           /* try
            {*/
                // get Rentel
                if (rentalNumber.SelectedValue != null)
                {
                    DataRow[] dataRows = Connection.getFullRentals().Select("idental = " + rentalNumber.SelectedValue.ToString());
                    DataRow dataRow = dataRows[0];
                    renter.SelectedValue = dataRow["renterID"].ToString();
                    detail.Text = dataRow["details"].ToString();
                    rentDuration.Text = dataRow["rentDuration"].ToString();
                    rentalType.Text = dataRow["rentalType"].ToString();
                    paymentMethod.Text = dataRow["paymentMethod"].ToString();
                try { startDate.Value = Convert.ToDateTime(dataRow["rentDate"]); } catch { }
                    graceMonth.Value = Convert.ToInt32(dataRow["graceMonth"]);
                    rentPercentage.Value = Convert.ToInt32(dataRow["rentPercentage"]);
                    DataRow[] data = Connection.getRentalServices().Select("idrental = " + rentalNumber.SelectedValue.ToString());

                    for (int i = 0; i < services.Items.Count; i++)
                    {
                        object item = services.Items[i];
                        DataRowView row = item as DataRowView;
                        if (data.Length != 0)
                            foreach (DataRow item1 in data)
                            {
                                if (item1["idservices"].ToString().Equals(row["idservices"].ToString()))
                                {
                                    services.SetItemChecked(i, true);
                                }


                            }
                        else
                            services.SetItemChecked(i, false);

                        getServices();

                    }
                }
       /*    }
            catch
            {
                Notification notification = new Notification("This Appartment have no rental", Color.Red);
                notification.Show();
            }*/

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
                   rentDuration.Value.ToString(), rentalType.Text, detail.Text,
                    startDate.Text, paymentMethod.Text, rentPercentage.Value.ToString(), graceMonth.Value.ToString());
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
            DataTable dataTable = Connection.getRentals().Clone();
            if (appartmentNumber.SelectedValue != null)
            {
                DataRow[] dataRows = Connection.getRentals().Select("appartmentNumber = " + appartmentNumber.SelectedValue.ToString());
                if (dataRows.Length != 0)
                {
                    for (int i = 0; i < dataRows.Length; i++)
                    {
                        dataTable.Rows.Add(dataRows[i].ItemArray);
                    }

                    rentalNumber.DataSource = dataTable;
                    rentalNumber.DisplayMember = "idental";
                    rentalNumber.ValueMember = "idental";
                }
            }
        }

        private void Services_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int pos = Convert.ToInt32(((CheckedListBox)sender).SelectedIndex.ToString());
            string value = ((CheckedListBox)sender).SelectedValue.ToString();

            //Console.WriteLine(((CheckedListBox)sender).GetItemCheckState(pos));

            try
            {
                if (((CheckedListBox)sender).GetItemCheckState(pos).ToString().Equals("Unchecked"))
                {
                    Connection.addRentalService(rentalNumber.SelectedValue.ToString(), value);
                    Console.WriteLine(((CheckedListBox)sender).GetItemCheckState(pos));

                }
                else
                {
                    Connection.deleteRentalService(rentalNumber.SelectedValue.ToString(), value);
                    Console.WriteLine(((CheckedListBox)sender).GetItemCheckState(pos));

                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void services_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
