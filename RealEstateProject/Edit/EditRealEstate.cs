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
    public partial class EditRealEstate : Form
    {
        Connection Connection = new Connection();

        public EditRealEstate(string id):this()
        {
            this.id = id;
            realEstateNumber.SelectedValue = id;
            getText();
        }

        public EditRealEstate()
        {
            InitializeComponent();
            getContries();
            getOwners();
            getRealEstates();
            getServices();


        }
        private string id;
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
        private void getRealEstates()
        {

            DataTable dataTable = Connection.getRealEstates();
            realEstateNumber.DataSource = dataTable;
            realEstateNumber.DisplayMember = "estateNumber";
            realEstateNumber.ValueMember = "ID";
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
        private void EditRealEstate_Load(object sender, EventArgs e)
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
            city.ValueMember = "name";
        }
        public DataRow getRealEstate(int id)
        {
            for (int i = 0; i < Connection.getRealEstates().Rows.Count; i++)
            {
                if (Convert.ToInt32(Connection.getRealEstates().Rows[i]["ID"]) == id)
                    return Connection.getRealEstates().Rows[i];
            }
            return null;
        }
        private void RealEstateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Connection.deleteRealEstate(id);
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteRealEstate(realEstateNumber.SelectedValue.ToString());
                getRealEstates();
            }
         
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string message = "";
            Color color = Color.White;

            //try
            //{

                int results = Connection.updateRealEstate(
                    realEstateNumber.SelectedValue.ToString(), buildingNumber.Text, country.Text, states.Text, city.Text, neigborhood.Text,
                    address.Text, currentState.Text, value.Text, collectorPercentage.Value.ToString(), owner.SelectedValue.ToString());


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

          /*  }
            catch
            {
                color = Color.Red;
                message = "There are error, please correct it";
            }*/
            Notification notification = new Notification(message, color);

            notification.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            getText();
        }
        public void getText()
        {
            DataRow dataRow = getRealEstate(Convert.ToInt32(realEstateNumber.SelectedValue.ToString()));
            buildingNumber.Text = dataRow["buildingNumber"].ToString();
            country.Text = dataRow["country"].ToString();
            states.Text = dataRow["state"].ToString();
            city.SelectedValue = dataRow["city"].ToString();
            value.Text = dataRow["value"].ToString();
            address.Text = dataRow["address"].ToString();
            collectorPercentage.Value = Convert.ToInt32(dataRow["collectorPercentage"].ToString());
            neigborhood.Text = dataRow["neigborhood"].ToString();
            currentState.Text = dataRow["currentState"].ToString();
            owner.SelectedValue = dataRow["ownerID"].ToString();
            DataRow[] data = Connection.getRealestateServices().Select("ID = "+ realEstateNumber.SelectedValue.ToString());
            for (int i=0;i<services.Items.Count;i++)
            {
                object item = services.Items[i];
                DataRowView row = item as DataRowView;
                if (data.Length != 0)
                    foreach (DataRow item1 in data)
                    {
                        if (item1["idservice"].ToString().Equals(row["idservices"].ToString()))
                        {
                            services.SetItemChecked(i, true);
                        }


                    }
                else
                    services.SetItemChecked(i, false);
                

            }
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

        private void Services_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int pos=Convert.ToInt32(((CheckedListBox)sender).SelectedIndex.ToString());
            string value = ((CheckedListBox)sender).SelectedValue.ToString();

            //Console.WriteLine(((CheckedListBox)sender).GetItemCheckState(pos));

            try
            {
                if (((CheckedListBox)sender).GetItemCheckState(pos).ToString().Equals("Unchecked"))
                {
                    Connection.addRealestateService(realEstateNumber.SelectedValue.ToString(), value);
                    Console.WriteLine(((CheckedListBox)sender).GetItemCheckState(pos));

                }
                else
                {
                    Connection.deleteRealestateService(realEstateNumber.SelectedValue.ToString(), value);
                    Console.WriteLine(((CheckedListBox)sender).GetItemCheckState(pos));

                }
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}
