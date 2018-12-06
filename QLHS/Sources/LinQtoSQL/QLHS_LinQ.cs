using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoSQL
{
    public class QLHS_LinQ
    {
        QLHSDataContext qlhs = new QLHSDataContext();
        //Lưu thay đổi
        public void SAVE()
        {
            qlhs.GetChangeSet();
            qlhs.SubmitChanges();
        }
        //Giáo viên
        public List<GIAOVIEN> loadGV()
        {
            return qlhs.GIAOVIENs.Select(t => t).ToList<GIAOVIEN>();
        }
        public void themGv(GIAOVIEN kh)
        {
            qlhs.GIAOVIENs.InsertOnSubmit(kh);
        }
        public void suaGV(GIAOVIEN gv)
        {
            GIAOVIEN gv1 = qlhs.GIAOVIENs.Where(t => t.MAGIAOVIEN == gv.MAGIAOVIEN).FirstOrDefault();
            if (gv1 != null)
            {
                gv1.HOTEN = gv.HOTEN;
                gv1.NGAYSINH = gv.NGAYSINH;
                gv1.MAMON = gv.MAMON;
                gv1.GIOITINH = gv.GIOITINH;
                gv1.SODIENTHOAI = gv.SODIENTHOAI;
                gv1.DIACHI = gv.DIACHI;
            }
        }
        public void xoaGV(string magv)
        {
            GIAOVIEN l = qlhs.GIAOVIENs.Where(t => t.MAGIAOVIEN == magv).FirstOrDefault();
            if (l != null)
            {
                qlhs.GIAOVIENs.DeleteOnSubmit(l);
            }
        }
        public bool kt_pkey_gv(string magv)
        {
            GIAOVIEN l = qlhs.GIAOVIENs.Where(t => t.MAGIAOVIEN == magv).FirstOrDefault();
            if (l != null)
            {
                return true;
            }
            return false;
        }
        //Học sinh
        //Môn học
        public List<MONHOC> loadMH()
        {
            return qlhs.MONHOCs.Select(t => t).ToList<MONHOC>();
        }
        //Kết quả
        //Mã tự động
        public int autogv()
        {
            int kq = 0;
            List<GIAOVIEN> lst = qlhs.GIAOVIENs.Select(t => t).ToList<GIAOVIEN>();
            if (qlhs.GIAOVIENs.Count() != 0)
            {
                GIAOVIEN gv = lst[qlhs.GIAOVIENs.Count() - 1];
                //string[] ma = gv.MAGIAOVIEN.Trim().Split('_');
                string m = gv.MAGIAOVIEN.Substring(2, 5);
                kq += (int.Parse(m) + 1);
            }
            return kq;
        }
        //
    }
}
