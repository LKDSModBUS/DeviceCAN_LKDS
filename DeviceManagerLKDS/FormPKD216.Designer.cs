
namespace DeviceManagerLKDS
{
    partial class FormPKD216
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
            this.userControl_PKD_2_161 = new DeviceManagerLKDS.UserControl_PKD_2_16();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl_PKD_2_161
            // 
            this.userControl_PKD_2_161.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userControl_PKD_2_161.Location = new System.Drawing.Point(49, 52);
            this.userControl_PKD_2_161.Name = "userControl_PKD_2_161";
            this.userControl_PKD_2_161.Size = new System.Drawing.Size(1097, 597);
            this.userControl_PKD_2_161.TabIndex = 0;
            // 
            // FormPKD216
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl_PKD_2_161);
            this.Name = "FormPKD216";
            this.Text = "FormPKD216";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_PKD_2_16 userControl_PKD_2_161;
        private System.Windows.Forms.Button button1;
    }
}