using System;
using System.Collections.Generic;

namespace p1.core.Entities
{
    public partial class Player
    {
        public Player()
        {
            ChampionUser = new HashSet<ChampionUser>();
        }

        public int Id { get; set; }
        public string NamePlayer { get; set; }
        public int Points { get; set; }

        public virtual ICollection<ChampionUser> ChampionUser { get; set; }
    }
}
