using CQRS.API.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Threading.Tasks;

namespace CQRS.API.Handlers.CommandHandlers
{
    public class UpdateProductCommandHandler : IUpdateProductCommandHandler
    {
        readonly IDbConnection _db;

        public UpdateProductCommandHandler()
        {
            _db = new SqlConnection("Data Source=.;Initial Catalog=CQRSEXAMPLE;Integrated Security=True;");
        }

        public async Task UpdateProductAsync(UpdateProductCommand updateProductCommand)
        {
            await _db.ExecuteAsync("UPDATE AA_PRODUCTS SET ProductName=@ProductName,ProductPrice=@ProductPrice WHERE ID = @ID",updateProductCommand);
        }
    }
}
