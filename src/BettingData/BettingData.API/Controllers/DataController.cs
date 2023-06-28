using BettingData.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace BettingData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private static XmlReaderService _readerService;

        public DataController(XmlReaderService readerService)
        {
            _readerService = readerService;
        }

        [HttpGet]
        public ActionResult GetData()
        {
            _readerService.ReadXml();

            return Ok();
        }
    }
}
