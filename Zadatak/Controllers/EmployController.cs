using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
namespace Zadatak.Controllers
{
    public class EmployController : Controller
    {

        private readonly TimeEntryServices _timeEntryService;
        private readonly string _apiKey;

        public EmployController(IConfiguration configuration)
        {
            _timeEntryService = new TimeEntryServices();
            _apiKey = configuration["ApiSettings:ApiKey"];
        }
        public async Task<IActionResult> Index()
        {
            var timeEntries = await _timeEntryService.GetEmployeeTimeEntries(_apiKey);
            return View(timeEntries);
        }
    }
}
