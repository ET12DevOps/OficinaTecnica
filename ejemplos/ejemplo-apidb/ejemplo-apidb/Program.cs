using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemplo_apidb.Dominio;
using ejemplo_apidb.Database;

namespace ejemplo_apidb
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado.ConectionString("localhost", "3306", "ejemploEmpleado", "root", "telesca1234");

            Empleado empleado = new Empleado("pepe", "pepe", "2000");

            Empleado.Insert(empleado);
        }
    }
}
