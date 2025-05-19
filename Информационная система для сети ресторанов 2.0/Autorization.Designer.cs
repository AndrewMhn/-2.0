namespace Информационная_система_для_сети_ресторанов
{
    partial class Autorization
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
            btnAutorization = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnAutorization
            // 
            btnAutorization.BackColor = Color.FromArgb(61, 64, 91);
            btnAutorization.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAutorization.ForeColor = Color.White;
            btnAutorization.Location = new Point(224, 377);
            btnAutorization.Margin = new Padding(3, 4, 3, 4);
            btnAutorization.Name = "btnAutorization";
            btnAutorization.Size = new Size(180, 62);
            btnAutorization.TabIndex = 0;
            btnAutorization.Text = "Войти";
            btnAutorization.UseVisualStyleBackColor = false;
            btnAutorization.Click += button1_Click;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(61, 64, 91);
            txtLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(189, 114);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 34);
            txtLogin.TabIndex = 3;
            txtLogin.Text = "Логин";
            txtLogin.TextAlign = HorizontalAlignment.Center;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(61, 64, 91);
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(189, 206);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Пароль";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxShowPassword.Location = new Point(189, 256);
            checkBoxShowPassword.Margin = new Padding(3, 4, 3, 4);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(133, 21);
            checkBoxShowPassword.TabIndex = 5;
            checkBoxShowPassword.Text = "Показать пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(632, 504);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnAutorization);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(650, 551);
            MinimumSize = new Size(650, 551);
            Name = "Autorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAutorization;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}