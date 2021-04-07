using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Infrustructure.Domain.Models.CategoryModels
{
    public class EntityTypeBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
