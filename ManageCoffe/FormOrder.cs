using ManageCoffe.DAO;
using ManageCoffe.DataAccess;
using ManageCoffe.DataAccessObject;
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
    public partial class FormOrder : Form
    {
        private AccountDT loginAccount;
        private OrderDA orderDa = new OrderDA();
        public FormOrder(AccountDT acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            Load();
        }
        void Load()
        {
            LoadMenuBeverages();
            
        }
        void changeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 0;
            tàiKhoảnToolStripMenuItem.Text += "(" + loginAccount.DisplayName1 + ")";
        }
        public AccountDT LoginAccount {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.Type1); }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadMenuBeverages()
        {
            listView_Menu.Items.Clear();
            List<MenuDT> menuList = MenuDA.Instance.GetAll();
            foreach(MenuDT item in menuList)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listView_Menu.Items.Add(listviewitem);
            }
        }
        void LoadOrderList()
        {
            
            List<OrderInforDT> orderList = orderDa.GetListOrder();
            int totalPrice = 0;
            foreach(OrderInforDT item in orderList)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listviewitem.SubItems.Add(item.Amount1.ToString());
                listviewitem.SubItems.Add(item.TotalPrice1.ToString());
                totalPrice += item.TotalPrice1;
                listView_Order.Items.Add(listviewitem);
            }
            textBox_TotalPrice.Text = totalPrice.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button_FindBeverages_Click(object sender, EventArgs e)
        {
            listView_Menu.Items.Clear();
            List<MenuDT> newMenu = MenuDA.Instance.SearchBeveragesByName(textBox_FindBeverages.Text);
            foreach (MenuDT item in newMenu)
            {
                ListViewItem listviewitem = new ListViewItem(item.Name1);
                listviewitem.SubItems.Add(item.Price1.ToString());
                listView_Menu.Items.Add(listviewitem);
            }
        }
        private void button_DeleteBeverage_Click(object sender, EventArgs e)
        {
            try
            {
                int BeverID = MenuDA.Instance.GetIdFromSelectedTextbox(textBox_BeverageSelected.Text);
                int IDBill = BillInforDA.Instance.getIDBillInfor();
                ICommand deleteOrder = new DeleteOrderCommand(orderDa, BeverID, IDBill);
                deleteOrder.execute();
                /*orderDa.DeleteBeverageFromOrder(BeverID, IDBill);*/
                if (listView_Order.Items.Count <= 1)
                {
                    listView_Order.Items.Clear();
                    textBox_TotalPrice.Text = "0";
                    BillInforDA.Instance.DeleteBill();
                }
                else
                {
                    listView_Order.Items.Clear();
                    textBox_TotalPrice.Clear();
                    LoadOrderList();
                }
            }
            catch
            {
                MessageBox.Show("Hãy chọn đồ uống cần xóa");
            }

        }
       

        private void button_AddBeverage_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (listView_Order.Items.Count == 0)
                {
                    BillInforDA.Instance.CreateBill();
                    textBox_ExcessCash.Text = "0";
                }
                listView_Order.Items.Clear();
                int IDBill = BillInforDA.Instance.getIDBillInfor();
                int BeverID = MenuDA.Instance.GetIdFromSelectedTextbox(textBox_BeverageSelected.Text);
                bool CheckBeverages = orderDa.CheckExistBeverage(BeverID, IDBill);
                int Amount = (int)numericUpDown_Amount.Value;
                ICommand insertOrder = new InsertOrderCommand(orderDa, BeverID, IDBill, Amount);
                if (CheckBeverages)
                {
                    orderDa.UpdateAmountOrder(Amount, BeverID, IDBill);
                }
                else
                {
                    insertOrder.execute();
                    /*orderDa.InsertOrder(IDBill, BeverID, Amount);*/
                }
                LoadOrderList();
            }
            catch
            {
                MessageBox.Show("Hãy chọn đồ uống cần thêm");
            }
        }
        private void button_Payment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Thanh Toán", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                listView_Order.Items.Clear();
                int TotalPrice = int.Parse(textBox_TotalPrice.Text);
                int IDBill = BillInforDA.Instance.getIDBillInfor();
                BillInforDA.Instance.InsertBillInfor(TotalPrice, IDBill);
                textBox_TotalPrice.Text = "0";
                int ReceiveMoney = int.Parse(textBox_ReceivedMoney.Text);
                int ExcessCash = ReceiveMoney - TotalPrice;
                textBox_ExcessCash.Text = ExcessCash.ToString();
                textBox_ReceivedMoney.Text = "0";
            }
        }
        private void listView_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView_Order.SelectedItems)
            {
                textBox_BeverageSelected.Text = items.SubItems[0].Text;
            }
        }

        private void listView_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView_Menu.SelectedItems)
            {
                textBox_BeverageSelected.Text = items.SubItems[0].Text;
            }
        }

        private void textBox_TotalPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Admin fa = new Form_Admin();
            fa.ShowDialog();
        }
    }
}
