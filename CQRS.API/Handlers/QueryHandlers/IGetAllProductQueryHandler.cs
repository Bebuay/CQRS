using CQRS.API.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Handlers.QueryHandlers
{
    public interface IGetAllProductQueryHandler
    {
        Task<List<GetAllProductQuery>> GetAllProductsAsync();
    }
}
