using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLinkForwarder.Links.Dtos
{
    public class CreateLinkDto
    {
        public string OriginUrl { get; set; }

        public string Remarks { get; set; }
        public DateTime ExpirationTimeUtc { get; set; }
    }
}
