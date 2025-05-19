namespace Информационная_система_для_сети_ресторанов_2._0
{
    partial class AddDelivery
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
            txtDeliveryCost = new TextBox();
            label3 = new Label();
            cmbDeliveryRestaurant = new ComboBox();
            comboDeliveryProvider = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 140);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 20;
            label2.Text = "Название ресторана";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 67);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 19;
            label1.Text = "Стоимость";
            // 
            // btnAddProvider
            // 
            btnAddProvider.BackColor = Color.FromArgb(61, 64, 91);
            btnAddProvider.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddProvider.ForeColor = Color.White;
            btnAddProvider.Location = new Point(112, 327);
            btnAddProvider.Margin = new Padding(3, 4, 3, 4);
            btnAddProvider.Name = "btnAddProvider";
            btnAddProvider.Size = new Size(250, 62);
            btnAddProvider.TabIndex = 18;
            btnAddProvider.Text = "Добавить поставку";
            btnAddProvider.UseVisualStyleBackColor = false;
            btnAddProvider.Click += btnAddProvider_Click;
            // 
            // txtDeliveryCost
            // 
            txtDeliveryCost.BackColor = Color.FromArgb(61, 64, 91);
            txtDeliveryCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDeliveryCost.ForeColor = Color.White;
            txtDeliveryCost.Location = new Point(112, 91);
            txtDeliveryCost.Margin = new Padding(3, 4, 3, 4);
            txtDeliveryCost.Name = "txtDeliveryCost";
            txtDeliveryCost.Size = new Size(250, 34);
            txtDeliveryCost.TabIndex = 16;
            txtDeliveryCost.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 217);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 22;
            label3.Text = "Поставщик";
            // 
            // cmbDeliveryRestaurant
            // 
            cmbDeliveryRestaurant.BackColor = Color.FromArgb(61, 64, 91);
            cmbDeliveryRestaurant.FormattingEnabled = true;
            cmbDeliveryRestaurant.Location = new Point(112, 176);
            cmbDeliveryRestaurant.Name = "cmbDeliveryRestaurant";
            cmbDeliveryRestaurant.Size = new Size(271, 28);
            cmbDeliveryRestaurant.TabIndex = 23;
            // 
            // comboDeliveryProvider
            // 
            comboDeliveryProvider.BackColor = Color.FromArgb(61, 64, 91);
            comboDeliveryProvider.FormattingEnabled = true;
            comboDeliveryProvider.Location = new Point(112, 254);
            comboDeliveryProvider.Name = "comboDeliveryProvider";
            comboDeliveryProvider.Size = new Size(271, 28);
            comboDeliveryProvider.TabIndex = 24;
            // 
            // AddDelivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 215, 230);
            ClientSize = new Size(474, 456);
            Controls.Add(comboDeliveryProvider);
            Controls.Add(cmbDeliveryRestaurant);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddProvider);
            Controls.Add(txtDeliveryCost);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddDelivery";
            Text = " Добавить поставку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnAddProvider;
        private TextBox txtDeliveryCost;
        private Label label3;
        private ComboBox cmbDeliveryRestaurant;
        private ComboBox comboDeliveryProvider;
    }
}