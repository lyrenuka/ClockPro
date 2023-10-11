using ClockPro;

public class Program
{
    public static void Main()
    {
       
            Clock clock = new Clock();

        // Simulate 86400 ticks
        for (int i = 0; i < 86400; i++)
            {
                Thread.Sleep(1000);
                clock.Tick();
                Console.Clear();
                Console.WriteLine(clock.GetTime());
            }
        
    }
}