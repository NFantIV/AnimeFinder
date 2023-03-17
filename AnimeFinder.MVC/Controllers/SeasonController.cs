using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


public class SeasonController : Controller
{
    private readonly ISeasonService _seasonService;

    private readonly ILogger<SeasonController> _logger;

    public SeasonController(ILogger<SeasonController> logger, ISeasonService seasonService)
    {
        _seasonService = seasonService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> GetSeasonById(int id)
    {
        return View(await _seasonService.GetSeasonById(id));
    }
    [HttpGet]
    public async Task<IActionResult> SeasonDetails(int id)
    {
        return View(await _seasonService.GetSeasonById(id));
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
