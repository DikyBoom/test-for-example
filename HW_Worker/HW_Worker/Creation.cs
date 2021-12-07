using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Worker
{
    internal class Creation
    {
        public static Worker Create(int profOpt, double salary, string name, int subordinates, int respLevel)
        {
            switch (profOpt)
            {
                case 1:

                    return new Professor(name, salary, subordinates, respLevel);
                case 2:
                    return new Rector(name, salary, subordinates, respLevel);
                case 3:
                    return new Dean(name, salary, subordinates, respLevel);
                case 4:
                    return new Laborant(name, salary, subordinates, respLevel);
                case 5:
                    return new Assistant(name, salary, subordinates, respLevel);
                default:
                    throw new Exception();
            }
        }
    }
}
