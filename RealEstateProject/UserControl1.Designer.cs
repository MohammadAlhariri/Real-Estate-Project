namespace RealEstateProject
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.owner = new System.Windows.Forms.Label();
            this.estateNumber = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(1026, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(159, 34);
            this.btn.TabIndex = 0;
            this.btn.Text = "Get More";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner.Location = new System.Drawing.Point(63, 13);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(130, 20);
            this.owner.TabIndex = 1;
            this.owner.Text = "Owner Full Name";
            // 
            // estateNumber
            // 
            this.estateNumber.AutoSize = true;
            this.estateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estateNumber.Location = new System.Drawing.Point(339, 13);
            this.estateNumber.Name = "estateNumber";
            this.estateNumber.Size = new System.Drawing.Size(116, 20);
            this.estateNumber.TabIndex = 2;
            this.estateNumber.Text = "Estate Number";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(624, 13);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(97, 20);
            this.address.TabIndex = 3;
            this.address.Text = "Full Address";
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.address);
            this.Controls.Add(this.estateNumber);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.btn);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1223, 43);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label owner;
        private System.Windows.Forms.Label estateNumber;
        private System.Windows.Forms.Label address;
    }
}
