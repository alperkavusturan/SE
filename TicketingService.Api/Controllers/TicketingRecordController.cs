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
using TicketingService.Domain.Commands.Command;
using TicketingService.Data.Models;

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

        [HttpGet]
        [Route("GetTicketingRecords/ByStatus/{status}")]
        public ActionResult<IEnumerable<TicketingRecordDTO>> GetAllByStatus(int status)
        {
            var query = new AllTicketingRecordsByStatusQuery(status);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TicketingRecordDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTicketingRecords/ByProfile/{profileId}")]
        public ActionResult<IEnumerable<TicketingRecordDTO>> GetAllByProfile(int profileId)
        {
            var query = new AllTicketingRecordsByProfileQuery(profileId);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TicketingRecordDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTicketingRecords/ByEvent/{eventId}")]
        public ActionResult<IEnumerable<TicketingRecordDTO>> GetAllByEvent(int eventId)
        {
            var query = new AllTicketingRecordsByEventQuery(eventId);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TicketingRecordDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTicketingRecords/ByEvent/{eventId}/ByStatus/{status}")]
        public ActionResult<IEnumerable<TicketingRecordDTO>> GetAllByEventAndStatus(int eventId, int status)
        {
            var query = new AllTicketingRecordsByEventAndStatusQuery(eventId, status);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TicketingRecordDTO>>(handler.Get()));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> Post([FromBody] CreateTicketingRecordDTO request)
        {
            var command = new CreateTicketingRecordCommand(_mapper.Map<TicketingRecord>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpPut]
        [Route("")]
        public ActionResult<TicketingRecord> Put([FromBody] UpdateTicketingRecordDTO request)
        {
            var command = new EditTicketingRecordCommand(_mapper.Map<TicketingRecord>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }
    }
}