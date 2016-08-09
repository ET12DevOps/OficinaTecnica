using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_Gestion_de_Materiales.Database
{
    interface IObjeto
    {
        List<Objeto> Select();

        List<Objeto> Select(string where);

        List<Objeto> Query(string query, List<Objeto> objetos);
    }
}
