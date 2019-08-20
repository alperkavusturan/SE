using System;
using System.Collections.Generic;
using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Data.Repository;

namespace VenueService.Business
{
    public class VenueService : IVenueService
    {
        readonly IUnitOfWork _unitOfWork;

        public VenueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateVenue(Venue request)
        {
            try
            {
                var VenueId = _unitOfWork.VenueRepository.Add(request);
                _unitOfWork.Save();

                return VenueId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteVenue(Venue request)
        {
            try
            {
                _unitOfWork.VenueRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Venue EditVenue(Venue request)
        {
            try
            {
                _unitOfWork.VenueRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Venue GetVenueById(int id)
        {
            try
            {
                return _unitOfWork.VenueRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Venue> GetVenues()
        {
            try
            {
                return _unitOfWork.VenueRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
