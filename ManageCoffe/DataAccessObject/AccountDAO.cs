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
    public class AccountDAO: IDAO<AccountDTO>
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public void Create(AccountDTO account)
        {
            string query = string.Format("INSERT Account VALUES('{0}' , '{1}' , N'{2}' , {3})", account.UserName1, account.Password1, account.DisplayName1, account.Type1);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void Delete(string UserName)
        {
            string query = "DELETE Account WHERE UserName = '" + UserName + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void Update(AccountDTO account)
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




        public bool Login(string UserName , string Password)
        {
            String query = "SELECT * FROM Account WHERE UserName = '"+ UserName +"' AND PassWord = '"+ Password +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public AccountDTO getAccountByUserName(string UserName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE UserName = '" + UserName + "'");
            foreach(DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }
        public List<AccountDTO> GetAll()
        {
            string query = "SELECT * FROM Account WHERE TypeAccount = 1";
            List<AccountDTO> listAccount = new List<AccountDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
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
                return new AccountDTO(item).Password1;
            }
            return null;
        }
        
    }
}
