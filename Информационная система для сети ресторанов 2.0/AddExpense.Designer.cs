namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddExpense
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
            btnAddExpense = new Button();
            cmbExpenseRestaurant = new ComboBox();
            label1 = new Label();
            txtExpenceSumma = new TextBox();
            label2 = new Label();
            labelNameDish = new Label();
            txtExpenceType = new TextBox();
            SuspendLayout();
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.FromArgb(61, 64, 91);
            btnAddExpense.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddExpense.ForeColor = Color.White;
            btnAddExpense.Location = new Point(129, 352);
            btnAddExpense.Margin = new Padding(3, 4, 3, 4);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(250, 62);
            btnAddExpense.TabIndex = 37;
            btnAddExpense.Text = "Добавить расходы";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // cmbExpenseRestaurant
            // 
            cmbExpenseRestaurant.BackColor = Color.FromArgb(61, 64, 91);
            cmbExpenseRestaurant.FormattingEnabled = true;
            cmbExpenseRestaurant.Location = new Point(129, 243);
            cmbExpenseRestaurant.Name = "cmbExpenseRestaurant";
            cmbExpenseRestaurant.Size = new Size(271, 28);
            cmbExpenseRestaurant.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 151);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 35;
            label1.Text = "Сумма";
            // 
            // txtExpenceSumma
            // 
            txtExpenceSumma.BackColor = Color.FromArgb(61, 64, 91);
            txtExpenceSumma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtExpenceSumma.ForeColor = Color.White;
            txtExpenceSumma.Location = new Point(129, 175);
            txtExpenceSumma.Margin = new Padding(3, 4, 3, 4);
            txtExpenceSumma.Name = "txtExpenceSumma";
            txtExpenceSumma.Size = new Size(250, 34);
            txtExpenceSumma.TabIndex = 34;
            txtExpenceSumma.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 220);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 33;
            label2.Text = "Ресторан";
            // 
            // labelNameDish
            // 
            labelNameDish.AutoSize = true;
            labelNameDish.Location = new Point(205, 78);
            labelNameDish.Name = "labelNameDish";
            labelNameDish.Size = new Size(95, 20);
            labelNameDish.TabIndex = 32;
            labelNameDish.Text = "Тип расхода";
            // 
            // txtExpenceType
            // 
            txtExpenceType.BackColor = Color.FromArgb(61, 64, 91);
            txtExpenceType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtExpenceType.ForeColor = Color.White;
            txtExpenceType.Location = new Point(129, 102);
            txtExpenceType.Margin = new Padding(3, 4, 3, 4);
            txtExpenceType.Name = "txtExpenceType";
            txtExpenceType.Size = new Size(250, 34);
            txtExpenceType.TabIndex = 31;
            txtExpenceType.TextAlign = HorizontalAlignment.Center;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(529, 462);
            Controls.Add(btnAddExpense);
            Controls.Add(cmbExpenseRestaurant);
            Controls.Add(label1);
            Controls.Add(txtExpenceSumma);
            Controls.Add(label2);
            Controls.Add(labelNameDish);
            Controls.Add(txtExpenceType);
            Name = "AddExpense";
            Text = "AddExpense";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddExpense;
        private ComboBox cmbExpenseRestaurant;
        private Label label1;
        private TextBox txtExpenceSumma;
        private Label label2;
        private Label labelNameDish;
        private TextBox txtExpenceType;
    }
}