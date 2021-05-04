using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject
{
    public partial class UserControl1 : UserControl
    {
        private string real="", add="",own="";
        public UserControl1(string real,string address1, string owner1)
        {
            InitializeComponent();
            this.real = real;
            this.add = address1;
            this.own = owner1;
            estateNumber.Text = real;
            owner.Text = own;
            address.Text = add;
        }
        public UserControl1()
        {
            InitializeComponent();
            btn.Visible = false;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
