using HatsAplpication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HatsAplpication.Models
{
    public class HatsDetails
    {
        public int Id { get; set; }
        public Hat hat { get; set; }
        public string Description { set; get; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Code { get; set; }

        public HatsDetails() { }

    }
}