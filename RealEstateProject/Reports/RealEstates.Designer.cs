namespace RealEstateProject.Reports
{
    partial class RealEstates
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
            this.label20 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl11 = new RealEstateProject.RealEstateRow();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(53, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(403, 54);
            this.label20.TabIndex = 86;
            this.label20.Text = "List of Real Estates";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1231, 328);
            this.flowLayoutPanel1.TabIndex = 87;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(677, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 53);
            this.button1.TabIndex = 88;
            this.button1.Text = "Extract to PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(956, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 53);
            this.button2.TabIndex = 89;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1223, 61);
            this.userControl11.TabIndex = 0;
            // 
            // RealEstates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1286, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label20);
            this.Name = "RealEstates";
            this.Text = "RealEstates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RealEstates_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RealEstateRow userControl11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}