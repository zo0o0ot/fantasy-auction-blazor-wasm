using System;

namespace BlazorApp.Shared
{
    public class AuctionDraft
    {
        public Guid ID { get; set; }

        public List<Owner> Owners { get; set; }

        public int StartingBudget { get; set; }

        public List<Team> Teams { get; set; }

        public List<AuctionPick> Picks { get; set; }

        public List<Player> Players { get; set; }
        
    }
}
