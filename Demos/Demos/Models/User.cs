using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl
        {
            get { return $"http://lorempixel.com/200/200/people/{Id}"; }
        }
    }
}
