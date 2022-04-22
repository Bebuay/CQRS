using CQRS.API.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CQRS.API.Handlers.CommandHandlers
{
    public class AddProductCommandHandler : IAddProductCommandHandler
    {
        readonly IDbConnection _db;

        public AddProductCommandHandler()
        {
            _db = new SqlConnection("Data Source=.;Initial Catalog=CQRSEXAMPLE;Integrated Security=True;");
        }

        public async Task AddProductCommandAsync(AddProductCommand addProductCommand)
        {
           await _db.ExecuteAsync("INSERT INTO AA_PRODUCTS (ProductName,ProductPrice) Values(@ProductName,@ProductPrice)", addProductCommand);
        }
    }
}
