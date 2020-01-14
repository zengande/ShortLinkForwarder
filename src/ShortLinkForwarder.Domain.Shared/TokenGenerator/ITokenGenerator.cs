using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace ShortLinkForwarder.TokenGenerator
{
    public interface ITokenGenerator : ISingletonDependency
    {
        string GenerateToken(string url);

        bool TryParseToken(string input, out string token);
    }
}
