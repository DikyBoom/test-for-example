using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Worker
{
    class CheckType
    {
        public static int Check(string str_check)
        {
            int value;
            while (!int.TryParse(str_check, out value))
            {
                Console.WriteLine("\n");
                Console.WriteLine("You should enter an another kind of data ");
                str_check = Console.ReadLine();
            }
            return value;
        }

    }
}
