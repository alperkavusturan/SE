using AutoMapper;
using EventService.Api.DTOs;
using EventService.Data.Models;
using EventService.Domain.Commands;
using EventService.Domain.Commands.Command;
using EventService.Domain.Queries;
using EventService.Domain.Queries.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EventService.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        readonly EventQueryHandlerFactory _queryHandler;
        readonly EventCommandHandlerFactory _commandHandler;
        IMapper _mapper;

        public EventController(EventQueryHandlerFactory queryHandler, EventCommandHandlerFactory commandHandler, IMapper mapper)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetEvents")]
        public ActionResult<IEnumerable<EventDTO>> GetAll()
        {
            var query = new AllEventsQuery();
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<EventDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetEvents/ByArtist/{id}")]
        public ActionResult<IEnumerable<EventDTO>> GetAllEventsByArtist(int id)
        {
            var query = new AllEventsByArtistIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<EventDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetEvents/ByVenue/{id}")]
        public ActionResult<IEnumerable<EventDTO>> GetAllEventsByVenue(int id)
        {
            var query = new AllEventsByVenueIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<EventDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetEvent/{id}")]
        public ActionResult<EventDTO> Get(int id)
        {
            var query = new OneEventByIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<EventDTO>(handler.Get()));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> Post([FromBody] CreateEventDTO request)
        {
            var command = new CreateEventCommand(_mapper.Map<Event>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpPut]
        [Route("")]
        public ActionResult<Event> Put([FromBody] UpdateEventDTO request)
        {
            var command = new EditEventCommand(_mapper.Map<Event>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpDelete]
        [Route("")]
        public ActionResult<bool> Delete([FromBody] DeleteEventDTO request)
        {
            var command = new DeleteEventCommand(_mapper.Map<Event>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }
    }
}
