using System.Collections.Generic;
using WhateverHappens.Models;

namespace WhateverHappens.Data

{
    public interface INombre
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}