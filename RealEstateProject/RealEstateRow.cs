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
using RealEstateProject.Model;

namespace RealEstateProject
{
    public partial class RealEstateRow : UserControl
    {

        private RealEstateModel realEstateModel;

        public RealEstateRow()
        {
            InitializeComponent();
            btn.Visible = false;

        }
        public RealEstateRow(RealEstateModel realEstateModel) : this()
        {
            btn.Visible = true;
            this.realEstateModel = realEstateModel;
            estateNumber.Text = realEstateModel.RealEstateNumber;
            owner.Text = realEstateModel.Owner;
            address.Text = realEstateModel.Address;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            RealEsateDialog confirmResult = new RealEsateDialog(realEstateModel);
            confirmResult.MdiParent = this.ParentForm.MdiParent;
            confirmResult.Show();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {

        }

   

  
        private void UserControl1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
