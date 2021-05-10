namespace RealEstateProject
{
    partial class PredefinedOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredefinedOptions));
            this.type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.option = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.price = new System.Windows.Forms.Label();
            this.pric = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(172, 98);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(245, 28);
            this.type.TabIndex = 0;
            this.type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 117;
            this.label10.Text = "Option Type";
            // 
            // option
            // 
            this.option.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.Location = new System.Drawing.Point(172, 157);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(198, 26);
            this.option.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Option ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 38);
            this.label7.TabIndex = 120;
            this.label7.Text = "Add Predefined Option";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OK.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(172, 276);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(207, 54);
            this.OK.TabIndex = 121;
            this.OK.Text = "Add Option";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.pric);
            this.groupBox1.Location = new System.Drawing.Point(40, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 67);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(2, 23);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(111, 20);
            this.price.TabIndex = 121;
            this.price.Text = "Price In Month";
            // 
            // pric
            // 
            this.pric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pric.Location = new System.Drawing.Point(129, 20);
            this.pric.Name = "pric";
            this.pric.Size = new System.Drawing.Size(198, 26);
            this.pric.TabIndex = 120;
            // 
            // PredefinedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(472, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.option);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.type);
            this.Name = "PredefinedOptions";
            this.Text = "PredefinedOptions";
            this.Load += new System.EventHandler(this.PredefinedOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox pric;
    }
}