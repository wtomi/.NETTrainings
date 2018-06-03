using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSpalanie
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISpalanie" in both code and config file together.
    [ServiceContract]
    public interface ISpalanie
    {
        [OperationContract]
        double Koszt(double cena, double odleglosc, double spalanie);
    }
}
