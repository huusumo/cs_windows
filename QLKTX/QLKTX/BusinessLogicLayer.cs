using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class BusinessLogicLayer
    {
        DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        #region FormDN

        public bool CheckTK(TaiKhoan tk)
        {
            return DAL.CheckTK(tk);
        }

        #endregion

        #region FormQLKN

        public DataTable GetAllKN()
        {
            return DAL.GetAllKN();
        }

        public bool ThemKN(KhuNha kn)
        {
            return DAL.ThemKN(kn);
        }

        public bool SuaKN(KhuNha kn)
        {
            return DAL.SuaKN(kn);
        }

        public bool XoaKN(KhuNha kn)
        {
            return DAL.XoaKN(kn);
        }

        public DataTable TimKN(string key)
        {
            return DAL.TimKN(key);
        }

        public bool XoaAllKN()
        {
            return DAL.XoaAllKN();
        }

        #endregion

        #region FormPhong

        public DataTable GetAllPhong()
        {
            return DAL.GetAllPhong();
        }

        public bool ThemPhong(Phong phg)
        {
            return DAL.ThemPhong(phg);
        }

        public bool SuaPhong(Phong phg)
        {
            return DAL.SuaPhong(phg);
        }

        public bool XoaPhong(Phong phg)
        {
            return DAL.XoaPhong(phg);
        }

        public DataTable TimPhong(string key)
        {
            return DAL.TimPhong(key);
        }

        public bool XoaAllPhong()
        {
            return DAL.XoaAllPhong();
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
