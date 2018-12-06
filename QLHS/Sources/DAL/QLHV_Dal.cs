using DAL.DatasetQLHVTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLHV_Dal
    {
        BIENLAITableAdapter bl = new BIENLAITableAdapter();
        CT_BIENLAITableAdapter ct = new CT_BIENLAITableAdapter();
        HOCVIEN_LOPHOCTableAdapter hl = new HOCVIEN_LOPHOCTableAdapter();
        LOPHOCTableAdapter l = new LOPHOCTableAdapter();
        HOCVIENTableAdapter hv = new HOCVIENTableAdapter();
        KETQUATableAdapter kq = new KETQUATableAdapter();
        KHOAHOCTableAdapter kh = new KHOAHOCTableAdapter();
        GIAOVIENTableAdapter gv = new GIAOVIENTableAdapter();

        public DataTable loadBl()
        {
            return bl.GetData();
        }
        public DataTable loadCt()
        {
            return ct.GetData();
        }
        public DataTable loadLop()
        {
            return l.GetData();
        }
        public DataTable loadHV()
        {
            return hv.GetData();
        }
        public DataTable loadGV()
        {
            return gv.GetData();
        }
        public DataTable loadLich()
        {
            return hl.GetData();
        }
        public DataTable loadKq()
        {
            return kq.GetData();
        }
        public DataTable loadKh()
        {
            return kh.GetData();
        }
    }
}
