using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


public class CharacterService : ICharacterService
{
    private readonly ApplicationDbContext _context;
    private IMapper _mapper;

    public CharacterService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> CreateCharacter(CharacterCreate model)
    {
        var character = _mapper.Map<Character>
        (model);
        await _context.Characters.AddAsync
        (character);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteCharacter(int id)
    {
        var character = await _context.Characters.FindAsync(id);
        if (character is null) return
        false;
        _context.Characters.Remove(character);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<CharacterDetail> GetCharacterById(int id)
    {
        // Want to grab a single chara from database
        var characterInDb = await _context.Characters
        .Include(c => c.Show)
        .FirstOrDefaultAsync(c => c.Id == id);
        // Want to convert CharaInDb data to CharaDetail data
        var character = _mapper.Map<CharacterDetail>(characterInDb);
        if (character is null) return null;
        return character;
    }

    public async Task<List<CharacterListItem>> GetCharacters()
    {
        var character = await _context.Characters.ToListAsync();
        return _mapper.Map<List<CharacterListItem>>(character);

    }

    public async Task<bool> UpdateCharacter(CharacterEdit model)
    {
        var character = await _context.Characters.FindAsync(model.Id);
        if (character is null) return
        false;

        character.Name = model.Name;
        character.StrongestAttack = model.StrongestAttack;
        character.MainRival = character.MainRival;
        return await _context.SaveChangesAsync() > 0;
    }
}
