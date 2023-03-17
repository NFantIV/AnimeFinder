using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface ICharacterService
    {
        Task<bool> CreateCharacter (CharacterCreate model);
        Task <List<CharacterListItem>> GetCharacters();
        Task <CharacterDetail> GetCharacterById(int id);

        Task<bool> UpdateCharacter (CharacterEdit model);

        Task <bool> DeleteCharacter (int id);
    }
