using System;
using System.Timers;

class ChatSystem
{
    private Timer timer;

    public ChatSystem()
    {
        timer = new Timer(60000); // 60,000 milliseconds = 1 minute
        timer.Elapsed += TimerElapsed;
        timer.Start();
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        BroadcastMessage("I love you!");
    }

    public void BroadcastMessage(string message)
    {
        Console.WriteLine("Chat: " + message);
    }
}

class Program
{
    static void Main()
    {
        ChatSystem chatSystem = new ChatSystem();

        // Keep the program running
        Console.ReadLine();
    }
}
