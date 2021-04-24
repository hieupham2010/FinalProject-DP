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
    public class BillInforDAO
    {
        private static BillInforDAO instance;
        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return instance; }
            private set { instance = value; }
        }
        private BillInforDAO() { }

        public void CreateBill()
        {
            string query = "INSERT BillInfor(TotalPrice) VALUES(" + 0 +") ";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public int getIDBillInfor()
        {
            string query = "SELECT * FROM BillInfor WHERE IDBill = (SELECT MAX(IDBill) FROM BillInfor)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new BillInforDTO(item).IDBill1;
            }
            return -1;
        }
        public void DeleteBill()
        {
            string query = "DELETE BillInfor WHERE IDBill = (SELECT MAX(IDBill) FROM BillInfor)";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void InsertBillInfor(int TotalPrice , int IDBill)
        {
            string query = "UPDATE BillInfor SET PaymentDate = GETDATE() , TotalPrice = " + TotalPrice + "WHERE IDBill =" + IDBill + "";
            DataProvider.Instance.ExecuteQuery(query);
        }
        
    }
}
