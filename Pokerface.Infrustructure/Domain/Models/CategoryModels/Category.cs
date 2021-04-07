using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Infrustructure.Domain.Models.CategoryModels
{
    public class Category : EntityTypeBase
    {
        public List<SubCategory> SubCategories { get; set; }
    }
}
