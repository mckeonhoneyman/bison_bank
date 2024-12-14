﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BisonBank.Models;

namespace BisonBank.Data
{
    public class BisonBankContext : DbContext
    {
        public BisonBankContext (DbContextOptions<BisonBankContext> options)
            : base(options)
        {
        }

        public DbSet<BisonBank.Models.Account> Account { get; set; } = default!;
        public DbSet<BisonBank.Models.Transaction> Transaction { get; set; } = default!;
        public DbSet<BisonBank.Models.Transfer> Transfer { get; set; } = default!;
        public DbSet<BisonBank.Models.Withdrawal> Withdrawal { get; set; } = default!;
    }
}