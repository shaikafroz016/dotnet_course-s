using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using udemy1.Models;
using udemy1.ViewModel;

namespace udemy1.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Course
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult c_show()
        {
           var cour= db.Courses.ToList();
            return View(cour);
        }
        //public ActionResult c_details(int id, string name, string catg)//Courses/c_details/1 here 1 is mapped automatically to the id parameter
        //{
        //    uwcViewModel model = new uwcViewModel();
        //    var obj = new Course { Id = id, name =/*model.courses[1].name.ToString(),*/name, catg = catg };
        //    return Content(obj.Id.ToString() + " " + obj.name + " " + obj.catg);
        //}
        public ActionResult c_details(int Id)
        {
            var course = db.Courses.Find(Id);
            var cs = course.Id + course.name + course.catg;
            return Content(cs.ToString());
            
        }
        //private IEnumerable<Course> getrec()
        //{
        //    return new List<Course>
        //    {
        //        new Course{Id=1001,name="java",catg="dev",Discription="awesme course"},//hardcoded list
        //        new Course{Id=1002,name="C++",catg="dev",Discription="awesme course"},
                
        //    };
        //}
        public ActionResult crsdetail(int? index, string name, string sk)//? means it is nullable. It is a opetional(action) parameter we can write as many parameter as we want in a function it will get mapped automatically. if we want custome routing we need to add routing config in order to map
        {
            if (!index.HasValue)
            {
                index = 1;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "name";
            }
            if (string.IsNullOrWhiteSpace(sk))
            {
                sk = "sk";
            }
            string st = "index=" + index.ToString() + "sortby=" + name + "course=" + sk;
            return Content(st);
        }
        [Route("Courses/coursebycat/{catgeoryname}")]
        public ActionResult coursebycat(string catgeoryname) //created mannual route i.e Courses/coursebycat/webdev
        {
            Course c = new Course();
            c.catg = catgeoryname;
            c.name = "webdevlepment";
            c.Id = 10023;
            return View(c);
        }
        [Route("userdetails/{name}/{id}")]//it is a test custom route to check userdeatils without course main route
        public ActionResult userdetals(string name, int? id)
        {


            string str = "name=" + name + " id= " + id;
            return Content(str);
        }
    }
}