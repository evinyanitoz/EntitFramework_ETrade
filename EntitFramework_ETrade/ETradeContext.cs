﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntitFramework_ETrade
{
    public  class ETradeContext:DbContext
    {

        public DbSet<Product> Products { get; set; }

    }
}
