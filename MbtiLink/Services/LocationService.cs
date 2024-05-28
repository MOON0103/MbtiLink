using System.Diagnostics;

namespace MbtiLink.Services
{
    public class LocationService
    {
        public async Task<Location> GetCurrentLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }
                return location;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving location: {ex.Message}");
                return null;
            }
        }
    }
}
