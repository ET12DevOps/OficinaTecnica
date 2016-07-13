using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using ejemplo_apidb.Database;
using MySql.Data.MySqlClient;

namespace ejemplo_apidb.Dominio
{
    class Empleado : Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _sueldo;

        public string Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public Empleado(string nombre, string apellido, string sueldo)
        {
            Nombre = nombre;

            Apellido = apellido;

            Sueldo = sueldo;

            Parametros.Add(new Parametro("@unNombre", Nombre));

            Parametros.Add(new Parametro("@unApellido", Apellido));

            Parametros.Add(new Parametro("@unSueldo", Sueldo));

            Tipo = "Empleado"; 
        }

        public Empleado(string id, string nombre, string apellido, string sueldo) 
            : this (nombre, apellido, sueldo)
        {
            Id = id;

            Parametros.Add(new Parametro("@unIdEmpleado", Id));

            Tipo = "Empleado";           
        }

        public Empleado(string idEmpleado)
        {
            _id = idEmpleado;

            Parametros.Add(new Parametro("@unIdEmpleado", _id));

            Tipo = "Empleado";
        }

        public static List<Empleado> Select()
        {
            List<Empleado> empleados = new List<Empleado>();

            string query = "select * from empleado";

            empleados = Query(query, empleados);

            return empleados;
        }

        public static List<Empleado> Select(string where)
        {
            List<Empleado> empleados = new List<Empleado>();

            string query = "select * from empleado " + where;

            empleados = Query(query, empleados);

            return empleados;
        }

        

        private static List<Empleado> Query(string query, List<Empleado> empleados)
        {
            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand(query, connectionLive);

            try
            {
                connectionLive.Open();

                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    empleados.Add(new Empleado(myReader["Id"].ToString(), myReader["Nombre"].ToString(), 
                    myReader["Apellido"].ToString(), myReader["Sueldo"].ToString()));
                }

                myReader.Dispose();

                connectionLive.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                throw new Exception(ex.ToString());
            }

            return empleados;
        }
    }
}
