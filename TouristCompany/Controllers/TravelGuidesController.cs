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
        //public TravelGuidesController(IBlTravelGuide blTravelGuide)
        //{
        //    this.blTravelGuide = blTravelGuide;
        //}
        public TravelGuidesController(BLManager bl)
        {
            this.blTravelGuide = bl.TravelGuides;
        }
        [HttpGet]
        public ActionResult<List<BlTravelGuide>> GetAll()
        {
            if (blTravelGuide.GetAll()==null)
            {
                return NotFound();
            }
            return blTravelGuide.GetAll();
        }
        [HttpGet("{Id}")]
        public ActionResult<BlTravelGuide> Get(int id)
        {
            if(blTravelGuide.Get(id)==null) { 
                return BadRequest(); 
            }
            return blTravelGuide.Get(id);
        }
        [HttpPost]
        public ActionResult<BlTravelGuide> Add(BlTravelGuide blTravelGuideToAdd)
        {
            return blTravelGuide.Add(blTravelGuideToAdd);
        }

    }
}
