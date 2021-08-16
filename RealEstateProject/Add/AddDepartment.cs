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
    public partial class AddDepartment : Form
    {
        private  Connection Connection = new Connection();
        private string realestateID;

        public AddDepartment()
        {
            InitializeComponent();
            getOwners();
            appartmentss.DataSource = Connection.getAppartments();
            getBuildings();
        }

        public AddDepartment(string realestateID):this()
        {
            this.realestateID = realestateID;
            buildingNumber.SelectedValue = realestateID;
        }

        private void AppartmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         

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
            dataTable.Columns.Add("realestate", typeof(string), "estateNumber + ' -> ' + Owner");
            buildingNumber.DataSource = dataTable;
            buildingNumber.DisplayMember = "realestate";
            buildingNumber.ValueMember = "ID";
        }
 
        private void AddDepartment_Load(object sender, EventArgs e)
        {
       

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Color color = Color.White;

            try
           {
                //public int insertDepartment(string appartmentNumber , string ownerID, string floor, string buildingID, string type, string numberOfRooms, string dailyRentalInDollar, string monthlyRentalInDollar, string yearlyRentalInDollar, string dailyRentalInLera, string monthlyRentalInLera, string yearlyRentalInLera, string details)

                int results = Connection.insertDepartment(
                    appartmentNumber.Value.ToString(), owner.SelectedValue.ToString(), floor.Text, buildingNumber.SelectedValue.ToString(), type.Text, numberOfRooms.Value.ToString(), mInDollar.Text, details.Text);

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
                appartmentss.DataSource = Connection.getAppartments();
      

            }
            catch
            {
                color = Color.Red;
                message= "There are error, please correct it";
            }
            Notification notification = new Notification(message, color);

            notification.Show();
            checkIfExist();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buildingNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            owner.Text = ((DataTable)buildingNumber.DataSource).Select("ID =" + buildingNumber.SelectedValue.ToString())[0][4].ToString();
            checkIfExist();
        }

        private void appartmentNumber_ValueChanged(object sender, EventArgs e)
        {
            checkIfExist();
        }
        public void checkIfExist()
        {
            DataRow[] dataRows = Connection.getAppartments().Select("buildingID=" + buildingNumber.SelectedValue.ToString() + " AND appartmentNumber= " + appartmentNumber.Value);
            if (dataRows.Length != 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
