using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Citizen
    {
        string _name;
        Citizen[] Children;
        private readonly int _fatherId;
        readonly int id;
        static int _numberOfCurrentCitizens;
        const int MAXIMUM_NUMBER_OF_CITIZENS = 2000;

        public int FatherId
        {
            get
            {
                return _fatherId;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Citizen(string name, int fatherId)
        {
            _name = name;
            _fatherId = fatherId;
        }

        static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"Number of citizens{_numberOfCurrentCitizens}");
        }
        static bool ReachedOutOfMaximumSize()
        {
            if (_numberOfCurrentCitizens >= MAXIMUM_NUMBER_OF_CITIZENS)
                return true;
            else
                return false;
        }

        void PrintId()
        {
            Console.WriteLine($"id:{this.id}");
        }
        void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine($"the gap number between the father id to my id is { _fatherId}-{ this.id}");
        }

        public void SetChildren(Citizen[] children)
        {
            this.Children = children;
        }
        public Citizen[] GetChildren()
        {
            return this.Children;
        }

        public override string ToString()
        {
            return $"name {_name},father id{_fatherId},id {id}";
        }
    }
}
