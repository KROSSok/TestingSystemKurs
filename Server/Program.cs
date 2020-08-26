using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ModelContext modelContext = new ModelContext();

            Group adminGroup = new Group { Title = "Admins" };
            Group teacherGroup = new Group { Title = "Teacher" };
            Group studentGroup = new Group { Title = "Student" };

            User admin = new User { Name = "Admin", Group = adminGroup, Login = "admin", Password = "admin" };
            User teacher = new User { Name = "Teacher", Group = teacherGroup, Login = "teacher", Password = "teacher" };
            User student = new User { Name = "Student", Group = studentGroup, Login = "student", Password = "student" };


            if (modelContext.Database.Exists())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                modelContext.Groups.Add(adminGroup);
                modelContext.Groups.Add(teacherGroup);
                modelContext.Groups.Add(studentGroup);

                modelContext.Users.Add(admin);
                modelContext.Users.Add(teacher);
                modelContext.Users.Add(student);

                modelContext.SaveChanges();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
