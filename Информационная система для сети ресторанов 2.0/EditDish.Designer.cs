namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class EditDish
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
            btnSaveEditDish = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEditDishTitle = new TextBox();
            txtEditDishPrice = new TextBox();
            txtEditDishCost = new TextBox();
            cmbEditDishRestaurant = new ComboBox();
            SuspendLayout();
            // 
            // btnSaveEditDish
            // 
            btnSaveEditDish.BackColor = Color.FromArgb(61, 64, 91);
            btnSaveEditDish.FlatAppearance.BorderSize = 0;
            btnSaveEditDish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSaveEditDish.ForeColor = Color.White;
            btnSaveEditDish.Location = new Point(138, 394);
            btnSaveEditDish.Name = "btnSaveEditDish";
            btnSaveEditDish.Size = new Size(250, 62);
            btnSaveEditDish.TabIndex = 0;
            btnSaveEditDish.Text = "Сохранить";
            btnSaveEditDish.UseVisualStyleBackColor = false;
            btnSaveEditDish.Click += btnSaveEditDish_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 65);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 135);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 210);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 3;
            label3.Text = "Себестоимость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 280);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 4;
            label4.Text = "Название ресторана";
            // 
            // txtEditDishTitle
            // 
            txtEditDishTitle.BackColor = Color.FromArgb(61, 64, 91);
            txtEditDishTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEditDishTitle.Location = new Point(138, 88);
            txtEditDishTitle.Name = "txtEditDishTitle";
            txtEditDishTitle.Size = new Size(250, 34);
            txtEditDishTitle.TabIndex = 5;
            // 
            // txtEditDishPrice
            // 
            txtEditDishPrice.BackColor = Color.FromArgb(61, 64, 91);
            txtEditDishPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEditDishPrice.Location = new Point(138, 158);
            txtEditDishPrice.Name = "txtEditDishPrice";
            txtEditDishPrice.Size = new Size(250, 34);
            txtEditDishPrice.TabIndex = 6;
            // 
            // txtEditDishCost
            // 
            txtEditDishCost.BackColor = Color.FromArgb(61, 64, 91);
            txtEditDishCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEditDishCost.Location = new Point(138, 233);
            txtEditDishCost.Name = "txtEditDishCost";
            txtEditDishCost.Size = new Size(250, 34);
            txtEditDishCost.TabIndex = 7;
            // 
            // cmbEditDishRestaurant
            // 
            cmbEditDishRestaurant.BackColor = Color.FromArgb(61, 64, 91);
            cmbEditDishRestaurant.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cmbEditDishRestaurant.ForeColor = SystemColors.Window;
            cmbEditDishRestaurant.FormattingEnabled = true;
            cmbEditDishRestaurant.Location = new Point(138, 303);
            cmbEditDishRestaurant.Name = "cmbEditDishRestaurant";
            cmbEditDishRestaurant.Size = new Size(272, 36);
            cmbEditDishRestaurant.TabIndex = 8;
            // 
            // EditDish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(524, 495);
            Controls.Add(cmbEditDishRestaurant);
            Controls.Add(txtEditDishCost);
            Controls.Add(txtEditDishPrice);
            Controls.Add(txtEditDishTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveEditDish);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditDish";
            Text = "Редактирование блюда";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveEditDish;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEditDishTitle;
        private TextBox txtEditDishPrice;
        private TextBox txtEditDishCost;
        private ComboBox cmbEditDishRestaurant;
    }
}