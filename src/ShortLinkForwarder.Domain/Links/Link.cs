using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace ShortLinkForwarder.Links
{
    public class Link : AggregateRoot<long>
    {
        public string OriginUrl { get; private set; }
        public string Token { get; private set; }
        public string Remarks { get; private set; }
        public bool Enabled { get; private set; }
        public DateTime UpdateTimeUtc { get; private set; }
        public DateTime ExpirationTimeUtc { get; private set; }

        public Link(string originUrl, string token, DateTime expirationTimeUtc, string remarks = null)
        {
            OriginUrl = originUrl;
            Token = token;
            ExpirationTimeUtc = expirationTimeUtc;
            Remarks = remarks;
            Enabled = true;
            UpdateTimeUtc = DateTime.UtcNow;
        }

        public void Enable()
        {
            Enabled = true;
            UpdateTimeUtc = DateTime.UtcNow;
        }

        public void Disable()
        {
            Enabled = false;
            UpdateTimeUtc = DateTime.UtcNow;
        }

        public void SetExpirationTime(DateTime expirationTimeUtc)
        {
            ExpirationTimeUtc = expirationTimeUtc;
        }
    }
}
