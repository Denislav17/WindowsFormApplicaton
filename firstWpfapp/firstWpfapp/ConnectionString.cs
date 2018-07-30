using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstWpfapp
{
    class ConnectionString : IDisposable
    {
        private SqlConnection cnn;
        private int usersCount = 0;
        public ConnectionString()
        {
            string connectionString;

            connectionString = @"Data Source=.;
                               Initial Catalog=ContactRegistry_1_0;
                               Integrated Security=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        public void returnOpen()
        {
            cnn.Open();
        }
        public void returnClosed()
        {  
            cnn.Close();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Users> getUsers()
        {
            List<Users> users = new List<Users>();
            SqlCommand command;
            SqlDataReader userDataReader;
            String sql;

            sql = "Select username,password from UserData";
            command = new SqlCommand(sql, cnn);

            userDataReader = command.ExecuteReader();

            while(userDataReader.Read())
            {
                Users user = new Users();
                user.setUsername(userDataReader.GetValue(0).ToString());
                user.setPassword(userDataReader.GetValue(1).ToString());

                users.Add(user);
                usersCount++;
            }

            userDataReader.Close();
            return users;
        }

        public void regUser(String firstName, String lastName, String username, String password, String company, String position, DateTime regDate)
        {           
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Insert into UserData (ID,firstName,lastName,username,password,companyName,position,regDate) " +
                "values("+ usersCount + ",'" 
                + firstName + "','" + lastName + "','"
                + username + "','" + password + "','"
                + company  + "','" + position + "','"
                + regDate + "')";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }
        
    }

    
}
