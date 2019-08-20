using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Data.Repository;
using System;
using System.Collections.Generic;

namespace EventService.Business
{
    public class EventService : IEventService
    {
        readonly IUnitOfWork _unitOfWork;

        public EventService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateEvent(Event request)
        {
            try
            {
                var EventId = _unitOfWork.EventRepository.Add(request);
                _unitOfWork.Save();

                return EventId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEvent(Event request)
        {
            try
            {
                _unitOfWork.EventRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Event EditEvent(Event request)
        {
            try
            {
                _unitOfWork.EventRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Event GetEventById(int id)
        {
            try
            {
                return _unitOfWork.EventRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Event> GetEvents()
        {
            try
            {
                return _unitOfWork.EventRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Event> GetEventsByArtistId(int artistId)
        {
            try
            {
                return _unitOfWork.EventRepository.GetByArtistId(artistId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Event> GetEventsByVenueId(int venueId)
        {
            try
            {
                return _unitOfWork.EventRepository.GetByVenueId(venueId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
