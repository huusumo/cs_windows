using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class BusinessLogicLayer
    {
        DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        #region FormLogin

        public bool CheckTK(TaiKhoan tk)
        {
            return DAL.CheckTK(tk);
        }

        #endregion

        #region FormQLSV

        public DataTable GetAllSV()
        {
            return DAL.GetAllSV();
        }

        public bool ThemSV(SinhVien sv)
        {
            return DAL.ThemSV(sv);
        }

        public bool SuaSV(SinhVien sv)
        {
            return DAL.SuaSV(sv);
        }

        public bool XoaSV(SinhVien sv)
        {
            return DAL.XoaSV(sv);
        }

        public DataTable TimSV(string key)
        {
            return DAL.TimSV(key);
        }

        public bool XoaAllSV()
        {
            return DAL.XoaAllSV();
        }

        #endregion
    }
}
