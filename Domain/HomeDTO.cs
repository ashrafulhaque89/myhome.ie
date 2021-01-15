using System;
using System.Collections.Generic;

namespace Application.Homes
{
    public class SearchResult
    {
        public List<HomeDTO> SearchResults { get; set; }
    }
    public class HomeDTO
    {
        public int PropertyId { get; set; }
        public string GroupLogoUrl { get; set; }
        public string BedsString { get; set; }
        public dynamic Price {get; set;}
        public double SizeStringMeters { get; set; }
        public string DisplayAddress { get; set; }
        public string PropertyType { get; set; }
        public string BathString { get; set; }
        public string BerRating { get; set; }
        public string MainPhoto { get; set; }
        public string[] Photo { get; set;}
    }
}
