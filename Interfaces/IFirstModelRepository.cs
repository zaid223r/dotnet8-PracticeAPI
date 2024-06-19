using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeAPI.Entities;

namespace PracticeAPI.Interfaces
{
    public interface IFirstModelRepository
    {
        Task<List<FirstModel>> GetAllAsync();
    }
}