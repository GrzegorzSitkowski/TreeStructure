using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Leafs;
using TreeStructure.Application.Leafs.Commands.CreateLeaf;
using TreeStructure.Application.Leafs.Commands.DeleteLeaf;
using TreeStructure.Application.Leafs.Commands.UpdateLeaf;
using TreeStructure.Application.Leafs.Queries.GetLeafDetail;
using TreeStructure.Domain;

namespace TreeStructure.Api.Controllers
{
    [Route("api/leafs")]
    public class LeafsController : BaseApiController
    {
        private readonly IDataContext _context;
        public LeafsController(IDataContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<LeafDetailVm>> GetLeaf(int id)
        {
            var vm = await Mediator.Send(new GetLeafDetailQuery() { Id = id });
            return vm;
        }
        [HttpGet]
        public async Task<ActionResult<LeafDto>> GetLeafs()
        {
            var leafs = await _context.Leafs.AsNoTracking().Where(p => p.ParentId != null).ToListAsync();
            return Ok(leafs);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLeaf(CreateLeafCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeaf(UpdateLeafCommand command)
        {
            var leaf = await Mediator.Send(command);
            return Ok(leaf);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeaf(int id)
        {
            var leaf = await Mediator.Send(new DeleteLeafCommand() { Id = id });
            return Ok(leaf);
        }
    }
}
