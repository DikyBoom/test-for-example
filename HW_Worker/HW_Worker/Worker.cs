using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Worker
{
    abstract class Worker
    {
        abstract public double Salary();

        abstract public string Position();

        abstract public int Subordinates();

        abstract public string Name();

        abstract public int ResponsibilityLevel();
    }
}
