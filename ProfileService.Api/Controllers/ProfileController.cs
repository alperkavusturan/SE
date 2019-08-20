using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProfileService.Api.DTOs;
using ProfileService.Domain.Commands;
using ProfileService.Domain.Commands.Command;
using ProfileService.Domain.Queries;
using ProfileService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ProfileService.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        readonly ProfileQueryHandlerFactory _queryHandler;
        readonly ProfileCommandHandlerFactory _commandHandler;
        IMapper _mapper;

        public ProfileController(ProfileQueryHandlerFactory queryHandler, ProfileCommandHandlerFactory commandHandler, IMapper mapper)
        {
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetProfiles")]
        public ActionResult<IEnumerable<ProfileDTO>> GetAll()
        {
            var query = new AllProfilesQuery();
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<IEnumerable<ProfileDTO>>(handler.Get()));
        }

        [HttpGet]
        [Route("GetProfile/{id}")]
        public ActionResult<ProfileDTO> Get(int id)
        {
            var query = new OneProfileByIdQuery(id);
            var handler = _queryHandler.Build(query);

            return Ok(_mapper.Map<ProfileDTO>(handler.Get()));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> Post(CreateProfileDTO request)
        {
            var command = new CreateProfileCommand(_mapper.Map<Data.Models.Profile>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpPut]
        [Route("")]
        public ActionResult<Data.Models.Profile> Put(UpdateProfileDTO request)
        {
            var command = new EditProfileCommand(_mapper.Map<Data.Models.Profile>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }

        [HttpDelete]
        [Route("")]
        public ActionResult<bool> Delete(DeleteProfileDTO request)
        {
            var command = new DeleteProfileCommand(_mapper.Map<Data.Models.Profile>(request));
            var handler = _commandHandler.Build(command);

            return Ok(handler.Execute());
        }
    }
}