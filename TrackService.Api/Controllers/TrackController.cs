using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrackService.Api.DTOs;
using TrackService.Data.Models;
using TrackService.Domain.Commands;
using TrackService.Domain.Commands.Command;
using TrackService.Domain.Queries;
using TrackService.Domain.Queries.Query;

namespace TrackService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        readonly TrackQueryHandlerFactory _queryHandler;
        readonly TrackCommandHandlerFactory _commandHandler;
        IMapper _mapper;

        public TrackController(TrackQueryHandlerFactory queryHandler, TrackCommandHandlerFactory commandHandler, IMapper mapper)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetTracks")]
        public ActionResult<IEnumerable<TrackDTO>> GetAll()
        {
            var query = new AllTracksQuery();
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TrackDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTracks/ByArtist/{id}")]
        public ActionResult<IEnumerable<TrackDTO>> GetAllTracksByArtist(int id)
        {
            var query = new AllTracksByArtistIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TrackDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTracks/ByProfile/{id}")]
        public ActionResult<IEnumerable<TrackDTO>> GetAllTracksByProfile(int id)
        {
            var query = new AllTracksByProfileIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<TrackDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetTrack/{id}")]
        public ActionResult<TrackDTO> Get(int id)
        {
            var query = new OneTrackByIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<TrackDTO>(handler.Get()));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> Post([FromBody] CreateTrackDTO request)
        {
            var command = new CreateTrackCommand(_mapper.Map<Track>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpPut]
        [Route("")]
        public ActionResult<Track> Put([FromBody] UpdateTrackDTO request)
        {
            var command = new EditTrackCommand(_mapper.Map<Track>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpDelete]
        [Route("")]
        public ActionResult<bool> Delete([FromBody] DeleteTrackDTO request)
        {
            var command = new DeleteTrackCommand(_mapper.Map<Track>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }
    }

}
