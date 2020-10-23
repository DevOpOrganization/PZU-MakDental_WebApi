using AServerData;
using Models.Dto;
using Models.Entety;
using Repositories.Interfaces;
using System;
using System.Linq;

namespace Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private MdDbContext _mdDbContext;

        public BlogRepository(MdDbContext mdDbContext)
        {
            _mdDbContext = mdDbContext;
        }



        public IQueryable<Blog> GetAll()
        {
            return _mdDbContext.Blogs.AsQueryable();

        }
        public Blog Get(Guid id)
        {
            return _mdDbContext.Blogs.FirstOrDefault(x => x.Id == id);
        }


        public Blog Add(Blog item)
        {
            _mdDbContext.Blogs.Add(item);
            _mdDbContext.SaveChanges();
            return item;
        }



        public Blog Edit(BlogDtoEdit item)
        {
            var blog = _mdDbContext.Blogs.Find(item.Id);

            blog.Title = item.Title;
            blog.Content = item.Content;
            blog.Updated = DateTime.Now;

            _mdDbContext.SaveChanges();
            return blog;
        }


        public int Delete(Guid id)
        {
            var blog = _mdDbContext.Blogs.Find(id);

            _mdDbContext.Remove(blog);
            return _mdDbContext.SaveChanges();


        }

       
    }
}
