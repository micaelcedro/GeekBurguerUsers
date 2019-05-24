using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurguer.Users.Contract
{
    public class UserRestrictionsToPost
    {
        public Guid Id { get; set; }
        public List<String> Restricoes { get; set; }
    }
}
