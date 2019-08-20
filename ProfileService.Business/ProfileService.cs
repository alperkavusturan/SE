using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Data.Repository;
using System;
using System.Collections.Generic;

namespace ProfileService.Business
{
    public class ProfileService : IProfileService
    {
        readonly IUnitOfWork _unitOfWork;

        public ProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateProfile(Profile request)
        {
            try
            {
                var profileId = _unitOfWork.ProfileRepository.Add(request);
                _unitOfWork.Save();

                return profileId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteProfile(Profile request)
        {
            try
            {
                _unitOfWork.ProfileRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profile EditProfile(Profile request)
        {
            try
            {
                _unitOfWork.ProfileRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profile GetProfileById(int id)
        {
            try
            {
                return _unitOfWork.ProfileRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Profile> GetProfiles()
        {
            try
            {
                return _unitOfWork.ProfileRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
