using CQRS.API.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using CQRS.API.Queries.Response;

namespace CQRS.API.Handlers.QueryHandlers
{
    public class GetProductByIdQueryHandler : IGetProductByIdQueryHandler
    {
        readonly IDbConnection _db;

        public GetProductByIdQueryHandler()
        {
            _db = new SqlConnection("Data Source=.;Initial Catalog=CQRSEXAMPLE;Integrated Security=True;");
        }

        public async Task<GetProductByIdQuery> GetProductByIdAsync(int ID)
        {
            return (GetProductByIdQuery)await _db.QueryFirstOrDefaultAsync<GetProductByIdQuery>("SELECT * FROM AA_PRODUCTS WHERE ID = @ID",new {ID = ID });
        }
    }
}
