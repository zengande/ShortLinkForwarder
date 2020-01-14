using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using ShortLinkForwarder.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace ShortLinkForwarder.Web.Controllers
{
    [Route("fw")]
    public class ForwardController : AbpController
    {
        private readonly ILinkForwarderAppService _service;
        private readonly ILogger<ForwardController> _logger;
        public ForwardController(ILinkForwarderAppService service,
            ILogger<ForwardController> logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet, Route("{token}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest();
            }
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var ua = Request.Headers["User-Agent"];
            if (string.IsNullOrWhiteSpace(ua))
            {
                _logger.LogWarning($"'{ip}' requested token '{token}' without User Agent. Request is blocked.");
                return BadRequest();
            }

            return await TokenRedirect(token, ip, ua);
        }

        private async Task<IActionResult> TokenRedirect(string token, string ip, StringValues ua)
        {
            // TODO 完成逻辑
            return Redirect("/");
        }
    }
}
