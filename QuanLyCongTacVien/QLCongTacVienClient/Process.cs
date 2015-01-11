using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    public class Process
    {
       
        public  QLCongTacVienEntities context;
        public  Process()
        {
            context = new QLCongTacVienEntities();
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
    }
}
