using BlazorAssignment.Library.Models.entityModels;
using BlazorAssignment.WebApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.WebApi.Services
{
    public class NavService : INavRepository
    {
        public async Task<IEnumerable<TblNavData>> GetNavDatas()
        {
            StudentDBContext dBContext = new StudentDBContext();
            return  await dBContext.TblNavData.ToListAsync();
        }
    }
}

