using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace Data
{
    public class ProductDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        // Método para mostrar los productos desde la base de datos.
        public DataSet showProducts()
        {
            
            MySqlDataAdapter objAdapter = new MySqlDataAdapter(); // Se crea un adaptador de datos para MySQL.
            DataSet objData = new DataSet(); // Se crea un DataSet para almacenar los resultados de la consulta.
            MySqlCommand objSelectCmd = new MySqlCommand(); // Se crea un comando MySQL para seleccionar los productos utilizando un procedimiento almacenado.
            objSelectCmd.Connection = objPer.openConnection(); // Se establece la conexión del comando utilizando el método openConnection() de Persistence.           
            objSelectCmd.CommandText = "proSelectProducts";// Se especifica el nombre del procedimiento almacenado a ejecutar.
            objSelectCmd.CommandType = CommandType.StoredProcedure; //Indica que se trata de un procedimiento almacenado.
            objAdapter.SelectCommand = objSelectCmd; //Establece el comando de selección del adaptador de datos.
            objAdapter.Fill(objData); // Se llena el DataSet con los resultados de la consulta.
            objPer.closeConnection();// Cierra la conexión después de obtener los datos
            return objData; //Devuelve el DataSet que contiene los productos.
        }



        //Metodo para guardar un nuevo Producto
        public bool saveProducts(string _code, string _description, int _quantity, double _price, int _fkProvider, int _fkCategory)
        {
            // Se inicializa una variable para indicar si la operación se ejecutó correctamente.
            bool executed = false;
            int row;// Variable para almacenar el número de filas afectadas por la operación.

            // Se crea un comando MySQL para insertar un nuevo producto utilizando un procedimiento almacenado.
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proInsertProducts"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del producto.
            objSelectCmd.Parameters.Add("v_codigo", MySqlDbType.VarString).Value = _code;
            objSelectCmd.Parameters.Add("v_descripcion", MySqlDbType.VarString).Value = _description;
            objSelectCmd.Parameters.Add("v_cantidad", MySqlDbType.Int32).Value = _quantity;
            objSelectCmd.Parameters.Add("v_precio", MySqlDbType.Double).Value = _price;
            objSelectCmd.Parameters.Add("v_prov_id", MySqlDbType.Int32).Value = _fkProvider;
            objSelectCmd.Parameters.Add("v_cat_id", MySqlDbType.Int32).Value = _fkCategory;

            try
            {
                // Se ejecuta el comando y se obtiene el número de filas afectadas.
                row = objSelectCmd.ExecuteNonQuery();

                // Si se inserta una fila correctamente, se establece executed a true.
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                // Si ocurre un error durante la ejecución del comando, se muestra en la consola.
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            // Se devuelve el valor de executed para indicar si la operación se ejecutó correctamente.
            return executed;
        }



        //Metodo para actulizar un producto
        public bool updateProducts(int _id, string _code, string _description, int _quantity, double _price, int _fkProvider, int _fkCategory)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proUpdateProducts"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del producto.
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_codigo", MySqlDbType.VarString).Value = _code;
            objSelectCmd.Parameters.Add("v_descripcion", MySqlDbType.VarString).Value = _description;
            objSelectCmd.Parameters.Add("v_cantidad", MySqlDbType.Int32).Value = _quantity;
            objSelectCmd.Parameters.Add("v_precio", MySqlDbType.Double).Value = _price;
            objSelectCmd.Parameters.Add("v_prov_id", MySqlDbType.Int32).Value = _fkProvider;
            objSelectCmd.Parameters.Add("v_cat_id", MySqlDbType.Int32).Value = _fkCategory;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }



        // Método para eliminar un producto
        public bool deleteProducts(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proDeleteProducts"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

    }

}