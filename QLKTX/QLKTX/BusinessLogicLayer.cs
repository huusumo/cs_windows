using System;
using System.Collections.Generic;
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
    }
}
