using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Data.Repository;

namespace TrackService.Business
{
    public class TrackService : ITrackService
    {
        readonly IUnitOfWork _unitOfWork;

        public TrackService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateTrack(Track request)
        {
            try
            {
                var TrackId = _unitOfWork.TrackRepository.Add(request);
                _unitOfWork.Save();

                return TrackId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteTrack(Track request)
        {
            try
            {
                _unitOfWork.TrackRepository.Delete(request);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Track EditTrack(Track request)
        {
            try
            {
                _unitOfWork.TrackRepository.Update(request);
                _unitOfWork.Save();
                return request;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Track GetTrackById(int id)
        {
            try
            {
                return _unitOfWork.TrackRepository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Track> GetTracks()
        {
            try
            {
                return _unitOfWork.TrackRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
