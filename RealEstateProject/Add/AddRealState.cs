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
    public partial class AddRealState : Form
    {
        Connection Connection = new Connection();
        public AddRealState()
        {
            InitializeComponent();
            getContries();
            getOwners();
            realEstates.DataSource = Connection.getRealEstates();
            getServices();
        }

        private void getServices()
        {
            DataTable dataTable = Connection.getServices();
            DataRow dr = dataTable.NewRow();
            dr["idservices"] = "0";
            dr["name"] = "Other";

            dataTable.Rows.Add(dr);
            services.DataSource = dataTable;
            services.DisplayMember = "name";
            services.ValueMember = "idservices";
        }

        private void getOwners()
        {
            DataTable dataTable = Connection.getOwnerPersons();
            owner.DataSource = dataTable;
            owner.DisplayMember = "name";
            owner.ValueMember = "idperson";
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Color color = Color.White;
            try
            {
                int results = Connection.insertRealEstate(
                    estateNumber.Text, buildingNumber.Text, country.Text, states.Text, city.Text, neigborhood.Text, address.Text, currentState.Text, value.Text, collectorPercentage.Value.ToString(), owner.SelectedValue.ToString());
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
                realEstates.DataSource = Connection.getRealEstates();
                //addRealestateService
                string id = Connection.getRealEstates().Select("estateNumber=" + estateNumber.Text)[0][0].ToString();
                Connection.addRealestateService(id, services.CheckedItems);


            }
            catch
            {
                message = "There are error, please correct it";
                color = Color.Red;
            }
            Notification notification = new Notification(message, color);
            notification.Show();


        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getStates(country.SelectedValue.ToString());
            states.DataSource = dataTable;
            states.DisplayMember = "name";
            states.ValueMember = "location_id";

        }

        private void AddRealState_Load(object sender, EventArgs e)
        {

        }

        private void States_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = Connection.getStates(states.SelectedValue.ToString());
            city.DataSource = dataTable;
            city.DisplayMember = "name";
            city.ValueMember = "location_id";

        }

        private void Services_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (((CheckedListBox)sender).Text.Equals("Other"))
                {
                    PredefinedOptions predefinedOptions = new PredefinedOptions(7);
                    DialogResult dr = predefinedOptions.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        predefinedOptions.Close();
                       getServices();
                        services.SelectedIndex = services.Items.Count - 2;

                    }
                    else if (dr == DialogResult.OK)
                    {
                        predefinedOptions.Close();
                    }
                }
            
            
        }
    }
}
