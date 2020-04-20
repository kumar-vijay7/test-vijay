﻿using BlazorAssignment.Library.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Respository
{
    public interface INavRepository
    {
        List<TblNavData> GetNavDatas();
    }
}
