﻿using Microsoft.AspNetCore.Mvc;
using WebHook1.Domain;
using WebHook1.Dtos.Login;
using WebHook1.Dtos.Profile;
using WebHook1.Dtos.Webhook;

namespace WebHook1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LineLoginController : ControllerBase
    {
        private readonly LineLoginService _lineLoginService;
        public LineLoginController()
        {
            _lineLoginService = new LineLoginService();
        }

        // 取得 Line Login 網址
        [HttpGet("Url")]
        public string GetLoginUrl([FromQuery] string redirectUrl)
        {
            return _lineLoginService.GetLoginUrl(redirectUrl);
        }

        // 使用 authToken 取回登入資訊
        [HttpGet("Tokens")]
        public async Task<TokensResponseDto> GetTokensByAuthToken([FromQuery] string authToken, [FromQuery] string callbackUrl)
        {
            return await _lineLoginService.GetTokensByAuthToken(authToken, callbackUrl);
        }

        // 使用 access token 取得 user profile
        [HttpGet("Profile/{accessToken}")]
        public async Task<UserProfileDto> GetUserProfileByAccessToken(string accessToken)
        {
            return await _lineLoginService.GetUserProfileByAccessToken(accessToken);
        }
    }
    
}
