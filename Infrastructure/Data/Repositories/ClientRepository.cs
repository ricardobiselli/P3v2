﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.IRepositories;
using Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Infrastructure.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        private readonly ApplicationDbContext _context;
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}



//        public async Task<Client> GetByIdAsync(int id)
//        {
//            return await _context.Clients.FindAsync(id);
//        }

//        public async Task<IEnumerable<Client>> GetAllAsync()
//        {
//            return await _context.Clients.ToListAsync();
//        }

//        public async Task AddAsync(Client client)
//        {
//            _context.Clients.Add(client);
//            await _context.SaveChangesAsync();
//        }

//        public async Task DeleteAsync(int id)
//        {
//            var client = await _context.Clients.FindAsync(id);
//            if (client != null)
//            {
//                _context.Clients.Remove(client);
//                await _context.SaveChangesAsync();
//            }

//        }

//        public async Task UpdateAsync(Client client)
//        {
//            _context.Clients.Update(client);
//            await _context.SaveChangesAsync();
//        }

//    }
//}





