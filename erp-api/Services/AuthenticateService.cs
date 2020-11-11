using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using erp_api.Data.DTO;
using erp_api.Helpers;
using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Services
{
    public interface IAuthenticateService
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        Task<IEnumerable<Contact>> GetAll(string id);
        Task<Contact> GetById(string id);
    }

    public class AuthenticateService : IAuthenticateService
    {
        private readonly AppSettings _appSettings;
        private readonly ContactsRepository contacts;

        public AuthenticateService(IOptions<AppSettings> appSettings, ContactsRepository contacts)
        {
            _appSettings = appSettings.Value;
            this.contacts = contacts;
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            var user = await contacts.GetAuthenticate(model);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        // helper methods

        private string generateJwtToken(Contact user)
        {
            // generate token that is valid for a limited period of time
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddMinutes(5), // AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<IEnumerable<Contact>> GetAll(string id)
        {
            return await contacts.GetAll();
        }
        
        public async Task<Contact> GetById(string id)
        {
            return await contacts.Get(id);
        }

    }
}