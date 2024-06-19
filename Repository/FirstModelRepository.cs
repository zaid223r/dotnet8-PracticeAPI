using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeAPI.Data;
using PracticeAPI.Entities;
using PracticeAPI.Interfaces;
using PracticeAPI.Migrations;

namespace PracticeAPI.Repository
{
    public class FirstModelRepository : IFirstModelRepository
    {
        private readonly ApplicationDBContext _context;
        public FirstModelRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<FirstModel>> GetAllAsync()
        {
            return await _context.firstModel.ToListAsync();
        }
    }
}