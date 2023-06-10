using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Product.API.Core.Entities;
using Product.API.Core.Interfaces;
using Product.API.Dtos;
using System.Diagnostics.Eventing.Reader;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService,IMapper mapper)
        {
            _productService = productService;

            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductToCreateDto productToCreateDto)
        {
            ///automaptte
            var productDomain = _mapper.Map<Productt>(productToCreateDto);

            var prouctt = await _productService.CreateProduct(productDomain);

            //map db to diaply


            return Ok(_mapper.Map<ProductToDisplayDto>(productDomain));


        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var products=await _productService.GetProduct();

            return Ok(_mapper.Map<List<ProductToDisplayDto>>(products));

        }

        [HttpGet]
        [Route("{id}")]

        public async Task<IActionResult> GetById([FromRoute]long id) 
        {
            var product = await _productService.GetProductById(id);

            return Ok(product);
        
        }

        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update(long id,Productt productt)
        {
            var product =_productService.UpdateProduct(id, productt);

            return Ok(productt);
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> Delete(long id)
        {
            var productr=_productService.DeleteProduct(id); 

            return Ok(productr);
        }
    }
}
