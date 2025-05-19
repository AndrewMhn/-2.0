namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddRestaurant
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
            txtRestaurantTitle = new TextBox();
            txtRestaurantAddress = new TextBox();
            btnAddRestaurant = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtRestaurantTitle
            // 
            txtRestaurantTitle.BackColor = Color.FromArgb(61, 64, 91);
            txtRestaurantTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtRestaurantTitle.ForeColor = Color.White;
            txtRestaurantTitle.Location = new Point(142, 72);
            txtRestaurantTitle.Margin = new Padding(3, 4, 3, 4);
            txtRestaurantTitle.Name = "txtRestaurantTitle";
            txtRestaurantTitle.Size = new Size(250, 34);
            txtRestaurantTitle.TabIndex = 4;
            txtRestaurantTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRestaurantAddress
            // 
            txtRestaurantAddress.BackColor = Color.FromArgb(61, 64, 91);
            txtRestaurantAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtRestaurantAddress.ForeColor = Color.White;
            txtRestaurantAddress.Location = new Point(142, 145);
            txtRestaurantAddress.Margin = new Padding(3, 4, 3, 4);
            txtRestaurantAddress.Name = "txtRestaurantAddress";
            txtRestaurantAddress.Size = new Size(250, 34);
            txtRestaurantAddress.TabIndex = 5;
            txtRestaurantAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddRestaurant
            // 
            btnAddRestaurant.BackColor = Color.FromArgb(61, 64, 91);
            btnAddRestaurant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddRestaurant.ForeColor = Color.White;
            btnAddRestaurant.Location = new Point(142, 240);
            btnAddRestaurant.Margin = new Padding(3, 4, 3, 4);
            btnAddRestaurant.Name = "btnAddRestaurant";
            btnAddRestaurant.Size = new Size(250, 62);
            btnAddRestaurant.TabIndex = 6;
            btnAddRestaurant.Text = "Добавить ресторан";
            btnAddRestaurant.UseVisualStyleBackColor = false;
            btnAddRestaurant.Click += btnAddRestaurant_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 48);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 121);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Адрес";
            // 
            // AddRestaurant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(529, 340);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddRestaurant);
            Controls.Add(txtRestaurantAddress);
            Controls.Add(txtRestaurantTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddRestaurant";
            Text = "AddRestaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRestaurantTitle;
        private TextBox txtRestaurantAddress;
        private Button btnAddRestaurant;
        private Label label1;
        private Label label2;
    }
}