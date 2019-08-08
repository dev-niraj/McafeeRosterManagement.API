using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using McafeeRosterManagement.API.Dtos;
using McafeeRosterManagement.API.Models;
using McafeeRosterManagement.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace McafeeRosterManagement.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase {
        private readonly RosterIAuthRepository _repo;
        private readonly IConfiguration _config;

        public AuthController (RosterIAuthRepository repo, IConfiguration config) {
            _config = config;
            _repo = repo;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Email = userForRegisterDto.Email.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Email))
                ModelState.AddModelError("Email","Email already exists");

            // validate request
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userToCreate = new Users
            {
                Wwid = userForRegisterDto.Wwid,
                Name = userForRegisterDto.Name,
                Role = userForRegisterDto.Role,
                Email = userForRegisterDto.Email,
                TId = userForRegisterDto.TId,
                Type = userForRegisterDto.Type,
                PhoneNo = userForRegisterDto.PhoneNo,
                Status = userForRegisterDto.Status,
                BuId = userForRegisterDto.BuId

            };

            var createUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
        


        [HttpPost ("login")]
        public async Task<IActionResult> Login ([FromBody] UserForLoginDtos userForLoginDtos) {
            var userFromRepo = await _repo.Login (userForLoginDtos.Email, userForLoginDtos.Password);

            Console.WriteLine(userForLoginDtos.Email);
            Console.WriteLine(userForLoginDtos.Password);

            if (userFromRepo == null)
                return Unauthorized ();

            var claims = new [] {
                new Claim (ClaimTypes.NameIdentifier, userFromRepo.Wwid.ToString ()),
                new Claim (ClaimTypes.Email, userFromRepo.Email.ToString()),
                new Claim (ClaimTypes.Name, userFromRepo.Name.ToString()),
                new Claim (ClaimTypes.Role, userFromRepo.Role.ToString())
            };

            var key = new SymmetricSecurityKey (Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new {
                token = tokenHandler.WriteToken(token) 
            });
        }
    }
}