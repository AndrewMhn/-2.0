namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddDish
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
            labelNameDish = new Label();
            txtDishName = new TextBox();
            label1 = new Label();
            txtDishPrice = new TextBox();
            label3 = new Label();
            txtDishCost = new TextBox();
            cmbDishRestaurant = new ComboBox();
            btnAddDish = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 263);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 23;
            label2.Text = "Ресторан";
            label2.Click += label2_Click;
            // 
            // labelNameDish
            // 
            labelNameDish.AutoSize = true;
            labelNameDish.Location = new Point(226, 40);
            labelNameDish.Name = "labelNameDish";
            labelNameDish.Size = new Size(77, 20);
            labelNameDish.TabIndex = 22;
            labelNameDish.Text = "Название";
            // 
            // txtDishName
            // 
            txtDishName.BackColor = Color.FromArgb(61, 64, 91);
            txtDishName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDishName.ForeColor = Color.White;
            txtDishName.Location = new Point(138, 64);
            txtDishName.Margin = new Padding(3, 4, 3, 4);
            txtDishName.Name = "txtDishName";
            txtDishName.Size = new Size(250, 34);
            txtDishName.TabIndex = 21;
            txtDishName.TextAlign = HorizontalAlignment.Center;
            txtDishName.TextChanged += txtDishName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 113);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 25;
            label1.Text = "Цена";
            // 
            // txtDishPrice
            // 
            txtDishPrice.BackColor = Color.FromArgb(61, 64, 91);
            txtDishPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDishPrice.ForeColor = Color.White;
            txtDishPrice.Location = new Point(138, 137);
            txtDishPrice.Margin = new Padding(3, 4, 3, 4);
            txtDishPrice.Name = "txtDishPrice";
            txtDishPrice.Size = new Size(250, 34);
            txtDishPrice.TabIndex = 24;
            txtDishPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 185);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 27;
            label3.Text = "Себестоимость";
            // 
            // txtDishCost
            // 
            txtDishCost.BackColor = Color.FromArgb(61, 64, 91);
            txtDishCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDishCost.ForeColor = Color.White;
            txtDishCost.Location = new Point(138, 209);
            txtDishCost.Margin = new Padding(3, 4, 3, 4);
            txtDishCost.Name = "txtDishCost";
            txtDishCost.Size = new Size(250, 34);
            txtDishCost.TabIndex = 26;
            txtDishCost.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbDishRestaurant
            // 
            cmbDishRestaurant.BackColor = Color.FromArgb(61, 64, 91);
            cmbDishRestaurant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbDishRestaurant.FormattingEnabled = true;
            cmbDishRestaurant.Location = new Point(138, 286);
            cmbDishRestaurant.Name = "cmbDishRestaurant";
            cmbDishRestaurant.Size = new Size(271, 36);
            cmbDishRestaurant.TabIndex = 29;
            // 
            // btnAddDish
            // 
            btnAddDish.BackColor = Color.FromArgb(61, 64, 91);
            btnAddDish.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddDish.ForeColor = Color.White;
            btnAddDish.Location = new Point(138, 394);
            btnAddDish.Margin = new Padding(3, 4, 3, 4);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(250, 62);
            btnAddDish.TabIndex = 30;
            btnAddDish.Text = "Добавить блюдо";
            btnAddDish.UseVisualStyleBackColor = false;
            btnAddDish.Click += btnAddDish_Click;
            // 
            // AddDish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(524, 495);
            Controls.Add(btnAddDish);
            Controls.Add(cmbDishRestaurant);
            Controls.Add(label3);
            Controls.Add(txtDishCost);
            Controls.Add(label1);
            Controls.Add(txtDishPrice);
            Controls.Add(label2);
            Controls.Add(labelNameDish);
            Controls.Add(txtDishName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddDish";
            Text = "Добавить блюдо";
            Load += AddDish_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label labelNameDish;
        private TextBox txtDishName;
        private Label label1;
        private TextBox txtDishPrice;
        private Label label3;
        private TextBox txtDishCost;
        private ComboBox cmbDishRestaurant;
        private Button btnAddDish;
    }
}