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
    public partial class AddPerson : Form
    {
        Connection Connection = new Connection();

        public AddPerson()
        {
            InitializeComponent();
            getContries();
            persons.DataSource = Connection.getAllPerson();


        }

        private void PersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
        }

        private void PersonBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void PersonBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
        }
        private void getContries()
        {
            DataTable dataTable = Connection.getCountries();

            country.DataSource = dataTable;
            country.DisplayMember = "name";
            country.ValueMember = "location_id";
            states.DataSource = Connection.getStates(country.SelectedValue.ToString());
            states.DisplayMember = "name";
            states.ValueMember = "location_id";
            city.DataSource = Connection.getStates(states.SelectedValue.ToString());
            city.DisplayMember = "name";
            city.ValueMember = "location_id";

        }
        private void Country_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getStates(country.SelectedValue.ToString());
            states.DataSource = dataTable;
            states.DisplayMember = "name";
            states.ValueMember = "location_id";

        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void States_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getStates(states.SelectedValue.ToString());
            city.DataSource = dataTable;
            city.DisplayMember = "name";
            city.ValueMember = "location_id";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Color color = Color.White;
            try
            {
               
                int results = Connection.insertPerson(
                    fName.Text, mName.Text, lName.Text, country.Text, states.Text, city.Text, address.Text, phone.Text, email.Text, role.Text);
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
                persons.DataSource = Connection.getAllPerson();


            }
            catch
            {
                message = "There are error, please correct it";
                color = Color.Red;
            }
            Notification notification = new Notification(message, color);
            notification.Show();

        }
    }
}
