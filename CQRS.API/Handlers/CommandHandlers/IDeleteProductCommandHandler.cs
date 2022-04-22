using CQRS.API.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Handlers.CommandHandlers
{
    public interface IDeleteProductCommandHandler
    {
        Task DeleteProductAsync(DeleteProductCommand deleteProductCommand);
    }
}
