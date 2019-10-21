using ArtistService.Api.DTOs;
using ArtistService.Data.Models;
using ArtistService.Domain.Commands;
using ArtistService.Domain.Commands.Command;
using ArtistService.Domain.Queries;
using ArtistService.Domain.Queries.Query;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArtistService.Api.Controllers
{
    
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
        readonly ArtistQueryHandlerFactory _queryHandler;
        readonly ArtistCommandHandlerFactory _commandHandler;
        IMapper _mapper;

        public ArtistController(ArtistQueryHandlerFactory queryHandler, ArtistCommandHandlerFactory commandHandler, IMapper mapper)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
            _mapper = mapper;
        }

        
        [HttpGet]
        [Route("GetArtists")]
        public ActionResult<IEnumerable<ArtistDTO>> GetAll()
        {
            var query = new AllArtistsQuery();
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<ArtistDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetArtist/{id}")]
        public ActionResult<ArtistDTO> Get(int id)
        {
            var query = new OneArtistByIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<ArtistDTO>(handler.Get()));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> Post([FromBody] CreateArtistDTO request)
        {
            var command = new CreateArtistCommand(_mapper.Map<Artist>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpPut]
        [Route("")]
        public ActionResult<Artist> Put([FromBody] UpdateArtistDTO request)
        {
            var command = new EditArtistCommand(_mapper.Map<Artist>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpDelete]
        [Route("")]
        public ActionResult<bool> Delete([FromBody] DeleteArtistDTO request)
        {
            var command = new DeleteArtistCommand(_mapper.Map<Artist>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }
    }
}