using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Data.Repository;

namespace TicketingService.Business
{
    public class TicketingService : ITicketingService
    {
        readonly IUnitOfWork _unitOfWork;

        public TicketingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateTicketingRecord(TicketingRecord request)
        {
            try
            {
                var RecordId = _unitOfWork.TicketingRepository.Add(request);
                _unitOfWork.Save();

                return RecordId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TicketingRecord EditTicketingRecord(TicketingRecord request)
        {
            try
            {
                _unitOfWork.TicketingRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TicketingRecord GetTicketingRecordById(int id)
        {
            try
            {
                return _unitOfWork.TicketingRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetTicketingRecords()
        {
            try
            {
                return _unitOfWork.TicketingRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetTicketingRecordsByEvent(int eventId)
        {
            try
            {
                return _unitOfWork.TicketingRepository.GetByEvent(eventId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetTicketingRecordsByEventAndStatus(int eventId, int status)
        {
            try
            {
                return _unitOfWork.TicketingRepository.GetByEventAndStatus(eventId, status);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetTicketingRecordsByProfile(int profileId)
        {
            try
            {
                return _unitOfWork.TicketingRepository.GetByProfile(profileId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetTicketingRecordsByStatus(int status)
        {
            try
            {
                return _unitOfWork.TicketingRepository.GetByStatus(status);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
