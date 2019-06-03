using CodeFirstWithEntity.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CodeFirstWithEntity
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            using (TestDbContext context = new TestDbContext())
            {
                context.Groups.Add(new Group()
                {
                    Name = "A6"
                });

                context.Students.Add(new Student()
                {
                    Name = "Anar",
                    Surname = "Ahmadov",
                    Mark = 5.0                   

                });
                context.SaveChanges();
            }
        }
    }
}
