using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp2.MVVM.Models;

namespace MauiApp2.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Persons Person { get; set; }

        public PersonViewModel()
        {
            Person = new Persons
            {
                Name = "anu",
                Age = 50,
                Married = true,
                BirthDate = new DateTime(2000, 08, 05),
                Weight = 100,
                Lunchtime = new TimeSpan(10, 0, 0)
            };
        }
    }
}
