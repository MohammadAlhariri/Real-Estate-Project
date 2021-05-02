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
    public partial class EditPerson : Form
    {
        Connection Connection = new Connection();

        public EditPerson()
        {
            InitializeComponent();
            getContries();
            getPersons();
        }

        private void getPersons()
        {
            DataTable dt = Connection.getAllPerson();
            dt.Columns.Add("FullName", typeof(string), "fName + ' ' + mName+' '+lName");

            person.DataSource = dt;
            person.DisplayMember = "FullName";
            person.ValueMember = "idperson";
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
        private void EditPerson_Load(object sender, EventArgs e)
        {

        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getStates(country.SelectedValue.ToString());
            states.DataSource = dataTable;
            states.DisplayMember = "name";
            states.ValueMember = "location_id";
        }

        private void States_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getStates(states.SelectedValue.ToString());
            city.DataSource = dataTable;
            city.DisplayMember = "name";
            city.ValueMember = "location_id";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deletePerson(person.SelectedValue.ToString());
                getPersons();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DataRow[] dataRows = Connection.getAllPerson().Select("idperson = " + person.SelectedValue.ToString());
            DataRow dataRow = dataRows[0];
            fName.Text = dataRow["fName"].ToString();
            mName.Text = dataRow["mName"].ToString();
            lName.Text = dataRow["lName"].ToString();
            country.Text = dataRow["country"].ToString();
            states.Text = dataRow["state"].ToString();
            city.Text = dataRow["city"].ToString();
            address.Text = dataRow["address"].ToString();
            role.Text = dataRow["role"].ToString();
            phone.Text = dataRow["phone"].ToString();
            email.Text = dataRow["email"].ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Color color = Color.White;
            try
            {

                int results = Connection.updatePerson(person.SelectedValue.ToString(),
                    fName.Text, mName.Text, lName.Text, country.Text,
                    states.Text, city.Text, address.Text, phone.Text,
                    email.Text, role.Text);
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
    }
}
