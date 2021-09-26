using System.Collections.Generic;
using WhateverHappens.Models;
using WhateverHappens.Data;
using Microsoft.AspNetCore.Mvc;

namespace WhateverHappens.Controllers 

{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
            private readonly INombre _repository;

            public CommandsController(INombre repository)
            {   
                _repository = repository;
            }

        //private readonly MockNombreRepo _repository = new MockNombreRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }
        [HttpGet("{id}")]
        //GET api/commands/{id}
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}