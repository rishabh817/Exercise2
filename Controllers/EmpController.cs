using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppBranching.Models;

namespace WebAppBranching.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            List<Emp> empList = new List<Emp>
            {
                new Emp{Eid=1,EName="Aditya",EDesig="Manager",EDOJ=DateTime.Parse("12/12/2012")},
                 new Emp{Eid=2,EName="Rahul",EDesig="Developer",EDOJ=DateTime.Parse("12/12/2012")},
                  new Emp{Eid=3,EName="Shruti",EDesig="Designer",EDOJ=DateTime.Parse("12/12/2012")},
                   new Emp{Eid=4,EName="Shivam",EDesig="Developer",EDOJ=DateTime.Parse("12/12/2012")},
                    new Emp{Eid=5,EName="Megha",EDesig="Designer",EDOJ=DateTime.Parse("12/12/2012")}

            };
            return View(empList);
        }
    }
}
