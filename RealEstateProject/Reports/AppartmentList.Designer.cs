
namespace RealEstateProject.Reports
{
    partial class AppartmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppartmentList));
            this.label20 = new System.Windows.Forms.Label();
            this.estate = new System.Windows.Forms.Label();
            this.NOA = new System.Windows.Forms.Label();
            this.NOAA = new System.Windows.Forms.Label();
            this.appartments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(50, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(484, 47);
            this.label20.TabIndex = 88;
            this.label20.Text = "List Of Estate Appartments";
            // 
            // estate
            // 
            this.estate.AutoSize = true;
            this.estate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estate.Location = new System.Drawing.Point(59, 111);
            this.estate.Name = "estate";
            this.estate.Size = new System.Drawing.Size(71, 24);
            this.estate.TabIndex = 89;
            this.estate.Text = "Estate: ";
            // 
            // NOA
            // 
            this.NOA.AutoSize = true;
            this.NOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOA.Location = new System.Drawing.Point(59, 145);
            this.NOA.Name = "NOA";
            this.NOA.Size = new System.Drawing.Size(224, 24);
            this.NOA.TabIndex = 90;
            this.NOA.Text = "Number Of Appartments: ";
            // 
            // NOAA
            // 
            this.NOAA.AutoSize = true;
            this.NOAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOAA.Location = new System.Drawing.Point(59, 178);
            this.NOAA.Name = "NOAA";
            this.NOAA.Size = new System.Drawing.Size(305, 24);
            this.NOAA.TabIndex = 91;
            this.NOAA.Text = "Number Of Available Appartments: ";
            // 
            // appartments
            // 
            this.appartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.appartments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.appartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appartments.Location = new System.Drawing.Point(63, 224);
            this.appartments.Name = "appartments";
            this.appartments.Size = new System.Drawing.Size(1168, 281);
            this.appartments.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(876, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 42);
            this.button1.TabIndex = 93;
            this.button1.Text = "Add Appartment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1127, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // AppartmentList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appartments);
            this.Controls.Add(this.NOAA);
            this.Controls.Add(this.NOA);
            this.Controls.Add(this.estate);
            this.Controls.Add(this.label20);
            this.Name = "AppartmentList";
            this.Text = "AppartmentList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppartmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label estate;
        private System.Windows.Forms.Label NOA;
        private System.Windows.Forms.Label NOAA;
        private System.Windows.Forms.DataGridView appartments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}