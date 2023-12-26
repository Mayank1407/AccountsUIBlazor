﻿using AccontApi.Core;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountApi.Sql.Queries;
using AccountApi.Application.Interfaces;
using AccountApi.Core;
using AccountApi.Core.Entities;

namespace AccountApi.Infrastructure.Repository
{
    public class StockInRepository : IStockInRepository
    {

        private readonly IConfiguration configuration;
       
        public StockInRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<IReadOnlyList<StockIn>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<StockIn>(CustomerQueries.AllCustomer);
                return result.ToList();
            }
        }

        public async Task<StockIn> GetByIdAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<StockIn>(CustomerQueries.CustomerById, new { CustomerId = id });
                return result;
            }
        }

        public async Task<string> AddAsync(StockIn entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(CustomerQueries.AddCustomer, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(StockIn entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(CustomerQueries.UpdateCustomer, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(CustomerQueries.DeleteCustomer, new { CustomerId = id });
                return result.ToString();
            }
        }


        public async Task<int> GetVendorLoadCount(int vendorid, string createdDate)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<StockIn>(CustomerQueries.CustomerById, new { CustomerId = 1 });
                return 0;
            }
        }

        public async Task<List<StockIn>> GetStockInDataAsperDates(string fromDate, string toDate)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(CustomerQueries.CustomerById, new { CustomerId = 1 });
                return null;
            }
        }


    }
}
