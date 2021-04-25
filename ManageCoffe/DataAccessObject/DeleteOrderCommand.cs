using ManageCoffe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccessObject
{
    public class DeleteOrderCommand: ICommand
    {
        private int BeverId;
        private int IdBill;
        private OrderDAO order;
        public DeleteOrderCommand(OrderDAO order, int BeverId, int IdBill)
        {
            this.order = order;
            this.BeverId = BeverId;
            this.IdBill = IdBill;
        }
        public void Execute()
        {
            order.DeleteBeverageFromOrder(BeverId, IdBill);
        }
    }
}
