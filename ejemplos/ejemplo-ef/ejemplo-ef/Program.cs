using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_ef
{
    class Program
    {
        static void Main(string[] args)
        {
            ejemploempleadoEntities db = new ejemploempleadoEntities();

            db.empleado.ToList().ForEach(x => { Console.WriteLine(x.Nombre); });

            Console.ReadKey();
        }
    }
}
