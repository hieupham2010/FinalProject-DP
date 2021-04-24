using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransferObject
{
    public class AccountBuilder : IAccountBuilder
    {
        private string UserName;
        private string Password;
        private string NameDisplay;
        private int TypeAccount;
        public AccountDTO Build()
        {
            return new AccountDTO(UserName, NameDisplay, TypeAccount, Password);
        }

        public IAccountBuilder SetDisplayName(string NameDisplay)
        {
            this.NameDisplay = NameDisplay;
            return this;
        }

        public IAccountBuilder SetPassword(string Password)
        {
            this.Password = Password;
            return this;
        }

        public IAccountBuilder SetTypeAccount(int TypeAccount)
        {
            this.TypeAccount = TypeAccount;
            return this;
        }

        public IAccountBuilder SetUserName(string UserName)
        {
            this.UserName = UserName;
            return this;
        }
    }
}
