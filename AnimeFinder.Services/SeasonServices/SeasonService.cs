using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

public class SeasonService : ISeasonService
    {
    private readonly ApplicationDbContext _context;
    private IMapper _mapper;

    public SeasonService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<SeasonDetail> GetSeasonById(int id)
    {
        var SeasonInDb = await _context.Seasons.FindAsync(id);
        var season = _mapper.Map<SeasonDetail> (SeasonInDb);
        if (season is null) return null;
        return season;
    }

}
