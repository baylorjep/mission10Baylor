
namespace mission10baylorapi.Data
{
    public class EFBowlingRepository : iBowlingRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlingRepository(BowlerContext temp) {

            _bowlerContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}
