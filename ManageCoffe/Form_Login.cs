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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text;
            string Password = textBox_Password.Text;
            if (CheckLogin(UserName , Password))
            {
                AccountDTO loginAccount = AccountDAO.Instance.getAccountByUserName(UserName);
                FormOrder fo = new FormOrder(loginAccount);
                fo.Hide();
                fo.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        public bool CheckLogin(string UserName , string Password)
        {
            return AccountDAO.Instance.Login(UserName , Password);
        }
    }
}
