using Microsoft.Extensions.Logging;
using ShortLinkForwarder.EntityFrameworkCore.Repositories;
using ShortLinkForwarder.Links.Dtos;
using ShortLinkForwarder.TokenGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ShortLinkForwarder.Links
{
    public class LinkForwarderAppService : ApplicationService, ILinkForwarderAppService
    {
        private readonly ILinkRepository _repository;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly ILogger<LinkForwarderAppService> _logger;
        public LinkForwarderAppService(ILinkRepository repository,
            ITokenGenerator tokenGenerator,
            ILogger<LinkForwarderAppService> logger)
        {
            _logger = logger;
            _repository = repository;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<bool> IsLinkExistsAsync(string token)
        {
            return (await _repository.GetByTokenAsync(token)) != null;
        }

        public async Task<string> CreateAsync(CreateLinkDto dto)
        {
            var tempLink = await _repository.FindOneAsync(l => l.OriginUrl == dto.OriginUrl);
            if (tempLink != null)
            {
                if (_tokenGenerator.TryParseToken(tempLink.Token, out var tk))
                {
                    _logger.LogInformation($"Link already exists for token '{tk}'");
                    return tk;
                }
                _logger.LogError($"Invalid token '{tempLink.Token}' found for existing url '{dto.OriginUrl}'");
            }

            var token = string.Empty;
            do
            {
                token = _tokenGenerator.GenerateToken(dto.OriginUrl);
            } while ((await _repository.GetByTokenAsync(token)) != null);

            _logger.LogInformation($"Generated Token '{token}' for url '{dto.OriginUrl}'");

            var link = new Link(dto.OriginUrl, token, dto.ExpirationTimeUtc, dto.Remarks);

            await _repository.InsertAsync(link, true);
            return token;
        }
    }
}
