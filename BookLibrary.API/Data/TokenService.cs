using BookLibrary.Models;
using BookLibraryAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System.Formats.Tar;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookLibraryAPI.Data
{
    public class TokenService
    {
        public string GenerateJwtToken(string username, List<Role> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuv0123456789");
            ClaimsIdentity clainIdentity = new ClaimsIdentity();
            clainIdentity.AddClaim(new Claim(ClaimTypes.Name, username));
            GetCaimsFromRoles(clainIdentity, roles);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = clainIdentity,
                Issuer = "statsApp",
                Audience = "https://localhost:7065",
                Expires = DateTime.UtcNow.AddHours(1), // Set the token expiration time
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private void GetCaimsFromRoles(ClaimsIdentity clainIdentity,List<Role> roles)
        {
            foreach(var role in roles)
            {
                clainIdentity.AddClaim(new Claim(ClaimTypes.Role, role.Type));
            }
        }
    }
}
