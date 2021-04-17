using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransfer
{
    public class MenuDT
    {
        private int BeverID;
        private string Name;
        private int Price;
        public MenuDT(int BeverID , string Name , int Price)
        {
            this.BeverID = BeverID;
            this.Name = Name;
            this.Price = Price;
        }
        public MenuDT(DataRow row)
        {
            this.BeverID = (int)row["BeverID"];
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
        }

        public int BeverID1 { get => BeverID; set => BeverID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Price1 { get => Price; set => Price = value; }
    }
}
