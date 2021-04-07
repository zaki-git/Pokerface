using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Infrustructure.Domain.Models.CategoryModels
{
    public class SubCategory : EntityTypeBase
    {
        public Category Category { get; set; }

        public List<ProductType> ProductTypes { get; set; }
    }
}
