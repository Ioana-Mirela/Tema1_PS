using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using _piataAZ.Entities;
using System.Collections;

namespace _piataAZ.DAL
{
    public class AdDAL
    {
        private static AdDAL _adDAL = null;
        private String _connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "piata_az");
        MySqlConnection _conn = null;

        private AdDAL()
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

        public static AdDAL getInstance()
        {
            if (_adDAL == null)
            {
                _adDAL = new AdDAL();
            }
            return _adDAL;
        }

        public void createAd(String title, String description, String image, String username)
        {
            _conn.Open();
            try
            {
                using (MySqlCommand command = new MySqlCommand("INSERT INTO ad(title,description,usernameEmployee, image) VALUES(@title, @description, @usernameEmployee, @image)", _conn))
                {
                    command.Parameters.Add(new MySqlParameter("title", title));
                    command.Parameters.Add(new MySqlParameter("description", description));
                    command.Parameters.Add(new MySqlParameter("image", image));
                    command.Parameters.Add(new MySqlParameter("usernameEmployee", username));
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

        public ArrayList getAllTitles()
        {
            ArrayList list = new ArrayList();
            String sql = "SELECT * FROM ad";
            try
            {
                _conn.Open();
                
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(reader["title"].ToString());
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

        public void deleteAd(String title)
        {
            try
            {
                _conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ad " + "WHERE title=@title", _conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
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

        public Ad getAd(String title)
        {
            Ad ad = null;
            String sql = "SELECT * FROM ad WHERE title='" + title + "'";
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ad = new Ad(reader["title"].ToString(), reader["description"].ToString(), reader["usernameEmployee"].ToString(), reader["image"].ToString());
                _conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return ad;
        }

        public void updateAd(String oldTitle, String newTitle, String newDescription, String newImage, String newUser)
        {
            String sql = "UPDATE ad SET title=@newTitle, description=@newDescription, usernameEmployee=@newUser, image=@newImage WHERE title = @oldTitle";
            try
            {
                MySqlCommand command = _conn.CreateCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@newTitle", newTitle);
                command.Parameters.AddWithValue("@newDescription", newDescription);
                command.Parameters.AddWithValue("@newUser", newUser);
                command.Parameters.AddWithValue("@oldTitle", oldTitle);
                command.Parameters.AddWithValue("@newImage", newImage);

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

        public int getNbAds(String usernameEmployee)
        {
            int nbAds = 0;
            String sql = "SELECT * FROM ad WHERE usernameEmployee='" + usernameEmployee + "'";
            try
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nbAds++;
                    }
                }
                reader.Close();
                _conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            return nbAds;
        }

        public ArrayList getAllReports(ArrayList employees)
        {
            ArrayList reports = new ArrayList();
            foreach (Employee i in employees)
            {
                Report r = new Report(i, this.getNbAds(i.getUserName()));
                reports.Add(r);
            }
            return reports;
        }

        }




    }


    

      

        




