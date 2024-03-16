using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mission10baylorapi.Data;

namespace mission10baylorapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private iBowlingRepository _bowlingRepository;
        public BowlingController(iBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Object> GetBowlers() 
        {
            var bowlerData = (from bowler in _bowlingRepository.Bowlers
                              join team in _bowlingRepository.Teams
                              on bowler.TeamID equals team.TeamID
                              where team.TeamName == "Marlins" | team.TeamName == "Sharks"
                              select new
                              {
                                  BowlerID = bowler.BowlerID,
                                  BowlerFirstName = bowler.BowlerFirstName,
                                  BowlerMiddleInit = bowler.BowlerMiddleInit,
                                  BowlerLastName = bowler.BowlerLastName,
                                  TeamName = team.TeamName,
                                  BowlerAddress = bowler.BowlerAddress,
                                  BowlerCity = bowler.BowlerCity,
                                  BowlerState = bowler.BowlerState,
                                  BowlerZip = bowler.BowlerZip,
                                  BowlerPhoneNumber = bowler.BowlerPhoneNumber

                              }).ToArray();

            return bowlerData;
        }
    }
}
