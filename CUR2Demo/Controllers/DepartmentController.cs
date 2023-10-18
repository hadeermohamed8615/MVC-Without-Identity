using CUR2Demo.Entities;
using CUR2Demo.Models.Day2;
using CUR2Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace CUR2Demo.Controllers
{

    public class DepartmentController : Controller
    {
       
        CUR2Company DB = new CUR2Company();

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveNew(Department d)
        {

            if(d.Name != null && d.Manger != null)
            {
                DB.Departments.Add(d);
                DB.SaveChanges();

                //List<Department> depts = DB.Departments.ToList();
                //return View("Index", depts);
                return RedirectToAction("Index");
            }
            return View("New",d);
        }


        public IActionResult Index()
        {
            List<Department> depts = DB.Departments.ToList();
            return View(depts);
           // return View(); //ViewName = Index && Model = Null
            //return View(depts);//ViewName = Index && Model = depts
           // return View("ShowAll",depts);//ViewName = ShowAll && Model = depts
          //  return View("ShowAll");//ViewName = ShowAll && Model = Null
        }

        public IActionResult ShowAllWithBranches(int id )
        {
            //1-
            Department dept = DB.Departments.Find(id);
            //2-
            List<string> Branches = new List<string>();
            Branches.Add("ISmailia");
            Branches.Add("Cairo");
            Branches.Add("Giza");
            Branches.Add("Monsoura");
            Branches.Add("Smart");
            //int num = 5;
            ViewData["num"] = 5;
            ViewData["brc"] = Branches;
            ViewBag.msg = "Hello from ViewBag";

            //3-
            //string str = "Hello";

            ViewData["str"] = "Hello";
            //4-
            string color = "red";
            ViewData["color"] = color;

            return View(dept);

           
            // return View(); //ViewName = Index && Model = Null
            //return View(depts);//ViewName = Index && Model = depts
            // return View("ShowAll",depts);//ViewName = ShowAll && Model = depts
            //  return View("ShowAll");//ViewName = ShowAll && Model = Null
        }



        public IActionResult ShowAllWithBrancheswithVM(int id)
        {
            //0-
            DeptWithBranchesAndMsgViewModel VM = new DeptWithBranchesAndMsgViewModel();

            //1-
            Department dept = DB.Departments.Find(id);

            VM.DeptName = dept.Name;
            VM.DeptMGR = dept.Manger;
            //2-
            List<string> Branches = new List<string>();
            Branches.Add("ISmailia");
            Branches.Add("Cairo");
            Branches.Add("Giza");
            Branches.Add("Monsoura");
            Branches.Add("Smart");

            VM.Branches = Branches;
            //int num = 5;
            VM.Num = 5;
           
         
            VM.Msg = "Hello";
            //3-
            //string str = "Hello";
            VM.Color = "red";
          

            return View(VM);


           
        }
    }
}
