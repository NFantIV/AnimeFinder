using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace AnimeFinder.MVC.Controllers
{

    public class ShowController : Controller
    {
        private readonly ILogger<ShowController> _logger;
        private IShowService _showService;
        public ShowController(ILogger<ShowController> logger, IShowService showService)
        {
            _logger = logger;
            _showService = showService;
        }

        [HttpGet]
        public async Task<IActionResult> Create(ShowCreate model)
        {
            var genreCollection = new List<Genre>(){
                Genre.Shonen,
                Genre.Shoujo,
                Genre.Mecha,
                Genre.Fantasy
            };

            var WhereToWatchCollection = new List<WhereToWatch>(){
                WhereToWatch.Netflix,
                WhereToWatch.Hulu,
                WhereToWatch.CrunchyRoll,
                WhereToWatch.Funimation
            };

            ShowCreate show = new ShowCreate();
            show.GenresSelection = genreCollection.Select(g => new SelectListItem{
                Text = g.ToString(), 
                Value = g.ToString()
            });
            show.WhereToWatchSelection = WhereToWatchCollection.Select(g => new SelectListItem
            {
                Text = g.ToString(),
                Value = g.ToString()
            });
            return View(show);
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShow(ShowCreate model)
        {
            if (!ModelState.IsValid) return BadRequest(model);

            if (await _showService.CreateShow(model))
                return RedirectToAction(nameof(Index));
            else
            {
                var genreCollection = new List<Genre>(){
                Genre.Shonen,
                Genre.Shoujo,
                Genre.Mecha,
                Genre.Fantasy
            };

                var WhereToWatchCollection = new List<WhereToWatch>(){
                WhereToWatch.Netflix,
                WhereToWatch.Hulu,
                WhereToWatch.CrunchyRoll,
                WhereToWatch.Funimation
            };

                
                model.GenresSelection = genreCollection.Select(g => new SelectListItem
                {
                    Text = g.ToString(),
                    Value = g.ToString()
                });
                model.WhereToWatchSelection = WhereToWatchCollection.Select(g => new SelectListItem
                {
                    Text = g.ToString(),
                    Value = g.ToString()
                });
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var shows = await _showService.GetShows();
            return View(shows);
        }

        [HttpGet]
        [ActionName("Details")]
        public async Task<IActionResult> Show(int id)
        {
            return View(await _showService.GetShowById(id));
        }

        [HttpGet]
        [ActionName("Edit")]

        public async Task<IActionResult> UpdateShow(int id)
        {
            var show = await _showService.GetShowById(id);
            var showEdit = new ShowEdit
            {
                Id = show.Id,
                Name = show.Name,
                WhereToWatch = show.WhereToWatch,
                Genre = show.Genre,
            };

            var genreCollection = new List<Genre>(){
                Genre.Shonen,
                Genre.Shoujo,
                Genre.Mecha,
                Genre.Fantasy
            };

            var WhereToWatchCollection = new List<WhereToWatch>(){
                WhereToWatch.Netflix,
                WhereToWatch.Hulu,
                WhereToWatch.CrunchyRoll,
                WhereToWatch.Funimation
            };

          
            showEdit.GenresSelection = genreCollection.Select(g => new SelectListItem
            {
                Text = g.ToString(),
                Value = g.ToString()
            });
            showEdit.WhereToWatchSelection = WhereToWatchCollection.Select(g => new SelectListItem
            {
                Text = g.ToString(),
                Value = g.ToString()
            });
            return View(showEdit);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateShow(ShowEdit model)
        {

            if (!ModelState.IsValid) return BadRequest(model);
            if (await _showService.UpdateShow (model))
                return RedirectToAction(nameof(Index));
            else
            {
var genreCollection = new List<Genre>(){
                Genre.Shonen,
                Genre.Shoujo,
                Genre.Mecha,
                Genre.Fantasy
            };

                var WhereToWatchCollection = new List<WhereToWatch>(){
                WhereToWatch.Netflix,
                WhereToWatch.Hulu,
                WhereToWatch.CrunchyRoll,
                WhereToWatch.Funimation
            };

                model.GenresSelection = genreCollection.Select(g => new SelectListItem
                {
                    Text = g.ToString(),
                    Value = g.ToString()
                });
                model.WhereToWatchSelection = WhereToWatchCollection.Select(g => new SelectListItem
                {
                    Text = g.ToString(),
                    Value = g.ToString()
                });
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var show = await _showService.GetShowById(id);
            return View(show);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int? id)
        {
            var isSuccessful = await _showService.DeleteShow(id.Value);
            if (isSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}