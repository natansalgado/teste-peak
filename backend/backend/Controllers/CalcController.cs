using backend.Models;
using backend.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly ICalcRepository _calcRepository;

        public CalcController(ICalcRepository calcRepository)
        {
            _calcRepository = calcRepository;
        }

        [HttpPost]
        public ActionResult<decimal> CalcValue([FromBody] CalcModel calcModel)
        {
            return _calcRepository.CalcValue(calcModel);
        }
    }
}
