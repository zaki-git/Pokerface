using Pokerface.Infrustructure.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerface.Infrustructure.Domain.Models.UserModels
{
    public class UserModelBase
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public UserType UserType { get; set; } 
    }
}
