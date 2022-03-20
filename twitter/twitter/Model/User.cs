using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace twitter.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
