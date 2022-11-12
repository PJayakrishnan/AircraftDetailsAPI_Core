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
        string contentPath;

        public AircraftController(IWebHostEnvironment _environment)
        {
            try
            {
                Environment = _environment;
                contentPath = this.Environment.ContentRootPath;
                var fullPath = Path.Combine(contentPath, "App_Data/AircraftDetails.json");
                if (System.IO.File.Exists(fullPath))
                {
                    var allText = System.IO.File.ReadAllText(fullPath);
                    aircraftObjList = JsonConvert.DeserializeObject<List<AircraftDetails>>(allText);
                }
                
            }
            catch(Exception e)
            {
                
            }
            
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(aircraftObjList);
            }
            catch (Exception ex)
            {

                return NotFound();
            }

        }


        
        [HttpGet]
        [Route("{searchWord}")]
        public IActionResult Get(string searchWord)
        {
            try
            {
                List<AircraftDetails> SearchRsltList = new List<AircraftDetails>();

                if (aircraftObjList != null)
                {
                    for (int i = 0; i < aircraftObjList.Count; i++)
                    {
                        if (aircraftObjList[i].Aircraft == searchWord.ToLower() || aircraftObjList[i].Manufacturer == searchWord.ToLower())
                        {
                            SearchRsltList.Add(aircraftObjList[i]);
                        }
                        else if (aircraftObjList[i].searchTags != null)
                        {
                            for (int j = 0; j < aircraftObjList[i].searchTags.Count; j++)
                            {
                                if (aircraftObjList[i].searchTags[j] == searchWord.ToLower())
                                {
                                    SearchRsltList.Add(aircraftObjList[i]);
                                    goto jumpSpot;
                                }
                            }
                        }

                    jumpSpot:
                        bool True = true;
                    }
                }

                return Ok(SearchRsltList);
            }
            catch (Exception ex)
            {

                return NotFound();
            }
            
        }

    }
}
