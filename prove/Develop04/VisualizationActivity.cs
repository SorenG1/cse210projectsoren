using System;
using System.Threading;
using System.Collections.Generic;

public class VisualizationActivity : Activity
{
    private List<string> _scenes;
    private Random _random;

    public VisualizationActivity()
        : base(
            "Visualization Activity",
            "This activity will help you relax by guiding you through imagining a peaceful scene. " +
            "Visualization can help calm your mind and reduce stress.")
    {
        _random = new Random();

        _scenes = new List<string>
        {
            "Imagine you are sitting on a quiet beach, listening to gentle waves.",
            "Imagine you are walking through a peaceful forest with sunlight filtering through the trees.",
            "Imagine you are lying in a meadow, feeling a warm breeze on your face.",
            "Imagine you are sitting beside a calm lake with mountains in the distance.",
            "Imagine you are wrapped in a warm blanket beside a crackling fireplace."
        };
    }

    public void Run()
    {
        Start();

        string scene = GetRandomScene();
        Console.WriteLine("Visualize the following scene:");
        Console.WriteLine();
        Console.WriteLine($"--- {scene} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Focus on the details... ");
            ShowSpinner(4);
            Console.WriteLine();
        }

        End();
    }

    private string GetRandomScene()
    {
        return _scenes[_random.Next(_scenes.Count)];
    }
}