
namespace RealEstateProject.Add
{
    partial class AddAppartmentServicesExpences
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
            this.label10 = new System.Windows.Forms.Label();
            this.realestateNumber = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AppartmentNumber = new System.Windows.Forms.ComboBox();
            this.renterName = new System.Windows.Forms.ComboBox();
            this.monthlyPayments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentalNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfMonths = new System.Windows.Forms.NumericUpDown();
            this.mMonth = new System.Windows.Forms.RadioButton();
            this.sMonth = new System.Windows.Forms.RadioButton();
            this.startYear = new System.Windows.Forms.Label();
            this.startMonth = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.month = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 173;
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
            this.realestateNumber.Location = new System.Drawing.Point(570, 104);
            this.realestateNumber.Name = "realestateNumber";
            this.realestateNumber.Size = new System.Drawing.Size(207, 28);
            this.realestateNumber.TabIndex = 172;
            this.realestateNumber.ValueMember = "(none)";
            this.realestateNumber.SelectedIndexChanged += new System.EventHandler(this.realestateNumber_SelectedIndexChanged);
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(145, 245);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(589, 65);
            this.details.TabIndex = 170;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(520, 200);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(214, 26);
            this.amount.TabIndex = 168;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(623, 38);
            this.label7.TabIndex = 167;
            this.label7.Text = "Add Monthly Appartment Services Expences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 158;
            this.label5.Text = "Amount";
            // 
            // AppartmentNumber
            // 
            this.AppartmentNumber.DisplayMember = "name";
            this.AppartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppartmentNumber.FormattingEnabled = true;
            this.AppartmentNumber.Location = new System.Drawing.Point(987, 104);
            this.AppartmentNumber.Name = "AppartmentNumber";
            this.AppartmentNumber.Size = new System.Drawing.Size(207, 28);
            this.AppartmentNumber.TabIndex = 162;
            this.AppartmentNumber.ValueMember = "name";
            this.AppartmentNumber.SelectedIndexChanged += new System.EventHandler(this.AppartmentNumber_SelectedIndexChanged);
            // 
            // renterName
            // 
            this.renterName.DisplayMember = "name";
            this.renterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renterName.FormattingEnabled = true;
            this.renterName.Location = new System.Drawing.Point(186, 104);
            this.renterName.Name = "renterName";
            this.renterName.Size = new System.Drawing.Size(235, 28);
            this.renterName.TabIndex = 161;
            this.renterName.ValueMember = "name";
            // 
            // monthlyPayments
            // 
            this.monthlyPayments.AllowUserToAddRows = false;
            this.monthlyPayments.AllowUserToDeleteRows = false;
            this.monthlyPayments.BackgroundColor = System.Drawing.Color.White;
            this.monthlyPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyPayments.Location = new System.Drawing.Point(28, 327);
            this.monthlyPayments.Name = "monthlyPayments";
            this.monthlyPayments.Size = new System.Drawing.Size(1213, 216);
            this.monthlyPayments.TabIndex = 166;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(893, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 165;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 164;
            this.label4.Text = "Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(808, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 163;
            this.label11.Text = "Appartment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 156;
            this.label1.Text = "Renter Name";
            // 
            // serviceName
            // 
            this.serviceName.DisplayMember = "name";
            this.serviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceName.FormattingEnabled = true;
            this.serviceName.Location = new System.Drawing.Point(158, 199);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(235, 28);
            this.serviceName.TabIndex = 181;
            this.serviceName.ValueMember = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 180;
            this.label2.Text = "Service";
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
            this.rentalNumber.Location = new System.Drawing.Point(190, 150);
            this.rentalNumber.Name = "rentalNumber";
            this.rentalNumber.Size = new System.Drawing.Size(621, 28);
            this.rentalNumber.TabIndex = 182;
            this.rentalNumber.ValueMember = "(none)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 183;
            this.label3.Text = "Rental";
            // 
            // numberOfMonths
            // 
            this.numberOfMonths.BackColor = System.Drawing.Color.White;
            this.numberOfMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMonths.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberOfMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numberOfMonths.Location = new System.Drawing.Point(1163, 154);
            this.numberOfMonths.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.numberOfMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfMonths.Name = "numberOfMonths";
            this.numberOfMonths.Size = new System.Drawing.Size(78, 26);
            this.numberOfMonths.TabIndex = 203;
            this.numberOfMonths.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numberOfMonths.Visible = false;
            // 
            // mMonth
            // 
            this.mMonth.AutoSize = true;
            this.mMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMonth.Location = new System.Drawing.Point(1001, 157);
            this.mMonth.Name = "mMonth";
            this.mMonth.Size = new System.Drawing.Size(124, 21);
            this.mMonth.TabIndex = 202;
            this.mMonth.Text = "Multiple Months";
            this.mMonth.UseVisualStyleBackColor = true;
            this.mMonth.CheckedChanged += new System.EventHandler(this.mMonth_CheckedChanged);
            // 
            // sMonth
            // 
            this.sMonth.AutoSize = true;
            this.sMonth.Checked = true;
            this.sMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sMonth.Location = new System.Drawing.Point(818, 157);
            this.sMonth.Name = "sMonth";
            this.sMonth.Size = new System.Drawing.Size(108, 21);
            this.sMonth.TabIndex = 201;
            this.sMonth.TabStop = true;
            this.sMonth.Text = "Single Month";
            this.sMonth.UseVisualStyleBackColor = true;
            // 
            // startYear
            // 
            this.startYear.AutoSize = true;
            this.startYear.BackColor = System.Drawing.Color.Transparent;
            this.startYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startYear.Location = new System.Drawing.Point(1047, 203);
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(43, 20);
            this.startYear.TabIndex = 200;
            this.startYear.Text = "Year";
            // 
            // startMonth
            // 
            this.startMonth.AutoSize = true;
            this.startMonth.BackColor = System.Drawing.Color.Transparent;
            this.startMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMonth.Location = new System.Drawing.Point(785, 203);
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(54, 20);
            this.startMonth.TabIndex = 199;
            this.startMonth.Text = "Month";
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.White;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.year.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.year.Location = new System.Drawing.Point(1163, 200);
            this.year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(80, 26);
            this.year.TabIndex = 198;
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.White;
            this.month.DisplayMember = "(none)";
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month.Location = new System.Drawing.Point(885, 199);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(141, 28);
            this.month.TabIndex = 197;
            this.month.ValueMember = "(none)";
            // 
            // AddAppartmentServicesExpences
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1253, 521);
            this.Controls.Add(this.numberOfMonths);
            this.Controls.Add(this.mMonth);
            this.Controls.Add(this.sMonth);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.startMonth);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.rentalNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.realestateNumber);
            this.Controls.Add(this.details);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AppartmentNumber);
            this.Controls.Add(this.renterName);
            this.Controls.Add(this.monthlyPayments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "AddAppartmentServicesExpences";
            this.Text = "AddAppartmentServicesExpences";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddAppartmentServicesExpences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox realestateNumber;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AppartmentNumber;
        private System.Windows.Forms.ComboBox renterName;
        private System.Windows.Forms.DataGridView monthlyPayments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rentalNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberOfMonths;
        private System.Windows.Forms.RadioButton mMonth;
        private System.Windows.Forms.RadioButton sMonth;
        private System.Windows.Forms.Label startYear;
        private System.Windows.Forms.Label startMonth;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.ComboBox month;
    }
}