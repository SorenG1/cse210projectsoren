using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public int GetScore() => _score;
    public int GetLevel() => _level;

    private string GetTitle()
    {
        if (_score < 500) return "Novice Adventurer";
        if (_score < 2000) return "Quest Knight";
        return "Eternal Champion";
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;

        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"\n🎉 Congratulations! You reached Level {_level}!");
            Console.WriteLine($"Your new title is: {GetTitle()}");
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetStatus()} {g.GetName()} ({g.GetDescription()})");
            i++;
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal g = _goals[choice - 1];
        int earned = g.RecordEvent();
        _score += earned;

        Console.WriteLine($"\nYou earned {earned} points!");
        Console.WriteLine($"Total Score: {_score}");

        CheckLevelUp();
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nScore: {_score}");
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"Title: {GetTitle()}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            output.WriteLine(_level);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        _goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                AddGoal(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            }
            else if (type == "EternalGoal")
            {
                AddGoal(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                AddGoal(new ChecklistGoal(
                    data[0], data[1], int.Parse(data[2]),
                    int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])
                ));
            }
        }
    }
}