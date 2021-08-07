﻿using Business.Abstract;
using Entities.Dtos.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(CategoryAddDto addDto)
        {
            var addResult = await _categoryService.AddAsync(addDto);
            if (!addResult.Success)
                return BadRequest(addResult);

            return Ok(addDto);
        }
    }
}