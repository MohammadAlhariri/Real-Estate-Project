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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            
            if (username.Text.Equals("1") && password.Text.Equals("1"))
            {
                Program.isLogged = true;
                this.Close();
            }
            else
            {

                errorProvider1.SetError(button1, "User Name or Password It Is Not Correct");
            }
        }
    }
}
