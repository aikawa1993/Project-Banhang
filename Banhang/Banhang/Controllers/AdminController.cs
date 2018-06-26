using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Banhang.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult ManagerAccount()
        {
            ViewBag.User = this.Session["User"];
            return View();
        }
        public ActionResult ManagerCustomer()
        {
            ViewBag.User = this.Session["User"];
            return View();
        }
        public ActionResult ManagerOrder()
        {
            ViewBag.User = this.Session["User"];
            return View();
        }
        public ActionResult ManagerProduct()
        {
            ViewBag.User = this.Session["User"];
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            //    using (LittlePrinceBakeryDataContext db = new LittlePrinceBakeryDataContext())
            //    {
            //        var v = db.Staffs.Where(a => a.StaffID.Equals(username) && a.Password.Equals(pass)).FirstOrDefault();
            //        if (v != null)
            //        {
            //            this.Session["ID"] = v.StaffID;
            //            this.Session["StaffName"] = v.StaffName;
            //            this.Session["Password"] = v.Password;
            //            this.Session["Role"] = v.RoleID;
            //            this.Session["State"] = v.State;
            //            if (v.RoleID.Equals("AD"))
            //                return RedirectToAction("Admin");
            //            else if (v.RoleID.Equals("MS") && v.State.Equals(true))
            //                return RedirectToAction("Index", "ManageOrder");
            //            else if (v.RoleID.Equals("SH") && v.State.Equals(true))
            //                return RedirectToAction("ShIndex", "ManageOrder");
            //            //if (v.RoleID.Equals("AD"))
            //            //    return RedirectToAction("Admin");
            //            //else if (v.RoleID.Equals("MS"))
            //            //    return RedirectToAction("Index", "ManageOrder");
            //            //else if (v.RoleID.Equals("SH"))
            //            //    return RedirectToAction("ShIndex", "ManageOrder");
            //        }
            //    }
            //}
            if (username == "admin" && password == "123456")
            {
                this.Session["User"] = username;
                return RedirectToAction("ManagerAccount", "Admin");
            }
            return RedirectToAction("Error", "Admin");
        }
      
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Login");
        }
    }
}