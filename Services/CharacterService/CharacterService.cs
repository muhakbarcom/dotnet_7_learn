using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_7_learn.Models;

namespace dotnet.Services.CharacterService
{
    public class CharacterService : iCharacterService
    {
        private static List<Character> Characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Sam"}
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            Characters.Add(newCharacter);
            ServiceResponse.Data = Characters;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            ServiceResponse.Data = Characters;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<Character>();
            var character = Characters.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data = character;
            return ServiceResponse;

        }
    }
}