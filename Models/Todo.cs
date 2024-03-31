using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_API.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}