using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using System.Data.SqlClient;

namespace SIGERHSis.DataAccess  
{
    public class DataAccess
    {
        private Database _SIGERHDB;
        private SqlCommand cmd;

        public DataAccess()
        {
            _SIGERHDB = DatabaseFactory.CreateDatabase("");
        }

        public Object[][] leerDB(String pSPname)
        {
            cmd = new SqlCommand(pSPname);
            cmd.CommandType = CommandType.StoredProcedure;

            List<Object[]> listaRegistros = new List<Object[]>();
            IDataReader reader = _SIGERHDB.ExecuteReader(cmd);
            while (reader.Read())
            {
                Object[] registro = new Object[reader.FieldCount];
                reader.GetValues(registro);
                listaRegistros.Add(registro);
            }
            reader.Close();
            Object[][] listaResultado = listaRegistros.ToArray();

            return listaResultado;
        }


        public Object[][] leerDB(String pSPname, String[] pnombreparametros, params String[] plistaParametros)
        {
            cmd = new SqlCommand(pSPname);
            cmd.CommandType = CommandType.StoredProcedure;

            List<Object[]> listaRegistros = new List<Object[]>();
            for (int i = 0; i < plistaParametros.Length; i++)
            {
                if (plistaParametros[i] == null)
                {
                    cmd.Parameters.Add(new SqlParameter(pnombreparametros[i], plistaParametros[i])).Value = DBNull.Value;

                }
                else
                {

                    cmd.Parameters.Add(new SqlParameter(pnombreparametros[i], plistaParametros[i]));

                }
            }

            IDataReader reader = _SIGERHDB.ExecuteReader(cmd);
            while (reader.Read())
            {
                Object[] registro = new Object[reader.FieldCount];
                reader.GetValues(registro);
                listaRegistros.Add(registro);
            }
            reader.Close();
            Object[][] listaResultado = listaRegistros.ToArray();
            return listaResultado;
        }



        public void escribirDB(String pSPname, String[] pnombreparametros, params String[] plistaParametros)
        {            
            cmd = new SqlCommand(pSPname);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < plistaParametros.Length; i++)
            {
                if (plistaParametros[i] == null)
                {
                    cmd.Parameters.Add(new SqlParameter(pnombreparametros[i], plistaParametros[i])).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter(pnombreparametros[i], plistaParametros[i]));
                }
            }

            _SIGERHDB.ExecuteReader(cmd);            
        }
    }
}