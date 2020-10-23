using Models.Dto;
using Models.Entety;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBlogServices
    {
        IEnumerable<BlogDtoGetAll> GetAll();
        Blog Get(Guid id);
        Blog Add(BlogDtoAdd item);
        Blog Edit(BlogDtoEdit item);
        bool Delete(Guid id);

    }
}
