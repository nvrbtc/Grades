using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_PROJECT.ProjectClasses
{
    internal class grade
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //selecting data from DB ; 
        public string Name { get; set; }  
        public int Grade { get; set; } 
        public int Id {  get; set; }
        

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring); 
            DataTable dt = new DataTable();
            try
            {
                //sql query 
                string sql = "SELECT * FROM tbl_witgrade";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sqlAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally 
            { 
                conn.Close();
            }
            return dt;
        }
        //inserting data to DB 
        public bool Insert(grade c ) 
        {
            
            // creating default return type and setting it to 0 ; 
            bool succes = false;
            //first step to connect to DB ; 
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //creating sql query to insert data ; 
                string sql = "INSERT INTO tbl_witgrade (name, grade) VALUES (@name, @grade)"; 
                //sql command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //_______________________________________________
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@grade", c.Grade);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // rows > 0 , query succeded . Else no . 
                if (rows > 0) 
                {
                    succes = true; 
                }
                else { succes = false; }
            }
            catch (Exception ex)
            {
                
                
            }
            finally { conn.Close(); }
            return succes;
        }

        public bool Update(grade c) 
        { 
            bool succes = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE tbl_witgrade SET grade=@grade, name=@name WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@grade", c.Grade);
                cmd.Parameters.AddWithValue("@id", c.Id);
                conn.Open(); 
                int rows = cmd.ExecuteNonQuery();
                if (  rows > 0 )
                {
                    succes = true;
                }
                else { succes = false; }


            }
            catch ( Exception ex )
            {

            }
            finally 
            {
                conn.Close();
            }
            return succes; 

        }
        public bool Delete(grade c) 
        { 
            bool succes = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbl_witgrade WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.Id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    succes = true;
                }
                else { succes = false; }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close ();
            }

            return succes;
        }
    }
}
