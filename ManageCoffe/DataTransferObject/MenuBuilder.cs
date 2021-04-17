using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransferObject
{
    public class MenuBuilder : IMenuBuilder

    {
        private int BeverId;
        private string Name;
        private int Price;
        public MenuDT Build()
        {
            return new MenuDT(BeverId, Name, Price);
        }

        public IMenuBuilder SetBeverId(int BeverId)
        {
            this.BeverId = BeverId;
            return this;
        }

        public IMenuBuilder SetName(string Name)
        {
            this.Name = Name;
            return this;
        }

        public IMenuBuilder SetPrice(int Price)
        {
            this.Price = Price;
            return this;
        }
    }
}
