using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NEWONE.AppData;
using NEWONE.Utils;

namespace NEWONE.Repositories
{
    internal class UserInfo
    {
        DBSysProjEntities2 db;
        

        public UserInfo()
        {
            db = new DBSysProjEntities2();
        }
        public List<VW_ADMIN3> combinedViews1()
        {
            using (db = new DBSysProjEntities2())
            {
                return db.VW_ADMIN3.ToList();
            }
        }

        public List<VW_PSITS4> vw_ViewPsits()
        {
            using (db = new DBSysProjEntities2())
            {
                return db.VW_PSITS4.ToList();
            }
        }
        public ErrorCode DeletePsitsUsingStoredProf(int sId, ref String szResponse)
        {
            using (db = new DBSysProjEntities2())
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
        public ErrorCode DeleteStudentUsingStoredProf(int sId, ref String szResponse)
        {
            using (db = new DBSysProjEntities2())
            {
                try
                {
                    db.sp_DeleteStudent(sId);
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
