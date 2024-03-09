using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mujo.Models;

namespace mujo.Interfaces
{
    public interface ITheModelRepository
    {
        Task<List<TheModel>> GetTheModels();
        Task<TheModel> CreateTheModel(TheModel theModel);
    }
}