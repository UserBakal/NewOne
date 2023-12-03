using System;
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
        

        public UserInfo()
        {
            db = new DBSysProjEntities1();
        }
        public List<vw_ViewAdmin1> combinedViews1()
        {
            using (db = new DBSysProjEntities1())
            {
                return db.vw_ViewAdmin1.ToList();
            }
        }

        public List<vw_ViewPsits1> vw_ViewPsits()
        {
            using (db = new DBSysProjEntities1())
            {
                return db.vw_ViewPsits1.ToList();
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
