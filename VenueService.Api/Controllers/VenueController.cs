using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VenueService.Api.DTOs;
using VenueService.Data.Models;
using VenueService.Domain.Commands;
using VenueService.Domain.Commands.Command;
using VenueService.Domain.Queries;
using VenueService.Domain.Queries.Query;

namespace VenueService.Api.Controllers
{
    #if DEBUG
    #else
    [Authorize]
    #endif
    [Route("api/[controller]")]
    public class VenueController : ControllerBase
    {
        readonly VenueQueryHandlerFactory _queryHandler;
        readonly VenueCommandHandlerFactory _commandHandler;
        IMapper _mapper;
        public VenueController(VenueQueryHandlerFactory queryHandler, VenueCommandHandlerFactory commandHandler, IMapper mapper)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetVenues")]
        public ActionResult<IEnumerable<VenueDTO>> GetAll()
        {
            var query = new AllVenuesQuery();
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<VenueDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetVenue/{id}")]
        public ActionResult<Venue> Get(int id)
        {
            var query = new OneVenueByIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<VenueDTO>(handler.Get()));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> Post([FromBody] CreateVenueDTO request)
        {
            var command = new CreateVenueCommand(_mapper.Map<Venue>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpPut]
        [Route("")]
        public ActionResult<UpdateVenueDTO> Put([FromBody] UpdateVenueDTO request)
        {
            var command = new EditVenueCommand(_mapper.Map<Venue>(request));
            var handler = _commandHandler.Build(command);

            return Ok(_mapper.Map<VenueDTO>(handler.Execute()));
        }

        [HttpDelete]
        [Route("")]
        public ActionResult<bool> Delete([FromBody] DeleteVenueDTO request)
        {
            var command = new DeleteVenueCommand(_mapper.Map<Venue>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }
    }
}