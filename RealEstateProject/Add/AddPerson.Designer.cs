namespace RealEstateProject
{
    partial class AddPerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPerson));
            this.address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.states = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.country = new System.Windows.Forms.ComboBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.persons = new System.Windows.Forms.DataGridView();
            this.mName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons)).BeginInit();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(225, 183);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(203, 26);
            this.address.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Address";
            // 
            // city
            // 
            this.city.DataSource = this.citiesBindingSource;
            this.city.DisplayMember = "name";
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(781, 135);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(166, 28);
            this.city.TabIndex = 41;
            this.city.ValueMember = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "State";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(710, 177);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(203, 26);
            this.phone.TabIndex = 38;
            // 
            // states
            // 
            this.states.DataSource = this.statesBindingSource;
            this.states.DisplayMember = "name";
            this.states.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.states.FormattingEnabled = true;
            this.states.Location = new System.Drawing.Point(470, 135);
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(166, 28);
            this.states.TabIndex = 34;
            this.states.ValueMember = "name";
            this.states.SelectedIndexChanged += new System.EventHandler(this.States_SelectedIndexChanged);
            // 
            // country
            // 
            this.country.DisplayMember = "name";
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(159, 135);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(166, 28);
            this.country.TabIndex = 33;
            this.country.ValueMember = "name";
            this.country.SelectedIndexChanged += new System.EventHandler(this.Country_SelectedIndexChanged_1);
            // 
            // role
            // 
            this.role.DisplayMember = "role";
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Owner",
            "Renter",
            "Other Owner"});
            this.role.Location = new System.Drawing.Point(710, 221);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(203, 28);
            this.role.TabIndex = 32;
            this.role.ValueMember = "role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(566, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Person Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Country";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(225, 221);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(203, 26);
            this.email.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(960, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 54);
            this.button1.TabIndex = 83;
            this.button1.Text = "Add Person";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 54);
            this.label7.TabIndex = 85;
            this.label7.Text = "Add Person";
            // 
            // persons
            // 
            this.persons.AllowUserToAddRows = false;
            this.persons.AllowUserToDeleteRows = false;
            this.persons.AllowUserToResizeColumns = false;
            this.persons.AllowUserToResizeRows = false;
            this.persons.BackgroundColor = System.Drawing.Color.White;
            this.persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.persons.Location = new System.Drawing.Point(52, 312);
            this.persons.Name = "persons";
            this.persons.Size = new System.Drawing.Size(1213, 305);
            this.persons.TabIndex = 84;
            // 
            // mName
            // 
            this.mName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mName.Location = new System.Drawing.Point(470, 92);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(166, 26);
            this.mName.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 128;
            this.label11.Text = "Middle Name";
            // 
            // fName
            // 
            this.fName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(159, 92);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(166, 26);
            this.fName.TabIndex = 127;
            // 
            // lName
            // 
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(781, 92);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(166, 26);
            this.lName.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 125;
            this.label5.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "First Name";
            // 
            // AddPerson
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1307, 706);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.persons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.states);
            this.Controls.Add(this.country);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddPerson";
            this.Tag = "persons";
            this.Text = "AddPerson";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox states;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView persons;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}