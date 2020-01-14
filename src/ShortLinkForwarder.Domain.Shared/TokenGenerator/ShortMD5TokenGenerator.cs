using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ShortLinkForwarder.TokenGenerator
{
    /// <summary>
    /// 摘要算法
    /// </summary>
    public class ShortMD5TokenGenerator : ITokenGenerator
    {
        private const int length = 8;

        public string GenerateToken(string url)
        {
            return url.ToMd5().Substring(0, length).ToLower();
        }

        public bool TryParseToken(string input, out string token)
        {
            token = null;
            if (input.Length != length)
            {
                return false;
            }
            token = input;
            return true;
        }
    }
}
