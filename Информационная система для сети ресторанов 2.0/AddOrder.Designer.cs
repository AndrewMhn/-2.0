namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddOrder
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
            cmbOrderDish = new ComboBox();
            label2 = new Label();
            labelDishQuantity = new Label();
            txtDishQuantity = new TextBox();
            btnAddOrder = new Button();
            SuspendLayout();
            // 
            // cmbOrderDish
            // 
            cmbOrderDish.BackColor = Color.FromArgb(61, 64, 91);
            cmbOrderDish.FormattingEnabled = true;
            cmbOrderDish.Location = new Point(122, 78);
            cmbOrderDish.Name = "cmbOrderDish";
            cmbOrderDish.Size = new Size(271, 28);
            cmbOrderDish.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 38;
            label2.Text = "Блюдо";
            // 
            // labelDishQuantity
            // 
            labelDishQuantity.AutoSize = true;
            labelDishQuantity.Location = new Point(174, 130);
            labelDishQuantity.Name = "labelDishQuantity";
            labelDishQuantity.Size = new Size(148, 20);
            labelDishQuantity.TabIndex = 41;
            labelDishQuantity.Text = "Количество порций";
            // 
            // txtDishQuantity
            // 
            txtDishQuantity.BackColor = Color.FromArgb(61, 64, 91);
            txtDishQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDishQuantity.ForeColor = Color.White;
            txtDishQuantity.Location = new Point(122, 154);
            txtDishQuantity.Margin = new Padding(3, 4, 3, 4);
            txtDishQuantity.Name = "txtDishQuantity";
            txtDishQuantity.Size = new Size(250, 34);
            txtDishQuantity.TabIndex = 40;
            txtDishQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(61, 64, 91);
            btnAddOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(122, 288);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(250, 62);
            btnAddOrder.TabIndex = 45;
            btnAddOrder.Text = "Добавить заказ";
            btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(497, 376);
            Controls.Add(btnAddOrder);
            Controls.Add(labelDishQuantity);
            Controls.Add(txtDishQuantity);
            Controls.Add(cmbOrderDish);
            Controls.Add(label2);
            Name = "AddOrder";
            Text = "Добавить заказ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOrderDish;
        private Label label2;
        private Label labelDishQuantity;
        private TextBox txtDishQuantity;
        private Button btnAddOrder;
    }
}