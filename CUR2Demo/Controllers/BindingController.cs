using CUR2Demo.Models.Day2;
using Microsoft.AspNetCore.Mvc;

namespace CUR2Demo.Controllers
{
    public class BindingController : Controller
    {
        ////Binding/PrimirveTest/1
        ////Binding/PrimirveTest?id=1&name=ali&color=red
        public IActionResult PrimirveTest(int id,string name,string[] color)
        {
            return Content("Primtive Test");
        }
        //Binding/CollectionTest?phones[ahmed]=123&phones[sara]=456
        public IActionResult CollectionTest(Dictionary<string , string> phones)
        {
           // phones["Ahmed"] = "1234";
            return Content("Collection Test");
        }
        //Binding/ComplixTest?Id=1&Name=SD&manger=Ahmed&employees[0].Name=hhhh
        public IActionResult ComplixTest(Department d)
        {
           
            return Content("Complix Test");
        }

    }
}
