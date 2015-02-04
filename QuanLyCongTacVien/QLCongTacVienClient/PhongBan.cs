using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class PhongBan : Process
    {
      

        public List<tblPhongBan> LoadDSPhongBan()
        {
            try
            {
                return context.tblPhongBans.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblPhongBan>();
            }
        }

        public bool ThemPhongBan(tblPhongBan obj)
        {
            try
            {
                context.tblPhongBans.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatPhongBan(tblPhongBan obj)
        {
            try
            {
                var result = context.tblPhongBans.Where(x => x.MaPhongBan.Equals(obj.MaPhongBan)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
              
                result.TenPhongBan = obj.TenPhongBan;
                result.GhiChuPhongBan = obj.GhiChuPhongBan;
                result.TrangThai = obj.TrangThai;
                result.UserUpdate = obj.UserUpdate;
                result.MoTaPhongBan = obj.MoTaPhongBan;
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaPhongBan(tblPhongBan obj)
        {
            try
            {
                var result = context.tblPhongBans.Where(x => x.MaPhongBan.Equals(obj.MaPhongBan)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblPhongBans.Remove(result);

                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public tblPhongBan getPhongBan(int MaPhongBan)
        {
            try
            {
                var result = context.tblPhongBans.Single(x => x.MaPhongBan == MaPhongBan);
                return result;
            }
            catch (Exception objEX)
            {
                return null;
            }
        }
    }
}
