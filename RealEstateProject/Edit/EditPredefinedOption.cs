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
    public partial class EditPredefinedOption : Form
    {
        Connection Connection = new Connection();

        public EditPredefinedOption()
        {
            InitializeComponent();
            getOptions();
        }
        private void getOptions()
        {
            DataTable dataTable = Connection.getOptions();
            type.DataSource = dataTable;
            type.DisplayMember = "option";
            type.ValueMember = "idoptions";
        }
        private void EditPredefinedOption_Load(object sender, EventArgs e)
        {

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable=Connection.getValues(type.SelectedValue.ToString());
            option.DataSource = dataTable;
            option.DisplayMember = dataTable.Columns[1].ColumnName;
            option.ValueMember = dataTable.Columns[0].ColumnName;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //delete
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteValue(type.SelectedValue.ToString(),option.SelectedValue.ToString());
                getOptions();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //update
            string message = "";
            Color color = Color.White;
            try
            {

                int results = Connection.updateValue(
                    type.SelectedValue.ToString(),
                    option.SelectedValue.ToString(),
                    value.Text);
                if (results == 0)
                {
                    message = "There are error";
                    color = Color.Red;
                }
                else if (results == 1)
                {
                    message = "Updated Succefully";
                    color = Color.Blue;
                    getOptions();


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
