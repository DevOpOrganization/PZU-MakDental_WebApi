using System;

namespace Models.Dto
{
    public class BlogDtoEdit
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Updated { get; set; }

    }
}
