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
        private OrderDA order;
        public DeleteOrderCommand(OrderDA order, int BeverId, int IdBill)
        {
            this.order = order;
            this.BeverId = BeverId;
            this.IdBill = IdBill;
        }
        public void execute()
        {
            order.DeleteBeverageFromOrder(BeverId, IdBill);
        }
    }
}
