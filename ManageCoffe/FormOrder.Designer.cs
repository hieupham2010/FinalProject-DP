namespace ManageCoffe
{
    partial class FormOrder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView_Menu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView_Order = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_BeverageSelected = new System.Windows.Forms.TextBox();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.textBox_FindBeverages = new System.Windows.Forms.TextBox();
            this.button_FindBeverages = new System.Windows.Forms.Button();
            this.button_AddBeverage = new System.Windows.Forms.Button();
            this.button_DeleteBeverage = new System.Windows.Forms.Button();
            this.button_Payment = new System.Windows.Forms.Button();
            this.textBox_ReceivedMoney = new System.Windows.Forms.TextBox();
            this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.textBox_ExcessCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.LogoutToolStripMenuItem.Text = "Đăng Xuất";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_Menu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 510);
            this.panel1.TabIndex = 1;
            // 
            // listView_Menu
            // 
            this.listView_Menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Menu.HideSelection = false;
            this.listView_Menu.Location = new System.Drawing.Point(3, 3);
            this.listView_Menu.Name = "listView_Menu";
            this.listView_Menu.Size = new System.Drawing.Size(678, 504);
            this.listView_Menu.TabIndex = 16;
            this.listView_Menu.UseCompatibleStateImageBehavior = false;
            this.listView_Menu.View = System.Windows.Forms.View.Details;
            this.listView_Menu.SelectedIndexChanged += new System.EventHandler(this.listView_Menu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 348;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 83;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 90);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView_Order);
            this.panel2.Location = new System.Drawing.Point(702, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 510);
            this.panel2.TabIndex = 2;
            // 
            // listView_Order
            // 
            this.listView_Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader3});
            this.listView_Order.HideSelection = false;
            this.listView_Order.Location = new System.Drawing.Point(3, 3);
            this.listView_Order.Name = "listView_Order";
            this.listView_Order.Size = new System.Drawing.Size(677, 504);
            this.listView_Order.TabIndex = 0;
            this.listView_Order.UseCompatibleStateImageBehavior = false;
            this.listView_Order.View = System.Windows.Forms.View.Details;
            this.listView_Order.SelectedIndexChanged += new System.EventHandler(this.listView_Order_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn Giá";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số Lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thành Tiền";
            this.columnHeader3.Width = 70;
            // 
            // textBox_BeverageSelected
            // 
            this.textBox_BeverageSelected.Location = new System.Drawing.Point(3, 33);
            this.textBox_BeverageSelected.Name = "textBox_BeverageSelected";
            this.textBox_BeverageSelected.ReadOnly = true;
            this.textBox_BeverageSelected.Size = new System.Drawing.Size(528, 26);
            this.textBox_BeverageSelected.TabIndex = 0;
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Location = new System.Drawing.Point(561, 34);
            this.numericUpDown_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown_Amount.TabIndex = 3;
            this.numericUpDown_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_FindBeverages
            // 
            this.textBox_FindBeverages.Location = new System.Drawing.Point(15, 45);
            this.textBox_FindBeverages.Name = "textBox_FindBeverages";
            this.textBox_FindBeverages.Size = new System.Drawing.Size(525, 26);
            this.textBox_FindBeverages.TabIndex = 4;
            // 
            // button_FindBeverages
            // 
            this.button_FindBeverages.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FindBeverages.Location = new System.Drawing.Point(573, 32);
            this.button_FindBeverages.Name = "button_FindBeverages";
            this.button_FindBeverages.Size = new System.Drawing.Size(120, 53);
            this.button_FindBeverages.TabIndex = 5;
            this.button_FindBeverages.Text = "Tìm kiếm";
            this.button_FindBeverages.UseVisualStyleBackColor = true;
            this.button_FindBeverages.Click += new System.EventHandler(this.button_FindBeverages_Click);
            // 
            // button_AddBeverage
            // 
            this.button_AddBeverage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddBeverage.Location = new System.Drawing.Point(690, 21);
            this.button_AddBeverage.Name = "button_AddBeverage";
            this.button_AddBeverage.Size = new System.Drawing.Size(106, 50);
            this.button_AddBeverage.TabIndex = 6;
            this.button_AddBeverage.Text = "Thêm";
            this.button_AddBeverage.UseVisualStyleBackColor = true;
            this.button_AddBeverage.Click += new System.EventHandler(this.button_AddBeverage_Click);
            // 
            // button_DeleteBeverage
            // 
            this.button_DeleteBeverage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteBeverage.Location = new System.Drawing.Point(814, 21);
            this.button_DeleteBeverage.Name = "button_DeleteBeverage";
            this.button_DeleteBeverage.Size = new System.Drawing.Size(106, 50);
            this.button_DeleteBeverage.TabIndex = 7;
            this.button_DeleteBeverage.Text = "Xóa";
            this.button_DeleteBeverage.UseVisualStyleBackColor = true;
            this.button_DeleteBeverage.Click += new System.EventHandler(this.button_DeleteBeverage_Click);
            // 
            // button_Payment
            // 
            this.button_Payment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Payment.Location = new System.Drawing.Point(1115, 15);
            this.button_Payment.Name = "button_Payment";
            this.button_Payment.Size = new System.Drawing.Size(120, 50);
            this.button_Payment.TabIndex = 8;
            this.button_Payment.Text = "Thanh Toán";
            this.button_Payment.UseVisualStyleBackColor = true;
            this.button_Payment.Click += new System.EventHandler(this.button_Payment_Click);
            // 
            // textBox_ReceivedMoney
            // 
            this.textBox_ReceivedMoney.Location = new System.Drawing.Point(989, 51);
            this.textBox_ReceivedMoney.Name = "textBox_ReceivedMoney";
            this.textBox_ReceivedMoney.Size = new System.Drawing.Size(120, 26);
            this.textBox_ReceivedMoney.TabIndex = 9;
            this.textBox_ReceivedMoney.Text = "0";
            this.textBox_ReceivedMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_TotalPrice
            // 
            this.textBox_TotalPrice.Location = new System.Drawing.Point(989, 9);
            this.textBox_TotalPrice.Name = "textBox_TotalPrice";
            this.textBox_TotalPrice.ReadOnly = true;
            this.textBox_TotalPrice.Size = new System.Drawing.Size(120, 26);
            this.textBox_TotalPrice.TabIndex = 10;
            this.textBox_TotalPrice.Text = "0";
            this.textBox_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_TotalPrice.TextChanged += new System.EventHandler(this.textBox_TotalPrice_TextChanged);
            // 
            // textBox_ExcessCash
            // 
            this.textBox_ExcessCash.Location = new System.Drawing.Point(1241, 33);
            this.textBox_ExcessCash.Name = "textBox_ExcessCash";
            this.textBox_ExcessCash.ReadOnly = true;
            this.textBox_ExcessCash.Size = new System.Drawing.Size(129, 26);
            this.textBox_ExcessCash.TabIndex = 11;
            this.textBox_ExcessCash.Text = "0";
            this.textBox_ExcessCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(936, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(935, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1279, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thừa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_ExcessCash);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.numericUpDown_Amount);
            this.panel4.Controls.Add(this.textBox_TotalPrice);
            this.panel4.Controls.Add(this.textBox_BeverageSelected);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox_ReceivedMoney);
            this.panel4.Controls.Add(this.button_AddBeverage);
            this.panel4.Controls.Add(this.button_Payment);
            this.panel4.Controls.Add(this.button_DeleteBeverage);
            this.panel4.Location = new System.Drawing.Point(12, 605);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1373, 100);
            this.panel4.TabIndex = 15;
            // 
            // FormOrder
            // 
            this.AcceptButton = this.button_FindBeverages;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1395, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_FindBeverages);
            this.Controls.Add(this.textBox_FindBeverages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_BeverageSelected;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.TextBox textBox_FindBeverages;
        private System.Windows.Forms.Button button_FindBeverages;
        private System.Windows.Forms.Button button_AddBeverage;
        private System.Windows.Forms.Button button_DeleteBeverage;
        private System.Windows.Forms.Button button_Payment;
        private System.Windows.Forms.TextBox textBox_ReceivedMoney;
        private System.Windows.Forms.TextBox textBox_TotalPrice;
        private System.Windows.Forms.TextBox textBox_ExcessCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView_Menu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView_Order;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}