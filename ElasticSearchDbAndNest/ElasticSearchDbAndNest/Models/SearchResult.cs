using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElasticSearchDbAndNest.Models
{
    public class SearchResult<T>
    {
        public SearchResult(List<T> results, string scrollId)
        {
            Results = results;
            ScrollId = scrollId;
        }
        public List<T> Results { get; set; }
        public string ScrollId { get; set; }
    }
}