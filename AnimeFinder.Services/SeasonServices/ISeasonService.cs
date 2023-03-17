using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface ISeasonService 
    {
        Task<SeasonDetail> GetSeasonById(int id);
    }
