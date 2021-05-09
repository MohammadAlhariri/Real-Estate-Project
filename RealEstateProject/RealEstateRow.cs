using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using RealEstateProject.Dialogs;

namespace RealEstateProject
{
    public partial class RealEstateRow : UserControl
    {
        private string real="", add="",own="";
        private string realestateID = "0";
        public RealEstateRow(string real,string address1, string owner1,string realestateID)
        {
            InitializeComponent();
            this.real = real;
            this.add = address1;
            this.own = owner1;
            this.realestateID = realestateID;
            estateNumber.Text = real;
            owner.Text = own;
            address.Text = add;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            RealEsateDialog confirmResult = new RealEsateDialog(real, add, own,  realestateID);
            confirmResult.MdiParent = this.ParentForm.MdiParent;
            confirmResult.Show();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        public RealEstateRow()
        {
            InitializeComponent();
            btn.Visible = false;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
