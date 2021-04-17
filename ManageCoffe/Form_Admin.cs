using ManageCoffe.DataAccess;
using ManageCoffe.DataAccessLayer;
using ManageCoffe.DataTransfer;
using ManageCoffe.DataTransferObject;
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
            List<MenuDT> menuList = MenuDA.Instance.GetAll();
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
            List<AccountDT> listAccount = AccountDA.Instance.GetAll();
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
            List<OrderInforDT> listBillInfor = OrderDA.Instance.GetListOrderPerDay(Date);
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
            
            List<OrderInforDT> listBillInfor = OrderDA.Instance.GetListOrderPerMonth(dateTimePicker1.Value, dateTimePicker1.Value);
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

            List<OrderInforDT> listBillInfor = OrderDA.Instance.GetListOrderPerYear(dateTimePicker1.Value);
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
                textBox_BeverID.Text = MenuDA.Instance.GetIDByBeveragesName(items.SubItems[0].Text).ToString();
            }
        }


        private void button_AddBeverage_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Name = textBox_NameBeverage.Text;
                int Price = int.Parse(textBox_Price.Text);
                bool checkBeverages = MenuDA.Instance.CheckExists(Name);
                if (checkBeverages)
                {
                    MessageBox.Show("Đồ uống đã tồn tại" , "Thông Báo");
                }
                else
                {
                    IMenuBuilder menu = new MenuBuilder().SetName(Name).SetPrice(Price);
                    MenuDA.Instance.Create(menu.Build());
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
                MenuDA.Instance.Delete(BeverID);
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
                IMenuBuilder menu = new MenuBuilder().SetBeverId(BeverID).SetName(Name).SetPrice(Price);
                MenuDA.Instance.Update(menu.Build());
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
                    IAccountBuilder account = new AccountBuilder().SetUserName(UserName).SetPassword(Password).SetDisplayName(NameDisplay).SetTypeAccount(Type);
                    AccountDA.Instance.Create(account.Build());
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
            bool checkAccount = AccountDA.Instance.CheckExists(textBox_UserName.Text);
            if(checkAccount) {
                AccountDA.Instance.Delete(UserName);
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
            string NameDisplay = textBox_DisplayName.Text;
            bool checkAccount = AccountDA.Instance.CheckExists(textBox_UserName.Text);
            if (checkAccount)
            {
                IAccountBuilder account = new AccountBuilder().SetUserName(UserName).SetPassword(Password).SetDisplayName(NameDisplay);
                AccountDA.Instance.Update(account.Build());
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
