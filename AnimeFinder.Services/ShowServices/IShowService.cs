using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IShowService
    {
        Task<bool> CreateShow(ShowCreate model);
        Task<List<ShowListItem>> GetShows();
        Task<ShowDetail> GetShowById(int id);
        Task <bool> UpdateShow (ShowEdit model);
        Task <bool> DeleteShow (int id);
    }
