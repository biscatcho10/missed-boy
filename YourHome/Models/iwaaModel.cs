using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YourHome.Models
{
    public class iwaaModel
    {
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Mail { get; set; }
        public string Photos { get; set; }

        public virtual City City { get; set; }

        public List<string> imagesList  { get; set; }
    }
}