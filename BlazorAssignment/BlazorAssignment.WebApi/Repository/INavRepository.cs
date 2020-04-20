using BlazorAssignment.Library.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.WebApi.Repository
{
    public interface INavRepository
    {
        Task<IEnumerable<TblNavData>> GetNavDatas();
    }
}
