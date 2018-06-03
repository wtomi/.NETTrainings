using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSpalanie
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Spalanie" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Spalanie.svc or Spalanie.svc.cs at the Solution Explorer and start debugging.
    public class Spalanie : ISpalanie
    {
        public double Koszt(double cena, double odleglosc, double spalanie)
        {
            return (odleglosc / spalanie) * cena;
        }
    }
}
