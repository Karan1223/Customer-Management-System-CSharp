using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class CustomerDB
    {
        public static Customer  GetCustomer()
        {
            SqlConnection connection = SalesDB.GetConnection();
            string selectStatement = "SELECT CustomerID, FirstName, " +
                "MiddleInitial, LastName " +
                "FROM Customers ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader();
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.cid = (int)custReader["CustomerID"];
                    if(custReader["FirstName"] != null)
                    {
                        customer.fname = (string)custReader["FirstName"];
                    }
                    else
                    {
                        customer.fname = "";
                    }
                    if (custReader["LastName"] != null)
                    {
                        customer.lname = (string)custReader["LastName"];
                    }
                    else
                    {
                        customer.lname = "";
                    }
                    //if (custReader["MiddleInitial"] != null)
                    //{
                    //    customer.mname = (string)custReader["MiddleInitial"];
                    //}
                    //else
                    //{
                    //    customer.mname = "";
                    //}
                    customer.mname = "";
                    return customer;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
    
}
