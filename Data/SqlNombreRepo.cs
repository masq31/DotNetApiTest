using System.Collections.Generic;
using System.Linq;
using WhateverHappens.Models;

namespace WhateverHappens.Data
{
    public class SqlNombreRepo : INombre
    {
        private readonly CommanderContext _context;

        public SqlNombreRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);

        }

    }
}

