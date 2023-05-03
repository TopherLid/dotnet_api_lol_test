using System;
using System.Collections.Generic;

namespace p1.core.Entities
{
    public partial class ChampionUser
    {
        public int ChampionId { get; set; }
        public int PlayerId { get; set; }

        public virtual Champion Champion { get; set; }
        public virtual Player Player { get; set; }
    }
}
