using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();
        int choice = -1;

        while (choice != 6)
        {
            goalManager.Start();
            choice = getChoice();

            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoalDetails();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                default:
                    break;
            }
        }
    }
    public static int getChoice()
    {
        try
        {
            int choice = Int32.Parse(Console.ReadLine());
            return choice;
        }
        catch (System.Exception)
        {
            return 6;
        }
    }
}