using System;
using System.Collections.Generic;

namespace p1.core.Entities
{
    public partial class Champion
    {
        public Champion()
        {
            ChampionUser = new HashSet<ChampionUser>();
        }

        public int Id { get; set; }
        public string NameChampion { get; set; }
        public string Title { get; set; }
        public int Cost { get; set; }

        public virtual ICollection<ChampionUser> ChampionUser { get; set; }
    }
}
