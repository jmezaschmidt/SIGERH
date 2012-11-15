using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using System.Data.SqlClient;

namespace SIGERHSis.AccesoDatos
{
    public class AccesoDatos
    {

        private Database _DbSIGERH;
        private SqlCommand cmd;

        public AccesoDatos()
        {
            _DbSIGERH = DatabaseFactory.CreateDatabase("DB_SIGERH");
        }


        // Retorna un boolean para saber si la operación tuvo éxito o no
        public Boolean escribir(String pStoredProcedure, String[] pNombreParametros, params Object[] pValorParametros)
        {
            cmd = new SqlCommand(pStoredProcedure);
            cmd.CommandType = CommandType.StoredProcedure;

            if (pNombreParametros.Length != 0)
            {
                for (int i = 0; i < pValorParametros.Length; i++)
                {
                    if (pValorParametros[i] == null)
                    {
                        cmd.Parameters.Add(new SqlParameter(pNombreParametros[i], pValorParametros[i])).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter(pNombreParametros[i], pValorParametros[i]));
                    }
                }
            }

            IDataReader reader = _DbSIGERH.ExecuteReader(cmd);

            if (reader.Read())
            {
                return reader.GetBoolean(0);
            }

            return false;
        }


        // Retorna el IDataReader para que sea procesado por el DataAccess especifico
        public IDataReader leer(String pStoredProcedure, String[] pNombreParametros, params Object[] pValorParametros)
        {
            cmd = new SqlCommand(pStoredProcedure);
            cmd.CommandType = CommandType.StoredProcedure;

            if (pNombreParametros.Length != 0)
            {
                for (int i = 0; i < pValorParametros.Length; i++)
                {
                    if (pValorParametros[i] == null)
                    {
                        cmd.Parameters.Add(new SqlParameter(pNombreParametros[i], pValorParametros[i])).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter(pNombreParametros[i], pValorParametros[i]));
                    }
                }
            }
            
            IDataReader reader = _DbSIGERH.ExecuteReader(cmd);
            return reader;         
        }
    }
}