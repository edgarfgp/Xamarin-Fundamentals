using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Models
{
    class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }

        public string ImageUrl
        {
            get { return $"http://lorempixel.com/100/100/people/{UserId}"; }
        }

    }
}
