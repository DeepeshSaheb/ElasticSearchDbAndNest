using ElasticSearchDbAndNest.Attributes;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElasticSearchDbAndNest.Models
{
    [ElasticIndexDetails("all_log", true)]
    [ElasticsearchType(Name = "log")]
    public class Log : EntityBase
    {
        [Text(Name="logType")]
        public string LogType { get; set; }

        [Text(Name="description")]
        public string Description { get; set; }
    }
}