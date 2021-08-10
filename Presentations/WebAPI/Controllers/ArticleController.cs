using Business.Abstract;
using Entities.Dtos.Article;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService  articleService)
        {
            _articleService = articleService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(ArticleAddDto addDto)
        {
            var addResult = await _articleService.AddAsync(addDto);
            if (!addResult.Success)
                return BadRequest(addResult);

            return Ok(addResult);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var categoriesResult = await _articleService.GetAllAsync();
            if (!categoriesResult.Success)
                return BadRequest(categoriesResult);

            return Ok(categoriesResult);

        }
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(ArticleUpdateDto updateDto)
        {
            var updateResult = await _articleService.UpdateAsync(updateDto);
            if (!updateResult.Success)
                return BadRequest(updateResult);

            return Ok(updateResult);

        }

    }
}
