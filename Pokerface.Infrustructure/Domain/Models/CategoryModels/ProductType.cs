using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Infrustructure.Domain.Models.CategoryModels
{
    public class ProductType : EntityTypeBase
    {
        public SubCategory SubCategory { get; set; }
    }
}
