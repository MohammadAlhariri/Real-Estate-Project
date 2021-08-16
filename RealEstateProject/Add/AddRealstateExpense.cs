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
        private string realestateID;

        public AddRealstateExpense()
        {
            InitializeComponent();
            expences.DataSource = Connection.getRealestateExpenses();
            getRealestates();
            getExpenseTypes();
        }

        public AddRealstateExpense(string realestateID):this()
        {
            this.realestateID = realestateID;
            realestateNumber.SelectedValue = realestateID;
        }

        private void getRealestates()
        {
            //realestateNumber
            DataTable dataTable = Connection.getRealEstates();
            dataTable.Columns.Add("realestate", typeof(string), "estateNumber + ' -> ' + Owner");
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "realestate";
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


        private void AddRealstateExpense_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int results=0;
            string message="";
            Color color = Color.White;
            try
            {
                if(mMonth.Checked)
                {
                    var dat = new DateTime((int)year.Value, month.SelectedIndex, 1);

                    for (int ctr = 1; ctr <= numberOfMonths.Value; ctr++)
                    {
                        dat = dat.AddMonths(1);
                        //Console.WriteLine(dat.Year);
                       // Console.WriteLine(dat.ToString("MMMM"));
                        results=Connection.insertRealEstateExpense(
                    realestateNumber.SelectedValue.ToString(),
                   expenseType.Text, ((amount.Value)/numberOfMonths.Value)+"",
                    date.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                   detail.Text, receiptNumber.Text, dat.ToString("MMMM"), dat.Year+"");
                    }
                }
            
                else
                results = Connection.insertRealEstateExpense(
                     realestateNumber.SelectedValue.ToString(),
                     expenseType.Text,amount.Value.ToString(),
                     date.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    detail.Text, receiptNumber.Text,month.Text,year.Value.ToString());

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                numberOfMonths.Visible = true;
                startMonth.Text = "Start Month";
                startYear.Text = "Start Year";
            }  else    {
                numberOfMonths.Visible = false;
                startMonth.Text = "Month";
                startYear.Text = "Year";
            }
        }
    }
}
