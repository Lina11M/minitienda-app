using Model;
﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class UsersDat
    {
        //CRUD
        Persistence objPer = new Persistence();

        //Metodo para mostrar todos los usuarios
        public DataSet showUsers()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proSelectUserss";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        //Metodo para insertar un Usuario
        public bool saveUsers(string _correo, string _contrasena, string _salt, string _estado)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proInsertUsers"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarString).Value = _correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.VarString).Value = _contrasena;
            objSelectCmd.Parameters.Add("v_salt", MySqlDbType.VarString).Value = _salt;
            objSelectCmd.Parameters.Add("v_estado", MySqlDbType.VarString).Value = _estado;

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

        //Metodo para actualizar un Usuario
        public bool updateUsers(int _idUsers, string _correo, string _contrasena, string _salt, string _estado)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proUpdateUsers"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _idUsers;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarString).Value = _correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.VarString).Value = _contrasena;
            objSelectCmd.Parameters.Add("v_salt", MySqlDbType.VarString).Value = _salt;
            objSelectCmd.Parameters.Add("v_estado", MySqlDbType.VarString).Value = _estado;

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

        //Metodo para eliminar un Usuario
        public bool deleteUsers(int _idUsers)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "proDeleteUsers"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _idUsers;

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

        //Metodo 
        public UserMod showUserMail(string mail)
        {
            UserMod objUser = null;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectUsersMail";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("p_mail", MySqlDbType.VarString).Value = mail;
            MySqlDataReader reader = objSelectCmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return objUser;
            }
            else
            {
                while (reader.Read())
                {
                    objUser = new UserMod(reader["usu_correo"].ToString(), reader["usu_contrasena"].ToString(),
                        reader["usu_salt"].ToString(), reader["usu_estado"].ToString());
                }
            }
            objPer.closeConnection();
            return objUser;
        }


    }
}