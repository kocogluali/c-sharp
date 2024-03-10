using firstapp.Entities;

namespace firstapp.Business;

public class CourseManager

{
    Course[] courses = new Course[3];
    public CourseManager()
    {
        Console.WriteLine("contructor runnin");
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "c# .net";
        course1.Description = ".net 8";
        course1.Price = 100.0;

        Course course2 = new();
        course2.Id = 2;
        course2.Name = "java";
        course2.Description = "java 17";
        course2.Price = 0;


        Course course3 = new();
        course3.Id = 3;
        course3.Name = "python";
        course3.Description = "3.20";
        course3.Price = 50.0;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;

    }
    public Course[] GetAll()
    {
        return courses;
    }
}
