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
        public List<Infomation> LoadInfoList()
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
            string query = string.Format("INSERT dbo.INFORMATION VALUES ( '{0}', N'{1}', '{2}')",
                                                                MSSV, HoTen, NgaySinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Infomation SearchEmployee(string MSSV)
        {
            Infomation Info = new Infomation();
            Info.MSSV = MSSV;
            List<Infomation> InfoList = InfomationDAO.Instance.LoadInfoList();
            foreach (Infomation item in InfoList)
            {
                if (Info.MSSV == item.MSSV)
                {
                    Info.HoTen = item.HoTen;
                    Info.NgaySinh = item.NgaySinh;
                }
            }
            return Info;
        }
    }
}
