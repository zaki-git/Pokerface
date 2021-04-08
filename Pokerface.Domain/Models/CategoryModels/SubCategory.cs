using System.Collections.Generic;

namespace Pokerface.Domain.Models.CategoryModels
{
    public class SubCategory : EntityTypeBase
    {
        public Category Category { get; set; }

        public List<ProductType> ProductTypes { get; set; }
    }
}
