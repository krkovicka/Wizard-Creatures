using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Wizard
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int Age { get; set; }
        public DateTime AdmisionDate { get; set; }
        public bool Graduation { get; set; }

        public Wizard(string name, int power, int age, DateTime admision, bool graduate)
        {
            Name = name;
            PowerLevel = power;
            Age = age;
            AdmisionDate = admision;
            Graduation = graduate;
        }
    }
}
