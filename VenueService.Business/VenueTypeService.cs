using System;
using System.Collections.Generic;
using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Data.Repository;

namespace VenueService.Business
{
    public class VenueTypeService : IVenueTypeService
    {
        readonly IUnitOfWork _unitOfWork;

        public VenueTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateVenueType(VenueType request)
        {
            try
            {
                var VenueTypeId = _unitOfWork.VenueTypeRepository.Add(request);
                _unitOfWork.Save();

                return VenueTypeId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteVenueType(VenueType request)
        {
            try
            {
                _unitOfWork.VenueTypeRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VenueType EditVenueType(VenueType request)
        {
            try
            {
                _unitOfWork.VenueTypeRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VenueType GetVenueTypeById(int id)
        {
            try
            {
                return _unitOfWork.VenueTypeRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<VenueType> GetVenueTypes()
        {
            try
            {
                return _unitOfWork.VenueTypeRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
