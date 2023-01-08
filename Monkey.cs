using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpopComebacks.Model
{
    public class Monkey
    {

        public Monkey(string name, string imageUrl)
            {
                this.Name = name;

                this.ImageUrl = imageUrl; 
            }

            public string Name { get; set; }

            public string ImageUrl { get; set; }
    }
}
