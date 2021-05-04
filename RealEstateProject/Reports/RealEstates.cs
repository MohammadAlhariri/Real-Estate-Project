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
                string address = item["country"].ToString()+" / " +item["state"].ToString()+" / " +item["city"].ToString()+" / "+item["address"].ToString();
                new UserControl1(item["estateNumber"].ToString(),address, getOwnerName(item["ownerID"].ToString())).Parent = flowLayoutPanel1;
            }
        }
        public string getOwnerName(string id)
        {
            DataRow row = connection.getOwnerPersons().Select("idperson ="+id)[0];
            return row["name"].ToString();

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PrintAllImages();
        }



        private int imagesToPrintCount;
        private void PrintAllImages()
        {
            imagesToPrintCount = flowLayoutPanel1.Controls.Count;
            flowLayoutPanel1.Height = 220 * 5;
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += Document_PrintPage;
            PrintDialog dialog = new PrintDialog();
            dialog.Document = doc;
            if (dialog.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RectangleF bounds = e.PageSettings.PrintableArea;
            e.Graphics.DrawImage(GetNextImage(), e.MarginBounds);
            e.HasMorePages = imagesToPrintCount > 0;

        }
        private Bitmap GetNextImage()
        {
            Bitmap bmp = new Bitmap(flowLayoutPanel1.Width, flowLayoutPanel1.Height, flowLayoutPanel1.CreateGraphics());
            flowLayoutPanel1.DrawToBitmap(bmp, new Rectangle(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height));
            imagesToPrintCount = imagesToPrintCount - 5;
            return bmp;
        }

    }
}
