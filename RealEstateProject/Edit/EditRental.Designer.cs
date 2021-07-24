namespace RealEstateProject.Edit
{
    partial class EditRental
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.services = new System.Windows.Forms.CheckedListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rentPercentage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.graceMonth = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentMethod = new System.Windows.Forms.ComboBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentalType = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.rentDuration = new System.Windows.Forms.NumericUpDown();
            this.renter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.realestateNumber = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.appartmentNumber = new System.Windows.Forms.ComboBox();
            this.rentalNumber = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graceMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 54);
            this.label5.TabIndex = 79;
            this.label5.Text = "Edit Rental";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(240, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 78;
            this.button1.Text = "Update Rental";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(563, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 54);
            this.button2.TabIndex = 90;
            this.button2.Text = "Delete Rental";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(864, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 54);
            this.button3.TabIndex = 91;
            this.button3.Text = "Get Rental";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.services);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.rentPercentage);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.graceMonth);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.paymentMethod);
            this.groupBox1.Controls.Add(this.detail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rentalType);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rentDuration);
            this.groupBox1.Controls.Add(this.renter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 352);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // services
            // 
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services.FormattingEnabled = true;
            this.services.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.services.Location = new System.Drawing.Point(690, 164);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(388, 151);
            this.services.TabIndex = 114;
            this.services.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Services_ItemCheck);
            this.services.SelectedIndexChanged += new System.EventHandler(this.services_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(579, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 20);
            this.label17.TabIndex = 113;
            this.label17.Text = "Services IN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(267, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 20);
            this.label15.TabIndex = 112;
            this.label15.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(267, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 111;
            this.label14.Text = "Months";
            // 
            // rentPercentage
            // 
            this.rentPercentage.BackColor = System.Drawing.Color.White;
            this.rentPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentPercentage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentPercentage.Location = new System.Drawing.Point(179, 178);
            this.rentPercentage.Name = "rentPercentage";
            this.rentPercentage.Size = new System.Drawing.Size(73, 26);
            this.rentPercentage.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 109;
            this.label13.Text = "Rent percentage";
            // 
            // graceMonth
            // 
            this.graceMonth.BackColor = System.Drawing.Color.White;
            this.graceMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graceMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graceMonth.Location = new System.Drawing.Point(179, 146);
            this.graceMonth.Name = "graceMonth";
            this.graceMonth.Size = new System.Drawing.Size(73, 26);
            this.graceMonth.TabIndex = 108;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 20);
            this.label16.TabIndex = 107;
            this.label16.Text = "Grace month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(794, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 106;
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
            this.paymentMethod.Location = new System.Drawing.Point(944, 41);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(199, 28);
            this.paymentMethod.TabIndex = 105;
            this.paymentMethod.ValueMember = "(none)";
            // 
            // detail
            // 
            this.detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.Location = new System.Drawing.Point(89, 224);
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(401, 118);
            this.detail.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Rental Type";
            // 
            // rentalType
            // 
            this.rentalType.BackColor = System.Drawing.Color.White;
            this.rentalType.DisplayMember = "(none)";
            this.rentalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentalType.FormattingEnabled = true;
            this.rentalType.Location = new System.Drawing.Point(534, 41);
            this.rentalType.Name = "rentalType";
            this.rentalType.Size = new System.Drawing.Size(199, 28);
            this.rentalType.TabIndex = 102;
            this.rentalType.ValueMember = "(none)";
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(167, 102);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(296, 26);
            this.startDate.TabIndex = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 99;
            this.label11.Text = "Details";
            // 
            // rentDuration
            // 
            this.rentDuration.BackColor = System.Drawing.Color.White;
            this.rentDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentDuration.Location = new System.Drawing.Point(624, 102);
            this.rentDuration.Name = "rentDuration";
            this.rentDuration.Size = new System.Drawing.Size(63, 26);
            this.rentDuration.TabIndex = 97;
            // 
            // renter
            // 
            this.renter.BackColor = System.Drawing.Color.White;
            this.renter.DisplayMember = "name";
            this.renter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renter.FormattingEnabled = true;
            this.renter.Location = new System.Drawing.Point(167, 41);
            this.renter.Name = "renter";
            this.renter.Size = new System.Drawing.Size(199, 28);
            this.renter.TabIndex = 95;
            this.renter.ValueMember = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 94;
            this.label7.Text = "Rent Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Rent Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Renter Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(528, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 108;
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
            this.realestateNumber.Location = new System.Drawing.Point(652, 24);
            this.realestateNumber.Name = "realestateNumber";
            this.realestateNumber.Size = new System.Drawing.Size(152, 28);
            this.realestateNumber.TabIndex = 107;
            this.realestateNumber.ValueMember = "(none)";
            this.realestateNumber.SelectedIndexChanged += new System.EventHandler(this.RealestateNumber_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(809, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Appartment Number";
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
            this.appartmentNumber.Location = new System.Drawing.Point(973, 24);
            this.appartmentNumber.Name = "appartmentNumber";
            this.appartmentNumber.Size = new System.Drawing.Size(152, 28);
            this.appartmentNumber.TabIndex = 96;
            this.appartmentNumber.ValueMember = "(none)";
            this.appartmentNumber.SelectedIndexChanged += new System.EventHandler(this.AppartmentNumber_SelectedIndexChanged);
            // 
            // rentalNumber
            // 
            this.rentalNumber.BackColor = System.Drawing.Color.White;
            this.rentalNumber.DisplayMember = "(none)";
            this.rentalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentalNumber.FormattingEnabled = true;
            this.rentalNumber.Items.AddRange(new object[] {
            "select one"});
            this.rentalNumber.Location = new System.Drawing.Point(652, 71);
            this.rentalNumber.Name = "rentalNumber";
            this.rentalNumber.Size = new System.Drawing.Size(152, 28);
            this.rentalNumber.TabIndex = 109;
            this.rentalNumber.ValueMember = "(none)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(528, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 110;
            this.label12.Text = "Rental Number";
            // 
            // EditRental
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1243, 567);
            this.Controls.Add(this.rentalNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.realestateNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appartmentNumber);
            this.Controls.Add(this.label9);
            this.Name = "EditRental";
            this.Text = "EditRental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditRental_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graceMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox paymentMethod;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rentalType;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown rentDuration;
        private System.Windows.Forms.ComboBox renter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox realestateNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox appartmentNumber;
        private System.Windows.Forms.ComboBox rentalNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown rentPercentage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown graceMonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox services;
        private System.Windows.Forms.Label label17;
    }
}