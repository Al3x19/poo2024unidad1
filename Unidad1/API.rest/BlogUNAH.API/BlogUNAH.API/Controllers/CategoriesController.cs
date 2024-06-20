using BlogUNAH.API.Database.Entities;
using BlogUNAH.API.DTOS.Categories;
using BlogUNAH.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUNAH.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public List<Category> _categories {get; set; }

        public CategoriesController(ICategoriesService categoriesService) 
        {
            this._categoriesService = categoriesService;
        }
        [HttpGet]
        public async Task<ActionResult>  GetAll() 
        {
            return Ok(await _categoriesService.GetCategoriesListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get( Guid  id)
        {
            var category = await _categoriesService.GetCategoryByIdAsync(id);

            if (category != null)
            {
                return Ok(category);
            }

            return NotFound(new { Message = $"No se encontro la categoria: {id}" });
        }
        [HttpPost]

        public async Task<ActionResult> Create(CategoryCreateDto dto) 
        {
           
            await _categoriesService.CreateAsync(dto);

            //bool categoryExist = _categories.Any(x => x.Name.ToUpper().Trim().Contains(category.Name.ToUpper()));

            //if (!categoryExist)
            //{
            //    return BadRequest("La categoria ya esta registrada.");
            //}

            //category.Id = Guid.NewGuid();
            //_categories.Add(category);

            return StatusCode(201);
        }

        [HttpPut]
        public async Task<ActionResult> Edit(CategoryEditDto dto, Guid id) 
        {
            var result = await _categoriesService.EditAsync(dto, id);

            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) 
        {
            var category = await _categoriesService.GetCategoryByIdAsync(id);

            if (category is null)
            {
                return NotFound();
            }
            await _categoriesService.DeleteAsync(id);

            return Ok();
        }
    }
}
