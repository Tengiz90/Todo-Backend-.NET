using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Application.Services.Interfaces;
using TodoBackend.Application.Services.Models;
using TodoBackend.Domain.Models;

namespace TodoBackend.Application.Services.Implementations
{
    public class TokenService(IOptions<AuthSettings> options, IUserService userService) : ITokenService
    {

        public string GetAccessToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(options.Value.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserID", user.Id.ToString(), ClaimValueTypes.Integer)
                }),
                Expires = DateTime.UtcNow.Add(options.Value.AccessTokenExpires),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenData = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(tokenData);
        }

        public string GetRefreshToken()
        {
            var refreshToken = "";
            var isUnique = false;
            do
            {
                
                var randomBytes = new byte[32];
                RandomNumberGenerator.Fill(randomBytes);
                refreshToken = Convert.ToBase64String(randomBytes);

                isUnique = !userService.RefreshTokenAlreadyExists(refreshToken);

            } while (!isUnique);

            return refreshToken;
        }
    }
    
}
