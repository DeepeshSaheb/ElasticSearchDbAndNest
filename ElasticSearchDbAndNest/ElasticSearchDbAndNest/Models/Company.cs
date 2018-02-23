using ElasticSearchDbAndNest.Attributes;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElasticSearchDbAndNest.Models
{
    [ElasticIndexDetails("company", false)]
    [ElasticsearchType(Name = "company")]
    public class Company : EntityBase
    {
        [Keyword(Name="companyName")]
        public string CompanyName { get; set; }
    }
}