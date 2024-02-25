using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlTour;
using BlTour.BlApi;
using BlTour.BlModels;

namespace TouristCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelGuidesController : ControllerBase
    {
        IBlTravelGuide blTravelGuide;
        public TravelGuidesController(BLManager bl)
        {
            this.blTravelGuide = bl.TravelGuides;
        }
        [HttpGet]
        public ActionResult<List<BlTravelGuide>> GetAll()
        {
            return blTravelGuide.GetAll();
        }
        [HttpGet("{Id}")]
        public ActionResult<BlTravelGuide> Get(int id)
        {
            return blTravelGuide.Get(id);
        }
        [HttpPost]
        

    }
}
