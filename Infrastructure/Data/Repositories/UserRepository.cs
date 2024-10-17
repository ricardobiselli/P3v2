﻿using Domain.IRepositories;
using Domain.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<User> GetUserByEmailOrUsername(string emailOrUsername)
        {
            return _context.Users.FirstOrDefaultAsync(u =>
                u.Email.ToLower() == emailOrUsername.ToLower() ||
                u.UserName.ToLower() == emailOrUsername.ToLower());
        }
    }
}