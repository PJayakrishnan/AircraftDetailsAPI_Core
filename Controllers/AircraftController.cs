using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Aircraft_Details_API_Core.Models;
using Newtonsoft.Json;

namespace Aircraft_Details_API_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        List<AircraftDetails>? aircraftObjList = new List<AircraftDetails>();
        private IWebHostEnvironment Environment;

        public AircraftController(IWebHostEnvironment _environment)
        {
            try
            {
                Environment = _environment;
                string wwwPath = this.Environment.WebRootPath;
                string contentPath = this.Environment.ContentRootPath;
                var fullPath = Path.Combine(contentPath, "App_Data/AircraftDetails.json");
                var allText = System.IO.File.ReadAllText(fullPath);
                aircraftObjList = JsonConvert.DeserializeObject<List<AircraftDetails>>(allText);
            }
            catch(Exception e)
            {
                
            }
            
        }


        [HttpGet]
        public List<AircraftDetails> Get()
        {
            return aircraftObjList;
        }


        
        [HttpGet]
        [Route("{searchWord}")]
        public List<AircraftDetails> Get(string searchWord)
        {
            List<AircraftDetails> SearchRsltList = new List<AircraftDetails>();

            for (int i = 0; i < aircraftObjList.Count; i++)
            {
                for (int j = 0; j < aircraftObjList[i].searchTags.Count; j++)
                {
                    if (aircraftObjList[i].Aircraft == searchWord || aircraftObjList[i].searchTags[j] == searchWord || aircraftObjList[i].Manufacturer == searchWord)
                    {
                        SearchRsltList.Add(aircraftObjList[i]);
                        goto jumpSpot;
                    }
                }
            jumpSpot:
                bool True = true;
            }

            return SearchRsltList;
        }

    }
}
