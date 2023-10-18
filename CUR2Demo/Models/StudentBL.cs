namespace CUR2Demo.Models
{
    public static class StudentBL
    {
         public static  List<Student>  students = new List<Student>();
        static StudentBL()
        {
          
            students.Add(new Student() { Id = 1, Name = "Ahmed",Age=22,Address="Cairo",Image="1.png "}) ; 
            students.Add(new Student() { Id = 2, Name = "Nada",Age=22,Address="October",Image="3.png "}) ; 
            students.Add(new Student() { Id = 3, Name = "Sara",Age=24,Address="Giza",Image="4.jpg "}) ; 
            students.Add(new Student() { Id = 4, Name = "Ali",Age=25,Address="Alix",Image="2.jpg "});
        }
        
    }
}
