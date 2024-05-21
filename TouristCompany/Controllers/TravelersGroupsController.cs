using BlTour;
using BlTour.BlApi;
using BlTour.BlModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TouristCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelersGroupsController : ControllerBase
    {
        IBlTravelersGroup travelersGroup;
        public TravelersGroupsController(BLManager bl)
        {
            this.travelersGroup = bl.TravelersGroups;
        }
        [HttpGet]
        public ActionResult<List<BlTravelersGroup>> GetAll()
        {
            if (travelersGroup.GetAll()==null)
            {
                return NotFound();
            }
            return Ok(travelersGroup.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<BlTravelersGroup> Get(int id)
        {
            if (travelersGroup.Get(id) == null)
            {
                return BadRequest();
            }
            return Ok(travelersGroup.Get(id));
        }
        [HttpPost]
        public ActionResult<BlTravelersGroup> Add(BlTravelersGroup item)
        {

            if (travelersGroup.Add(item) == null)
            {
                return BadRequest();
            }
            return travelersGroup.Add(item);
        }
    }
}
