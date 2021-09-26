using Microsoft.EntityFrameworkCore;
using WhateverHappens.Models;

namespace WhateverHappens.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }

    }
}