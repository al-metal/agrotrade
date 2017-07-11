namespace agrotrade
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswords = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.lblVsego = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTovar = new System.Windows.Forms.Label();
            this.lblNamePosition = new System.Windows.Forms.Label();
            this.ofdLoadPrice = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Логин:";
            // 
            // tbPasswords
            // 
            this.tbPasswords.Location = new System.Drawing.Point(12, 64);
            this.tbPasswords.Name = "tbPasswords";
            this.tbPasswords.Size = new System.Drawing.Size(125, 20);
            this.tbPasswords.TabIndex = 18;
            this.tbPasswords.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(125, 20);
            this.tbLogin.TabIndex = 17;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(143, 22);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(126, 24);
            this.btnPrice.TabIndex = 21;
            this.btnPrice.Text = "Обработать прайс";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // lblVsego
            // 
            this.lblVsego.AutoSize = true;
            this.lblVsego.Location = new System.Drawing.Point(242, 67);
            this.lblVsego.Name = "lblVsego";
            this.lblVsego.Size = new System.Drawing.Size(13, 13);
            this.lblVsego.TabIndex = 25;
            this.lblVsego.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "из";
            // 
            // lblTovar
            // 
            this.lblTovar.AutoSize = true;
            this.lblTovar.Location = new System.Drawing.Point(187, 67);
            this.lblTovar.Name = "lblTovar";
            this.lblTovar.Size = new System.Drawing.Size(13, 13);
            this.lblTovar.TabIndex = 23;
            this.lblTovar.Text = "0";
            // 
            // lblNamePosition
            // 
            this.lblNamePosition.AutoSize = true;
            this.lblNamePosition.Location = new System.Drawing.Point(143, 67);
            this.lblNamePosition.Name = "lblNamePosition";
            this.lblNamePosition.Size = new System.Drawing.Size(47, 13);
            this.lblNamePosition.TabIndex = 22;
            this.lblNamePosition.Text = "Раздел ";
            // 
            // ofdLoadPrice
            // 
            this.ofdLoadPrice.FileName = "openFileDialog1";
            this.ofdLoadPrice.Filter = "Excel|*.xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 264);
            this.Controls.Add(this.lblVsego);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTovar);
            this.Controls.Add(this.lblNamePosition);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswords);
            this.Controls.Add(this.tbLogin);
            this.Name = "Form1";
            this.Text = "АгроТрейд";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswords;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lblVsego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTovar;
        private System.Windows.Forms.Label lblNamePosition;
        private System.Windows.Forms.OpenFileDialog ofdLoadPrice;
    }
}

