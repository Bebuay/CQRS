using CQRS.API.Commands;
using CQRS.API.Handlers.CommandHandlers;
using CQRS.API.Handlers.QueryHandlers;
using CQRS.API.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGetAllProductQueryHandler _getAllProductQueryHandler;
        private readonly IGetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly IAddProductCommandHandler _addProductCommandHandler;
        private readonly IDeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly IUpdateProductCommandHandler _updateProductCommandHandler;

        public ProductController(IGetAllProductQueryHandler getAllProductQueryHandler,IGetProductByIdQueryHandler getProductByIdQueryHandler,IAddProductCommandHandler addProductCommandHandler,IDeleteProductCommandHandler deleteProductCommandHandler,IUpdateProductCommandHandler updateProductCommandHandler)
        {
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _addProductCommandHandler = addProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProductAsync()
        {
            var response = await _getAllProductQueryHandler.GetAllProductsAsync();
            return Ok(response);
        }

        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProductByIdAsync(int ID)
        {
            var response = await _getProductByIdQueryHandler.GetProductByIdAsync(ID);
            return Ok(response);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProductAsync(AddProductCommand addProductCommand)
        {
            await _addProductCommandHandler.AddProductCommandAsync(addProductCommand);
            return Ok();
        }

        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProductAsync(DeleteProductCommand deleteProductCommand)
        {
            await _deleteProductCommandHandler.DeleteProductAsync(deleteProductCommand);
            return Ok();
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductCommand updateProductCommand)
        {
            await _updateProductCommandHandler.UpdateProductAsync(updateProductCommand);
            return Ok();
        }
    }
}
