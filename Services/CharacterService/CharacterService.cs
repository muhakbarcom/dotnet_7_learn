using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Services.CharacterService
{
    public class CharacterService : iCharacterService
    {
        private static List<Character> Characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Sam"}
        };

        public List<Character> AddCharacter(Character newCharacter)
        {
           Characters.Add(newCharacter);
            return Characters;
        }

        public List<Character> GetAllCharacters()
        {
            return Characters;
        }

        public Character GetCharacterById(int id)
        {
            var character = Characters.FirstOrDefault(c => c.Id == id);

            if (character is not null)
                return character;

            throw new Exception("Character not found");
        }
    }
}