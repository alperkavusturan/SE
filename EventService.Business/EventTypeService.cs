using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Data.Repository;
using System;
using System.Collections.Generic;

namespace EventService.Business
{
    public class EventTypeService : IEventTypeService
    {
        readonly IUnitOfWork _unitOfWork;

        public EventTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateEventType(EventType request)
        {
            try
            {
                var EventTypeId = _unitOfWork.EventTypeRepository.Add(request);
                _unitOfWork.Save();

                return EventTypeId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEventType(EventType request)
        {
            try
            {
                _unitOfWork.EventTypeRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EventType EditEventType(EventType request)
        {
            try
            {
                _unitOfWork.EventTypeRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EventType GetEventTypeById(int id)
        {
            try
            {
                return _unitOfWork.EventTypeRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<EventType> GetEventTypes()
        {
            try
            {
                return _unitOfWork.EventTypeRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
