using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoSQL
{
    public class QLHV_LinQ
    {
    //    QLHVDataContext qlhv = new QLHVDataContext();
    //    //Lưu thay đổi
    //    public void SAVE()
    //    {
    //        qlhv.SubmitChanges();
    //    }
    //    //Khóa học
    //    public List<KHOAHOC> loadKhoa()
    //    {
    //        return qlhv.KHOAHOCs.Select(t => t).ToList<KHOAHOC>();
    //    }
    //    public void themKhoa(KHOAHOC kh)
    //    {
    //        qlhv.KHOAHOCs.InsertOnSubmit(kh);
    //    }
    //    public void suaKhoa(KHOAHOC kh)
    //    {
    //        KHOAHOC l1 = qlhv.KHOAHOCs.Where(t => t.MAKHOAHOC == kh.MAKHOAHOC).FirstOrDefault();
    //        if (l1 != null)
    //        {
    //            l1.TENKHOAHOC = kh.TENKHOAHOC;
    //            l1.NGAYBATDAU = kh.NGAYBATDAU;
    //            l1.NGAYKETTHUC = kh.NGAYKETTHUC;
    //        }
    //    }
    //    public void xoaKhoa(string mak)
    //    {
    //        KHOAHOC l = qlhv.KHOAHOCs.Where(t => t.MAKHOAHOC == mak).FirstOrDefault();
    //        if (l != null)
    //        {
    //            qlhv.KHOAHOCs.DeleteOnSubmit(l);
    //        }
    //    }
    //    public bool kt_pkey_khoa(string mak)
    //    {
    //        KHOAHOC l = qlhv.KHOAHOCs.Where(t => t.MAKHOAHOC == mak).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public bool kt_fkey_khoa(string mak)
    //    {
    //        LOPHOC l = qlhv.LOPHOCs.Where(t => t.MAKHOAHOC == mak).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public string autokh()
    //    {
    //        int kq = 0;
    //        List<KHOAHOC> lst = qlhv.KHOAHOCs.Select(t => t).ToList<KHOAHOC>();
    //        if (qlhv.GIAOVIENs.Count() != 0)
    //        {
    //            KHOAHOC hv = lst[qlhv.KHOAHOCs.Count() - 1];
    //            string[] ma = hv.MAKHOAHOC.Trim().Split('_');
    //            kq += (int.Parse(ma[1]) + 1);
    //        }
    //        return kq.ToString();
    //    }
    //    //Lớp học
    //    public List<LOPHOC> loadLop_Khoa(string mak)
    //    {
    //        return qlhv.LOPHOCs.Where(t => t.MAKHOAHOC == mak).ToList<LOPHOC>();
    //    }
    //    public List<LOPHOC> loadLop()
    //    {
    //        return qlhv.LOPHOCs.Select(t => t).ToList<LOPHOC>();
    //    }
    //    public void themLop(LOPHOC l)
    //    {
    //        qlhv.LOPHOCs.InsertOnSubmit(l);
    //    }
    //    public void suaLop(LOPHOC l)
    //    {
    //        LOPHOC l1 = qlhv.LOPHOCs.Where(t => t.MALOPHOC == l.MALOPHOC && t.MAKHOAHOC == l.MAKHOAHOC).FirstOrDefault();
    //        if (l1 != null)
    //        {
    //            l1.TENLOP = l.TENLOP;
    //            l1.PHONG = l.PHONG;
    //            l1.SISO = l.SISO;
    //            l1.HOCPHI = l.HOCPHI;
    //            l1.NGAYHOC = l.NGAYHOC;
    //            l1.GIOHOC = l.GIOHOC;
    //        }
    //    }
    //    public void xoaLop(string mal)
    //    {
    //        LOPHOC l = qlhv.LOPHOCs.Where(t => t.MALOPHOC == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            qlhv.LOPHOCs.DeleteOnSubmit(l);
    //        }
    //    }
    //    public bool kt_pkey_lop(string mal)
    //    {
    //        LOPHOC l = qlhv.LOPHOCs.Where(t => t.MALOPHOC == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public bool kt_fkey_lop(string mal)
    //    {
    //        HOCVIEN_LOPHOC l = qlhv.HOCVIEN_LOPHOCs.Where(t => t.MALOPHOC == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public string autolop()
    //    {
    //        int kq = 0;
    //        List<LOPHOC> lst = qlhv.LOPHOCs.Select(t => t).ToList<LOPHOC>();
    //        if (qlhv.LOPHOCs.Count() != 0)
    //        {
    //            LOPHOC hv = lst[qlhv.LOPHOCs.Count() - 1];
    //            string[] ma = hv.MALOPHOC.Trim().Split('_');
    //            kq += (int.Parse(ma[1]) + 1);
    //        }
    //        return kq.ToString();
    //    }
    //    //Giáo viên
    //    public List<GIAOVIEN> loadGv()
    //    {
    //        return qlhv.GIAOVIENs.Select(t => t).ToList<GIAOVIEN>();
    //    }
    //    public void themGv(GIAOVIEN kh)
    //    {
    //        qlhv.GIAOVIENs.InsertOnSubmit(kh);
    //    }
    //    public void suaGv(GIAOVIEN gv)
    //    {
    //        GIAOVIEN l1 = qlhv.GIAOVIENs.Where(t => t.MAGV == gv.MAGV).FirstOrDefault();
    //        if (l1 != null)
    //        {
    //            l1.HOTENGV = gv.HOTENGV;
    //            l1.NGAYSINHGV = gv.NGAYSINHGV;
    //            l1.SDTGV = gv.SDTGV;
    //            l1.DIACHIGV = gv.DIACHIGV;
    //        }
    //    }
    //    public void xoaGv(string magv)
    //    {
    //        GIAOVIEN l = qlhv.GIAOVIENs.Where(t => t.MAGV == magv).FirstOrDefault();
    //        if (l != null)
    //        {
    //            qlhv.GIAOVIENs.DeleteOnSubmit(l);
    //        }
    //    }
    //    public bool kt_pkey_gv(string magv)
    //    {
    //        GIAOVIEN l = qlhv.GIAOVIENs.Where(t => t.MAGV == magv).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public string autogv()
    //    {
    //        int kq = 0;
    //        List<GIAOVIEN> lst = qlhv.GIAOVIENs.Select(t => t).ToList<GIAOVIEN>();
    //        if (qlhv.GIAOVIENs.Count() != 0)
    //        {
    //            GIAOVIEN hv = lst[qlhv.GIAOVIENs.Count() - 1];
    //            string[] ma = hv.MAGV.Trim().Split('_');
    //            kq += (int.Parse(ma[1]) + 1);
    //        }
    //        return kq.ToString();
    //    }
    //    //Học viên
    //    public List<HOCVIEN> loadHv()
    //    {
    //        return qlhv.HOCVIENs.Select(t => t).ToList<HOCVIEN>();
    //    }
    //    public void themHv(HOCVIEN kh)
    //    {
    //        qlhv.HOCVIENs.InsertOnSubmit(kh);
    //    }
    //    public void suaHv(HOCVIEN hv)
    //    {
    //        HOCVIEN l1 = qlhv.HOCVIENs.Where(t => t.MASOHV == hv.MASOHV).FirstOrDefault();
    //        if (l1 != null)
    //        {
    //            l1.HOTENHV = hv.HOTENHV;
    //            l1.NGAYSINHHV = hv.NGAYSINHHV;
    //            l1.DIACHIHV = hv.DIACHIHV;
    //            l1.SDTHV = hv.SDTHV;
    //            l1.GIOITINH = hv.GIOITINH;
    //        }
    //    }
    //    public void xoaHv(string mahv)
    //    {
    //        HOCVIEN l = qlhv.HOCVIENs.Where(t => t.MASOHV == mahv).FirstOrDefault();
    //        if (l != null)
    //        {
    //            qlhv.HOCVIENs.DeleteOnSubmit(l);
    //        }
    //    }
    //    public bool kt_pkey_hv(string mahv)
    //    {
    //        HOCVIEN l = qlhv.HOCVIENs.Where(t => t.MASOHV == mahv).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public bool kt_fkey_hv(string mahv)
    //    {
    //        KETQUA l = qlhv.KETQUAs.Where(t => t.MAHV == mahv).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public string autohv()
    //    {
    //        int kq = 0;
    //        List<HOCVIEN> lst = qlhv.HOCVIENs.Select(t => t).ToList<HOCVIEN>();
    //        if (qlhv.HOCVIENs.Count() != 0)
    //        {
    //            HOCVIEN hv = lst[qlhv.HOCVIENs.Count() - 1];
    //            string[] ma = hv.MASOHV.Trim().Split('_');
    //            kq += (int.Parse(ma[1]) + 1);
    //        }
    //        return kq.ToString();
    //    }
    //    //Kết quả
    //    public List<KETQUA> loadKq()
    //    {
    //        return qlhv.KETQUAs.Select(t => t).ToList<KETQUA>();
    //    }
    //    public void themKq(KETQUA kh)
    //    {
    //        qlhv.KETQUAs.InsertOnSubmit(kh);
    //    }
    //    public void suaKq(KETQUA hv)
    //    {
    //        KETQUA l1 = qlhv.KETQUAs.Where(t => t.MAHV == hv.MAHV && t.MALH == hv.MALH).FirstOrDefault();
    //        if (l1 != null)
    //        {
    //            l1.DIEM = hv.DIEM;
    //            l1.XEPLOAI = hv.XEPLOAI;
    //            l1.KETQUA1 = hv.KETQUA1;
    //        }
    //    }
    //    public void xoaKq(string mahv,string mal)
    //    {
    //        KETQUA l = qlhv.KETQUAs.Where(t => t.MAHV == mahv && t.MALH == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            qlhv.KETQUAs.DeleteOnSubmit(l);
    //        }
    //    }
    //    public bool kt_pkey_kq(string mahv, string mal)
    //    {
    //        KETQUA l = qlhv.KETQUAs.Where(t => t.MAHV == mahv && t.MALH == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    //Lịch học
    //    public List<HOCVIEN_LOPHOC> loadLich()
    //    {
    //        return qlhv.HOCVIEN_LOPHOCs.Select(t => t).ToList<HOCVIEN_LOPHOC>();
    //    }
    //    public void themLich(HOCVIEN_LOPHOC kh)
    //    {
    //        qlhv.HOCVIEN_LOPHOCs.InsertOnSubmit(kh);
    //    }
    //    public void suaLich(HOCVIEN_LOPHOC hv)
    //    {
    //        HOCVIEN_LOPHOC l1 = qlhv.HOCVIEN_LOPHOCs.Where(t => t.MASOHV == hv.MASOHV && t.MALOPHOC == hv.MALOPHOC).FirstOrDefault();
    //        if (l1 != null)
    //        {
    //            l1.NGAYHOC = hv.NGAYHOC;
    //            l1.GIOHOC = hv.GIOHOC;
    //        }
    //    }
    //    public void xoaLich(string mahv, string mal)
    //    {
    //        HOCVIEN_LOPHOC l = qlhv.HOCVIEN_LOPHOCs.Where(t => t.MASOHV == mahv && t.MALOPHOC == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            qlhv.HOCVIEN_LOPHOCs.DeleteOnSubmit(l);
    //        }
    //    }
    //    public bool kt_pkey_lich(string mahv, string mal)
    //    {
    //        HOCVIEN_LOPHOC l = qlhv.HOCVIEN_LOPHOCs.Where(t => t.MASOHV == mahv && t.MALOPHOC == mal).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    //Biên lai
    //    public List<BIENLAI> loadBL(string mabl)
    //    {
    //        return qlhv.BIENLAIs.Where(t => t.MASOBL == mabl).ToList<BIENLAI>();
    //    }
    //    public List<BIENLAI> loadBienlai()
    //    {
    //        return qlhv.BIENLAIs.Select(t => t).ToList<BIENLAI>();
    //    }
    //    public void themCTBL(CT_BIENLAI bl)
    //    {
    //        qlhv.CT_BIENLAIs.InsertOnSubmit(bl);
    //    }
    //    public void suaCTBL(CT_BIENLAI bl)
    //    {
    //        CT_BIENLAI bl1 = qlhv.CT_BIENLAIs.Where(t => t.MASOBL == bl.MASOBL).FirstOrDefault();
    //        if (bl1 != null)
    //        {
    //            bl1.MIENGIAM = bl.MIENGIAM;
    //        }
    //    }
    //    public void xoaCTBL(string mbl)
    //    {
    //        CT_BIENLAI bl1 = qlhv.CT_BIENLAIs.Where(t => t.MASOBL == mbl).FirstOrDefault();
    //        if (bl1 != null)
    //        {
    //            qlhv.CT_BIENLAIs.DeleteOnSubmit(bl1);
    //        }
    //    }
    //    public void themBL(BIENLAI bl)
    //    {
    //        qlhv.BIENLAIs.InsertOnSubmit(bl);
    //    }
    //    public void suaBL(BIENLAI bl)
    //    {
    //        BIENLAI bl1 = qlhv.BIENLAIs.Where(t => t.MASOBL == bl.MASOBL).FirstOrDefault();
    //        if (bl1 != null)
    //        {
    //            bl1.THANHTIEN = bl.THANHTIEN;
    //        }
    //    }
    //    public void xoaBL(string mbl)
    //    {
    //        BIENLAI bl1 = qlhv.BIENLAIs.Where(t => t.MASOBL == mbl).FirstOrDefault();
    //        if (bl1 != null)
    //        {
    //            qlhv.BIENLAIs.DeleteOnSubmit(bl1);
    //        }
    //    }
    //    public string malop(string mahv)
    //    {
    //        HOCVIEN_LOPHOC hv = qlhv.HOCVIEN_LOPHOCs.Where(t => t.MASOHV == mahv).FirstOrDefault();
    //        return hv.MALOPHOC.ToString();
    //    }
    //    public float hphi(string mal)
    //    {
    //        LOPHOC l = qlhv.LOPHOCs.Where(t => t.MALOPHOC == mal).FirstOrDefault();
    //        return float.Parse(l.HOCPHI.ToString());
    //    }
    //    public bool kt_pkey_bl(string bl)
    //    {
    //        BIENLAI l = qlhv.BIENLAIs.Where(t => t.MASOBL == bl).FirstOrDefault();
    //        if (l != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public string autobl()
    //    {
    //        int kq = 0;
    //        List<BIENLAI> lst = qlhv.BIENLAIs.Select(t => t).ToList<BIENLAI>();
    //        if (qlhv.BIENLAIs.Count() != 0)
    //        {
    //            BIENLAI hv = lst[qlhv.BIENLAIs.Count() - 1];
    //            string[] ma = hv.MASOBL.Trim().Split('_');
    //            kq += (int.Parse(ma[1]) + 1);
    //        }
    //        return kq.ToString();
    //    }
    //    //Tra cứu học viên
    //    public List<HOCVIEN> danhsachlop(string mal)
    //    {
    //        HOCVIEN_LOPHOC _hv = qlhv.HOCVIEN_LOPHOCs.Where(t => t.MALOPHOC == mal).FirstOrDefault();
    //        return qlhv.HOCVIENs.Where(t => t.MASOHV == _hv.MASOHV).ToList<HOCVIEN>();
    //    }
    //    public object ds_lop(string mal)
    //    {
    //        return from l in qlhv.HOCVIEN_LOPHOCs
    //               where l.MALOPHOC == mal
    //               join hv in qlhv.HOCVIENs on l.MASOHV equals hv.MASOHV
    //               select new { hv.MASOHV, hv.HOTENHV, hv.NGAYSINHHV, hv.SDTHV, hv.DIACHIHV, hv.GIOITINH };
    //    }
    //    public HOCVIEN hocvien(string mahv)
    //    {
    //        HOCVIEN hv = qlhv.HOCVIENs.Where(t => t.MASOHV == mahv).FirstOrDefault();
    //        if (hv != null)
    //            return hv;
    //        return null;
    //    }
    //    public object ds_dat()
    //    {
    //        return from kq in qlhv.KETQUAs where kq.KETQUA1 == "Đủ điều kiện thi"
    //               join hl in qlhv.HOCVIEN_LOPHOCs on kq.MAHV equals hl.MASOHV
    //               join lop in qlhv.LOPHOCs on hl.MALOPHOC equals lop.MALOPHOC
    //               join hv in qlhv.HOCVIENs on hl.MASOHV equals hv.MASOHV
    //               select new {
    //                   kq.DIEM, kq.XEPLOAI, lop.TENLOP, hv.MASOHV, hv.HOTENHV, hv.DIACHIHV, hv.SDTHV, hv.GIOITINH, hv.NGAYSINHHV
    //               };
    //    }
    //    public object bienlai(string ma)
    //    {
    //        return from bl in qlhv.BIENLAIs where bl.MASOBL == ma
    //               join ct in qlhv.CT_BIENLAIs on bl.MASOBL equals ct.MASOBL
    //               join hv in qlhv.HOCVIENs on ct.MAHV equals hv.MASOHV
    //               select new { bl.MASOBL, bl.NGAYLAP, bl.NGUOILAP, bl.THANHTIEN, hv.HOTENHV };
    //    }
    //    public double? diem(string mahv)
    //    {
    //        KETQUA kq = qlhv.KETQUAs.Where(t => t.MAHV == mahv).FirstOrDefault();
    //        if (kq != null)
    //        {
    //            return kq.DIEM;
    //        }
    //        return 0;
    //    }
    }
}
