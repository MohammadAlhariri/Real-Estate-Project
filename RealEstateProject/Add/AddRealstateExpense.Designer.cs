namespace RealEstateProject
{
    partial class AddRealstateExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRealstateExpense));
            this.label3 = new System.Windows.Forms.Label();
            this.expenseType = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expences = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.realestateNumber = new System.Windows.Forms.ComboBox();
            this.person = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.TextBox();
            this.receiptNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Expense Type";
            // 
            // expenseType
            // 
            this.expenseType.BackColor = System.Drawing.Color.White;
            this.expenseType.DisplayMember = "(none)";
            this.expenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expenseType.FormattingEnabled = true;
            this.expenseType.Items.AddRange(new object[] {
            "Housing",
            "Non-Housing",
            "Commercial",
            "Trade",
            "GeneralTrade",
            "Industry",
            "Investment",
            "Other"});
            this.expenseType.Location = new System.Drawing.Point(947, 114);
            this.expenseType.Name = "expenseType";
            this.expenseType.Size = new System.Drawing.Size(199, 28);
            this.expenseType.TabIndex = 82;
            this.expenseType.ValueMember = "(none)";
            this.expenseType.SelectedIndexChanged += new System.EventHandler(this.ExpenseType_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(522, 158);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(296, 26);
            this.date.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 79;
            this.label11.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 47);
            this.label5.TabIndex = 78;
            this.label5.Text = "Add Realestate Expense";
            // 
            // expences
            // 
            this.expences.AllowUserToAddRows = false;
            this.expences.AllowUserToDeleteRows = false;
            this.expences.AllowUserToOrderColumns = true;
            this.expences.BackgroundColor = System.Drawing.Color.White;
            this.expences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expences.Location = new System.Drawing.Point(23, 342);
            this.expences.Name = "expences";
            this.expences.Size = new System.Drawing.Size(1203, 202);
            this.expences.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(774, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 54);
            this.button1.TabIndex = 76;
            this.button1.Text = "Add RealEstateExpense";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "RealEstate Number";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.White;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amount.Location = new System.Drawing.Point(911, 158);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(110, 26);
            this.amount.TabIndex = 74;
            // 
            // realestateNumber
            // 
            this.realestateNumber.BackColor = System.Drawing.Color.White;
            this.realestateNumber.DisplayMember = "(none)";
            this.realestateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realestateNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realestateNumber.FormattingEnabled = true;
            this.realestateNumber.Location = new System.Drawing.Point(583, 114);
            this.realestateNumber.Name = "realestateNumber";
            this.realestateNumber.Size = new System.Drawing.Size(199, 28);
            this.realestateNumber.TabIndex = 73;
            this.realestateNumber.ValueMember = "(none)";
            // 
            // person
            // 
            this.person.BackColor = System.Drawing.Color.White;
            this.person.DisplayMember = "name";
            this.person.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.person.FormattingEnabled = true;
            this.person.Location = new System.Drawing.Point(174, 114);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(199, 28);
            this.person.TabIndex = 72;
            this.person.ValueMember = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(832, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Payment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Person Name";
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(90, 210);
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(620, 89);
            this.detail.TabIndex = 89;
            // 
            // receiptNumber
            // 
            this.receiptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptNumber.Location = new System.Drawing.Point(165, 158);
            this.receiptNumber.Name = "receiptNumber";
            this.receiptNumber.Size = new System.Drawing.Size(219, 26);
            this.receiptNumber.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Receipt Number";
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
            this.month.Location = new System.Drawing.Point(803, 209);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(141, 28);
            this.month.TabIndex = 94;
            this.month.ValueMember = "(none)";
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.White;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.year.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.year.Location = new System.Drawing.Point(1051, 210);
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
            this.year.TabIndex = 95;
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(717, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(965, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 97;
            this.label8.Text = "Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1047, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 98;
            this.label10.Text = "$$";
            // 
            // AddRealstateExpense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1255, 556);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.receiptNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expenseType);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.expences);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.realestateNumber);
            this.Controls.Add(this.person);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "AddRealstateExpense";
            this.Text = "AddRealstateExpense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddRealstateExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expenseType;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView expences;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.ComboBox realestateNumber;
        private System.Windows.Forms.ComboBox person;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.TextBox receiptNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}