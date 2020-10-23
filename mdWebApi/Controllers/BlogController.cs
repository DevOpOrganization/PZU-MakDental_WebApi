using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Models.Entety;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace mdWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogServices _blogServices;

        public BlogController(IBlogServices blogServices)
        {
            _blogServices = blogServices;
        }

        [HttpGet("getAll")]
        public IEnumerable<BlogDtoGetAll> GetAll()
        {
            return _blogServices.GetAll();
        }

        [HttpGet("getBlog")]
        public Blog Get(Guid id)
        {
            return _blogServices.Get(id);
        }

        [HttpPost("addBlog")]
        public Blog Add(BlogDtoAdd blog)
        {
            return _blogServices.Add(blog);

        }

        [HttpPut("updateBlog")]
        public Blog Update(BlogDtoEdit blog)
        {
            return _blogServices.Edit(blog);
        }

        [HttpDelete("deleteBlog")]
        public bool Delete(Guid id)
        {

            return _blogServices.Delete(id);

        }
    }
}
