using System;
using System.Collections.Generic;

namespace LoveMarriage.Data.Models
{
    public partial class LoveMarriageUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmailId { get; set; }
        public string UserPassword { get; set; }
    }
}
