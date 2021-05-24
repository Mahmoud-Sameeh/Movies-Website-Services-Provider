using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApicore2.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfJoing { get; set; }
    }
    public interface IjwtAuthnticationManger
    {
        string Authenticate(string username, string password);
    }
    
    public class jwtAuthnticationManger:IjwtAuthnticationManger
    {
        public jwtAuthnticationManger (string key)
        {
            this.key = key;
        }
        private readonly IDictionary<string, string> users = new Dictionary<string, string>() 
        { { "test1", "pass1" }, { "test2", "pass2" } };
        private string key;

        string IjwtAuthnticationManger.Authenticate(string username, string password)
        {
         if(!users.Any(u=>u.Key==username&&u.Value==password))
            {
                return null;
            }
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                new Claim (ClaimTypes.Name,username)
                }),

                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials=
                new SigningCredentials(new SymmetricSecurityKey(tokenkey),SecurityAlgorithms.HmacSha256)
            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            return tokenhandler.WriteToken(token); 
        }
    }
}
