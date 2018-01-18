using Npgsql;
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace InternshipER.App_Code
{
    public class Database
    {
        public static NpgsqlConnection connect()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["internshiper"].ConnectionString;
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            return con;
        }
        public static bool loginAttempt (String id, String password)
        {
            using (NpgsqlConnection con = connect())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT count(*) FROM users WHERE (email = @Id OR username = @Id) AND password = @Password"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Password", Encrypt(password));
                    cmd.Connection = con;
                    con.Open();
                    int count = int.Parse(cmd.ExecuteScalar().ToString());
                    con.Close();
                    if (count == 1) return true;
                    else return false;             
                }
            }
        }
        public static void registerCompany(string companyName, String username,String password,String email)
        {
            int user_id;
            using (NpgsqlConnection con = connect())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (username, email, password) VALUES(@Username, @Email, @Password)"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", Encrypt(password));
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            using (NpgsqlConnection con = connect())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT user_id FROM users WHERE username = @Id AND password = @Password"))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id",username);
                    cmd.Parameters.AddWithValue("@Password", Encrypt(password));
                    cmd.Connection = con;
                    con.Open();
                    user_id= int.Parse(cmd.ExecuteScalar().ToString());
                    con.Close();
                    
                }
            }
            using (NpgsqlConnection con = connect())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO company_details (user_id,name, email,address,telephone,website) VALUES(@User_id,@Name,@Email,@Address,@Telephone,@Website)"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@User_id", user_id);
                    cmd.Parameters.AddWithValue("@Name", companyName);
                    cmd.Parameters.AddWithValue("@Email","");
                    cmd.Parameters.AddWithValue("@Address", "");
                    cmd.Parameters.AddWithValue("@Telephone","");
                    cmd.Parameters.AddWithValue("@Website","");
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   
                }
            }

        }
        private static String Encrypt(string clearText)
        {
            string Key = "INTV1SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private static string Decrypt(string cipherText)
        {
            string Key = "INTV1SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}