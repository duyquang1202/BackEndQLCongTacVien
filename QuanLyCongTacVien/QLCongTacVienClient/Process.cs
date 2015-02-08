using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    public class Process
    {
       
        public  QLCongTacVienEntities context;
        private static Process instance;
        public  Process()
        {
            context = new QLCongTacVienEntities();
        }

        public static Process getInstance()
        {
            if (instance == null)
            {
                return new Process();
            }

            return instance;
        }
     
        public tblUser checkDangNhap(string UserName,string Password)
        {
            try
            {
                var result =  context.tblUsers.Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefault();
                return result;
            }
            catch (Exception objex)
            {
                return null;
            }
        }

        public List<LoaiAccount> getLoaiAccount()
        {
            var lstLoaiAccount = new List<LoaiAccount>();
            lstLoaiAccount.Add(new LoaiAccount() {Value="AD",Name="Admin" });
            lstLoaiAccount.Add(new LoaiAccount() { Value = "QL", Name = "Quản Lý" });
            lstLoaiAccount.Add(new LoaiAccount() { Value = "KT", Name = "Kế Toán" });
            lstLoaiAccount.Add(new LoaiAccount() { Value = "KD", Name = "Kinh Doanh" });
            lstLoaiAccount.Add(new LoaiAccount() { Value = "CTV", Name = "Cộng Tác Viên" });
            return lstLoaiAccount;

        }

        public List<tblGroupPermission> getGroupPermission()
        {
            try
            {
                return context.tblGroupPermissions.ToList();
            }
            catch (Exception obj)
            {
                return new List<tblGroupPermission>();
            }
        }
        public List<tblProduct> loadProduct()
        {
            try
            {
                return context.tblProducts.ToList();
            }
            catch (Exception ex)
            {
                return new List<tblProduct>();
            }
        }
        public List<Category> loadCategory()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception ex)
            {
                return new List<Category>();
            }
        }
        public List<tblAccount> loadAccount()
        {
            try
            {
                return context.tblAccounts.ToList();
            }
            catch (Exception ex)
            {
                return new List<tblAccount>();
            }
        }
        public List<tblKhachHang> loadKhachHang()
        {
            try
            {
                return context.tblKhachHangs.ToList();
            }
            catch (Exception ex)
            {
                return new List<tblKhachHang>();
            }
        }
        public  List<tblOrder_Account> loadOderAccount()
        {
            try
            {
                return context.tblOrder_Account.ToList();
            }
            catch (Exception ex)
            {
                return new List<tblOrder_Account>();
            }
        }
        public bool ThemOrderAccount(tblOrder_Account obj)
        {
            try
            {
                
                var result = context.tblOrder_Account.Where(x => x.AccountID.Equals(obj.AccountID)).FirstOrDefault();
                if (result != null)
                {
                    return false;
                }
                context.tblOrder_Account.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaOrderAccount(tblOrder_Account obj)
        {
            try
            {
                var result = context.tblOrder_Account.Where(x => x.AccountID.Equals(obj.AccountID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblOrder_Account.Remove(result);

                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }
        public bool ThemOrderAccountNhanVienGiaoDich(tblOrder_Account obj)
        {
            try
            {
                
                var result = context.tblOrder_Account.Where(x => x.AccountID.Equals(obj.AccountID)&& x.OrderID.Equals(obj.OrderID)).FirstOrDefault();
                
                if (result != null)
                {
                    return false;
                }
                context.tblOrder_Account.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }
        
        //Group_Permission
        public List<tblGroup_Perrmision> loadGroup_Permission()
        {
            try
            {
                return context.tblGroup_Perrmision.ToList();
            }
            catch (Exception ex)
            {
                return new List<tblGroup_Perrmision>();
            }
        }
        public bool ThemGroup_Permission(tblGroup_Perrmision obj)
        {
            try
            {

                var result = context.tblGroup_Perrmision.Where(x => x.GroupID.Equals(obj.GroupID)).FirstOrDefault();
                if (result != null)
                {
                    return false;
                }
                context.tblGroup_Perrmision.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaGroup_Permission(tblGroup_Perrmision obj)
        {
            try
            {
                var result = context.tblGroup_Perrmision.Where(x => x.GroupID.Equals(obj.GroupID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblGroup_Perrmision.Remove(result);

                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }
        public  bool CheckPermission(long UserID,string PermissionKey)
        {
            try 
            {  
               
               var result1= context.tblUsers.Where(x=>x.MaUser.Equals(UserID)).FirstOrDefault();
               if (result1 == null)
               {
                   return false;
               }
               var group = context.tblGroupPermissions.Where(x => x.GroupID == result1.GroupID).FirstOrDefault();
               if (group == null)

               {
                   return false;
               }
               if (group.Status == 0)
               {
                   return false;
               }
               var count = group.tblGroup_Perrmision.Where(x => x.tblPermission.PermissionKey == PermissionKey && x.tblPermission.Status==1).Count();
               if (count <= 0)
               {
                   return false;
               }
                
               return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }
         
    }
}
