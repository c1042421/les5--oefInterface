using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefInterface
{
    class Figuur: InterfaceObject
    {
        private double _breedte;
        private double _hoogte;

        public Figuur(double breedte, double hoogte)
        {
            Breedte = breedte;
            Hoogte = hoogte;
        }

        public double Breedte { get => _breedte; set => _breedte = value; }
        public double Hoogte { get => _hoogte; set => _hoogte = value; }

        public double Bereken()
        {
            return Breedte * Hoogte;
        }

        public override string ToString()
        {
            return string.Format("De oppervlakte van de figuur met hoogte {0} en breedte {1} is {2}", Hoogte, Breedte, Bereken());
        }
    }
}
