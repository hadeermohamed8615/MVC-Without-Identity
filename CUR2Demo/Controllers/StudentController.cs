using CUR2Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CUR2Demo.Controllers
{
    public class StudentController : Controller
    {



        ///Student/ShowAll
        ///
        public IActionResult ShowAll()
        {
            List<Student> stds = StudentBL.students.ToList();
            return View("ShowAllEmps",stds);
        }

       
        /// Student/getById/3
     

        public IActionResult getById(int id)
        {
            var std = StudentBL.students.FirstOrDefault(s=>s.Id == id);

            return View("Details", std);
        }











        ////Action => Public / not static / no overload
        ////URL =>Domin /Student/First
        //  public ContentResult First()
        //  {
        //      //Declaration
        //      ContentResult resC = new ContentResult();
        //      //Inilization
        //      resC.Content = "Hello from First Action";
        //      //Return

        //      return resC ;
        //  }
        //  //Student/Second

        //  public ViewResult Second()
        //  {

        //      //Views/Student/MyView.cshtml
        //      //Views/Shared/MyView.cshtml
        //      ViewResult res = new ViewResult();
        //      res.ViewName = "MyView";
        //      return res ;
        //  }
        //Student/mix?id = 5&name = ahmed
        //Student/mix/5?name=ahmed
        public IActionResult Mix(int id, string name)
        {
            if (id % 2 == 0)
            {
                //Declaration
                ContentResult resC = new ContentResult();
                //Inilization
                resC.Content = "Hello from First Action";
                //Return

                return resC;
            }
            else
            {
                ViewResult res = new ViewResult();
                res.ViewName = "MyView";
                return res;
            }
        }


        //  //ContentResult => Data (string)
        //  //ViewResult => View
        //  //JsonResult => Json
        //  //FileResult 

    }
}
