using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DapperExample.Models;

namespace DapperExample.Controllers
{
    public class AddMobileController : Controller
    {
        private IRepo _mobileMain;

        public AddMobileController(IRepo mobileMain)
        {
            this._mobileMain = mobileMain;
        }

        // GET: AddMobile
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddMobiles()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMobiles(TBMobileDetails MD)
        {
            //MobileMain mm = new MobileMain(); // No Ninject
            //mm.AddMobile(MD);
            _mobileMain.AddMobile(MD);
            return RedirectToAction("AllMobileList");
        }

        public ActionResult AllMobileList()   
        {
            MobileMain MM = new MobileMain();
            return View(MM.Allmobilelisting().ToList()); 
        }
    }
}