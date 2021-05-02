namespace RealEstateProject
{
    partial class AddRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRental));
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rentals = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rentDuration = new System.Windows.Forms.NumericUpDown();
            this.appartmentNumber = new System.Windows.Forms.ComboBox();
            this.renter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rentalType = new System.Windows.Forms.ComboBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.realestateNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 54);
            this.label5.TabIndex = 57;
            this.label5.Text = "Add Rental";
            // 
            // rentals
            // 
            this.rentals.AllowUserToAddRows = false;
            this.rentals.AllowUserToDeleteRows = false;
            this.rentals.AllowUserToResizeColumns = false;
            this.rentals.AllowUserToResizeRows = false;
            this.rentals.BackgroundColor = System.Drawing.Color.White;
            this.rentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentals.Location = new System.Drawing.Point(47, 338);
            this.rentals.Name = "rentals";
            this.rentals.Size = new System.Drawing.Size(1251, 281);
            this.rentals.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(958, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 54;
            this.button1.Text = "Add Rental";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(808, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Appartment Number";
            // 
            // rentDuration
            // 
            this.rentDuration.BackColor = System.Drawing.Color.White;
            this.rentDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentDuration.Location = new System.Drawing.Point(655, 153);
            this.rentDuration.Name = "rentDuration";
            this.rentDuration.Size = new System.Drawing.Size(63, 26);
            this.rentDuration.TabIndex = 43;
            // 
            // appartmentNumber
            // 
            this.appartmentNumber.BackColor = System.Drawing.Color.White;
            this.appartmentNumber.DisplayMember = "(none)";
            this.appartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appartmentNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.appartmentNumber.FormattingEnabled = true;
            this.appartmentNumber.Items.AddRange(new object[] {
            "select one"});
            this.appartmentNumber.Location = new System.Drawing.Point(996, 97);
            this.appartmentNumber.Name = "appartmentNumber";
            this.appartmentNumber.Size = new System.Drawing.Size(199, 28);
            this.appartmentNumber.TabIndex = 42;
            this.appartmentNumber.ValueMember = "(none)";
            // 
            // renter
            // 
            this.renter.BackColor = System.Drawing.Color.White;
            this.renter.DisplayMember = "name";
            this.renter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renter.FormattingEnabled = true;
            this.renter.Location = new System.Drawing.Point(189, 97);
            this.renter.Name = "renter";
            this.renter.Size = new System.Drawing.Size(199, 28);
            this.renter.TabIndex = 41;
            this.renter.ValueMember = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Rent Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(744, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Rent Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Renter Name";
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(198, 153);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(296, 26);
            this.startDate.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Rental Type";
            // 
            // rentalType
            // 
            this.rentalType.BackColor = System.Drawing.Color.White;
            this.rentalType.DisplayMember = "(none)";
            this.rentalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentalType.FormattingEnabled = true;
            this.rentalType.Location = new System.Drawing.Point(607, 217);
            this.rentalType.Name = "rentalType";
            this.rentalType.Size = new System.Drawing.Size(199, 28);
            this.rentalType.TabIndex = 61;
            this.rentalType.ValueMember = "(none)";
            this.rentalType.SelectedIndexChanged += new System.EventHandler(this.RentalType_SelectedIndexChanged);
            // 
            // detail
            // 
            this.detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.Location = new System.Drawing.Point(125, 196);
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(337, 118);
            this.detail.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(821, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Payment Method";
            // 
            // paymentMethod
            // 
            this.paymentMethod.BackColor = System.Drawing.Color.White;
            this.paymentMethod.DisplayMember = "(none)";
            this.paymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paymentMethod.FormattingEnabled = true;
            this.paymentMethod.Items.AddRange(new object[] {
            "1 Month in advance",
            "3 Months in advance",
            "6 Months in adcance",
            "1 Year in advance",
            "Other"});
            this.paymentMethod.Location = new System.Drawing.Point(971, 214);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(199, 28);
            this.paymentMethod.TabIndex = 64;
            this.paymentMethod.ValueMember = "(none)";
            this.paymentMethod.SelectedIndexChanged += new System.EventHandler(this.PaymentMethod_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 68;
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
            this.realestateNumber.Location = new System.Drawing.Point(574, 97);
            this.realestateNumber.Name = "realestateNumber";
            this.realestateNumber.Size = new System.Drawing.Size(199, 28);
            this.realestateNumber.TabIndex = 67;
            this.realestateNumber.ValueMember = "(none)";
            this.realestateNumber.SelectedIndexChanged += new System.EventHandler(this.RealestateNumber_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(832, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(901, 153);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(300, 26);
            this.type.TabIndex = 59;
            // 
            // AddRental
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1317, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.realestateNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rentalType);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rentals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rentDuration);
            this.Controls.Add(this.appartmentNumber);
            this.Controls.Add(this.renter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRental";
            this.Text = "AddRental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView rentals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown rentDuration;
        private System.Windows.Forms.ComboBox appartmentNumber;
        private System.Windows.Forms.ComboBox renter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rentalType;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox paymentMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox realestateNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type;
    }
}