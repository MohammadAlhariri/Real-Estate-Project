using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RealEstateProject.Edit
{
    public partial class EditRealEstateExpense : Form
    {
        Connection Connection = new Connection();

        public EditRealEstateExpense()
        {
            InitializeComponent();
            getPersons();
            getRealestatesExpences();
            getExpenseTypes();
            getRealestates();

        }
        private void getRealestates()
        {
            //realestateNumber
            DataTable dataTable = Connection.getRealEstates();
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "estateNumber";
            realestateNumber.ValueMember = "ID";
        }
        private void getRealestatesExpences()
        {
            //realestateNumber
            DataTable dataTable = Connection.getRealestateExpenses();
            receiptNumber.DataSource = dataTable;
            receiptNumber.DisplayMember = "receiptNumber";
            receiptNumber.ValueMember = "id";
        }
        private void getExpenseTypes()
        {
            //realestateNumber
            DataTable dataTable = Connection.getExpenseTypes();
            DataRow dr = dataTable.NewRow();
            dr["idexpense_type"] = "0";
            dr["expenseType"] = "Other";

            dataTable.Rows.Add(dr);
            expenseType.DataSource = dataTable;
            expenseType.DisplayMember = "expenseType";
            expenseType.ValueMember = "expenseType";
        }
        private void getPersons()
        {
            DataTable dataTable = Connection.getAllPerson();
            person.DataSource = dataTable;
            person.DisplayMember = "name";
            person.ValueMember = "idperson";
        }

        private void EditRealEstateExpense_Load(object sender, EventArgs e)
        {

        }

        private void ExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (expenseType.Text.Equals("Other"))
            {
                PredefinedOptions predefinedOptions = new PredefinedOptions(2);
                DialogResult dr = predefinedOptions.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    predefinedOptions.Close();
                    getExpenseTypes();
                    expenseType.SelectedIndex = expenseType.Items.Count - 2;

                }
                else if (dr == DialogResult.OK)
                {
                    predefinedOptions.Close();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //get
            DataRow[] dataRows = Connection.getRealestateExpenses().Select("id = " + receiptNumber.SelectedValue.ToString());
            DataRow dataRow = dataRows[0];
            person.SelectedValue = dataRow["personID"].ToString();
            realestateNumber.SelectedValue = dataRow["realestateID"].ToString();
            expenseType.Text = dataRow["ExpenseType"].ToString();
            amount.Text = dataRow["amount"].ToString();
            detail.Text = dataRow["detail"].ToString();
            date.Value = Convert.ToDateTime(dataRow["date"]);
            if (dataRow["moneyType"].ToString().Equals("$$"))
                dollar.Checked = true;
            else
                leb.Checked = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //delete
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteRealEstateExpense(receiptNumber.SelectedValue.ToString());
                getRealestatesExpences();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //update
            string message = "";
            Color color = Color.White;
            try
            {
                string moneyType = (leb.Checked) ? leb.Text : dollar.Text;

                int results = Connection.updateRealEstateExpense(
                     realestateNumber.SelectedValue.ToString(), person.SelectedValue.ToString(), expenseType.Text, amount.Value.ToString(), date.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    detail.Text, moneyType,receiptNumber.SelectedValue.ToString());

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
