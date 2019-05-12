using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {

            Citizen Father = new Citizen("Eyal", 100);
            Citizen Son1 = new Citizen("Dan", 100);
            Citizen Son2 = new Citizen("Ron", 100);
            Citizen Son3 = new Citizen("Guy", 100);

            Citizen[] EyalChildren = new Citizen[] { Son1, Son2, Son3 };

            Father.SetChildren(EyalChildren);

        }

        static bool CheckValidity(Citizen c)
        {
            foreach (Citizen child in c.GetChildren())
            {
                if (child.FatherId != c.Id)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
