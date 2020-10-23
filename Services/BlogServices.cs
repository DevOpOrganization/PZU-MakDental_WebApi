using Models.Dto;
using Models.Entety;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class BlogServices : IBlogServices
    {

        private readonly IBlogRepository _blogRepository;
        public BlogServices(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }


        public IEnumerable<BlogDtoGetAll> GetAll()
        {

            try
            {
                return _blogRepository.GetAll().Select(x => new BlogDtoGetAll()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Content = x.Content,
                    Created = x.Created,
                    Updated = x.Updated

                }).AsEnumerable();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public Blog Get(Guid id)
        {
            try
            {
                return _blogRepository.Get(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public Blog Add(BlogDtoAdd item)
        {

            try
            {

                var newBlog = new Blog()
                {
                    Title = item.Title,
                    Content = item.Content,
                    Created = DateTime.Now,

                };

                return _blogRepository.Add(newBlog);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public Blog Edit(BlogDtoEdit item)
        {
            try
            {
                return _blogRepository.Edit(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public bool Delete(Guid id)
        {
            try
            {
                var result = _blogRepository.Delete(id);

                if (result < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }




        }


    }




}
