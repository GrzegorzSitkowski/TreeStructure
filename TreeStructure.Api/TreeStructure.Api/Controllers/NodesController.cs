using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes;
using TreeStructure.Application.Nodes.Commands.CreateNode;
using TreeStructure.Application.Nodes.Commands.DeleteNode;
using TreeStructure.Application.Nodes.Commands.UpdateNode;
using TreeStructure.Application.Nodes.Queries.FirstNode;
using TreeStructure.Application.Nodes.Queries.GetNodeDetail;
using TreeStructure.Application.Nodes.Queries.GetNodes;
using TreeStructure.Domain;
using TreeStructure.Persistance;

namespace TreeStructure.Api.Controllers
{
    [Route("api/nodes")]
    public class NodesController : BaseApiController
    {
        private readonly DataContext _context;
        public NodesController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet("withoutParents")]
        public async Task<ActionResult<FirstNodeVm>> GetFirstNode()
        {
            return await Mediator.Send(new GetFirstNodeQuery());
        }
        
        [HttpGet]
        public async Task<ActionResult<TreeNodeVm>> GetNodes()
        {
            var nodes = await _context.Nodes.AsNoTracking().ToListAsync();
            return Ok(nodes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NodeDetailVm>> GetNode(int id)
        {
            var vm = await Mediator.Send(new GetNodeDetailQuery() { Id = id });
            return vm;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateNode(CreateNodeCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNode(UpdateNodeCommand command)
        {
            var node = await Mediator.Send(command);
            return Ok(node);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNode(int id)
        {
            var node = await Mediator.Send(new DeleteNodeCommand() { Id = id });
            return Ok(node);
        }
    }
}
