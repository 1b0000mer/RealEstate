using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstateWebsite.Models;

namespace RealEstateWebsite.Areas.Admin.Models
{
    public class QuitEmployee
    {
        public static void QuitEmp(int idEmp, string Reason)
        {
            using (RealEstateWebsiteEntities db = new RealEstateWebsiteEntities())
            {
                //Quit q = new Quit();
                //q.Employee.Employee_ID = idEmp;
                //q.QuitDate = DateTime.Now;
                //q.Reason = Reason;
                //q.ModifiedDate = DateTime.Now;
                //db.Quits.Add(q);
                //db.SaveChanges();
                db.USP_InsertQuitEmp(idEmp, Reason, DateTime.Now);
            }
        }
    }
}