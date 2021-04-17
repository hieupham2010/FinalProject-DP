using ManageCoffe.DAO;
using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccess
{
    public class OrderDA
    {
        private static OrderDA instance;
        public static OrderDA Instance
        {
            get { if (instance == null) instance = new OrderDA(); return instance; }
            private set { instance = value; }
        }
        private OrderDA() { }

        public void InsertOrder(int IDBill , int BeverID , int Amount) 
        {
            string query = "INSERT OrderBever VALUES(" + IDBill + "," + BeverID + "," + Amount + ")";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void UpdateAmountOrder(int Amount , int BeverID , int IDBill)
        {
            string query = "UPDATE OrderBever SET Amount = Amount +" + Amount + "WHERE BeverID = " + BeverID + "AND IDBill = " + IDBill + "";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckExistBeverage(int BeverID , int IDBill)
        {
            string query = "SELECT * FROM OrderBever WHERE BeverID = " + BeverID + "AND IDBill = " + IDBill + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count >= 1;
        }
        public void DeleteBeverageFromOrder(int BeverID, int IDBill)
        {
            string query = "DELETE OrderBever WHERE BeverID = " + BeverID + "AND IDBill = " + IDBill + "";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public List<OrderInforDT> getListOrder()
        {
            string query = "EXEC SP_OrderInfor";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<OrderInforDT> OrderList = new List<OrderInforDT>();
            foreach(DataRow item in data.Rows)
            {
                OrderInforDT order = new OrderInforDT(item);
                OrderList.Add(order);
            }
            return OrderList;
        }
        public List<OrderInforDT> getListOrderPerDay(DateTime Date)
        {
            string query = "EXEC SP_TotalRevenuePerDay @Date = '"+ Date +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<OrderInforDT> OrderList = new List<OrderInforDT>();
            foreach (DataRow item in data.Rows)
            {
                OrderInforDT order = new OrderInforDT(item);
                OrderList.Add(order);
            }
            return OrderList;
        }
        public List<OrderInforDT> getListOrderPerMonth(DateTime Month , DateTime Year)
        {
            string query = "EXEC SP_TotalRevenuePerMonth @Month = '" + Month + "' , @Year = '"+ Year +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<OrderInforDT> OrderList = new List<OrderInforDT>();
            foreach (DataRow item in data.Rows)
            {
                OrderInforDT order = new OrderInforDT(item);
                OrderList.Add(order);
            }
            return OrderList;
        }
        public List<OrderInforDT> getListOrderPerYear(DateTime Year)
        {
            string query = "EXEC SP_TotalRevenuePerYear @Year = '" + Year + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<OrderInforDT> OrderList = new List<OrderInforDT>();
            foreach (DataRow item in data.Rows)
            {
                OrderInforDT order = new OrderInforDT(item);
                OrderList.Add(order);
            }
            return OrderList;
        }

    }
}
