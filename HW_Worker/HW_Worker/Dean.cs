using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Worker
{
     class Dean : Worker
    {

        private double _salary;
        private string _name;
       
        private int _subordinates;
        private int _responsibilityLevel;




        public Dean(string name, double salary, int subordinates, int respLevel)
        {
            _salary = salary;
            _name = name;
            
            _subordinates = subordinates;
            _responsibilityLevel = respLevel;
        }

        public override string Name()
        {
            return _name;
        }

        public override string Position()
        {
            return "Dean";
        }

        public override int ResponsibilityLevel()
        {
            return _responsibilityLevel;
        }

        public override double Salary()
        {
            return _salary;
        }

        public override int Subordinates()
        {
            return _subordinates;
        }
    }
}
