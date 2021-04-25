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
        private OrderDAO order;
        public InsertOrderCommand(OrderDAO order, int BeverId, int IdBill, int Amount)
        {
            this.order = order;
            this.BeverId = BeverId;
            this.IdBill = IdBill;
            this.Amount = Amount;
        }
        public void Execute()
        {
            order.InsertOrder(IdBill, BeverId, Amount);
        }
    }
}
