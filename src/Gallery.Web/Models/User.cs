using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Social_media> Social_medias { get; set; } = new List<Social_media>();
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
