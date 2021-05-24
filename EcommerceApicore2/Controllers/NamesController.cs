using EcommerceApicore2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceApicore2.Controllers
{
    //[Authorize]
    //[Route("api/[controller]")]
    //[ApiController]
    //public class NamesController : Controller
    //{
    //    private IConfiguration _config;

    //    public NamesController(IConfiguration config)
    //    {
    //        _config = config;
    //    }
    //    // GET: api/<NamesController>
    //    [HttpGet]
    //    public IEnumerable<string> Get()
    //    {
    //        return new string[] { "value1", "value2" };
    //    }

    //    // GET api/<NamesController>/5
    //    [HttpGet("{id}")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }
    //    [AllowAnonymous]
    //    [HttpPost]
    //    public IActionResult Login([FromBody] UserModel login)
    //    {
    //        IActionResult response = Unauthorized();
    //        var user = AuthenticateUser(login);

    //        if (user != null)
    //        {
    //            var tokenString = GenerateJSONWebToken(user);
    //            response = Ok(new { token = tokenString });
    //        }

    //        return response;
    //    }
    //    [AllowAnonymous]
    //    [HttpPost("authenticate")]
    //    public IActionResult Authenticate([FromBody] UserCred userCred)
    //    {
    //        var w = new UserModel() { Username = userCred.username, Password = userCred.password };
    //        var token =AuthenticateUser(w);
    //        if (token != null)
    //        {
    //            var tok = GenerateJSONWebToken(token);
    //            return Ok(tok);
    //        }
    //        return NotFound();
    //    }
    //    private string GenerateJSONWebToken(UserModel userInfo)
    //    {
    //        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
    //        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

    //        var claims = new[] {
    //            new Claim(JwtRegisteredClaimNames.Sub, userInfo.Username),
    //            new Claim(JwtRegisteredClaimNames.Email, userInfo.EmailAddress),
    //            new Claim("DateOfJoing", userInfo.DateOfJoing.ToString("yyyy-MM-dd")),
    //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    //        };

    //        var token = new JwtSecurityToken(_config["Jwt:Issuer"],
    //            _config["Jwt:Issuer"],
    //            claims,
    //            expires: DateTime.Now.AddMinutes(120),
    //            signingCredentials: credentials);

    //        return new JwtSecurityTokenHandler().WriteToken(token);
    //    }

    //    private UserModel AuthenticateUser(UserModel login)
    //    {
    //        UserModel user = null;

    //        //Validate the User Credentials
    //        //Demo Purpose, I have Passed HardCoded User Information
    //        if (login.Username == "test1")
    //        {
    //            user = new UserModel { Username = "test1", EmailAddress = "test.btest@gmail.com", DateOfJoing = new DateTime(2010, 08, 02) };
    //        }
    //        return user;
    //    }
    //}
}
