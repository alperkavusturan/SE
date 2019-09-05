using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketingService.Domain.Queries;
using TicketingService.Domain.Commands;
using AutoMapper;
using TicketingService.Api.DTOs;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Api.Controllers
{
    #if DEBUG
    #else
    [Authorize]
    #endif
    [Route("api/[controller]")]
    public class TicketingRecordController : ControllerBase
    {
        readonly TicketingQueryHandlerFactory _queryHandler;
        readonly TicketingCommandHandlerFactory _commandHandler;
        IMapper _mapper;

        public TicketingRecordController(TicketingQueryHandlerFactory queryHandler, TicketingCommandHandlerFactory commandHandler, IMapper mapper)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetTicketingRecords")]
        public ActionResult<IEnumerable<TicketingRecordDTO>> GetAll()
        {
            var query = new AllTicketingRecordsQuery();
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TicketingRecordDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTicketingRecord/{id}")]
        public ActionResult<TicketingRecordDTO> Get(int id)
        {
            var query = new OneTicketingRecordByIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<TicketingRecordDTO>(handler.Get()));
        }
    }
}