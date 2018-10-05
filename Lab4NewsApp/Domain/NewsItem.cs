using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4NewsApp.Domain
{
    public class NewsItem
    {
        public long Id { get; set; }
        public DateTime PublishTime { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
    }
}
