using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.DAO.Base
{
    public abstract class daoB
    {
        protected SqlConnection objCon;

        public daoB()
        {
            daoConexion con = new daoConexion();
            objCon = new SqlConnection(con.StringCon);
        } 
    }
}
