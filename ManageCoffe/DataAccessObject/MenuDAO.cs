using ManageCoffe.DAO;
using ManageCoffe.DataAccessObject;
using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccess
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }

        public List<MenuDTO> GetAll()
        {
            string query = "SELECT * FROM Beverages";
            List<MenuDTO> listMenu = new List<MenuDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<MenuDTO> SearchBeveragesByName(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name LIKE N'%" + Name + "%'";
            List<MenuDTO> listMenu = new List<MenuDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public int GetIdFromSelectedTextbox(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name = N'" + Name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new MenuDTO(item).BeverID1;
            }
            return -1;
        }
        public void Create(MenuDTO menu)
        {
            string query = "INSERT Beverages VALUES(N'" + menu.Name1 + "'," + menu.Price1 + ")";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void Delete(int BeverID)
        {
            string query = "DELETE Beverages WHERE BeverID = " + BeverID +"";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void Update(MenuDTO menu)
        {
            string query = "UPDATE Beverages SET Name = N'" + menu.Name1 + "', Price = " + menu.Price1 + "WHERE BeverID = " + menu.BeverID1 + "";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckExists(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name = N'" + Name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count >= 1;
        }
        public int GetIDByBeveragesName(string Name)
        {
            string query = "SELECT * FROM Beverages WHERE Name = N'" + Name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new MenuDTO(item).BeverID1;
            }
            return -1;
        }
    }
}
