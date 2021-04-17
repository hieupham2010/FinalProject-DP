using ManageCoffe.DataAccess;
using ManageCoffe.DataAccessLayer;
using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCoffe
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            LoadListBeverages();
            LoadListAccount();
            LoadListOrderPerDay();
        }
        void LoadListBeverages()
        {
            listView_Beverages.Items.Clear();
            List<MenuDT> menuList = MenuDA.Instance.getListBeveragesToMenu();
            foreach (MenuDT item in menuList)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listView_Beverages.Items.Add(listviewitem);
            }
        }
        void LoadListAccount()
        {
            listView_Account.Items.Clear();
            List<AccountDT> listAccount = AccountDA.Instance.getListAccount();
            foreach(AccountDT item in listAccount)
            {
                ListViewItem listviewitem = new ListViewItem(item.UserName1);
                listviewitem.SubItems.Add(item.DisplayName1);
                listviewitem.SubItems.Add(item.Type1.ToString());
                listView_Account.Items.Add(listviewitem);
            }
        }
        void LoadListOrderPerDay()
        {
            listView_Revenue.Items.Clear();
            DateTime Date = dateTimePicker1.Value;
            List<OrderInforDT> listBillInfor = OrderDA.Instance.getListOrderPerDay(Date);
            int TotalRevenue = 0;
            foreach (OrderInforDT item in listBillInfor)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listviewitem.SubItems.Add(item.Amount1.ToString());
                listviewitem.SubItems.Add(item.TotalPrice1.ToString());
                TotalRevenue += item.TotalPrice1;
                listView_Revenue.Items.Add(listviewitem);
            }
            textBox_TotalRevenue.Text = TotalRevenue.ToString();
        }
        void LoadListOrderPerMonth()
        {
            listView_Revenue.Items.Clear();
            
            List<OrderInforDT> listBillInfor = OrderDA.Instance.getListOrderPerMonth(dateTimePicker1.Value, dateTimePicker1.Value);
            int TotalRevenue = 0;
            foreach (OrderInforDT item in listBillInfor)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listviewitem.SubItems.Add(item.Amount1.ToString());
                listviewitem.SubItems.Add(item.TotalPrice1.ToString());
                TotalRevenue += item.TotalPrice1;
                listView_Revenue.Items.Add(listviewitem);
            }
            textBox_TotalRevenue.Text = TotalRevenue.ToString();
        }
        void LoadListOrderPerYear()
        {
            listView_Revenue.Items.Clear();

            List<OrderInforDT> listBillInfor = OrderDA.Instance.getListOrderPerYear(dateTimePicker1.Value);
            int TotalRevenue = 0;
            foreach (OrderInforDT item in listBillInfor)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listviewitem.SubItems.Add(item.Amount1.ToString());
                listviewitem.SubItems.Add(item.TotalPrice1.ToString());
                TotalRevenue += item.TotalPrice1;
                listView_Revenue.Items.Add(listviewitem);
            }
            textBox_TotalRevenue.Text = TotalRevenue.ToString();
        }
        private void button_SearchAccount_Click(object sender, EventArgs e)
        {
            listView_Beverages.Items.Clear();
            List<MenuDT> newMenu = MenuDA.Instance.SearchBeveragesByName(textBox_SearchBeverages.Text);
            foreach (MenuDT item in newMenu)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listView_Beverages.Items.Add(listviewitem);
            }
        }

        private void listView_Beverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView_Beverages.SelectedItems)
            {
                textBox_NameBeverage.Text = items.SubItems[0].Text;
                textBox_Price.Text = items.SubItems[1].Text;
                textBox_BeverID.Text = MenuDA.Instance.getIDByBeveragesName(items.SubItems[0].Text).ToString();
            }
        }


        private void button_AddBeverage_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Name = textBox_NameBeverage.Text;
                int Price = int.Parse(textBox_Price.Text);
                bool checkBeverages = MenuDA.Instance.CheckExistBeverages(Name);
                if (checkBeverages)
                {
                    MessageBox.Show("Đồ uống đã tồn tại" , "Thông Báo");
                }
                else
                {
                    MenuDA.Instance.AddBeverages(Name, Price);
                    textBox_BeverID.Clear();
                    textBox_NameBeverage.Clear();
                    textBox_Price.Clear();
                    LoadListBeverages();
                    MessageBox.Show("Thêm đồ uống thành công", "Thông Báo");
                }

            }
            catch
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin đồ uống mà bạn muốn thêm", "Thông Báo");
            }
        }

        private void button_DeleteBeverage_Click(object sender, EventArgs e)
        {
            try
            {
                int BeverID = int.Parse(textBox_BeverID.Text);
                MenuDA.Instance.DeleteBeverage(BeverID);
                textBox_BeverID.Clear();
                textBox_NameBeverage.Clear();
                textBox_Price.Clear();
                LoadListBeverages();
                MessageBox.Show("Xóa đồ uống thành công", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Hãy chọn đồ uống mà bạn muốn xóa" , "Thông Báo");
            }
        }

        private void button_UpdateBeverage_Click(object sender, EventArgs e)
        {
            try
            {
                int BeverID = int.Parse(textBox_BeverID.Text);
                string Name = textBox_NameBeverage.Text;
                int Price = int.Parse(textBox_Price.Text);
                MenuDA.Instance.UpdateBeverage(Name, Price, BeverID);
                textBox_BeverID.Clear();
                textBox_NameBeverage.Clear();
                textBox_Price.Clear();
                LoadListBeverages();
                MessageBox.Show("Sửa đồ uống thành công", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Hãy chọn đồ uống mà bạn muốn sửa", "Thông Báo");
            }
        }

        private void button_AddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_UserName.Text) || string.IsNullOrEmpty(textBox_Password.Text) || string.IsNullOrEmpty(textBox_DisplayName.Text))
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin tài khoản bạn muốn thêm" , "Thông báo");
                }
                else {
                    string UserName = textBox_UserName.Text;
                    string Password = textBox_Password.Text;
                    string NameDisplay = textBox_DisplayName.Text;
                    int Type = int.Parse(textBox_Type.Text);
                    AccountDA.Instance.CreateAccount(UserName, Password, NameDisplay, Type);
                    textBox_UserName.Clear();
                    textBox_Password.Clear();
                    textBox_DisplayName.Clear();
                    LoadListAccount();
                    MessageBox.Show("Thêm tài khoản thành công" , "Thông báo");
                }
                
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Hãy thử lại" , "Thông Báo");
            }
        }
        private void button_DeleteAccount_Click(object sender, EventArgs e)
        {

            string UserName = textBox_UserName.Text;
            bool checkAccount = AccountDA.Instance.CheckExistAccount(textBox_UserName.Text);
            if(checkAccount) {
                AccountDA.Instance.DeleteAccount(UserName);
                textBox_UserName.Clear();
                textBox_Password.Clear();
                textBox_DisplayName.Clear();
                LoadListAccount();
                MessageBox.Show("Xóa tài khoản thành công" , "Thông báo");
            }
            else if (string.IsNullOrEmpty(textBox_UserName.Text))
            {
                MessageBox.Show("Hãy chọn tài khoản mà bạn muốn xóa", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Tài khoản mà bạn muốn xóa không tồn tại", "Thông Báo");
            }
        }
        private void button_UpdateAccount_Click(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text;
            string Password = textBox_Password.Text;
            string NamDisplay = textBox_DisplayName.Text;
            bool checkAccount = AccountDA.Instance.CheckExistAccount(textBox_UserName.Text);
            if (checkAccount)
            {
                AccountDA.Instance.UpdateAccount(UserName, Password, NamDisplay);
                textBox_UserName.Clear();
                textBox_Password.Clear();
                textBox_DisplayName.Clear();
                LoadListAccount();
                MessageBox.Show("Sửa tài khoản thành công", "Thông báo");
            }
            else if(string.IsNullOrEmpty(textBox_UserName.Text))
            {
                MessageBox.Show("Hãy chọn tài khoản mà bạn muốn sửa", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Tài khoản bạn muốn sửa không tồn tại", "Thông Báo");
            }
        }
        private void button_Day_Click(object sender, EventArgs e)
        {
            LoadListOrderPerDay();
        }
        private void button_Month_Click(object sender, EventArgs e)
        {
            LoadListOrderPerMonth();
        }
        private void button_Year_Click(object sender, EventArgs e)
        {
            LoadListOrderPerYear();
        }
        private void listView_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView_Account.SelectedItems)
            {
                textBox_UserName.Text = items.SubItems[0].Text;
                textBox_DisplayName.Text = items.SubItems[1].Text;
                textBox_Type.Text = items.SubItems[2].Text;
                textBox_Password.Text = AccountDA.Instance.getPasswordByUserName(textBox_UserName.Text);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
