using Pokerface.Domain.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Contracts.ServiceContracts
{
    public interface ICategoryService
    {
        List<Category> GetAllCategory();
    }
}
