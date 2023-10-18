using CUR2Demo.Entities;
using CUR2Demo.Models.Day2;
using Microsoft.AspNetCore.Mvc;

namespace CUR2Demo.Controllers
{
   // [Route("emp")]
    public class EmployeeController : Controller
    {
        CUR2Company Db = new CUR2Company();

        public IActionResult TestSalary(int Salary,int DeptId)
        {
            //Your Own Logic
            if(Salary !=0 && Salary % 5 == 0 && DeptId == 1 )
            {
                return Json(true);
            }
            else if (Salary != 0 && Salary % 3 == 0 && DeptId == 2)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }


       // [Route("emp/DisplayAll")]
        public IActionResult Index()
        {
            return View(Db.Employees.ToList());
        }
    
        [HttpGet]
        public IActionResult New()
        {
            ViewBag.depts = Db.Departments.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult New(Employee emp)
        {
            if(ModelState.IsValid == true)
           // if(emp.Name != null && emp.Salary > 3000)
            {
                try
                {
                  // throw new Exception("My Message");
                     Db.Add(emp);
                     Db.SaveChanges();
                     return RedirectToAction("Index");
                }catch(Exception ex)
                {
                  ModelState.AddModelError("Name", ex.Message);
                 
                }
               
            }
            //else
            //{
                ViewBag.depts = Db.Departments.ToList();
                return View("New", emp);
           // }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.depts = Db.Departments.ToList();
            return View(Db.Employees.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Employee emp,[FromRoute]int id)
        {
            
;           if(ModelState.IsValid)
            { 
                Employee OldEmp = Db.Employees.FirstOrDefault(E=>E.Id == id);
                OldEmp.Name = emp.Name;
                OldEmp.Address = emp.Address;
                OldEmp.Age = emp.Age;
                OldEmp.Salary = emp.Salary;
                OldEmp.DeptId = emp.DeptId;
                //Db.Employees.Update(emp);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.depts = Db.Departments.ToList();
         
            return View("Edit",emp);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
          
            return View(Db.Employees.Find(id));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(Db.Employees.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Employee emp,[FromRoute]int id)
        {
            // Db.Employees.Remove(emp);
            var e = Db.Employees.Find(id);
            Db.Remove(e);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
