﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Context :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet <Duyurular> Duyurulars { get; set; }
    }
}