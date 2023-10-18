using CUR2Demo.Validators;

namespace CUR2Demo.Models.Day2
{
    public class Department
    {
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Location { get; set; }
        public string Manger { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
