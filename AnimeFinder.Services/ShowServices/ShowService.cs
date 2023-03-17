using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


public class ShowService : IShowService
{
    private readonly ApplicationDbContext _context;
    private IMapper _mapper;

    public ShowService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> CreateShow(ShowCreate model)
    {
        var show = _mapper.Map<Show>(model);
        await _context.Shows.AddAsync(show);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteShow(int id)
    {
        var show = await _context.Shows.FindAsync(id);
        if (show is null) return false;
        _context.Shows.Remove(show);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<ShowDetail> GetShowById(int id)
    {
        var show = _mapper.Map<ShowDetail>(await _context.Shows
        .Include(s => s.Characters)
        .Include(s => s.Seasons)
        .FirstOrDefaultAsync(s => s.Id == id));
        if (show is null) return null;
        return show;
    }

    public async Task<List<ShowListItem>> GetShows()
    {
        var conversion = await _context.Shows.ToListAsync();
        return _mapper.Map<List<ShowListItem>>(conversion);
    }

    public async Task<bool> UpdateShow(ShowEdit model)
    {
        var show = await _context.Shows.FindAsync(model.Id);
        if (show is null) return false;

        show.Name = model.Name;
        show.Genre = model.Genre;
        show.WhereToWatch = model.WhereToWatch;
        return await _context.SaveChangesAsync() > 0;
    }
}
