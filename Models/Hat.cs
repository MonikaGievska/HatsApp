using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HatsAplpication.Models
{
    public class Hat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Gender { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImgURL { get; set; }

        public Hat() { }

    }
}