using System;
using System.Threading.Tasks;
using McafeeRosterManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace McafeeRosterManagement.API.Repository {
    public class RosterAuthRepository : RosterIAuthRepository {
        private readonly RosterDBContext _context;
        public RosterAuthRepository (RosterDBContext context) {
            _context = context;
        }
        public async Task<Users> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.Passwordhash, user.Passwordsalt))
                return null;

            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        public async Task<Users> Register(Users user, string password)
        {
            Byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.Passwordhash = passwordHash;
            user.Passwordsalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private void CreatePasswordHash(string password, out Byte[] passwordHash, out Byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string email)
        {
            if (await _context.Users.AnyAsync(x => x.Email == email))
                return true;
            return false;
        }
    }
}