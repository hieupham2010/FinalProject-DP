using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransferObject
{
    public interface IMenuBuilder
    {
        IMenuBuilder SetBeverId(int BeverID);

        IMenuBuilder SetName(string Name);

        IMenuBuilder SetPrice(int Price);

        MenuDT Build();
    }
}
