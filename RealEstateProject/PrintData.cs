using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.xml;
using System.Data;

namespace RealEstateProject
{
    class PrintData
    {
        private DataTable dataGridView1;

        public PrintData(DataTable dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }

        public void export_pdf()
        {
            //Table start.
            string html = "<table cellpadding='3' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial;margin:0 auto;text-align:center'>";

            //Adding HeaderRow.
            html += "<tr>";
            foreach (DataColumn column in dataGridView1.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc;'>" + column.ColumnName + "</th>";
            }
            html += "</tr>";

            //Adding DataRow.
            foreach (DataRow row in dataGridView1.Rows)
            {
                html += "<tr>";
                foreach (var cell in row.ItemArray)
                {
                    html += "<td dir='rtl' style='width:100px;border: 1px solid #ccc'>" + cell.ToString() + "</td>";
                }
                html += "</tr>";
            }

            //Table end.
            html += "</table>";
            string fileName = "file.html";
            string path = Path.Combine(Environment.CurrentDirectory, @"\", fileName);
            saveFileToPdf(html);

        }
        public void saveFileToPdf(string example_html)
        {
            //Create a byte array that will eventually hold our final PDF
            Byte[] bytes;
            var example_css = @"table{background:#ffffff}";

            //Boilerplate iTextSharp setup here
            //Create a stream that we can write to, in this case a MemoryStream
            using (var ms = new MemoryStream())
            {

                //Create an iTextSharp Document which is an abstraction of a PDF but **NOT** a PDF
                using (var doc = new Document())
                {

                    //Create a writer that's bound to our PDF abstraction and our stream
                    using (var writer = PdfWriter.GetInstance(doc, ms))
                    {

                        //Open the document for writing
                        doc.Open();

                        /**************************************************
                         *                                                *
                         *                                                *
                         * Use the XMLWorker to parse HTML and CSS        *
                         * ************************************************/

                        //In order to read CSS as a string we need to switch to a different constructor
                        //that takes Streams instead of TextReaders.
                        //Below we convert the strings into UTF8 byte array and wrap those in MemoryStreams

                        using (var msCss = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(example_css)))
                        {
                            using (var msHtml = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(example_html)))
                            {
                                //Parse the HTML
                                iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, msHtml, msCss);

                            }
                        }

                        doc.Close();
                    }
                }

                //After all of the PDF "stuff" above is done and closed but **before** we
                //close the MemoryStream, grab all of the active bytes from the stream
                bytes = ms.ToArray();
            }
            string text = "";
            //Now we just need to do something with those bytes.
            //Here I'm writing them to disk but if you were in ASP.Net you might Response.BinaryWrite() them.
            //You could also write the bytes to a database in a varbinary() column (but please don't) or you
            //could pass them to another function for further PDF processing.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.Title = "Save Pdf Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf file (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllBytes(text, bytes);
        }
    }
}
