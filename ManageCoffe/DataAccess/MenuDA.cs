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
    public class MenuDA
    {
        private static MenuDA instance;
        public static MenuDA Instance
        {
            get { if (instance == null) instance = new MenuDA(); return instance; }
            private set { instance = value; }
        }
        private MenuDA() { }

        public List<MenuDT> getListBeveragesToMenu()
        {
            string query = "SELECT * FROM Beverages";
            List<MenuDT> listMenu = new List<MenuDT>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                MenuDT menu = new MenuDT(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<MenuDT> SearchBeveragesByName(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name LIKE N'%" + Name + "%'";
            List<MenuDT> listMenu = new List<MenuDT>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDT menu = new MenuDT(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public int getIdFromSelectedTextbox(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name = N'" + Name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new MenuDT(item).BeverID1;
            }
            return -1;
        }
        public void AddBeverages(string Name , int Price)
        {
            string query = "INSERT Beverages VALUES(N'" + Name + "'," + Price + ")";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteBeverage(int BeverID)
        {
            string query = "DELETE Beverages WHERE BeverID = " + BeverID +"";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void UpdateBeverage(string Name , int Price , int BeverID)
        {
            string query = "UPDATE Beverages SET Name = N'" + Name + "', Price = " + Price + "WHERE BeverID = " + BeverID + "";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckExistBeverages(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name = N'" + Name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count >= 1;
        }
        public int getIDByBeveragesName(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name = N'" + Name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new MenuDT(item).BeverID1;
            }
            return -1;
        }
    }
}
