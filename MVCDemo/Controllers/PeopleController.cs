using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            /*personModel p = new personModel();
            int i = 5 / p.age;*/

            return View();
        }

        public ActionResult ListPeople()
        {
            List<personModel> people = new List<personModel>();
            people.Add(new personModel { FirstName = "Patrick", LastName = "Brown", age = 22 });
            people.Add(new personModel { FirstName = "Bruce", LastName = "Wayne", age = 35 });
            people.Add(new personModel { FirstName = "Sarah", LastName = "Sanders", age = 53 });

            return View(people);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}