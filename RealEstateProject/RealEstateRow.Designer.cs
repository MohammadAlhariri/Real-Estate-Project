namespace RealEstateProject
{
    partial class RealEstateRow
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
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn.Location = new System.Drawing.Point(1051, 7);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(3);
            this.btn.Size = new System.Drawing.Size(147, 33);
            this.btn.TabIndex = 0;
            this.btn.Text = "Show More";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.owner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.owner.Location = new System.Drawing.Point(63, 13);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(130, 20);
            this.owner.TabIndex = 1;
            this.owner.Text = "Owner Full Name";
            // 
            // estateNumber
            // 
            this.estateNumber.AutoSize = true;
            this.estateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.estateNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.estateNumber.Location = new System.Drawing.Point(288, 13);
            this.estateNumber.Name = "estateNumber";
            this.estateNumber.Size = new System.Drawing.Size(116, 20);
            this.estateNumber.TabIndex = 2;
            this.estateNumber.Text = "Estate Number";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.address.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.address.Location = new System.Drawing.Point(521, 13);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(97, 20);
            this.address.TabIndex = 3;
            this.address.Text = "Full Address";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Element2";
            this.accordionControlElement2.Click += new System.EventHandler(this.AccordionControlElement2_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5});
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Element4";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Element5";
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
            this.Size = new System.Drawing.Size(1223, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label owner;
        private System.Windows.Forms.Label estateNumber;
        private System.Windows.Forms.Label address;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
    }
}
