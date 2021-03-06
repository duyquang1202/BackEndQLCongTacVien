﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class Group_Permission:Process
    {
        public List<tblGroup_Perrmision> LoadDSGroup_Permission(int GroupID)
        {
            try
            {
                var objGroup = context.tblGroupPermissions.Find(GroupID);
                if (objGroup == null)
                {
                    return new List<tblGroup_Perrmision>();
                }
                return objGroup.tblGroup_Perrmision.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblGroup_Perrmision>();
            }
        }
        public List<tblPermission> LoadDSPermission()
        {
            try
            {
                return context.tblPermissions.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblPermission>();
            }
        }
        public bool ThemGroup_Permission(tblGroup_Perrmision obj)
        {
            try
            {
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
                var result = context.tblGroup_Perrmision.Where(x => x.PermissionID.Equals(obj.PermissionID)).FirstOrDefault();
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
       
     
    }
}
