
namespace DeviceManagerLKDS
{
    partial class Form_ASK
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.userControl_ASK1 = new DeviceManagerLKDS.UserControl_ASK();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl_ASK1
            // 
            this.userControl_ASK1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userControl_ASK1.Location = new System.Drawing.Point(10, 67);
            this.userControl_ASK1.Name = "userControl_ASK1";
            this.userControl_ASK1.Size = new System.Drawing.Size(829, 554);
            this.userControl_ASK1.TabIndex = 0;
            // 
            // Form_ASK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl_ASK1);
            this.Name = "Form_ASK";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UserControl_ASK userControl_ASK1;
    }
}

