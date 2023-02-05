using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.model
{
    public class saveimage
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public saveimage(string id, string image)
        {
            Id = id;
            Image = image;
        }
    }
}
