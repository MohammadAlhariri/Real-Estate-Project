using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject.Reports
{
    public partial class RealEstates : Form
    {
        Connection connection = new Connection();
        public RealEstates()
        {
            InitializeComponent();
        }

        private void RealEstates_Load(object sender, EventArgs e)
        {
            DataRow[] rows = connection.getRealEstates().Select();
            foreach (var item in rows)
            {
                new UserControl1(item["estateNumber"].ToString(), item["address"].ToString(), item["ownerID"].ToString()).Parent = flowLayoutPanel1;
            }
        }
    }
}
