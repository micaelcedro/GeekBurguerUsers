﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurguer.Users.Contract
{
    public class User
    {
        public Guid Id { get; set; }
        public Byte[] Face { get; set; }
        public List<string> Restricoes { get; set; }
    }
}
