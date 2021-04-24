using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransfer
{
    public class OrderDTO
    {
        private int OrderID;
        private int IDBill;
        private int BeverID;
        private int Amount;
        public OrderDTO(int OrderID , int IDBill , int BeverID , int Amount)
        {
            this.OrderID = OrderID;
            this.IDBill = IDBill;
            this.BeverID = BeverID;
            this.Amount = Amount;
        }
        public int OrderID1 { get => OrderID; set => OrderID = value; }
        public int IDBill1 { get => IDBill; set => IDBill = value; }
        public int BeverID1 { get => BeverID; set => BeverID = value; }
        public int Amount1 { get => Amount; set => Amount = value; }
        public OrderDTO(DataRow row)
        {
            this.OrderID = (int)row["OrderID"];
            this.IDBill = (int)row["IDBill"];
            this.BeverID = (int)row["BeverID"];
            this.Amount = (int)row["Amount"];
        }
        
    }
}
