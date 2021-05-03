namespace RealEstateProject
{
    partial class AddMonthlyRentalPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMonthlyRentalPayments));
            this.label7 = new System.Windows.Forms.Label();
            this.monthlyRentalPayments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkNumber = new System.Windows.Forms.TextBox();
            this.AppartmentNumber = new System.Windows.Forms.ComboBox();
            this.renterName = new System.Windows.Forms.ComboBox();
            this.payMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.payDate = new System.Windows.Forms.DateTimePicker();
            this.details = new System.Windows.Forms.TextBox();
            this.payRequirments = new System.Windows.Forms.GroupBox();
            this.bank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.realestateNumber = new System.Windows.Forms.ComboBox();
            this.receiptNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyRentalPayments)).BeginInit();
            this.payRequirments.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(547, 47);
            this.label7.TabIndex = 109;
            this.label7.Text = "Add Monthly Rental Payments";
            // 
            // monthlyRentalPayments
            // 
            this.monthlyRentalPayments.AllowUserToAddRows = false;
            this.monthlyRentalPayments.AllowUserToDeleteRows = false;
            this.monthlyRentalPayments.AllowUserToResizeColumns = false;
            this.monthlyRentalPayments.AllowUserToResizeRows = false;
            this.monthlyRentalPayments.BackgroundColor = System.Drawing.Color.White;
            this.monthlyRentalPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyRentalPayments.Location = new System.Drawing.Point(8, 320);
            this.monthlyRentalPayments.Name = "monthlyRentalPayments";
            this.monthlyRentalPayments.Size = new System.Drawing.Size(1213, 264);
            this.monthlyRentalPayments.TabIndex = 108;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(884, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 107;
            this.button1.Text = "Add Monthly Rental Payments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(793, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 103;
            this.label11.Text = "Appartment Number";
            // 
            // checkNumber
            // 
            this.checkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumber.Location = new System.Drawing.Point(146, 62);
            this.checkNumber.Name = "checkNumber";
            this.checkNumber.Size = new System.Drawing.Size(207, 26);
            this.checkNumber.TabIndex = 97;
            // 
            // AppartmentNumber
            // 
            this.AppartmentNumber.DisplayMember = "name";
            this.AppartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppartmentNumber.FormattingEnabled = true;
            this.AppartmentNumber.Location = new System.Drawing.Point(974, 90);
            this.AppartmentNumber.Name = "AppartmentNumber";
            this.AppartmentNumber.Size = new System.Drawing.Size(207, 28);
            this.AppartmentNumber.TabIndex = 95;
            this.AppartmentNumber.ValueMember = "name";
            // 
            // renterName
            // 
            this.renterName.DisplayMember = "name";
            this.renterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renterName.FormattingEnabled = true;
            this.renterName.Location = new System.Drawing.Point(173, 90);
            this.renterName.Name = "renterName";
            this.renterName.Size = new System.Drawing.Size(235, 28);
            this.renterName.TabIndex = 94;
            this.renterName.ValueMember = "name";
            // 
            // payMethod
            // 
            this.payMethod.DisplayMember = "role";
            this.payMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMethod.FormattingEnabled = true;
            this.payMethod.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Other"});
            this.payMethod.Location = new System.Drawing.Point(561, 137);
            this.payMethod.Name = "payMethod";
            this.payMethod.Size = new System.Drawing.Size(207, 28);
            this.payMethod.TabIndex = 93;
            this.payMethod.ValueMember = "role";
            this.payMethod.SelectedIndexChanged += new System.EventHandler(this.PayMethod_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 92;
            this.label8.Text = "Pay Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 91;
            this.label6.Text = "Check Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(793, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Pay Date";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Renter Name";
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(974, 142);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(207, 26);
            this.amount.TabIndex = 111;
            this.amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // payDate
            // 
            this.payDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDate.Location = new System.Drawing.Point(129, 138);
            this.payDate.Name = "payDate";
            this.payDate.Size = new System.Drawing.Size(279, 26);
            this.payDate.TabIndex = 112;
            this.payDate.ValueChanged += new System.EventHandler(this.PayDate_ValueChanged);
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(129, 195);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(279, 77);
            this.details.TabIndex = 113;
            // 
            // payRequirments
            // 
            this.payRequirments.BackColor = System.Drawing.Color.Transparent;
            this.payRequirments.Controls.Add(this.bank);
            this.payRequirments.Controls.Add(this.label3);
            this.payRequirments.Controls.Add(this.label6);
            this.payRequirments.Controls.Add(this.checkNumber);
            this.payRequirments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payRequirments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRequirments.Location = new System.Drawing.Point(423, 180);
            this.payRequirments.Name = "payRequirments";
            this.payRequirments.Size = new System.Drawing.Size(361, 100);
            this.payRequirments.TabIndex = 114;
            this.payRequirments.TabStop = false;
            this.payRequirments.Text = "Payment Requirments";
            this.payRequirments.Visible = false;
            // 
            // bank
            // 
            this.bank.DisplayMember = "role";
            this.bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.FormattingEnabled = true;
            this.bank.Items.AddRange(new object[] {
            "Owner",
            "Renter",
            "Other Owner"});
            this.bank.Location = new System.Drawing.Point(146, 25);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(207, 28);
            this.bank.TabIndex = 115;
            this.bank.ValueMember = "role";
            this.bank.SelectedIndexChanged += new System.EventHandler(this.Bank_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 116;
            this.label10.Text = "Estate Number";
            // 
            // realestateNumber
            // 
            this.realestateNumber.BackColor = System.Drawing.Color.White;
            this.realestateNumber.DisplayMember = "(none)";
            this.realestateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realestateNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realestateNumber.FormattingEnabled = true;
            this.realestateNumber.Items.AddRange(new object[] {
            "select one"});
            this.realestateNumber.Location = new System.Drawing.Point(557, 90);
            this.realestateNumber.Name = "realestateNumber";
            this.realestateNumber.Size = new System.Drawing.Size(207, 28);
            this.realestateNumber.TabIndex = 115;
            this.realestateNumber.ValueMember = "(none)";
            this.realestateNumber.SelectedIndexChanged += new System.EventHandler(this.RealestateNumber_SelectedIndexChanged);
            // 
            // receiptNumber
            // 
            this.receiptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptNumber.Location = new System.Drawing.Point(974, 192);
            this.receiptNumber.Name = "receiptNumber";
            this.receiptNumber.Size = new System.Drawing.Size(207, 26);
            this.receiptNumber.TabIndex = 118;
            this.receiptNumber.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 117;
            this.label9.Text = "Receipt Number";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // AddMonthlyRentalPayments
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1233, 596);
            this.Controls.Add(this.receiptNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.realestateNumber);
            this.Controls.Add(this.payRequirments);
            this.Controls.Add(this.details);
            this.Controls.Add(this.payDate);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthlyRentalPayments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AppartmentNumber);
            this.Controls.Add(this.renterName);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddMonthlyRentalPayments";
            this.Text = "AddMonthlyRentalPayments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMonthlyRentalPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyRentalPayments)).EndInit();
            this.payRequirments.ResumeLayout(false);
            this.payRequirments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView monthlyRentalPayments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox checkNumber;
        private System.Windows.Forms.ComboBox AppartmentNumber;
        private System.Windows.Forms.ComboBox renterName;
        private System.Windows.Forms.ComboBox payMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.DateTimePicker payDate;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.GroupBox payRequirments;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox realestateNumber;
        private System.Windows.Forms.TextBox receiptNumber;
        private System.Windows.Forms.Label label9;
    }
}