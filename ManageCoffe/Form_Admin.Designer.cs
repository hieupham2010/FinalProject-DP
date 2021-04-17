namespace ManageCoffe
{
    partial class Form_Admin
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
            this.tabPage_Manage_Account = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_DisplayName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.button_AddAccount = new System.Windows.Forms.Button();
            this.button_DeleteAccount = new System.Windows.Forms.Button();
            this.button_UpdateAccount = new System.Windows.Forms.Button();
            this.textBox_SearchAccount = new System.Windows.Forms.TextBox();
            this.button_SearchAccount = new System.Windows.Forms.Button();
            this.listView_Account = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_CategoryBeverages = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_BeverID = new System.Windows.Forms.TextBox();
            this.textBox_NameBeverage = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_AddBeverage = new System.Windows.Forms.Button();
            this.button_DeleteBeverage = new System.Windows.Forms.Button();
            this.button_UpdateBeverage = new System.Windows.Forms.Button();
            this.label_BeverID = new System.Windows.Forms.Label();
            this.button_SearchBeverages = new System.Windows.Forms.Button();
            this.textBox_SearchBeverages = new System.Windows.Forms.TextBox();
            this.listView_Beverages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_ViewRevenue = new System.Windows.Forms.TabPage();
            this.listView_Revenue = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Day = new System.Windows.Forms.Button();
            this.button_Month = new System.Windows.Forms.Button();
            this.button_Year = new System.Windows.Forms.Button();
            this.textBox_TotalRevenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_Manage_Account.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_CategoryBeverages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_ViewRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_Manage_Account
            // 
            this.tabPage_Manage_Account.Controls.Add(this.listView_Account);
            this.tabPage_Manage_Account.Controls.Add(this.textBox_SearchAccount);
            this.tabPage_Manage_Account.Controls.Add(this.button_SearchAccount);
            this.tabPage_Manage_Account.Controls.Add(this.panel2);
            this.tabPage_Manage_Account.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Manage_Account.Name = "tabPage_Manage_Account";
            this.tabPage_Manage_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Manage_Account.Size = new System.Drawing.Size(1363, 654);
            this.tabPage_Manage_Account.TabIndex = 1;
            this.tabPage_Manage_Account.Text = "Quản Lý Tài Khoản";
            this.tabPage_Manage_Account.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_UpdateAccount);
            this.panel2.Controls.Add(this.button_DeleteAccount);
            this.panel2.Controls.Add(this.button_AddAccount);
            this.panel2.Controls.Add(this.textBox_Type);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_DisplayName);
            this.panel2.Controls.Add(this.textBox_Password);
            this.panel2.Controls.Add(this.textBox_UserName);
            this.panel2.Location = new System.Drawing.Point(822, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 563);
            this.panel2.TabIndex = 14;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(162, 40);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(306, 26);
            this.textBox_UserName.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(162, 126);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(306, 26);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_DisplayName
            // 
            this.textBox_DisplayName.Location = new System.Drawing.Point(162, 216);
            this.textBox_DisplayName.Name = "textBox_DisplayName";
            this.textBox_DisplayName.Size = new System.Drawing.Size(306, 26);
            this.textBox_DisplayName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Hiển Thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loại Tài Khoản";
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(162, 306);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.ReadOnly = true;
            this.textBox_Type.Size = new System.Drawing.Size(306, 26);
            this.textBox_Type.TabIndex = 10;
            this.textBox_Type.Text = "1";
            this.textBox_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_AddAccount
            // 
            this.button_AddAccount.Location = new System.Drawing.Point(29, 461);
            this.button_AddAccount.Name = "button_AddAccount";
            this.button_AddAccount.Size = new System.Drawing.Size(104, 52);
            this.button_AddAccount.TabIndex = 13;
            this.button_AddAccount.Text = "Thêm";
            this.button_AddAccount.UseVisualStyleBackColor = true;
            this.button_AddAccount.Click += new System.EventHandler(this.button_AddAccount_Click);
            // 
            // button_DeleteAccount
            // 
            this.button_DeleteAccount.Location = new System.Drawing.Point(213, 461);
            this.button_DeleteAccount.Name = "button_DeleteAccount";
            this.button_DeleteAccount.Size = new System.Drawing.Size(104, 52);
            this.button_DeleteAccount.TabIndex = 14;
            this.button_DeleteAccount.Text = "Xóa";
            this.button_DeleteAccount.UseVisualStyleBackColor = true;
            this.button_DeleteAccount.Click += new System.EventHandler(this.button_DeleteAccount_Click);
            // 
            // button_UpdateAccount
            // 
            this.button_UpdateAccount.Location = new System.Drawing.Point(389, 461);
            this.button_UpdateAccount.Name = "button_UpdateAccount";
            this.button_UpdateAccount.Size = new System.Drawing.Size(104, 52);
            this.button_UpdateAccount.TabIndex = 15;
            this.button_UpdateAccount.Text = "Sửa";
            this.button_UpdateAccount.UseVisualStyleBackColor = true;
            this.button_UpdateAccount.Click += new System.EventHandler(this.button_UpdateAccount_Click);
            // 
            // textBox_SearchAccount
            // 
            this.textBox_SearchAccount.Location = new System.Drawing.Point(18, 26);
            this.textBox_SearchAccount.Name = "textBox_SearchAccount";
            this.textBox_SearchAccount.Size = new System.Drawing.Size(576, 26);
            this.textBox_SearchAccount.TabIndex = 15;
            // 
            // button_SearchAccount
            // 
            this.button_SearchAccount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchAccount.Location = new System.Drawing.Point(663, 12);
            this.button_SearchAccount.Name = "button_SearchAccount";
            this.button_SearchAccount.Size = new System.Drawing.Size(121, 54);
            this.button_SearchAccount.TabIndex = 16;
            this.button_SearchAccount.Text = "Tìm Kiếm";
            this.button_SearchAccount.UseVisualStyleBackColor = true;
            // 
            // listView_Account
            // 
            this.listView_Account.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Account.HideSelection = false;
            this.listView_Account.Location = new System.Drawing.Point(18, 73);
            this.listView_Account.Name = "listView_Account";
            this.listView_Account.Size = new System.Drawing.Size(766, 563);
            this.listView_Account.TabIndex = 17;
            this.listView_Account.UseCompatibleStateImageBehavior = false;
            this.listView_Account.View = System.Windows.Forms.View.Details;
            this.listView_Account.SelectedIndexChanged += new System.EventHandler(this.listView_Account_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Tài Khoản";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Hiển Thị";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại Tài Khoản";
            this.columnHeader5.Width = 100;
            // 
            // tabPage_CategoryBeverages
            // 
            this.tabPage_CategoryBeverages.Controls.Add(this.listView_Beverages);
            this.tabPage_CategoryBeverages.Controls.Add(this.textBox_SearchBeverages);
            this.tabPage_CategoryBeverages.Controls.Add(this.button_SearchBeverages);
            this.tabPage_CategoryBeverages.Controls.Add(this.panel1);
            this.tabPage_CategoryBeverages.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_CategoryBeverages.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CategoryBeverages.Name = "tabPage_CategoryBeverages";
            this.tabPage_CategoryBeverages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CategoryBeverages.Size = new System.Drawing.Size(1363, 654);
            this.tabPage_CategoryBeverages.TabIndex = 0;
            this.tabPage_CategoryBeverages.Text = "Danh Mục Đồ Uống";
            this.tabPage_CategoryBeverages.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_BeverID);
            this.panel1.Controls.Add(this.button_UpdateBeverage);
            this.panel1.Controls.Add(this.button_DeleteBeverage);
            this.panel1.Controls.Add(this.button_AddBeverage);
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.label_UserName);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.textBox_NameBeverage);
            this.panel1.Controls.Add(this.textBox_BeverID);
            this.panel1.Location = new System.Drawing.Point(822, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 563);
            this.panel1.TabIndex = 2;
            // 
            // textBox_BeverID
            // 
            this.textBox_BeverID.Location = new System.Drawing.Point(162, 40);
            this.textBox_BeverID.Name = "textBox_BeverID";
            this.textBox_BeverID.ReadOnly = true;
            this.textBox_BeverID.Size = new System.Drawing.Size(306, 28);
            this.textBox_BeverID.TabIndex = 1;
            // 
            // textBox_NameBeverage
            // 
            this.textBox_NameBeverage.Location = new System.Drawing.Point(162, 124);
            this.textBox_NameBeverage.Name = "textBox_NameBeverage";
            this.textBox_NameBeverage.Size = new System.Drawing.Size(306, 28);
            this.textBox_NameBeverage.TabIndex = 2;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(162, 210);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(306, 28);
            this.textBox_Price.TabIndex = 3;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(25, 127);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(113, 20);
            this.label_UserName.TabIndex = 6;
            this.label_UserName.Text = "Tên Đồ Uống";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(25, 213);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(37, 20);
            this.label_Password.TabIndex = 7;
            this.label_Password.Text = "Giá";
            // 
            // button_AddBeverage
            // 
            this.button_AddBeverage.Location = new System.Drawing.Point(29, 462);
            this.button_AddBeverage.Name = "button_AddBeverage";
            this.button_AddBeverage.Size = new System.Drawing.Size(104, 51);
            this.button_AddBeverage.TabIndex = 13;
            this.button_AddBeverage.Text = "Thêm";
            this.button_AddBeverage.UseVisualStyleBackColor = true;
            this.button_AddBeverage.Click += new System.EventHandler(this.button_AddBeverage_Click_1);
            // 
            // button_DeleteBeverage
            // 
            this.button_DeleteBeverage.Location = new System.Drawing.Point(213, 462);
            this.button_DeleteBeverage.Name = "button_DeleteBeverage";
            this.button_DeleteBeverage.Size = new System.Drawing.Size(104, 51);
            this.button_DeleteBeverage.TabIndex = 14;
            this.button_DeleteBeverage.Text = "Xóa";
            this.button_DeleteBeverage.UseVisualStyleBackColor = true;
            this.button_DeleteBeverage.Click += new System.EventHandler(this.button_DeleteBeverage_Click);
            // 
            // button_UpdateBeverage
            // 
            this.button_UpdateBeverage.Location = new System.Drawing.Point(389, 462);
            this.button_UpdateBeverage.Name = "button_UpdateBeverage";
            this.button_UpdateBeverage.Size = new System.Drawing.Size(104, 51);
            this.button_UpdateBeverage.TabIndex = 15;
            this.button_UpdateBeverage.Text = "Sửa";
            this.button_UpdateBeverage.UseVisualStyleBackColor = true;
            this.button_UpdateBeverage.Click += new System.EventHandler(this.button_UpdateBeverage_Click);
            // 
            // label_BeverID
            // 
            this.label_BeverID.AutoSize = true;
            this.label_BeverID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BeverID.Location = new System.Drawing.Point(25, 43);
            this.label_BeverID.Name = "label_BeverID";
            this.label_BeverID.Size = new System.Drawing.Size(104, 20);
            this.label_BeverID.TabIndex = 16;
            this.label_BeverID.Text = "ID Đồ Uống";
            // 
            // button_SearchBeverages
            // 
            this.button_SearchBeverages.Location = new System.Drawing.Point(664, 11);
            this.button_SearchBeverages.Name = "button_SearchBeverages";
            this.button_SearchBeverages.Size = new System.Drawing.Size(120, 52);
            this.button_SearchBeverages.TabIndex = 12;
            this.button_SearchBeverages.Text = "Tìm Kiếm";
            this.button_SearchBeverages.UseVisualStyleBackColor = true;
            this.button_SearchBeverages.Click += new System.EventHandler(this.button_SearchAccount_Click);
            // 
            // textBox_SearchBeverages
            // 
            this.textBox_SearchBeverages.Location = new System.Drawing.Point(18, 24);
            this.textBox_SearchBeverages.Name = "textBox_SearchBeverages";
            this.textBox_SearchBeverages.Size = new System.Drawing.Size(576, 28);
            this.textBox_SearchBeverages.TabIndex = 11;
            // 
            // listView_Beverages
            // 
            this.listView_Beverages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Beverages.HideSelection = false;
            this.listView_Beverages.Location = new System.Drawing.Point(18, 71);
            this.listView_Beverages.Name = "listView_Beverages";
            this.listView_Beverages.Size = new System.Drawing.Size(766, 563);
            this.listView_Beverages.TabIndex = 13;
            this.listView_Beverages.UseCompatibleStateImageBehavior = false;
            this.listView_Beverages.View = System.Windows.Forms.View.Details;
            this.listView_Beverages.SelectedIndexChanged += new System.EventHandler(this.listView_Beverages_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Đồ Uống";
            this.columnHeader1.Width = 383;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 107;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_CategoryBeverages);
            this.tabControl.Controls.Add(this.tabPage_Manage_Account);
            this.tabControl.Controls.Add(this.tabPage_ViewRevenue);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1371, 687);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_ViewRevenue
            // 
            this.tabPage_ViewRevenue.Controls.Add(this.label5);
            this.tabPage_ViewRevenue.Controls.Add(this.textBox_TotalRevenue);
            this.tabPage_ViewRevenue.Controls.Add(this.button_Year);
            this.tabPage_ViewRevenue.Controls.Add(this.button_Month);
            this.tabPage_ViewRevenue.Controls.Add(this.button_Day);
            this.tabPage_ViewRevenue.Controls.Add(this.dateTimePicker1);
            this.tabPage_ViewRevenue.Controls.Add(this.listView_Revenue);
            this.tabPage_ViewRevenue.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ViewRevenue.Name = "tabPage_ViewRevenue";
            this.tabPage_ViewRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ViewRevenue.Size = new System.Drawing.Size(1363, 654);
            this.tabPage_ViewRevenue.TabIndex = 3;
            this.tabPage_ViewRevenue.Text = "Doanh Thu";
            this.tabPage_ViewRevenue.UseVisualStyleBackColor = true;
            // 
            // listView_Revenue
            // 
            this.listView_Revenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_Revenue.HideSelection = false;
            this.listView_Revenue.Location = new System.Drawing.Point(114, 38);
            this.listView_Revenue.Name = "listView_Revenue";
            this.listView_Revenue.Size = new System.Drawing.Size(1134, 499);
            this.listView_Revenue.TabIndex = 0;
            this.listView_Revenue.UseCompatibleStateImageBehavior = false;
            this.listView_Revenue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên";
            this.columnHeader6.Width = 400;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn Giá";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Lượng";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thành Tiền";
            this.columnHeader9.Width = 100;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(498, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button_Day
            // 
            this.button_Day.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Day.Location = new System.Drawing.Point(114, 543);
            this.button_Day.Name = "button_Day";
            this.button_Day.Size = new System.Drawing.Size(160, 51);
            this.button_Day.TabIndex = 2;
            this.button_Day.Text = "Xem Theo Ngày";
            this.button_Day.UseVisualStyleBackColor = true;
            this.button_Day.Click += new System.EventHandler(this.button_Day_Click);
            // 
            // button_Month
            // 
            this.button_Month.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Month.Location = new System.Drawing.Point(368, 543);
            this.button_Month.Name = "button_Month";
            this.button_Month.Size = new System.Drawing.Size(160, 51);
            this.button_Month.TabIndex = 3;
            this.button_Month.Text = "Xem Theo Tháng";
            this.button_Month.UseVisualStyleBackColor = true;
            this.button_Month.Click += new System.EventHandler(this.button_Month_Click);
            // 
            // button_Year
            // 
            this.button_Year.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Year.Location = new System.Drawing.Point(620, 543);
            this.button_Year.Name = "button_Year";
            this.button_Year.Size = new System.Drawing.Size(160, 51);
            this.button_Year.TabIndex = 4;
            this.button_Year.Text = "Xem Theo Năm";
            this.button_Year.UseVisualStyleBackColor = true;
            this.button_Year.Click += new System.EventHandler(this.button_Year_Click);
            // 
            // textBox_TotalRevenue
            // 
            this.textBox_TotalRevenue.Location = new System.Drawing.Point(1004, 555);
            this.textBox_TotalRevenue.Name = "textBox_TotalRevenue";
            this.textBox_TotalRevenue.Size = new System.Drawing.Size(244, 26);
            this.textBox_TotalRevenue.TabIndex = 5;
            this.textBox_TotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(848, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng Doanh Thu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1395, 711);
            this.Controls.Add(this.tabControl);
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabPage_Manage_Account.ResumeLayout(false);
            this.tabPage_Manage_Account.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_CategoryBeverages.ResumeLayout(false);
            this.tabPage_CategoryBeverages.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage_ViewRevenue.ResumeLayout(false);
            this.tabPage_ViewRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_Manage_Account;
        private System.Windows.Forms.ListView listView_Account;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBox_SearchAccount;
        private System.Windows.Forms.Button button_SearchAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_UpdateAccount;
        private System.Windows.Forms.Button button_DeleteAccount;
        private System.Windows.Forms.Button button_AddAccount;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DisplayName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TabPage tabPage_CategoryBeverages;
        private System.Windows.Forms.ListView listView_Beverages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox_SearchBeverages;
        private System.Windows.Forms.Button button_SearchBeverages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_BeverID;
        private System.Windows.Forms.Button button_UpdateBeverage;
        private System.Windows.Forms.Button button_DeleteBeverage;
        private System.Windows.Forms.Button button_AddBeverage;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_NameBeverage;
        private System.Windows.Forms.TextBox textBox_BeverID;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_ViewRevenue;
        private System.Windows.Forms.ListView listView_Revenue;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TotalRevenue;
        private System.Windows.Forms.Button button_Year;
        private System.Windows.Forms.Button button_Month;
        private System.Windows.Forms.Button button_Day;
    }
}