using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using _piataAZ.Entities;
using _piataAZ.DAL;
using System.Collections;

namespace _piataAZ.BL
{
    public class UserService
    {
        UsersDAL userDal;
        Employee employee;

        public UserService()
        {
            userDal = UsersDAL.getInstance();
        }

        private string createPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public String login(String username, String password)
        {
            String pass = getMd5Hash(password);
            employee = userDal.getUser(username, pass);
            return employee.getRole();          
        }

        public String update(String username)
        {
            String password = createPassword(5);
            String pass = getMd5Hash(password);
            userDal.updateUser(username, pass);
            return password;
        }

        public String updateAccount(String username,String password, String name, String role)
        {
            String pass = getMd5Hash(password);
            userDal.updateAccount(username, pass,name,role);
            return password;
        }

        public void create(String username, String password, String name, String role)
        {
            String pass = getMd5Hash(password);
            userDal.createUser(username, pass, name, role);
        }

        public void delete(String username)
        {
            userDal.deleteUser(username);
        }

        public String generatePassword()
        {
            return createPassword(5);
        }

        public String getName(String username)
        {
            employee = userDal.getUser(username);
            return employee.getName();
        }

        public String getRole(String username)
        {
            employee = userDal.getUser(username);
            return employee.getRole();
        }

        public ArrayList getAllEmployees()
        {
            return userDal.getAllEmployees();
        }
    }
}
