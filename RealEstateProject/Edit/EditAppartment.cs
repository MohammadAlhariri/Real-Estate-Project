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
    public partial class EditAppartment : Form
    {
        Connection Connection = new Connection();
        private string realestateID;

        public EditAppartment()
        {
            InitializeComponent();
            getOwners();
            getBuildings();

        }

        public EditAppartment(string realestateID):this()
        {
            this.realestateID = realestateID;
            buildingNumber.SelectedValue = realestateID;

        }

        public void getOwners()
        {
            DataTable dataTable = Connection.getOwnerPersons();
            owner.DataSource = dataTable;
            owner.DisplayMember = "name";
            owner.ValueMember = "idperson";
        }
        public void getBuildings()
        {
            DataTable dataTable = Connection.getRealEstates();
            buildingNumber.DataSource = dataTable;
            buildingNumber.DisplayMember = "estateNumber";
            buildingNumber.ValueMember = "ID";
        }
        private void EditAppartment_Load(object sender, EventArgs e)
        {

        }
        public DataTable getAppartments(int id)
        {
            DataTable dataTable = Connection.getAppartments().Clone();
            DataRow[] dataRows = Connection.getAppartments().Select("buildingID = " + id);
            for (int i = 0; i < dataRows.Length; i++)
            {
         
                    dataTable.Rows.Add(dataRows[i].ItemArray);
            }
            return dataTable;

        }

        private void BuildingNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataTable dataTable = getAppartments(Convert.ToInt32(buildingNumber.SelectedValue.ToString()));
            AppartmentNumber.DataSource = dataTable;
            AppartmentNumber.DisplayMember = "appartmentNumber";
            AppartmentNumber.ValueMember = "iddepartment";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteAppartment(AppartmentNumber.SelectedValue.ToString());
                getBuildings();
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DataRow[] dataRows = Connection.getAppartments().Select("iddepartment = " + AppartmentNumber.SelectedValue.ToString());
            DataRow dataRow = dataRows[0];
            mInDollar.Text = dataRow["monthlyRentalInDollar"].ToString();
            type.Text = dataRow["type"].ToString();

            floor.Value = Convert.ToInt32(dataRow["floor"].ToString());
            numberOfRooms.Value = Convert.ToInt32(dataRow["numberOfRooms"].ToString());
            details.Text = dataRow["details"].ToString();
            owner.SelectedValue = dataRow["ownerID"].ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string message = "";
            Color color = Color.White;
            //
            try
            {


                int results = Connection.updateDepartment(
                    AppartmentNumber.SelectedValue.ToString(), owner.SelectedValue.ToString(), 
                    floor.Text, buildingNumber.SelectedValue.ToString(), type.Text,
                    numberOfRooms.Value.ToString(),mInDollar.Text, 
                    details.Text);

                if (results == 0)
                {
                    message = "There are error";
                    color = Color.Red;
                }
                else if (results == 1)
                {
                    message = "Updated Succefully";
                    color = Color.Blue;
                    AppartmentNumber.SelectedIndex = 0;
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
    }
}
