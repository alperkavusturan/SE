using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Data.Repository;
using System;
using System.Collections.Generic;

namespace ArtistService.Business
{
    public class ArtistService : IArtistService
    {
        readonly IUnitOfWork _unitOfWork;

        public ArtistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateArtist(Artist request)
        {
            try
            {
                var ArtistId = _unitOfWork.ArtistRepository.Add(request);
                _unitOfWork.Save();

                return ArtistId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteArtist(Artist request)
        {
            try
            {
                _unitOfWork.ArtistRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Artist EditArtist(Artist request)
        {
            try
            {
                _unitOfWork.ArtistRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Artist GetArtistById(int id)
        {
            try
            {
                return _unitOfWork.ArtistRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Artist> GetArtists()
        {
            try
            {
                return _unitOfWork.ArtistRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
