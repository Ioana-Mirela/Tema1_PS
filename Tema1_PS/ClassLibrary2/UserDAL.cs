using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using _piataAZ.Entities;
using System.Collections;

namespace _piataAZ.DAL
{
    public class UsersDAL
    {
        private static UsersDAL _usersDAL = null;
        private String _connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "piata_az");
        MySqlConnection _conn = null;

        private UsersDAL()
        {
            try
            {
                _conn = new MySqlConnection(_connectionString);
            }
            catch (MySqlException e)
            {
                //de facut ceva error handling, afisat mesaj, etcc..
                _conn = null;
            }
        }

        public static UsersDAL getInstance()
        {
            if (_usersDAL == null)
            {
                _usersDAL = new UsersDAL();
            }
            return _usersDAL;
        }

        public Employee getUser(String username, String password)
        {
            Employee u = null;
            String sql = "SELECT * FROM user WHERE username='" + username + "'AND password='" + password + "'";
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                u = new Employee(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                _conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return u;
        }

        public Employee getUser(String username)
        {
            Employee u = null;
            String sql = "SELECT * FROM user WHERE username='" + username + "'";
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                u = new Employee(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                _conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return u;
        }

        public void updateUser(String username, String password)
        {
            String sql = "UPDATE user SET password=@password WHERE username = @username";   
            try
            {
                MySqlCommand command = _conn.CreateCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (MySqlException e)
            {
                 Console.WriteLine(e.Message);
                _conn.Close();
            }
        }

        public void updateAccount(String username, String password, String name, String role)
        {
            String sql = "UPDATE user SET password=@password, name=@name, role=@role WHERE username = @username";
            try
            {
                MySqlCommand command = _conn.CreateCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@role", role);

                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                _conn.Close();
            }
        }

        public void createUser(String username, String password, String name, String role)
        {
                _conn.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO user VALUES(@username, @password, @name, @role)", _conn))
                    {
                        command.Parameters.Add(new MySqlParameter("username", username));
                        command.Parameters.Add(new MySqlParameter("password", password));
                        command.Parameters.Add(new MySqlParameter("name", name));
                        command.Parameters.Add(new MySqlParameter("role", role));
                        command.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    _conn.Close();
                }
        }

        public void deleteUser(String username)
        {
            try
            {
                _conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM user " + "WHERE username=@username", _conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int rows = cmd.ExecuteNonQuery();
                    }
                _conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                _conn.Close();
            }
               
        }

        public ArrayList getAllEmployees()
        {
            ArrayList list = new ArrayList();
            Employee u = null;
            String sql = "SELECT * FROM user";
            try
            {
                _conn.Open();
                
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        u = new Employee(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                        list.Add(u);
                    }
                }
                reader.Close();
                _conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return list;
        }

      }

    }

