using CQRS.API.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Handlers.QueryHandlers
{
    public interface IGetProductByIdQueryHandler
    {
        Task<GetProductByIdQuery> GetProductByIdAsync(int ID);
    }
}
