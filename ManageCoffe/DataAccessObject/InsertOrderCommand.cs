using ManageCoffe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccessObject
{
    public class InsertOrderCommand : ICommand
    {
        private int BeverId;
        private int IdBill;
        private int Amount;
        private OrderDA order;
        public InsertOrderCommand(OrderDA order, int BeverId, int IdBill, int Amount)
        {
            this.order = order;
            this.BeverId = BeverId;
            this.IdBill = IdBill;
            this.Amount = Amount;
        }
        public void execute()
        {
            order.InsertOrder(IdBill, BeverId, Amount);
        }
    }
}
