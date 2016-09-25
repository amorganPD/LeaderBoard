using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaderBoard.Models
{
    public class LeaderboardModel
    {
        public List<ScoreboardItem> GetScoreboard()
        {
            using(var context = new acleaderbaordEntities())
            {
                var x = context.Scores.First();

                return context.Scores.Select(score => new ScoreboardItem
                {
                    UserName = score.Username,
                    Score = score.ScoreValue
                }).ToList();
            }
        }
        public void InsertScore(ScoreboardItem newScore)
        {
            using(var context = new acleaderbaordEntities())
            {
                var scoreToAdd = new Score()
                {
                    Username = newScore.UserName,
                    ScoreValue = newScore.Score
                };

                context.Scores.Add(scoreToAdd);

                context.SaveChanges();

            }
        }
    }
}