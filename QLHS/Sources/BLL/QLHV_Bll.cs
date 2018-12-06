using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class QLHV_Bll
    {
        QLHV_Dal dal = new QLHV_Dal();

        public DataTable loadBl()
        {
            return dal.loadBl();
        }
        public DataTable loadCt()
        {
            return dal.loadCt();
        }
        public DataTable loadLop()
        {
            return dal.loadLop();
        }
        public DataTable loadHV()
        {
            return dal.loadHV();
        }
        public DataTable loadGV()
        {
            return dal.loadGV();
        }
        public DataTable loadLich()
        {
            return dal.loadLich();
        }
        public DataTable loadKq()
        {
            return dal.loadKq();
        }
        public DataTable loadKh()
        {
            return dal.loadKh();
        }
    }
}
