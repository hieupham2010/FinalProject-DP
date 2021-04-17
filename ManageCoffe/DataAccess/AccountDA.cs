using ManageCoffe.DAO;
using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccessLayer
{
    public class AccountDA
    {
        private static AccountDA instance;
        public static AccountDA Instance
        {
            get { if (instance == null) instance = new AccountDA(); return instance; }
            private set { instance = value; }
        }
        private AccountDA() { }
        public bool Login(string UserName , string Password)
        {
            String query = "SELECT * FROM Account WHERE UserName = '"+ UserName +"' AND PassWord = '"+ Password +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public AccountDT getAccountByUserName(string UserName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE UserName = '" + UserName + "'");
            foreach(DataRow item in data.Rows)
            {
                return new AccountDT(item);
            }
            return null;
        }
        public List<AccountDT> getListAccount()
        {
            string query = "SELECT * FROM Account WHERE TypeAccount = 1";
            List<AccountDT> listAccount = new List<AccountDT>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                AccountDT account = new AccountDT(item);
                listAccount.Add(account);
            }
            return listAccount;
        }
        public string getPasswordByUserName(string UserName)
        {
            string query = "SELECT * FROM Account WHERE UserName = '" + UserName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new AccountDT(item).Password1;
            }
            return null;
        }
        public void CreateAccount(string UserName , string Password , string NameDisplay , int Type)
        {
            string query = string.Format("INSERT Account VALUES('{0}' , '{1}' , N'{2}' , {3})", UserName, Password, NameDisplay, Type);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteAccount(string UserName)
        {
            string query = "DELETE Account WHERE UserName = '" + UserName + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void UpdateAccount(string UserName , string Password , string NameDisplay)
        {
            string query = "UPDATE Account SET PassWord = '" + Password + "' , NameDisplay = '" + NameDisplay + "' WHERE UserName = '" + UserName + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckExistAccount(string UserName)
        {
            string query = "SELECT * FROM Account WHERE UserName = '" + UserName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count >= 1;
        }
    }
}
