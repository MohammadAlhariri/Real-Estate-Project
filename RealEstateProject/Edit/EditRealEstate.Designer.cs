namespace RealEstateProject.Edit
{
    partial class EditRealEstate
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.services = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.currentState = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.buildingNumber = new System.Windows.Forms.TextBox();
            this.neigborhood = new System.Windows.Forms.TextBox();
            this.states = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.owner = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.realEstateNumber = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 48);
            this.label5.TabIndex = 55;
            this.label5.Text = "Edit Real Estate";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 54;
            this.button1.Text = "Update RealEstate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Estate Number";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(634, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 54);
            this.button2.TabIndex = 57;
            this.button2.Text = "Delete RealEstate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.services);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.currentState);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.value);
            this.groupBox1.Controls.Add(this.buildingNumber);
            this.groupBox1.Controls.Add(this.neigborhood);
            this.groupBox1.Controls.Add(this.states);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.owner);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 286);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // services
            // 
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services.FormattingEnabled = true;
            this.services.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.services.Location = new System.Drawing.Point(895, 144);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(213, 130);
            this.services.TabIndex = 78;
            this.services.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Services_ItemCheck);
            this.services.SelectedIndexChanged += new System.EventHandler(this.Services_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(781, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 77;
            this.label13.Text = "Services IN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "Building Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(799, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 75;
            this.label12.Text = "Current State";
            // 
            // currentState
            // 
            this.currentState.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentState.DisplayMember = "name";
            this.currentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentState.FormattingEnabled = true;
            this.currentState.Items.AddRange(new object[] {
            "popular",
            "popular to middle",
            "middle ",
            "middle to luxurious",
            "luxurious"});
            this.currentState.Location = new System.Drawing.Point(943, 40);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(191, 28);
            this.currentState.TabIndex = 74;
            this.currentState.ValueMember = "name";
            // 
            // address
            // 
            this.address.AcceptsReturn = true;
            this.address.AcceptsTab = true;
            this.address.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.address.Location = new System.Drawing.Point(531, 144);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(163, 29);
            this.address.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Address";
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city.DisplayMember = "name";
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(917, 92);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(191, 28);
            this.city.TabIndex = 71;
            this.city.ValueMember = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "State";
            // 
            // value
            // 
            this.value.AcceptsReturn = true;
            this.value.AcceptsTab = true;
            this.value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.value.Location = new System.Drawing.Point(190, 194);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(187, 29);
            this.value.TabIndex = 69;
            // 
            // buildingNumber
            // 
            this.buildingNumber.AcceptsReturn = true;
            this.buildingNumber.AcceptsTab = true;
            this.buildingNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buildingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buildingNumber.Location = new System.Drawing.Point(207, 40);
            this.buildingNumber.Name = "buildingNumber";
            this.buildingNumber.Size = new System.Drawing.Size(183, 29);
            this.buildingNumber.TabIndex = 68;
            // 
            // neigborhood
            // 
            this.neigborhood.AcceptsReturn = true;
            this.neigborhood.AcceptsTab = true;
            this.neigborhood.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neigborhood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neigborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neigborhood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neigborhood.Location = new System.Drawing.Point(190, 144);
            this.neigborhood.Name = "neigborhood";
            this.neigborhood.Size = new System.Drawing.Size(187, 29);
            this.neigborhood.TabIndex = 67;
            // 
            // states
            // 
            this.states.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.states.DisplayMember = "(none)";
            this.states.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.states.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.states.FormattingEnabled = true;
            this.states.Location = new System.Drawing.Point(575, 96);
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(163, 28);
            this.states.TabIndex = 65;
            this.states.ValueMember = "(none)";
            this.states.SelectedIndexChanged += new System.EventHandler(this.States_SelectedIndexChanged);
            // 
            // country
            // 
            this.country.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.country.DisplayMember = "name";
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(196, 96);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(187, 28);
            this.country.TabIndex = 64;
            this.country.ValueMember = "name";
            this.country.SelectedIndexChanged += new System.EventHandler(this.Country_SelectedIndexChanged);
            // 
            // owner
            // 
            this.owner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.owner.DisplayMember = "(none)";
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.owner.FormattingEnabled = true;
            this.owner.Location = new System.Drawing.Point(569, 40);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(191, 28);
            this.owner.TabIndex = 63;
            this.owner.ValueMember = "(none)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Owner Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Neigborhood";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Country";
            // 
            // realEstateNumber
            // 
            this.realEstateNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.realEstateNumber.DisplayMember = "(none)";
            this.realEstateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realEstateNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realEstateNumber.FormattingEnabled = true;
            this.realEstateNumber.Location = new System.Drawing.Point(634, 53);
            this.realEstateNumber.Name = "realEstateNumber";
            this.realEstateNumber.Size = new System.Drawing.Size(209, 28);
            this.realEstateNumber.TabIndex = 77;
            this.realEstateNumber.ValueMember = "(none)";
            this.realEstateNumber.SelectedIndexChanged += new System.EventHandler(this.RealEstateNumber_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(888, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 40);
            this.button3.TabIndex = 78;
            this.button3.Text = "get RealEstate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // EditRealEstate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.realEstateNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "EditRealEstate";
            this.Text = "EditRealEstate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditRealEstate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox currentState;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox buildingNumber;
        private System.Windows.Forms.TextBox neigborhood;
        private System.Windows.Forms.ComboBox states;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.ComboBox owner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox realEstateNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox services;
        private System.Windows.Forms.Label label13;
    }
}