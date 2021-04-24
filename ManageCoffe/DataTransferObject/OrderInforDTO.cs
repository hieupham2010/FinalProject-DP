using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransfer
{
    public class OrderInforDTO
    {
        private string Name;
        private int Price;
        private int Amount;
        private int TotalPrice;
        public OrderInforDTO(string Name , int Price , int Amount , int TotalPrice)
        {
            this.Name = Name;
            this.Price = Price;
            this.Amount = Amount;
            this.TotalPrice = TotalPrice;
        }
        public OrderInforDTO(DataRow row)
        {
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
            this.Amount = (int)row["Amount"];
            this.TotalPrice = (int)row["TotalPrice"];
        }

        public string Name1 { get => Name; set => Name = value; }
        public int Amount1 { get => Amount; set => Amount = value; }
        public int Price1 { get => Price; set => Price = value; }
        public int TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }
    }
}
