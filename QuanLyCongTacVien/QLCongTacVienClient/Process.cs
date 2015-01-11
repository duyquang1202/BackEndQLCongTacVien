using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    public class Process
    {
        private static Process Instance = null;
        public static QLCongTacVienEntities context;
        public  Process()
        {
           
        }

        public static Process getInstance()
        {
            context = new QLCongTacVienEntities();
            if (Instance == null)
            {
                return Instance = new Process();
            }
            return Instance;
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
