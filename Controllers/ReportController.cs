using System.Threading.Tasks;
using McafeeRosterManagement.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace McafeeRosterManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportsIRepository _repo;
        public ReportController(ReportsIRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetReports()
        {
            var reports = await _repo.GetReport();
            return Ok(reports);
        }
    }
}