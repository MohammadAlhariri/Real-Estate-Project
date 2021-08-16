using RealEstateProject.Model;
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
            getRealEstates();
        }
        public string getOwnerName(string id)
        {
            DataRow row = connection.getOwnerPersons().Select("idperson ="+id)[0];
            return row["name"].ToString();

        }
        public void getRealEstates()
        {
            DataRow[] rows = connection.getRealEstates().Select();
            RealEstateModel realEstateModel;
            foreach (var item in rows)
            {
                //string address = item["country"].ToString() + " / " + item["state"].ToString() + " / " + item["city"].ToString() + " / " + item["address"].ToString();

                realEstateModel = new RealEstateModel(item["Owner"].ToString(), item["ID"].ToString(), item["Location"].ToString(), item["estateNumber"].ToString());

                new RealEstateRow(realEstateModel).Parent = flowLayoutPanel1;
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                new PrintData(connection.getRealEstateReport()).export_pdf();
            }
            catch
            {

            }
        }





    }
}
