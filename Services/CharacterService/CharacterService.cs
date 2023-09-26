global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_7_learn.Models;

namespace dotnet_7_learn.Services.CharacterService
{
    public class CharacterService : iCharacterService

    {
        private static List<Character> Characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Sam"}
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            var Character = _mapper.Map<Character>(newCharacter);
            Character.Id = Characters.Max(c => c.Id) + 1;
            Characters.Add(Character);
            ServiceResponse.Data = Characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            ServiceResponse.Data = Characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDTO>();
            var character = Characters.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data = _mapper.Map<GetCharacterDTO>(character);
            return ServiceResponse;
        }
    }
}