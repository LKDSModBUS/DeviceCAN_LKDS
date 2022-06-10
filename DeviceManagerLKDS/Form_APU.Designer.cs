
namespace DeviceManagerLKDS
{
    partial class Form_APU
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
            this.userControl_APU1 = new DeviceManagerLKDS.UserControl_APU();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl_APU1
            // 
            this.userControl_APU1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userControl_APU1.Location = new System.Drawing.Point(54, 54);
            this.userControl_APU1.Name = "userControl_APU1";
            this.userControl_APU1.Size = new System.Drawing.Size(1069, 597);
            this.userControl_APU1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1048, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_APU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl_APU1);
            this.Name = "Form_APU";
            this.Text = "Form_APU";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_APU userControl_APU1;
        private System.Windows.Forms.Button button1;
    }
}