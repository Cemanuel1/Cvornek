using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cvornek.Models
{
    public class CvornekModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Skills { get; set; }
        public HttpPostedFileBase PImage { get; set; }
        public HttpPostedFileBase Documents { get; set; }
    }
}