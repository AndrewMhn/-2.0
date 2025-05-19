namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddEmpoyee
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
            cmbEmployeeRestaurant = new ComboBox();
            label3 = new Label();
            txtEmployeeSalary = new TextBox();
            label1 = new Label();
            txtEmployeePosition = new TextBox();
            label2 = new Label();
            labelNameDish = new Label();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            txtEmployeeNumber = new TextBox();
            label5 = new Label();
            txtEmployeeLogin = new TextBox();
            label6 = new Label();
            txtEmployeePassword = new TextBox();
            btnAddEmployee = new Button();
            SuspendLayout();
            // 
            // cmbEmployeeRestaurant
            // 
            cmbEmployeeRestaurant.BackColor = Color.FromArgb(61, 64, 91);
            cmbEmployeeRestaurant.FormattingEnabled = true;
            cmbEmployeeRestaurant.Location = new Point(119, 413);
            cmbEmployeeRestaurant.Name = "cmbEmployeeRestaurant";
            cmbEmployeeRestaurant.Size = new Size(271, 28);
            cmbEmployeeRestaurant.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 143);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 36;
            label3.Text = "Зарплата";
            // 
            // txtEmployeeSalary
            // 
            txtEmployeeSalary.BackColor = Color.FromArgb(61, 64, 91);
            txtEmployeeSalary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEmployeeSalary.ForeColor = Color.White;
            txtEmployeeSalary.Location = new Point(119, 167);
            txtEmployeeSalary.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeSalary.Name = "txtEmployeeSalary";
            txtEmployeeSalary.Size = new Size(250, 34);
            txtEmployeeSalary.TabIndex = 35;
            txtEmployeeSalary.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 81);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 34;
            label1.Text = "Должность";
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.BackColor = Color.FromArgb(61, 64, 91);
            txtEmployeePosition.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEmployeePosition.ForeColor = Color.White;
            txtEmployeePosition.Location = new Point(119, 105);
            txtEmployeePosition.Margin = new Padding(3, 4, 3, 4);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(250, 34);
            txtEmployeePosition.TabIndex = 33;
            txtEmployeePosition.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 390);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 32;
            label2.Text = "Ресторан";
            // 
            // labelNameDish
            // 
            labelNameDish.AutoSize = true;
            labelNameDish.Location = new Point(227, 19);
            labelNameDish.Name = "labelNameDish";
            labelNameDish.Size = new Size(42, 20);
            labelNameDish.TabIndex = 31;
            labelNameDish.Text = "ФИО";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.FromArgb(61, 64, 91);
            txtEmployeeName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEmployeeName.ForeColor = Color.White;
            txtEmployeeName.Location = new Point(119, 43);
            txtEmployeeName.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(250, 34);
            txtEmployeeName.TabIndex = 30;
            txtEmployeeName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 205);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 39;
            label4.Text = "Номер телефона";
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.BackColor = Color.FromArgb(61, 64, 91);
            txtEmployeeNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEmployeeNumber.ForeColor = Color.White;
            txtEmployeeNumber.Location = new Point(119, 228);
            txtEmployeeNumber.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(250, 34);
            txtEmployeeNumber.TabIndex = 38;
            txtEmployeeNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 266);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 41;
            label5.Text = "Логин";
            // 
            // txtEmployeeLogin
            // 
            txtEmployeeLogin.BackColor = Color.FromArgb(61, 64, 91);
            txtEmployeeLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEmployeeLogin.ForeColor = Color.White;
            txtEmployeeLogin.Location = new Point(119, 290);
            txtEmployeeLogin.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeLogin.Name = "txtEmployeeLogin";
            txtEmployeeLogin.Size = new Size(250, 34);
            txtEmployeeLogin.TabIndex = 40;
            txtEmployeeLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 328);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 43;
            label6.Text = "Пароль";
            // 
            // txtEmployeePassword
            // 
            txtEmployeePassword.BackColor = Color.FromArgb(61, 64, 91);
            txtEmployeePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtEmployeePassword.ForeColor = Color.White;
            txtEmployeePassword.Location = new Point(119, 352);
            txtEmployeePassword.Margin = new Padding(3, 4, 3, 4);
            txtEmployeePassword.Name = "txtEmployeePassword";
            txtEmployeePassword.Size = new Size(250, 34);
            txtEmployeePassword.TabIndex = 42;
            txtEmployeePassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(61, 64, 91);
            btnAddEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(119, 539);
            btnAddEmployee.Margin = new Padding(3, 4, 3, 4);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(250, 62);
            btnAddEmployee.TabIndex = 44;
            btnAddEmployee.Text = "Добавить сотрудника";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // AddEmpoyee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(499, 648);
            Controls.Add(btnAddEmployee);
            Controls.Add(label6);
            Controls.Add(txtEmployeePassword);
            Controls.Add(label5);
            Controls.Add(txtEmployeeLogin);
            Controls.Add(label4);
            Controls.Add(txtEmployeeNumber);
            Controls.Add(cmbEmployeeRestaurant);
            Controls.Add(label3);
            Controls.Add(txtEmployeeSalary);
            Controls.Add(label1);
            Controls.Add(txtEmployeePosition);
            Controls.Add(label2);
            Controls.Add(labelNameDish);
            Controls.Add(txtEmployeeName);
            Name = "AddEmpoyee";
            Text = "Добавить сотрудника";
            Load += AddEmpoyee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmployeeRestaurant;
        private Label label3;
        private TextBox txtEmployeeSalary;
        private Label label1;
        private TextBox txtEmployeePosition;
        private Label label2;
        private Label labelNameDish;
        private TextBox txtEmployeeName;
        private Label label4;
        private TextBox txtEmployeeNumber;
        private Label label5;
        private TextBox txtEmployeeLogin;
        private Label label6;
        private TextBox txtEmployeePassword;
        private Button btnAddEmployee;
    }
}