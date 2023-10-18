using CUR2Demo.Models.Day2;

namespace CUR2Demo.ViewModels
{
    public class DeptWithBranchesAndMsgViewModel
    {
        //Primitive Data

        public string  DeptName { get; set; }
        public string  DeptMGR { get; set; }
  
        public List<string> Branches { get; set; }
        public int Num { get; set; }

        public string  Msg { get; set; }
        public string Color { get; set; }
        public List<Employee>? emps { get; set; }
    }
}
