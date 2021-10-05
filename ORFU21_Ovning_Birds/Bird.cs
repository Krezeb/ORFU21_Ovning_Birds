using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Birds
{
    abstract class Bird
    {
        protected string _species;

        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        public virtual void Fly()
        {
            Console.WriteLine($"The {_species} flies!");
        }

    }
}
