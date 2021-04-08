using System.Collections.Generic;

namespace Pokerface.Domain.Models.CategoryModels
{
    public class Category : EntityTypeBase
    {
        public List<SubCategory> SubCategories { get; set; }
    }
}
