using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iostream.Models.Dbb
{
    public class Request
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Text { get; set; }
    }
}
