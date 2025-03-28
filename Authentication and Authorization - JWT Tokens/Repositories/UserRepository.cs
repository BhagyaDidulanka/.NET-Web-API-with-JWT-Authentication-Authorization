﻿using Authentication_and_Authorization___JWT_Tokens.Data;
using Authentication_and_Authorization___JWT_Tokens.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication_and_Authorization___JWT_Tokens.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context=context;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
