using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Home
    {
        [Key]
        public int PropertyId { get; set; }
        public string GroupLogoUrl { get; set; }
        public string BedsString { get; set; }
        public string Price { get; set; }
        public double SizeStringMeters { get; set; }
        public string DisplayAddress { get; set; }
        public string PropertyType { get; set; }
        public string BathString { get; set; }
        public string BerRating { get; set; }
        public string MainPhoto { get; set; }
        public string Photos { get; set; }
    }
}
