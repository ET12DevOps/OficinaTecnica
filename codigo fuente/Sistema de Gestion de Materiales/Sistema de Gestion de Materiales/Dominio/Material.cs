using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Sistema_de_Gestion_de_Materiales.Database;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Materiales.Dominio
{
    class Material : Objeto
    {
        private string _CodInterno;

        public string CodigoInterno
        {
            get { return _CodInterno; }
            set { _CodInterno = value; }
        }

        private string _CodBarra;

        public string CodigoBarra
        {
            get { return _CodBarra; }
            set { _CodBarra = value; }
        }

        private string _DescripLarga;

        public string DescripcionLargar
        {
            get { return _DescripLarga; }
            set { _DescripLarga = value; }
        }

        private string _DescripCorta;

        public string DescripcionCorta
        {
            get { return _DescripCorta; }
            set { _DescripCorta = value; }
        }

        private string _Unidad;

        public string Unidad
        {
            get { return _Unidad; }
            set { _Unidad = value; }
        }

        public Material(string codInterno, string codBarra, string descripLarga, string descripCorta, string unidad)
        {
            CodigoInterno = codInterno;
            CodigoBarra = codBarra;
            DescripcionLargar = descripLarga;
            DescripcionCorta = descripCorta;
            Unidad = unidad;

            Parametros.Add(new Parametro("CodigoInterno", CodigoInterno));
            Parametros.Add(new Parametro("CodigoBarra", codBarra));
            Parametros.Add(new Parametro("DescripcionLarga", DescripcionLargar));
            Parametros.Add(new Parametro("DescripcionCorta", DescripcionCorta));
            Parametros.Add(new Parametro("Unidad", Unidad));

            Tipo = "Material";
        }

        public static List<Material> Select(string where)
        {
            List<Material> materiales = new List<Material>();

            string query = "select * from material " + where;

            materiales = Query(query, materiales);

            return materiales;
        }

        private static List<Material> Query(string query, List<Material> materiales)
        {
            MySqlDataReader myReader = null;
            MyReaderSqlConnection connectionLive = databaseMySqlConnection();
            MySqlCommand command = new MySqlCommand(query, connectionLive);

            try
            {
                connectionLive.Open();

                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    materiales.Add(new Material(myReader["CodigoInterno"].ToString(),myReader["CodigoBarra"].ToString(), myReader["DescripcionLarga"].ToString(), myReader["DescripcionCorta"].ToString(), myReader["Unidad"].ToString()));
                }

                myReader.Dispose();

                connectionLive.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return materiales;
        }
    }
}
