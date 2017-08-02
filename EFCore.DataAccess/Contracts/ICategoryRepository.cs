using EFCore.DataAccess.Infrastructure;
using EFCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.DataAccess.Contracts
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
