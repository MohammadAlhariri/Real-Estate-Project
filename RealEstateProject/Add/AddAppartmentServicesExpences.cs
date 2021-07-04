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
    public partial class AddAppartmentServicesExpences : Form
    {
        Connection Connection = new Connection();

        public AddAppartmentServicesExpences()
        {
            InitializeComponent();
            getRenters();
            getRealEstates();
            monthlyPayments.DataSource = Connection.getMonthlyAppartmentServiseExpences();
            getServices();
        }

        private void getServices()
        {
            DataRow[] dataTable = Connection.getRealestateServices().Select("ID ='" + realestateNumber.SelectedValue.ToString() + "'");
            DataTable dataTable1 = Connection.getRealestateServices().Clone();

            for (int i = 0; i < dataTable.Length; i++)
            {
                dataTable1.Rows.Add(dataTable[i].ItemArray);
            }
            serviceName.DataSource = dataTable1;
            serviceName.DisplayMember = "name";
            serviceName.ValueMember = "idservices";
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

        private void button1_Click(object sender, EventArgs e)
        {
            //addMonthlyAppartmentServiseExpences
            Notification notification = new Notification("Added Successfully", Color.RoyalBlue);
            try
            {
                int results = Connection.addMonthlyAppartmentServiseExpences(
                     rentalNumber.SelectedValue.ToString(), amount.Text, serviceName.SelectedValue.ToString(),
                    details.Text, month.Text, year.Value.ToString());
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
                monthlyPayments.DataSource = Connection.getMonthlyAppartmentServiseExpences();

            }
            catch
            {

                notification = new Notification("There are error, please correct it", Color.Red);
            }

            notification.Show();
        }

    

        private void AddAppartmentServicesExpences_Load(object sender, EventArgs e)
        {

        }

        private void realestateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = getAppartments(Convert.ToInt32(realestateNumber.SelectedValue.ToString()));
            AppartmentNumber.DataSource = dataTable;
            AppartmentNumber.DisplayMember = "appartmentNumber";
            AppartmentNumber.ValueMember = "iddepartment";
            getServices();
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
                }
            }
        }
    }
}
