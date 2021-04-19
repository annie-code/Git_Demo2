using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo4_Validation.Models;
namespace Demo4_Validation.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        [HttpGet]
        public ActionResult ValidationIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidationIndex(Employee emp)
        {
            if (ModelState.IsValid)
            {
                ViewBag.status = "Success";
            }
            else
            {
                ViewBag.status = "Fail";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="Name,Age")]Employee emp)
        {
            if (ModelState.IsValid)
            {
                ViewBag.status = "Success";
            }
            else
            {
                ViewBag.status = "Fail";
            }
            return View();
        }
    }
}