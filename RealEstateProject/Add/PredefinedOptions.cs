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
    public partial class PredefinedOptions : Form
    {
        Connection Connection = new Connection();
        public PredefinedOptions(int i)
        {

            InitializeComponent();
            
            getOptions();
            type.SelectedIndex = i;
        }        public PredefinedOptions()
        {

            InitializeComponent();
            getOptions();

        }

        private void getOptions()
        {
            DataTable dataTable = Connection.getOptions();
            type.DataSource = dataTable;
            type.DisplayMember = "option";
            type.ValueMember = "idoptions";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Connection.AddPredefinedOption(Convert.ToInt32(type.SelectedValue), option.Text);
            this.Close();
        }

        private void PredefinedOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
