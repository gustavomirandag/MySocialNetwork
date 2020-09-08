using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string UserEmail { get; set; }
        public string Message { get; set; }
        public string PhotoUrl { get; set; }
    }
}
