
namespace DeviceManagerLKDS
{
    partial class Form_ATU
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
            this.button1 = new System.Windows.Forms.Button();
            this.userControl1_ATU1 = new DeviceManagerLKDS.UserControl1_ATU();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userControl1_ATU1
            // 
            this.userControl1_ATU1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userControl1_ATU1.Location = new System.Drawing.Point(3, 61);
            this.userControl1_ATU1.Name = "userControl1_ATU1";
            this.userControl1_ATU1.Size = new System.Drawing.Size(1006, 567);
            this.userControl1_ATU1.TabIndex = 2;
            // 
            // Form_ATU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 640);
            this.Controls.Add(this.userControl1_ATU1);
            this.Controls.Add(this.button1);
            this.Name = "Form_ATU";
            this.Text = "Form_ATU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UserControl1_ATU userControl1_ATU1;
    }
}