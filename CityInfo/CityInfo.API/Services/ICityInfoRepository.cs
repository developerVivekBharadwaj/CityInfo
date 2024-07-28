using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();

        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);

        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestsAsync(int cityId);

        Task<PointOfInterest> GetPointOfInterestsAsync(int cityId,
            int pointOfInterestId);

    }
}
