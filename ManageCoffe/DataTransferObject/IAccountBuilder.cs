using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransferObject
{
    public interface IAccountBuilder
    {
        IAccountBuilder SetUserName(string UserName);

        IAccountBuilder SetDisplayName(string DisplayName);

        IAccountBuilder SetTypeAccount(int TypeAccount);

        IAccountBuilder SetPassword(string Password);

        AccountDTO Build();
    }
}
