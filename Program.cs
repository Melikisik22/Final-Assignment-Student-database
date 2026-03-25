using System;
using System.Linq;

namespace StudentCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Student Code-First demo...");

            using (var db = new SchoolContext())
            {

                Console.WriteLine("Creating database (if not exists) and adding one student...");

                var student = new Student
                {
                    FirstName = "Ali",
                    LastName = "Khan",
                    Email = "ali.khan@example.com"
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student saved with ID: " + student.StudentId);


                var all = db.Students.ToList();
                Console.WriteLine("All students in DB:");
                foreach (var s in all)
                {
                    Console.WriteLine($"ID: {s.StudentId} | {s.FirstName} {s.LastName} | {s.Email}");
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
