using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mujo.Data;
using mujo.Interfaces;
using mujo.Models;

namespace mujo.Repositories
{
    public class TheModelRepository : ITheModelRepository
    {
        private readonly ApplicationDbContext _context;
        public TheModelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TheModel> CreateTheModel(TheModel theModel)
        {
            await _context.TheModels.AddAsync(theModel);
            await _context.SaveChangesAsync();

            return theModel;
        }

        public async Task<List<TheModel>> GetTheModels()
        {
            var allTheModels = await _context.TheModels.ToListAsync();

            return allTheModels;
        }
    }
}