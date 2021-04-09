using Pokerface.Domain.Models.CategoryModels;
using Pokerface.Repository.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(PokerfaceContext context) : base(context)
        {
        }
    }
}
