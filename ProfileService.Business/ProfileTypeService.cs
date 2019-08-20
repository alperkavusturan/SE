using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Data.Repository;
using System;
using System.Collections.Generic;

namespace ProfileService.Business
{
    public class ProfileTypeService : IProfileTypeService
    {
        readonly IUnitOfWork _unitOfWork;

        public ProfileTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateProfileType(ProfileType request)
        {
            try
            {
                var profileTypeId = _unitOfWork.ProfileTypeRepository.Add(request);
                _unitOfWork.Save();

                return profileTypeId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteProfileType(ProfileType request)
        {
            try
            {
                _unitOfWork.ProfileTypeRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProfileType EditProfileType(ProfileType request)
        {
            try
            {
                _unitOfWork.ProfileTypeRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProfileType GetProfileTypeById(int id)
        {
            try
            {
                return _unitOfWork.ProfileTypeRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ProfileType> GetProfileTypes()
        {
            try
            {
                return _unitOfWork.ProfileTypeRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
