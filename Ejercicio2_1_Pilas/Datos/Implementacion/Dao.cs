using Ejercicio2_1_Pilas.Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1_Pilas.Datos.Inplementacion
{
    internal class Dao : IDao
    {
        
        SqlConnection cnn = new SqlConnection(@"Data Source =laptop-sjp45n95; Initial Catalog = ejercico2_1; Integrated Security = True");

        List<Elementos> lista = new List<Elementos>();

        public bool estaVacia(string pa)
        {
            bool estadoVacio = true; 
            DataTable table = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pa, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table.Load(cmd.ExecuteReader());

                if (table.Rows.Count > 0)
                {
                    estadoVacio = false;
                }

            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }               
            }            
            return estadoVacio;
        }



        public bool extrae(string pa)
        {
            bool flag = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pa, cnn);
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }



        public bool  añadir (string oElemento, string pa)
        {
            bool flag =false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pa, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Objeto", oElemento);
                cmd.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception e)
            { 
            
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }


        public DataTable primerElemento(string pa)
        {

            DataTable table = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pa, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table.Load(cmd.ExecuteReader());
                return table;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }
        }
        public DataTable ElementoSaliente( string pa)
        {

            DataTable table = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pa, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table.Load(cmd.ExecuteReader());

                return table;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }
        }


    }
}
