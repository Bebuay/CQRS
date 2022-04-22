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
    public class DeleteProductHandler : IDeleteProductCommandHandler
    {
        readonly IDbConnection _db;

        public DeleteProductHandler()
        {
            _db = new SqlConnection("Data Source=.;Initial Catalog=CQRSEXAMPLE;Integrated Security=True;");
        }

        public async Task DeleteProductAsync(DeleteProductCommand deleteProductCommand)
        {
            await _db.ExecuteAsync("DELETE FROM AA_PRODUCTS WHERE ID=@ID",deleteProductCommand);
        }
    }
}
