using LeaderBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeaderBoard.Controllers
{
    public class ScoreboardController : ApiController
    {
        public List<ScoreboardItem> Get()
        {
            var model = new LeaderboardModel();

            var x = model.GetScoreboard();

            return x;
            
        }

        public void Post([FromBody]ScoreboardItem newScore)
        {
            var model = new LeaderboardModel();
            model.InsertScore(newScore);

        }
    }
}
