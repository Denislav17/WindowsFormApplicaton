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
        private SqlConnection _DBConnection;
        private int usersTotalNumber = 0;
        public ConnectionString()
        { 
            string connectionString = @"Data Source=.;
                               Initial Catalog=ContactRegistry_1_0;
                               Integrated Security=True;";
            _DBConnection = new SqlConnection(connectionString);
            _DBConnection.Open();

            getTotalNumberOfUsers();
        }

        public List<Users> getUsers(List<Users> users)
        {
            SqlCommand command;
            SqlDataReader userDataReader;
            String sql;

            sql = "Select username,password from UserData";
            command = new SqlCommand(sql, _DBConnection);

            userDataReader = command.ExecuteReader();

            while(userDataReader.Read())
            {
                Users user = new Users();
                user.setUsername(userDataReader.GetValue(0).ToString());
                user.setPassword(userDataReader.GetValue(1).ToString());

                users.Add(user);
            }

            userDataReader.Close();
            return users;
        }

        public List<Users> getExistingUsersData(List<Users> users)
        {
            SqlCommand command;
            SqlDataReader userDataReader;
            String sql;

            sql = "Select ID, firstName, lastName, companyName, position, cardNumber from UserData order by ID";

            command = new SqlCommand(sql, _DBConnection);

            userDataReader = command.ExecuteReader();

            while (userDataReader.Read())
            {
                Users user = new Users();
                user.setId(Convert.ToInt32(userDataReader.GetValue(0)));
                user.setFirstName(userDataReader.GetValue(1).ToString());
                user.setLastName(userDataReader.GetValue(2).ToString());
                user.setCompany(userDataReader.GetValue(3).ToString());
                user.setPosition(userDataReader.GetValue(4).ToString());
                user.setCardNumber(userDataReader.GetValue(5).ToString());

                users.Add(user);

            }

            userDataReader.Close();
            return users;

        }

        public List<Users> getAddedContactsData(Users contextUser)
        {
            List<Users> users = new List<Users>();
            SqlCommand command;
            SqlDataReader userDataReader;
            String sql;

            sql = "Select contactId,firstName,lastName,companyName,position,cardNumber from " + contextUser.getUsername() + "_ContactBasket order by contactId";
            command = new SqlCommand(sql, _DBConnection);

            userDataReader = command.ExecuteReader();

            while(userDataReader.Read())
            {
                Users user = new Users();
                user.setId(Convert.ToInt32(userDataReader.GetValue(0)));
                user.setFirstName(userDataReader.GetValue(1).ToString());
                user.setLastName(userDataReader.GetValue(2).ToString());
                user.setCompany(userDataReader.GetValue(3).ToString());
                user.setPosition(userDataReader.GetValue(4).ToString());
                user.setCardNumber(userDataReader.GetValue(5).ToString());

                users.Add(user);
                
            }

            userDataReader.Close();
            return users;
        }

        public void regUser(Users user)
        {           
            SqlDataAdapter userAdapter = new SqlDataAdapter();

            //To implement cardNumber class which will generate random card nubmer
            //edit SQL statement so that it injects card number in the DB.

            //Register user into UserData Table
            String insertionQuery = "Insert into UserData (ID,firstName,lastName,username,password,companyName,position,regDate) " +
                "values("+ usersTotalNumber + ",'" 
                + user.getFirstName() + "','" + user.getLastName() + "','"
                + user.getUsername() + "','" + user.getPassword() + "','"
                + user.getCompany()  + "','" + user.getPosition() + "','"
                + user.getRegDate() + "')";

            SqlCommand insertUserDataCommand = new SqlCommand(insertionQuery, _DBConnection);
            userAdapter.InsertCommand = new SqlCommand(insertionQuery, _DBConnection);
            userAdapter.InsertCommand.ExecuteNonQuery();
            insertUserDataCommand.Dispose();
            //End of User Registration Query

            //Register Contact basket for the same user
            regUserContactBasket(user, userAdapter);

            //Close connection
            _DBConnection.Close();
        }

        private void regUserContactBasket(Users user, SqlDataAdapter adapter)
        {
            String createTableQuery = "CREATE TABLE " + user.getUsername() + "_ContactBasket (contactId varchar(50), firstName varchar(50), lastName varchar(50), companyName varchar(50), position varchar(50), cardNumber varchar(50))";
            SqlCommand createContactBasketCommand = new SqlCommand(createTableQuery, _DBConnection);

            adapter.InsertCommand = new SqlCommand(createTableQuery, _DBConnection);
            adapter.InsertCommand.ExecuteNonQuery();

            createContactBasketCommand.Dispose();
        }

        public void addToUserContactBasket(Users userBasketOwner, Users userBasketFeeder)
        {

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Insert into " + userBasketOwner.getUsername() + "_ContactBasket (contactId, firstName, lastName, companyName, position, cardNumber) " +
                "values(" + userBasketFeeder.getId() + ",'"
                + userBasketFeeder.getFirstName() + "','" + userBasketFeeder.getLastName() + "','"
                + userBasketFeeder.getCompany() + "','" + userBasketFeeder.getPosition() + "','"
                + userBasketFeeder.getCardNumber() + "')";
            command = new SqlCommand(sql, _DBConnection);

            adapter.InsertCommand = new SqlCommand(sql, _DBConnection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();

            _DBConnection.Close();

        }

        private void getTotalNumberOfUsers()
        {
            SqlCommand totalNumberOfUsersCommand;
            SqlDataReader userNumberReader;
            String totalAmountQuery;

            totalAmountQuery = "select ID from UserData";

            totalNumberOfUsersCommand = new SqlCommand(totalAmountQuery, _DBConnection);

            userNumberReader = totalNumberOfUsersCommand.ExecuteReader();

            while (userNumberReader.Read()) {
                usersTotalNumber++;
            }
            userNumberReader.Close();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    
}
