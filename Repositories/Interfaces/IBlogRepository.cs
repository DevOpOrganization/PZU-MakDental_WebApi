using Models.Dto;
using Models.Entety;

using System;
using System.Linq;

namespace Repositories.Interfaces
{
    public interface IBlogRepository
    {

        IQueryable<Blog> GetAll();
        Blog Get(Guid id);
        Blog Add(Blog item);
        Blog Edit(BlogDtoEdit item);
        int Delete(Guid id);
    }
}
