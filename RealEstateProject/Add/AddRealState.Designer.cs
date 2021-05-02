﻿namespace RealEstateProject
{
    partial class AddRealState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRealState));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.states = new System.Windows.Forms.ComboBox();
            this.collectorPercentage = new System.Windows.Forms.NumericUpDown();
            this.neigborhood = new System.Windows.Forms.TextBox();
            this.buildingNumber = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.estateNumber = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.currentState = new System.Windows.Forms.ComboBox();
            this.realEstates = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collectorPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstates)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estate Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Neigborhood";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Collector\'s Percentage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(625, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Owner Name";
            // 
            // owner
            // 
            this.owner.BackColor = System.Drawing.Color.White;
            this.owner.DisplayMember = "(none)";
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.owner.FormattingEnabled = true;
            this.owner.Location = new System.Drawing.Point(770, 243);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(191, 28);
            this.owner.TabIndex = 8;
            this.owner.ValueMember = "(none)";
            // 
            // country
            // 
            this.country.BackColor = System.Drawing.Color.White;
            this.country.DisplayMember = "name";
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(130, 149);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(187, 28);
            this.country.TabIndex = 9;
            this.country.ValueMember = "name";
            this.country.SelectedIndexChanged += new System.EventHandler(this.Country_SelectedIndexChanged);
            // 
            // states
            // 
            this.states.BackColor = System.Drawing.Color.White;
            this.states.DisplayMember = "(none)";
            this.states.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.states.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.states.FormattingEnabled = true;
            this.states.Location = new System.Drawing.Point(431, 149);
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(163, 28);
            this.states.TabIndex = 10;
            this.states.ValueMember = "(none)";
            this.states.SelectedIndexChanged += new System.EventHandler(this.States_SelectedIndexChanged);
            // 
            // collectorPercentage
            // 
            this.collectorPercentage.BackColor = System.Drawing.Color.White;
            this.collectorPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectorPercentage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collectorPercentage.Location = new System.Drawing.Point(531, 243);
            this.collectorPercentage.Name = "collectorPercentage";
            this.collectorPercentage.Size = new System.Drawing.Size(63, 26);
            this.collectorPercentage.TabIndex = 11;
            // 
            // neigborhood
            // 
            this.neigborhood.BackColor = System.Drawing.Color.White;
            this.neigborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neigborhood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neigborhood.Location = new System.Drawing.Point(130, 197);
            this.neigborhood.Name = "neigborhood";
            this.neigborhood.Size = new System.Drawing.Size(187, 26);
            this.neigborhood.TabIndex = 12;
            // 
            // buildingNumber
            // 
            this.buildingNumber.BackColor = System.Drawing.Color.White;
            this.buildingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buildingNumber.Location = new System.Drawing.Point(664, 102);
            this.buildingNumber.Name = "buildingNumber";
            this.buildingNumber.Size = new System.Drawing.Size(183, 26);
            this.buildingNumber.TabIndex = 13;
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.White;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.value.Location = new System.Drawing.Point(130, 247);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(187, 26);
            this.value.TabIndex = 14;
            // 
            // estateNumber
            // 
            this.estateNumber.BackColor = System.Drawing.Color.White;
            this.estateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estateNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.estateNumber.Location = new System.Drawing.Point(275, 102);
            this.estateNumber.Name = "estateNumber";
            this.estateNumber.Size = new System.Drawing.Size(183, 26);
            this.estateNumber.TabIndex = 15;
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.DisplayMember = "name";
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(770, 145);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(191, 28);
            this.city.TabIndex = 18;
            this.city.ValueMember = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "State";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.address.Location = new System.Drawing.Point(431, 197);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(163, 26);
            this.address.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(621, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Current State";
            // 
            // currentState
            // 
            this.currentState.BackColor = System.Drawing.Color.White;
            this.currentState.DisplayMember = "name";
            this.currentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentState.FormattingEnabled = true;
            this.currentState.Items.AddRange(new object[] {
            "Bad -> Good",
            "Good -> VeryGood",
            "VeryGood -> Excellent"});
            this.currentState.Location = new System.Drawing.Point(770, 193);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(191, 28);
            this.currentState.TabIndex = 26;
            this.currentState.ValueMember = "name";
            // 
            // realEstates
            // 
            this.realEstates.AllowUserToAddRows = false;
            this.realEstates.AllowUserToDeleteRows = false;
            this.realEstates.AllowUserToResizeColumns = false;
            this.realEstates.AllowUserToResizeRows = false;
            this.realEstates.BackgroundColor = System.Drawing.Color.White;
            this.realEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realEstates.Location = new System.Drawing.Point(12, 333);
            this.realEstates.Name = "realEstates";
            this.realEstates.Size = new System.Drawing.Size(1274, 305);
            this.realEstates.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(983, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add RealEstate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 54);
            this.label5.TabIndex = 31;
            this.label5.Text = "Add Real Estate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(490, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Building Number";
            // 
            // AddRealState
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1298, 661);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.realEstates);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.currentState);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.estateNumber);
            this.Controls.Add(this.value);
            this.Controls.Add(this.buildingNumber);
            this.Controls.Add(this.neigborhood);
            this.Controls.Add(this.collectorPercentage);
            this.Controls.Add(this.states);
            this.Controls.Add(this.country);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRealState";
            this.Tag = "estate";
            this.Text = "AddRealState";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddRealState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectorPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox owner;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.ComboBox states;
        private System.Windows.Forms.NumericUpDown collectorPercentage;
        private System.Windows.Forms.TextBox neigborhood;
        private System.Windows.Forms.TextBox buildingNumber;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox estateNumber;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox currentState;
        private System.Windows.Forms.DataGridView realEstates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}