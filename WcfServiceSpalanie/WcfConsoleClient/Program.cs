using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfConsoleClient.ServiceReference1;

namespace WcfConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SpalanieClient client = new SpalanieClient();
            try
            {
                double koszt = client.Koszt(100, 3, 10);
                Console.WriteLine("Koszt: " + koszt);
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
                throw;
            }
        }
    }
}
