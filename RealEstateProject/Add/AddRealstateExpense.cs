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
    public partial class AddRealstateExpense : Form
    {
        Connection Connection = new Connection();

        public AddRealstateExpense()
        {
            InitializeComponent();
            expences.DataSource = Connection.getRealestateExpenses();
            getPersons();
            getRealestates();
            getExpenseTypes();
        }

        private void getRealestates()
        {
            //realestateNumber
            DataTable dataTable = Connection.getRealEstates();
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "estateNumber";
            realestateNumber.ValueMember = "ID";
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

        private void AddRealstateExpense_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string message="";
            Color color = Color.White;
            try
            {
                string moneyType = (leb.Checked) ?leb.Text:dollar.Text;

                int results = Connection.insertRealEstateExpense(
                     realestateNumber.SelectedValue.ToString(), person.SelectedValue.ToString(), expenseType.ToString(),amount.Value.ToString(), date.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    detail.Text,moneyType, receiptNumber.Text);

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
                expences.DataSource = Connection.getRealestateExpenses();


            }
            catch
            {
               color = Color.Red;
                message = "There are error, please correct it";
            }
            Notification notification = new Notification(message, color);
            notification.Show();

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
    }
}
