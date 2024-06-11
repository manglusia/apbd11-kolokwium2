using System.Transactions;
using Kolokwium2.DTOs;
using Kolokwium2.Models;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Controller : ControllerBase
{
    private readonly IDbService _dbService;
    
    public Controller(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetSmth(int characterId)
    {
        if (_dbService.DoesCharacterExist(characterId).Result)
        {
            return NotFound();
        }

        var character = await _dbService.GetCharacter(characterId);
        
        return Ok(
            character.Select(e=> new CharacterGetDTO()
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                CurrentWeight = e.CurrentWeight,
                MaxWeight = e.MaxWeight,
                Title = e.CharacterTitles.Select(c=>new CharacterTitleDTO()
                {
                    Title = ,
                    AcquiredAt = c.AcquiredAt
                }).ToList()
            })
            );
    }


}