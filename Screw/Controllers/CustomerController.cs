using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Screw.Models;

namespace Screw.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        //return customerform 0r routing oroblem

        private MyDBContext _context;

        public CustomerController()
        {
            _context = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult New()
        {
           
            return View("CustomerForm");
        }
        
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Save()
        {
            return View();
        }
    }
}