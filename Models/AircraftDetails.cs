using Newtonsoft.Json;
namespace Aircraft_Details_API_Core.Models
{
    public class AircraftDetails
    {
        /// <summary>
        /// Name of  Aircraft.
        /// </summary>
        [JsonProperty("Aircraft")]
        public string? Aircraft { get; set; }

        /// <summary>
        /// Manufacturer of the aircraft.
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string? Manufacturer { get; set; }

        /// <summary>
        /// Type of aircraft.
        /// </summary>
        [JsonProperty("AircraftType")]
        public string? AircraftType { get; set; }

        /// <summary>
        /// Range of the aircraft.
        /// </summary>
        [JsonProperty("Range")]
        public string? Range { get; set; }

        /// <summary>
        /// Maximum Takeoff Weight of the aircraft.
        /// </summary>
        [JsonProperty("MaxTakeOffWeight")]
        public string? MaxTakeOffWeight { get; set; }

        /// <summary>
        /// Search tags to help find matching aircraft objects when searches
        /// </summary>
        [JsonProperty("searchTags")]
        public List<string>? searchTags { get; set; }

    }
}
