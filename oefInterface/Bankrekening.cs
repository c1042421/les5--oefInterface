using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefInterface
{
    class Bankrekening: InterfaceObject
    {
        private double _rentevoet;
        private double _saldo;

        public Bankrekening(double rentevoet, double saldo)
        {
            Rentevoet = rentevoet;
            Saldo = saldo;
        }

        public double Rentevoet { get => _rentevoet; set => _rentevoet = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }

        public double Bereken()
        {
            return Saldo * Rentevoet / 100.0;
        }

        public override string ToString()
        {
            return string.Format("De intrest van de rekening met saldo €{0} en rentevoet {1} is €{2}", Saldo, Rentevoet, Bereken());
        }
    }
}
