using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

    public class CharacterController : Controller
    {
        private readonly ILogger<CharacterController> _logger;
        private ICharacterService _characterService;
    private IShowService _showService;
    public CharacterController(ILogger<CharacterController> logger, ICharacterService characterService, IShowService showService)
    {
        _logger = logger;
        _characterService = characterService;
        _showService = showService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var character = await _characterService.GetCharacters();
        return View(character);
    }
    [HttpGet]
    public async Task<IActionResult> Create(CharacterCreate model)
    {   
        CharacterCreate character = new CharacterCreate();
        character.ShowSelection =  _showService.GetShows().Result.Select(
            s => new SelectListItem{
                Text = s.Name,
                Value = s.Id.ToString()
            }
        );
        
        return View(character);
    }

    [HttpPost]
    [ActionName("Create")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateCharacter(CharacterCreate model)
    {
        if (!ModelState.IsValid) return BadRequest(model);

        if (await _characterService.CreateCharacter(model))
            return RedirectToAction(nameof(Index));
        else
            return View(model);
    }



    [HttpGet]
    [ActionName("Details")]
    public async Task<IActionResult> Character(int id)
    {
        return View(await _characterService.GetCharacterById(id));
    }

[HttpGet]
[ActionName("Edit")]

public async Task<IActionResult> UpdateCharacter (int id)
{
    var character = await _characterService.GetCharacterById(id);
    var characterEdit = new CharacterEdit
    {
        Id = character.Id,
        Name = character.Name,
        StrongestAttack = character.StrongestAttack,
        MainRival = character.MainRival
    };
    return View(characterEdit);
}

    [HttpPost]
    [ActionName("Edit")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UpdateCharacter(CharacterEdit model)
    {

        if (!ModelState.IsValid) return BadRequest(model);
        if (await _characterService.UpdateCharacter(model))
            return RedirectToAction(nameof(Index));
        else
            return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var show = await _characterService.GetCharacterById(id);
        return View(show);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> Delete(int? id)
    {
        var isSuccessful = await _characterService.DeleteCharacter(id.Value);
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
