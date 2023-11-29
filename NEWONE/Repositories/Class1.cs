﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using NEWONE.Model;
using NEWONE.Utils;

namespace NEWONE.Repositories
{
    internal class UserInfo
    {
        DBSysProjEntities1 db;
        CombinedView CV = new CombinedView();
        

        public UserInfo()
        {
            db = new DBSysProjEntities1();
        }
        public List<CombinedView> combinedViews1()
        {
            using (db = new DBSysProjEntities1())
            {
                return db.CombinedView.ToList();
            }
        }

        public List<vw_ViewPsits> vw_ViewPsits()
        {
            using (db = new DBSysProjEntities1())
            {
                return db.vw_ViewPsits.ToList();
            }
        }
        public ErrorCode DeletePsitsUsingStoredProf(int sId, ref String szResponse)
        {
            using (db = new DBSysProjEntities1())
            {
                try
                {
                    db.sp_DeletePsits(sId);
                    szResponse = "Deleted";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
                

                  
            }
        }
    }

}
