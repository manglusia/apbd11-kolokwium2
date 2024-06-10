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
    
    [HttpPost]
    public async Task<IActionResult> AddSmth()
    {
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetSmth()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteSmth()
    {
        return Ok();
    }

}