using System;
using System.Collections.Generic;
using System.Linq;

namespace EternalQuest
{
    // Creative addition: small achievement tracker
    public class AchievementManager
    {
        private List<string> _achievements = new List<string>();
        private GoalManager _manager;

        public AchievementManager(GoalManager manager)
        {
            _manager = manager;
        }

        public void CheckAchievements()
        {
            if (_manager.Score >= 50 && !_achievements.Contains("50 Points!"))
            {
                _achievements.Add("50 Points!");
                Console.WriteLine("Achievement Unlocked: 50 Points!");
            }

            if (_manager.GetGoals().OfType<ChecklistGoal>().Any(g => g.IsComplete()) &&
                !_achievements.Contains("Checklist Completed!"))
            {
                _achievements.Add("Checklist Completed!");
                Console.WriteLine("Achievement Unlocked: Checklist Completed!");
            }
        }

        public void ShowAchievements()
        {
            if (_achievements.Count == 0)
            {
                Console.WriteLine("No achievements yet.");
            }
            else
            {
                Console.WriteLine("Achievements:");
                foreach (var a in _achievements)
                {
                    Console.WriteLine("- " + a);
                }
            }
        }
    }
}

