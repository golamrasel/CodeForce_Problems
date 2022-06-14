using System;

namespace Football_43A
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfGoal = int.Parse(Console.ReadLine());
            string teamA = "", teamB = ""; // Team Name
            int AGoal = 0, BGoal = 0; // Team Goal

            for (int i = 0; i < NoOfGoal; i++)
            {
                string team = Console.ReadLine();
                if (teamA.Length == 0 || teamA == team)
                {
                    teamA = team;// Set Team Name
                    AGoal = AGoal + 1; // Set Team Goal
                }
                else
                {
                    teamB = team;
                    BGoal = BGoal + 1;
                }
            }

            if (AGoal > BGoal)
                Console.WriteLine(teamA);
            else
                Console.WriteLine(teamB);
        }
    }
}
