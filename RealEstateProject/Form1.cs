using RealEstateProject.Edit;
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
    public partial class RealEstateManagmentApplication : Form
    {
        public RealEstateManagmentApplication()
        {
            InitializeComponent();
            Connection connection = new Connection();
        }

        private void AddRealStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RealEstateManagmentApplication_Load(object sender, EventArgs e)
        {

        }

        private void AddRealStateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRealState add = new AddRealState();
            add.MdiParent = this;
            add.Show();

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson add = new AddPerson();
            add.MdiParent = this;
            add.Show();

        }

        private void AddApartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment add = new AddDepartment();
            add.MdiParent = this;
            add.Show();

        }

        private void AddRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental add = new AddRental();
            add.MdiParent = this;
            add.Show();
        }

        private void AddMonthlyRentalPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMonthlyRentalPayments add = new AddMonthlyRentalPayments();
            add.MdiParent = this;
            add.Show();

        }

        private void EditExictToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRealstateExpense add = new AddRealstateExpense();
            add.MdiParent = this;
            add.Show();
        }

        private void AddPredefinedOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredefinedOptions add = new PredefinedOptions();
            add.MdiParent = this;
            add.Show();
        }

        private void EditRealEstateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRealEstate add = new EditRealEstate();
            add.MdiParent = this;
            add.Show();

        }


        private void EditAppartmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditAppartment add = new EditAppartment();
            add.MdiParent = this;
            add.Show();
        }

        private void EditPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerson editPerson = new EditPerson();
            editPerson.MdiParent = this;
            editPerson.Show();
        }

        private void EditRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRental editRental = new EditRental();
            editRental.MdiParent = this;
            editRental.Show();
        }

        private void EditRealEstateExpenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRealEstateExpense editRealEstateExpense = new EditRealEstateExpense();
            editRealEstateExpense.MdiParent = this;
            editRealEstateExpense.Show();
        }

        private void EditMonthlyRentalPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMonthlyRentalPayment editMonthlyRentalPayment = new EditMonthlyRentalPayment();
            editMonthlyRentalPayment.MdiParent = this;
            editMonthlyRentalPayment.Show();
        }
    }
}
