using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Commands
{
    public class DeleteProductCommand
    {
        public int ID { get; set; }
    }
}
