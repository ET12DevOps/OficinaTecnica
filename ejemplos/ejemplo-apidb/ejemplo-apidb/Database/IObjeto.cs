using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_apidb.Database
{
    interface IObjeto
    {
        List<Objeto> Select();

        List<Objeto> Select(string where);

        List<Objeto> Query(string query, List<Objeto> objetos);
    }
}
