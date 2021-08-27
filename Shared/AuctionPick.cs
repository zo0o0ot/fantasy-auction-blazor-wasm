using System;

namespace BlazorApp.Shared
{
    public class AuctionPick
    {
        public int PickNumber { get; set; }

        public Owner Suggester { get; set; }

        public Player SelectedPlayer { get; set; }

        public int WinningBid { get; set; }

        public Owner WinningBidder { get; set; }

        public float PointsPerDollar => {
            if (SelectedPlayer.Stats.Count > 0 && WinningBid > 0)
            {
                SelectedPlayer.Stats[0] / WinningBid
            }
            else
            {
                0.0
            }
        }
        
    }
}
