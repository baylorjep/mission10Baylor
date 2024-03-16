namespace mission10baylorapi.Data
{
    public interface iBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
