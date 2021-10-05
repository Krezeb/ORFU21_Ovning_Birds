using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Birds
{
    class Ostrich : Bird
    {
        public Ostrich()
        {
            _species = "Ostrich";
        }
        public override void Fly()
        {
            Console.WriteLine($"The {_species} cannot fly!");
        }
    }
}
