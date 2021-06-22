namespace RealEstateProject
{
    partial class RealEstateManagmentApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealEstateManagmentApplication));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRealStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRealStateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addApartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMonthlyRentalPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPredefinedOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMonthlyServicePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRealEstateServicesExpencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExictToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRealEstateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRealEstateExpenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMonthlyRentalPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPredefinedOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realEstatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realEstateTradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppartmentServicesExpencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRealStateToolStripMenuItem,
            this.editExictToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.realEstateTradeToolStripMenuItem,
            this.calenderToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.phoneBookToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRealStateToolStripMenuItem
            // 
            this.addRealStateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRealStateToolStripMenuItem1,
            this.addApartmentToolStripMenuItem,
            this.addPersonToolStripMenuItem,
            this.addRentalToolStripMenuItem,
            this.addToolStripMenuItem,
            this.addMonthlyRentalPaymentToolStripMenuItem,
            this.addPredefinedOptionToolStripMenuItem,
            this.addMonthlyServicePaymentToolStripMenuItem,
            this.addRealEstateServicesExpencesToolStripMenuItem,
            this.addAppartmentServicesExpencesToolStripMenuItem});
            this.addRealStateToolStripMenuItem.Name = "addRealStateToolStripMenuItem";
            this.addRealStateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addRealStateToolStripMenuItem.Text = "Add New";
            this.addRealStateToolStripMenuItem.Click += new System.EventHandler(this.AddRealStateToolStripMenuItem_Click);
            // 
            // addRealStateToolStripMenuItem1
            // 
            this.addRealStateToolStripMenuItem1.Name = "addRealStateToolStripMenuItem1";
            this.addRealStateToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.addRealStateToolStripMenuItem1.Tag = "estate";
            this.addRealStateToolStripMenuItem1.Text = "AddRealState";
            this.addRealStateToolStripMenuItem1.Click += new System.EventHandler(this.AddRealStateToolStripMenuItem1_Click);
            // 
            // addApartmentToolStripMenuItem
            // 
            this.addApartmentToolStripMenuItem.Name = "addApartmentToolStripMenuItem";
            this.addApartmentToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addApartmentToolStripMenuItem.Text = "AddApartment";
            this.addApartmentToolStripMenuItem.Click += new System.EventHandler(this.AddApartmentToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addPersonToolStripMenuItem.Tag = "person";
            this.addPersonToolStripMenuItem.Text = "AddPerson";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.AddPersonToolStripMenuItem_Click);
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addRentalToolStripMenuItem.Text = "AddRental";
            this.addRentalToolStripMenuItem.Click += new System.EventHandler(this.AddRentalToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addToolStripMenuItem.Text = "AddRealStateExpense";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // addMonthlyRentalPaymentToolStripMenuItem
            // 
            this.addMonthlyRentalPaymentToolStripMenuItem.Name = "addMonthlyRentalPaymentToolStripMenuItem";
            this.addMonthlyRentalPaymentToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addMonthlyRentalPaymentToolStripMenuItem.Text = "AddMonthlyRentalPayment";
            this.addMonthlyRentalPaymentToolStripMenuItem.Click += new System.EventHandler(this.AddMonthlyRentalPaymentToolStripMenuItem_Click);
            // 
            // addPredefinedOptionToolStripMenuItem
            // 
            this.addPredefinedOptionToolStripMenuItem.Name = "addPredefinedOptionToolStripMenuItem";
            this.addPredefinedOptionToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addPredefinedOptionToolStripMenuItem.Text = "AddPredefinedOption";
            this.addPredefinedOptionToolStripMenuItem.Click += new System.EventHandler(this.AddPredefinedOptionToolStripMenuItem_Click);
            // 
            // addMonthlyServicePaymentToolStripMenuItem
            // 
            this.addMonthlyServicePaymentToolStripMenuItem.Name = "addMonthlyServicePaymentToolStripMenuItem";
            this.addMonthlyServicePaymentToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addMonthlyServicePaymentToolStripMenuItem.Text = "AddMonthlyServicePayment";
            this.addMonthlyServicePaymentToolStripMenuItem.Click += new System.EventHandler(this.addMonthlyServicePaymentToolStripMenuItem_Click);
            // 
            // addRealEstateServicesExpencesToolStripMenuItem
            // 
            this.addRealEstateServicesExpencesToolStripMenuItem.Name = "addRealEstateServicesExpencesToolStripMenuItem";
            this.addRealEstateServicesExpencesToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addRealEstateServicesExpencesToolStripMenuItem.Text = "AddRealEstateServicesExpences";
            this.addRealEstateServicesExpencesToolStripMenuItem.Click += new System.EventHandler(this.addRealEstateServicesExpencesToolStripMenuItem_Click);
            // 
            // editExictToolStripMenuItem
            // 
            this.editExictToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRealEstateToolStripMenuItem,
            this.editAppartmentToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.editRentalToolStripMenuItem,
            this.editRealEstateExpenceToolStripMenuItem,
            this.editMonthlyRentalPaymentToolStripMenuItem,
            this.editPredefinedOptionToolStripMenuItem});
            this.editExictToolStripMenuItem.Name = "editExictToolStripMenuItem";
            this.editExictToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.editExictToolStripMenuItem.Text = "Edit Exist";
            this.editExictToolStripMenuItem.Click += new System.EventHandler(this.EditExictToolStripMenuItem_Click);
            // 
            // editRealEstateToolStripMenuItem
            // 
            this.editRealEstateToolStripMenuItem.Name = "editRealEstateToolStripMenuItem";
            this.editRealEstateToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editRealEstateToolStripMenuItem.Text = "Edit RealEstate";
            this.editRealEstateToolStripMenuItem.Click += new System.EventHandler(this.EditRealEstateToolStripMenuItem_Click);
            // 
            // editAppartmentToolStripMenuItem
            // 
            this.editAppartmentToolStripMenuItem.Name = "editAppartmentToolStripMenuItem";
            this.editAppartmentToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editAppartmentToolStripMenuItem.Text = "Edit Appartment";
            this.editAppartmentToolStripMenuItem.Click += new System.EventHandler(this.EditAppartmentToolStripMenuItem_Click_1);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editPersonToolStripMenuItem.Text = "Edit Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.EditPersonToolStripMenuItem_Click);
            // 
            // editRentalToolStripMenuItem
            // 
            this.editRentalToolStripMenuItem.Name = "editRentalToolStripMenuItem";
            this.editRentalToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editRentalToolStripMenuItem.Text = "Edit Rental";
            this.editRentalToolStripMenuItem.Click += new System.EventHandler(this.EditRentalToolStripMenuItem_Click);
            // 
            // editRealEstateExpenceToolStripMenuItem
            // 
            this.editRealEstateExpenceToolStripMenuItem.Name = "editRealEstateExpenceToolStripMenuItem";
            this.editRealEstateExpenceToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editRealEstateExpenceToolStripMenuItem.Text = "Edit RealEstate Expence";
            this.editRealEstateExpenceToolStripMenuItem.Click += new System.EventHandler(this.EditRealEstateExpenceToolStripMenuItem_Click);
            // 
            // editMonthlyRentalPaymentToolStripMenuItem
            // 
            this.editMonthlyRentalPaymentToolStripMenuItem.Name = "editMonthlyRentalPaymentToolStripMenuItem";
            this.editMonthlyRentalPaymentToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editMonthlyRentalPaymentToolStripMenuItem.Text = "Edit Monthly Rental Payment";
            this.editMonthlyRentalPaymentToolStripMenuItem.Click += new System.EventHandler(this.EditMonthlyRentalPaymentToolStripMenuItem_Click);
            // 
            // editPredefinedOptionToolStripMenuItem
            // 
            this.editPredefinedOptionToolStripMenuItem.Name = "editPredefinedOptionToolStripMenuItem";
            this.editPredefinedOptionToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editPredefinedOptionToolStripMenuItem.Text = "Edit Predefined Option";
            this.editPredefinedOptionToolStripMenuItem.Click += new System.EventHandler(this.EditPredefinedOptionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realEstatesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // realEstatesToolStripMenuItem
            // 
            this.realEstatesToolStripMenuItem.Name = "realEstatesToolStripMenuItem";
            this.realEstatesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.realEstatesToolStripMenuItem.Text = "Real Estates";
            this.realEstatesToolStripMenuItem.Click += new System.EventHandler(this.RealEstatesToolStripMenuItem_Click);
            // 
            // realEstateTradeToolStripMenuItem
            // 
            this.realEstateTradeToolStripMenuItem.Name = "realEstateTradeToolStripMenuItem";
            this.realEstateTradeToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.realEstateTradeToolStripMenuItem.Text = "RealEstateTrade";
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.calenderToolStripMenuItem.Text = "Calender";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // phoneBookToolStripMenuItem
            // 
            this.phoneBookToolStripMenuItem.Name = "phoneBookToolStripMenuItem";
            this.phoneBookToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.phoneBookToolStripMenuItem.Text = "PhoneBook";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // addAppartmentServicesExpencesToolStripMenuItem
            // 
            this.addAppartmentServicesExpencesToolStripMenuItem.Name = "addAppartmentServicesExpencesToolStripMenuItem";
            this.addAppartmentServicesExpencesToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addAppartmentServicesExpencesToolStripMenuItem.Text = "AddAppartmentServicesExpences";
            this.addAppartmentServicesExpencesToolStripMenuItem.Click += new System.EventHandler(this.addAppartmentServicesExpencesToolStripMenuItem_Click);
            // 
            // RealEstateManagmentApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RealEstateManagmentApplication";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RealEstateManagmentApplication";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RealEstateManagmentApplication_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRealStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRealStateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMonthlyRentalPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPredefinedOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realEstateTradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addApartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExictToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRealEstateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRealEstateExpenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMonthlyRentalPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPredefinedOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realEstatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMonthlyServicePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRealEstateServicesExpencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppartmentServicesExpencesToolStripMenuItem;
    }
}

