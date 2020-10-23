using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Entety
{
    public class Blog
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(5000)]
        public string Content { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
