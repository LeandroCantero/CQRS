using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandService.Models;

namespace CommandService.Commands.Interfaces
{
    public interface IProductCommand
    {
        Task<ProductCommandModel> AddProductAsync(ProductCommandModel model);
        Task<bool> UpdateProductAsync(ProductCommandModel model);
        Task<bool> DeleteProductAsync(int id);
    }
}
