using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransfer
{
    public class BillInforDTO
    {
        private int IDBill;
        private DateTime PaymentDate;
        private int TotalPrice;

        public int IDBill1 { get => IDBill; set => IDBill = value; }
        public DateTime PaymentDate1 { get => PaymentDate; set => PaymentDate = value; }
        public int TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }

        public BillInforDTO(int IDBill , DateTime PaymentDate , int TotalPrice)
        {
            this.IDBill1 = IDBill;
            this.PaymentDate1 = PaymentDate;
            this.TotalPrice1 = TotalPrice;
        }
        public BillInforDTO(DataRow row)
        {
            this.IDBill1 = (int)row["IDBill"];
            this.PaymentDate1 = (DateTime)row["PaymentDate"];
            this.TotalPrice1 = (int)row["TotalPrice"];
        }
        
    }
}
