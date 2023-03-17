using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class CharacterDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? StrongestAttack { get; set; }
        public string? MainRival { get; set; }

        public ShowListItem Show { get; set; } = null!;
    }
    
