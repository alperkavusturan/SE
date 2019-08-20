using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Data.Repository;
using System;
using System.Collections.Generic;

namespace ArtistService.Business
{
    public class ArtistTypeService : IArtistTypeService
    {
        readonly IUnitOfWork _unitOfWork;

        public ArtistTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateArtistType(ArtistType request)
        {
            try
            {
                var ArtistTypeId = _unitOfWork.ArtistTypeRepository.Add(request);
                _unitOfWork.Save();

                return ArtistTypeId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteArtistType(ArtistType request)
        {
            try
            {
                _unitOfWork.ArtistTypeRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ArtistType EditArtistType(ArtistType request)
        {
            try
            {
                _unitOfWork.ArtistTypeRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ArtistType GetArtistTypeById(int id)
        {
            try
            {
                return _unitOfWork.ArtistTypeRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ArtistType> GetArtistTypes()
        {
            try
            {
                return _unitOfWork.ArtistTypeRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
