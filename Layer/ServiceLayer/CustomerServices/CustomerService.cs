using DataLayer.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Dapper;
using FUIServerSample.Layer.DataLayer;
using static Microsoft.Fast.Components.FluentUI.Emojis.Symbols.Color.Default;

namespace FUIServerSample.Layer.ServiceLayer.CustomerServices
{
    public class CustomerService
    {
        private readonly DemoContext _context;

        public CustomerService(DemoContext context)
        {
            _context = context;
        }


        private int GetId()
        {

            try
            {
                using (IDbConnection connection = new SqlConnection(_context.Database.GetConnectionString()))
                {
                    try
                    {
                        var sql = "SELECT COUNT(*) FROM Customers;";
                        var count = connection.ExecuteScalar(sql);

                        // This will cast the count object to an integer and return it.
                        return (int)count + 1;
                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                        return 0;
                    }

                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return 0;
            }

        }
        public Customer Add(Customer customer)
        {


            try
            {
                using (IDbConnection connection = new SqlConnection(_context.Database.GetConnectionString()))
                {
                    int custId = GetId();
                    customer.Id = custId;
                   

                    try
                    {
                        var sql = "INSERT INTO Customers (Id, FirstName, LastName, Tax_Id, SSN, Cust_Type, Address, City, Postal_Code, Country, Phone, Cellular, Email) " +
    "VALUES (@Id, @FirstName, @LastName, @Tax_Id, @SSN, @Cust_Type, @Address, @City, @Postal_Code, @Country, @Phone, @Cellular, @Email); " +
    "SELECT @Id AS LastInsertedId;";

                       
                        var lastInsertedId = connection.QueryFirstOrDefault<int>(sql, customer);
                       
                        customer.Id = lastInsertedId;
                        return customer;
                    }
                    catch (Exception e)
                    {
                        string msg = e.Message;
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return null;
            }

        }
        public async Task<IEnumerable<CustomerListDto>> GetCustomerListAsycn()
        {
            string sql = @"select Id, FirstName + ' ' + LastName as FullName, Phone from Customers;";
            try
            {
                using (IDbConnection connection = new SqlConnection(_context.Database.GetConnectionString()))
                {
                    var data = await connection.QueryAsync<CustomerListDto>(sql, new { });
                    return data.ToList().AsQueryable();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return null;
            }

        }
    }
}
