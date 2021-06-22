﻿using System;
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
    public partial class AddMonthlyServisesPayment : Form
    {
        Connection Connection = new Connection();

        public AddMonthlyServisesPayment()
        {
            InitializeComponent();
            getRenters();
            getRealEstates();
            getAllMonthlyRentalServices();
        }

        private void getAllMonthlyRentalServices()
        {
            if (rentalNumber.SelectedValue != null)
            {
                double services =0, payment =0, nets = 0;
                DataRow[] dataTable = Connection.getAllRentalServices().Select("idrental=" + rentalNumber.SelectedValue.ToString() + " AND month= '" + month.Text + "' AND year=" + year.Value.ToString());
                if (dataTable.Length != 0)
                {
                    
                    monthlyservicePayments.DataSource = dataTable.CopyToDataTable();
                    services = Convert.ToDouble(dataTable.CopyToDataTable().Compute("SUM(amount)", "").ToString());
                    total.Text = services+"";
                }
                else
                {
                    monthlyservicePayments.DataSource = null;
                    services = 0;
                    total.Text = "0";
                }
                DataRow[] dataRows = Connection.getMonthlyAppartmentServicesPayments().Select("rentalID=" + rentalNumber.SelectedValue.ToString() + " AND month= '" + month.Text + "' AND year=" + year.Value.ToString());
                if (dataRows.Length != 0)
                {
                    payments.DataSource = dataRows.CopyToDataTable();
                    payment = Convert.ToDouble(dataRows.CopyToDataTable().Compute("SUM(amount)", "").ToString());
                    totalPayments.Text =payment+""; 
                }
                else
                {
                    payments.DataSource = null;
                    payment = 0;
                    totalPayments.Text ="0";
                }
                net.Text = (services - payment) + "";
                
            }
        }

        private void getServices()
        {
            try
            {
                if (rentalNumber.SelectedValue != null)
                {
                    DataRow[] dataTable = Connection.getRentalServices().Select(" idental = " + rentalNumber.SelectedValue.ToString());
                    if (dataTable.Length != 0)
                    {
                        serviceName.DataSource = dataTable.CopyToDataTable();
                        serviceName.DisplayMember = "name";
                        serviceName.ValueMember = "idservices";
                    }
                    else
                    {
                        serviceName.DataSource = null;
                    }
                }
            }
            catch { }
        }

        private void getRenters()
        {
            DataTable dataTable = Connection.getRenterPersons();
            renterName.DataSource = dataTable;
            renterName.DisplayMember = "name";
            renterName.ValueMember = "idperson";
        }
        public void getRealEstates()
        {
            DataTable dataTable = Connection.getRealEstates();
            realestateNumber.DataSource = dataTable;
            realestateNumber.DisplayMember = "estateNumber";
            realestateNumber.ValueMember = "ID";
            dataTable = getAppartments(Convert.ToInt32(realestateNumber.SelectedValue.ToString()));
            AppartmentNumber.DataSource = dataTable;
            AppartmentNumber.DisplayMember = "appartmentNumber";
            AppartmentNumber.ValueMember = "iddepartment";
        }
        private void AddMonthlyServisesPayment_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void realestateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = getAppartments(Convert.ToInt32(realestateNumber.SelectedValue.ToString()));
            AppartmentNumber.DataSource = dataTable;
            AppartmentNumber.DisplayMember = "appartmentNumber";
            AppartmentNumber.ValueMember = "iddepartment";
        }
        public DataTable getAppartments(int id)
        {
            DataTable dataTable = Connection.getAppartments().Clone();
            DataRow[] dataRows = Connection.getAppartments().Select("buildingID = " + id + " AND rented = 1");
            for (int i = 0; i < dataRows.Length; i++)
            {

                dataTable.Rows.Add(dataRows[i].ItemArray);
            }
            return dataTable.Rows.Count == 0 ? null : dataTable;

        }

        private void AppartmentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AppartmentNumber.SelectedValue != null)
            {
                DataTable dataTable = Connection.getRentals().Select("appartmentNumber = " + AppartmentNumber.SelectedValue.ToString()).CopyToDataTable();
                if (dataTable.Rows.Count != 0)
                {

                    rentalNumber.DataSource = dataTable;
                    rentalNumber.DisplayMember = "idental";
                    rentalNumber.ValueMember = "idental";
                    getServices();
                }
            }
        }

        private void rentalNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            getServices();
        }

        private void payMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payMethod.SelectedItem.ToString().Equals("Check"))
            {
                payRequirments.Visible = true;
            }


            else
            {
                payRequirments.Visible = false;

            }
        }

        private void bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bank.Text.Equals("Other"))
            {
                PredefinedOptions predefinedOptions = new PredefinedOptions(0);
                DialogResult dr = predefinedOptions.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    predefinedOptions.Close();
                    getBanks();
                    bank.SelectedIndex = bank.Items.Count - 2;
                }
                else if (dr == DialogResult.OK)
                {
                    //predefinedOptions.Close();
                }
            }
        }
        private void getBanks()
        {
            DataTable dataTable = Connection.getBanks();
            DataRow dr = dataTable.NewRow();
            dr["idbanks"] = "0";
            dr["bank"] = "Other";
            dataTable.Rows.Add(dr);
            bank.DataSource = dataTable;
            bank.DisplayMember = "bank";
            bank.ValueMember = "bank";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //addMonthlyRentalPayment
            Notification notification = new Notification("Added Successfully", Color.RoyalBlue);
/*            try
            {*/
                int results = Connection.addMonthlyRentalServicesPayments(
                    rentalNumber.SelectedValue.ToString(), amount.Text, payDate.Value.Date.ToString("yyyy-MM-dd HH:mm"),
                    details.Text, payMethod.Text, checkNumber.Text, bank.Text, receiptNumber.Text, month.Text, year.Value.ToString());
                if (results == 0)
                {

                    notification = new Notification("There are error", Color.Red);
                }
                else if (results == 1)
                {

                    notification = new Notification("Added Successfully", Color.Green);

                }
                else
                {

                    notification = new Notification("Please fill all Required fields", Color.Yellow);

                }
            getAllMonthlyRentalServices();

/*            }
            catch
            {

                notification = new Notification("There are error, please correct it", Color.Red);
            }*/

            notification.Show();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAllMonthlyRentalServices();
           

        }
    }
}
