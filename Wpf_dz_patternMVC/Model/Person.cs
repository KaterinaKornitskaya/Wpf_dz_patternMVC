using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_dz_patternMVC.Model
{
    public class Person  // класс Персона
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string nameP, int ageP)
        {
            Name = nameP;
            Age = ageP;
        }

        public override string ToString()
        {
            return ($"Name: {Name} , Age: {Age}");
        }
    }
}
