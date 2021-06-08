using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Web.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User Athor { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
    }
}
