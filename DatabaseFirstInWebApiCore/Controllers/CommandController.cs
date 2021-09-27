using Data;
using Data.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirstInWebApiCore.Controllers
{
    [ApiController]
    [Route(template:"[Controller]")]
   


    public class CommandController : Controller
    {
        public CommandController(ICommandRepository commandRepository) :base()
        {
            _commandRepository = commandRepository;
        }
        internal ICommandRepository _commandRepository { get;}


        //  Command/getCommand
        [HttpGet(template: "getCommand")]
        public async Task<ActionResult<IList<Models.Command>>> getCommand()
        {

            var res=await _commandRepository.GetAllAsync();
            return Ok(value:res);
        }

    }
}
