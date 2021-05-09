using RealEstateProject.Edit;
using RealEstateProject.Reports;
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

namespace RealEstateProject.Dialogs
{
    public partial class RealEsateDialog : Form
    {
        private string real;
        private string add;
        private string own;
        private string realestateID;
        Connection Connection = new Connection();

        public RealEsateDialog()
        {
            InitializeComponent();
        }

        public RealEsateDialog(string real, string add, string own, string realestateID)
        {
            InitializeComponent();
            this.real = real;
            this.add = add;
            this.own = own;
            this.realestateID = realestateID;
            realEstate.Text = real + " || " + own + " || " + add;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EditRealEstate editRealEstate = new EditRealEstate(realestateID);
            editRealEstate.MdiParent = this.MdiParent;
            editRealEstate.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                Connection.deleteRealEstate(realestateID);

                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment(realestateID);
            addDepartment.MdiParent = this.MdiParent;
            addDepartment.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EditAppartment editAppartment = new EditAppartment(realestateID);
            editAppartment.MdiParent = this.MdiParent;
            editAppartment.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            AddRealstateExpense addRealstateExpense = new AddRealstateExpense(realestateID);
            addRealstateExpense.MdiParent = this.MdiParent;
            addRealstateExpense.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            EditRealEstateExpense editRealEstateExpense = new EditRealEstateExpense(realestateID);
            editRealEstateExpense.MdiParent = this.MdiParent;
            editRealEstateExpense.Show();
        }
    }
}
