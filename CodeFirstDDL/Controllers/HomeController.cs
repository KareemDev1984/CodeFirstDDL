using CodeFirstDDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstDDL.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var states = db.States.ToList();
            List<SelectListItem> selectList = new List<SelectListItem>();
            foreach (var item in states)
            {
                selectList.Add(new SelectListItem
                {
                    Text = item.StateName,
                    Value = item.StateID.ToString()
                });
            }
            ViewBag.StateId = selectList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            //var states = db.States.ToList();
            //List<SelectListItem> selectList = new List<SelectListItem>();
            //foreach (var item in states)
            //{
            //    selectList.Add(new SelectListItem
            //    {
            //        Text = item.StateName,
            //        Value = item.StateID.ToString()
            //    });
            //}
            //ViewBag.StateId = selectList;
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
            }



            return RedirectToAction("Create");
        }

    }
}