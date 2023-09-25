using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_7_learn.Models;

namespace dotnet.Services.CharacterService
{
    public interface iCharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}