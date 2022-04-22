using CQRS.API.Handlers.QueryHandlers;
using CQRS.API.Queries;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Handlers
{
    public class GetAllProductQueryHandler :IGetAllProductQueryHandler
    {
        readonly IDbConnection _db;

        public GetAllProductQueryHandler()
        {
            _db = new SqlConnection("Data Source=.;Initial Catalog=CQRSEXAMPLE;Integrated Security=True;");
        }

        public async Task<List<GetAllProductQuery>> GetAllProductsAsync()
        {
            return (List<GetAllProductQuery>)await _db.QueryAsync<GetAllProductQuery>("SELECT * FROM AA_PRODUCTS");
        }
    }
}
