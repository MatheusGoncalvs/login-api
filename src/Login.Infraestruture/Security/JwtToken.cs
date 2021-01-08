using System;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace Login.Infraestruture.Security
{
    public class JwtToken
    {
        private readonly IConfiguration _configuration;

        public JwtToken(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string GerarTokenJwt(Guid idUsuario)
        {
            var meuClaims = new[]
            {
                    new Claim("claimIdUsuario", idUsuario.ToString())
            };

            var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration["JwtTokenKey"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    issuer: "www",
                    audience: "www",
                    claims: meuClaims,
                    expires: DateTime.Now.AddDays(7),
                    signingCredentials: creds);

            string retorno = new JwtSecurityTokenHandler().WriteToken(token);

            return retorno;
        }
        public string ObterIdDoToken(string Authorization)
        {
            string tirandoAPalavraBearer = Authorization.Substring(7);
            string token = tirandoAPalavraBearer;
            var manipularOToken = new JwtSecurityTokenHandler();
            var tokenEmJson = manipularOToken.ReadToken(token) as JwtSecurityToken;

            var idObtidoDoTokenString = tokenEmJson.Claims.First(claim => claim.Type == "claimIdUsuario").Value;

            return idObtidoDoTokenString;
        }
    }
}