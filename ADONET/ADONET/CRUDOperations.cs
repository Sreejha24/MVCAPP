﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADONET
{
    class CRUDOperations
    {
        private string connectionstring;
        private SqlConnection conn;
        public CRUDOperations()
        {
            connectionstring = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            conn = new SqlConnection(connectionstring);
        }
        public void CreateOperation()
        {
            conn.Open();
            var sql = "Select EmployeeID, FirstName, LastName,Email,City,Mobile From Employees";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader["EmployeeID"] + "\t" + dataReader["FirstName"] + "\t" + dataReader["LastName"] + "\t" + dataReader["Email"] + "\t" + dataReader["City"] + "\t" + dataReader["Mobile"]);
            }
            conn.Close();
        }
        public void InsertOperation()
        {
            
            Console.WriteLine("Create Details:");
            //int EmployeeID = int.Parse(Console.ReadLine());
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string Email = Console.ReadLine();
            string City = Console.ReadLine();
            long Mobile = long.Parse(Console.ReadLine());
            conn.Open();
            var sql = "Insert Into Employees Values (@FirstName, @LastName, @Email, @City, @Mobile)";
            SqlCommand cmd = new SqlCommand(sql,conn);
            //cmd.Parameters.AddWithValue("@EmployeeID",EmployeeID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@Mobile", Mobile);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void UpdateOperation()
        {
            Console.WriteLine("Update Details:");
            //int EmployeeID = int.Parse(Console.ReadLine());
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            //string Email = Console.ReadLine();
            //string City = Console.ReadLine();
            //long Mobile = long.Parse(Console.ReadLine());
            conn.Open();
            var sql = "Update Employees set LastName = @LastName where FirstName = @FirstName";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@EmployeeID",EmployeeID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            //cmd.Parameters.AddWithValue("@Email", Email);
            //cmd.Parameters.AddWithValue("@City", City);
            //cmd.Parameters.AddWithValue("@Mobile", Mobile);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteOperation()
        {
            Console.WriteLine("Delete Details:");
            //int EmployeeID = int.Parse(Console.ReadLine());
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            //string Email = Console.ReadLine();
            //string City = Console.ReadLine();
            //long Mobile = long.Parse(Console.ReadLine());
            conn.Open();
            var sql = "Delete from Employees where FirstName = @FirstName";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@EmployeeID",EmployeeID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            //cmd.Parameters.AddWithValue("@Email", Email);
            //cmd.Parameters.AddWithValue("@City", City);
            //cmd.Parameters.AddWithValue("@Mobile", Mobile);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
