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

        public async Task<FirstModel> CreateAsync(FirstModel firstModel)
        {
            await _context.firstModel.AddAsync(firstModel);
            await _context.SaveChangesAsync();

            return firstModel;
        }

        public async Task<FirstModel?> DeleteAsync(int id)
        {
            var firstModel = await _context.firstModel.FirstOrDefaultAsync(x => x.Id == id);

            if (firstModel == null)
            {
                return null;
            }

            _context.firstModel.Remove(firstModel);
            await _context.SaveChangesAsync();    

            return firstModel;
        }

        public async Task<List<FirstModel>> GetAllAsync()
        {
            return await _context.firstModel.ToListAsync();
        }

        public async Task<FirstModel?> UpdateAsync(int id, FirstModel firstModel)
        {
            var firstModel1 = await _context.firstModel.FirstOrDefaultAsync(x => x.Id == id);

            if (firstModel1 == null)
            {
                return null;
            }

            firstModel1.Name = firstModel.Name;
            firstModel1.FirstName = firstModel.FirstName;
            firstModel1.LastName = firstModel.LastName;
            firstModel1.Place = firstModel.Place;

            await _context.SaveChangesAsync();

            return firstModel1;
        }
    }
}