using System.Collections.Generic;
using WhateverHappens.Models;

namespace WhateverHappens.Data
{
    public class MockNombreRepo : INombre
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            { 
                new Command{Id=0, prop2="field1", Line="field2", Platform="field3"},
                new Command{Id=1, prop2="field1.5", Line="field2.5", Platform="field4"},
                new Command{Id=2, prop2="field2.0", Line="field3.0", Platform="field5"}
            };
        
             return commands;
        }

        public Command GetCommandById(int id)
            {
                return new Command{Id=0, prop2="field10", Line="field20", Platform="field30"};
            }
    }
}