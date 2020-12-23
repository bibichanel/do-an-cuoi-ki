using Do_AN_Cuoi_Ki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_AN_Cuoi_Ki.DAO
{
    class InfomationDAO
    {
        private static InfomationDAO instance;

        internal static InfomationDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new InfomationDAO();
                return InfomationDAO.instance;
            }
            private set => instance = value;
        }
        private InfomationDAO() { }
        public List<Infomation> LoadCTHDList()
        {
            List<Infomation> InfomationList = new List<Infomation>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT* FROM INFORMATION");
            foreach (DataRow item in data.Rows)
            {
                Infomation Info = new Infomation(item);
                InfomationList.Add(Info);
            }
            return InfomationList;
        }
        public bool InsertInfomationPerson(string MSSV, string HoTen, string NgaySinh)
        {
            string query = string.Format("INSERT dbo.INFORMATION VALUES ( '{0}', '{1}', {2})",
                                                                MSSV, HoTen, NgaySinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
