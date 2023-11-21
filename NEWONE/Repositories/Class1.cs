using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using NEWONE.Model;

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

    }

}
