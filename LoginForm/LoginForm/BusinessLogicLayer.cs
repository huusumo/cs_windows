using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
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

        #endregion
    }
}
