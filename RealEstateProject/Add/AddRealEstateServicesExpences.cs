using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject.Add
{
    public partial class AddRealEstateServicesExpences : Form
    {
        Connection Connection = new Connection();

        public AddRealEstateServicesExpences()
        {
            InitializeComponent();
            getRealestates();
            expences.DataSource = Connection.getRealestateServicesExpences();

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
        private void AddRealEstateServicesExpences_Load(object sender, EventArgs e)
        {

        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            double payment = 0;
            DataRow[] dataRows = Connection.getRealestateServicesExpences().Select("realestateID=" + realestateNumber.SelectedValue.ToString() + " AND month= '" + month.Text + "' AND year=" + year.Value.ToString());
            if (dataRows.Length != 0)
            {
                expences.DataSource = dataRows.CopyToDataTable();
                payment = Convert.ToDouble(dataRows.CopyToDataTable().Compute("SUM(amount)", "").ToString());
                total.Text = payment + "";
            }
            else
            {
                expences.DataSource = null;
                payment = 0;
               total.Text = "0";
            }

        }

        private void realestateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] dataTable = Connection.getRealestateServices().Select("ID=" + realestateNumber.SelectedValue.ToString());
            if (dataTable.Length != 0)
            {
                services.DataSource = dataTable.CopyToDataTable();
                services.DisplayMember = "name";
                services.ValueMember = "idservices";
            }
            else
            {
                services.DataSource = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //addRealestateServicesExpences
            string message = "";
            Color color = Color.White;
            int results = 0;
            if (mMonth.Checked)
            {
                var dat = new DateTime((int)year.Value, month.SelectedIndex, 1);

                for (int ctr = 1; ctr <= numberOfMonths.Value; ctr++)
                {
                    dat = dat.AddMonths(1);
                    //Console.WriteLine(dat.Year);
                    // Console.WriteLine(dat.ToString("MMMM"));
                    results = Connection.addRealestateServicesExpences(
                     realestateNumber.SelectedValue.ToString(),
                     services.SelectedValue.ToString(), ((Convert.ToInt32(amount.Text)) / numberOfMonths.Value) + "",
                     date.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    detail.Text, receiptNumber.Text, dat.ToString("MMMM"), dat.Year + "");
                }

            }

            else
                try
                {

                    results = Connection.addRealestateServicesExpences(
                        realestateNumber.SelectedValue.ToString(),
                        services.SelectedValue.ToString(), amount.Value.ToString(),
                        date.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                       detail.Text, receiptNumber.Text, month.Text, year.Value.ToString());
                }catch
                {
                    color = Color.Red;
                    message = "There are error, please correct it";
                }
                if (results == 0)
                {
                    message = "There are error";
                    color = Color.Red;
                }
                else if (results == 1)
                {
                    message = "Added Succefully";
                    color = Color.Green;
                    DataRow[] dataRows = Connection.getRealestateServicesExpences().Select("realestateID=" + realestateNumber.SelectedValue.ToString() + " AND month= '" + month.Text + "' AND year=" + year.Value.ToString());
                 
                        expences.DataSource = dataRows.CopyToDataTable();
                    double payment = 0;

                    payment = Convert.ToDouble(dataRows.CopyToDataTable().Compute("SUM(amount)", "").ToString());
                    total.Text = payment + "";

                }
                else
                {
                    message = "Please fill all Required fields";
                    color = Color.Blue;

                }


            
         
            Notification notification = new Notification(message, color);
            notification.Show();

        }

        private void mMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                numberOfMonths.Visible = true;
                startMonth.Text = "Start Month";
                startYear.Text = "Start Year";
            }
            else
            {
                numberOfMonths.Visible = false;
                startMonth.Text = "Month";
                startYear.Text = "Year";
            }
        }

        private void month_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
