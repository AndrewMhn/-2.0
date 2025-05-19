namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddProvider
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
            label2 = new Label();
            label1 = new Label();
            btnAddProvider = new Button();
            txtContactPerson = new TextBox();
            txtProviderTitle = new TextBox();
            txtProviderNumber = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 133);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 13;
            label2.Text = "Контактное лицо";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 12;
            label1.Text = "Название";
            // 
            // btnAddProvider
            // 
            btnAddProvider.BackColor = Color.FromArgb(61, 64, 91);
            btnAddProvider.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddProvider.ForeColor = Color.White;
            btnAddProvider.Location = new Point(145, 320);
            btnAddProvider.Margin = new Padding(3, 4, 3, 4);
            btnAddProvider.Name = "btnAddProvider";
            btnAddProvider.Size = new Size(250, 62);
            btnAddProvider.TabIndex = 11;
            btnAddProvider.Text = "Добавить поставщика";
            btnAddProvider.UseVisualStyleBackColor = false;
            // 
            // txtContactPerson
            // 
            txtContactPerson.BackColor = Color.FromArgb(61, 64, 91);
            txtContactPerson.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtContactPerson.ForeColor = Color.White;
            txtContactPerson.Location = new Point(145, 157);
            txtContactPerson.Margin = new Padding(3, 4, 3, 4);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(250, 34);
            txtContactPerson.TabIndex = 10;
            txtContactPerson.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProviderTitle
            // 
            txtProviderTitle.BackColor = Color.FromArgb(61, 64, 91);
            txtProviderTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtProviderTitle.ForeColor = Color.White;
            txtProviderTitle.Location = new Point(145, 84);
            txtProviderTitle.Margin = new Padding(3, 4, 3, 4);
            txtProviderTitle.Name = "txtProviderTitle";
            txtProviderTitle.Size = new Size(250, 34);
            txtProviderTitle.TabIndex = 9;
            txtProviderTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProviderNumber
            // 
            txtProviderNumber.BackColor = Color.FromArgb(61, 64, 91);
            txtProviderNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtProviderNumber.ForeColor = Color.White;
            txtProviderNumber.Location = new Point(145, 234);
            txtProviderNumber.Margin = new Padding(3, 4, 3, 4);
            txtProviderNumber.Name = "txtProviderNumber";
            txtProviderNumber.Size = new Size(250, 34);
            txtProviderNumber.TabIndex = 14;
            txtProviderNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 210);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 15;
            label3.Text = "Номер телефона";
            // 
            // AddProvider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(536, 450);
            Controls.Add(label3);
            Controls.Add(txtProviderNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddProvider);
            Controls.Add(txtContactPerson);
            Controls.Add(txtProviderTitle);
            Name = "AddProvider";
            Text = "AddProvider";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnAddProvider;
        private TextBox txtContactPerson;
        private TextBox txtProviderTitle;
        private TextBox txtProviderNumber;
        private Label label3;
    }
}