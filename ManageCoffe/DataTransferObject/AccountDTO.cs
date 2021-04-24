using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransfer
{
    public class AccountDTO
    {
        private string UserName;
        private string Password;
        private string NameDisplay;
        private int TypeAccount;
        public AccountDTO(string UserName , string NameDisplay , int TypeAccount , string Password = null)
        {
            this.UserName = UserName;
            this.NameDisplay = NameDisplay;
            this.TypeAccount = TypeAccount;
            this.Password = Password;
        }
        public AccountDTO(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.NameDisplay = row["NameDisplay"].ToString();
            this.TypeAccount = (int)row["TypeAccount"];
            this.Password = row["Password"].ToString();
        }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string DisplayName1 { get => NameDisplay; set => NameDisplay = value; }
        public int Type1 { get => TypeAccount; set => TypeAccount = value; }
    }
}
