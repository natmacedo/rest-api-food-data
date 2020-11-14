using FoodApi.Models;
using FoodApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FoodApi.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductsControllers : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsControllers(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Products>> Get() =>
            _productService.Get();

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public ActionResult<Products> Get(string id)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public ActionResult<Products> Create(Products product)
        {
            _productService.Create(product);

            return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Products productIn)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            _productService.Update(id, productIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            _productService.Remove(product.Id);

            return NoContent();
        }
    }
}