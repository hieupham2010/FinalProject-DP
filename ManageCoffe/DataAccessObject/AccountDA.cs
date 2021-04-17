using ManageCoffe.DAO;
using ManageCoffe.DataAccessObject;
using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccessLayer
{
    public class AccountDA: IDAO<AccountDT>
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
        public List<AccountDT> GetAll()
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
        public void Create(AccountDT account)
        {
            string query = string.Format("INSERT Account VALUES('{0}' , '{1}' , N'{2}' , {3})", account.UserName1, account.Password1, account.DisplayName1, account.Type1);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void Delete(string UserName)
        {
            string query = "DELETE Account WHERE UserName = '" + UserName + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void Update(AccountDT account)
        {
            string query = "UPDATE Account SET PassWord = '" + account.Password1 + "' , NameDisplay = '" + account.DisplayName1 + "' WHERE UserName = '" + account.UserName1 + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckExists(string UserName)
        {
            string query = "SELECT * FROM Account WHERE UserName = '" + UserName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count >= 1;
        }

        public List<AccountDT> Search(string Name)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
