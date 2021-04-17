using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccess
{
    public interface IOrder
    {
        void InsertOrder(int IDBill, int BeverID, int Amount);

        void DeleteBeverageFromOrder(int BeverID, int IDBill);

        bool CheckExistBeverage(int BeverID, int IDBill);

        void UpdateAmountOrder(int Amount, int BeverID, int IDBill);

        List<OrderInforDT> GetListOrder();
        List<OrderInforDT> GetListOrderPerMonth(DateTime Month, DateTime Year);
        List<OrderInforDT> GetListOrderPerYear(DateTime Year);
    }
}
