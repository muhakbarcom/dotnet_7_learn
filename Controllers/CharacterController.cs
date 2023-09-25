
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_7_learn.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly iCharacterService _characterService;

        public CharacterController(iCharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        // public ActionResult<List<Character>> UpdateCharacter(Character updatedCharacter)
        // {
        //     return Ok(_characterService.UpdateCharacter(updatedCharacter));
        // }
    }
}