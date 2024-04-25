using System;
using System.Threading;

public class CarDashboard
{
    private int speed;
    private int rpm;
    private bool headlightsOn;
    private bool accelerating;
    private bool braking;

    public CarDashboard()
    {
        speed = 0;
        rpm = 0;
        headlightsOn = false;
        accelerating = false;
        braking = false;
    }

    public void SimulateData()
    {
        if (accelerating)
        {
            speed += 5; // Simulate acceleration
        }
        else if (braking)
        {
            speed -= 5; // Simulate braking
        }

        speed = Math.Max(0, Math.Min(speed, 150)); // Limit speed between 0-150 mph
        rpm = (int)(speed * 2.5); // Example: Link RPM to simulated speed
    }

    public void UpdateDisplay()
    {
        Console.Clear(); // Clear previous console output

        // Display car data in a formatted way with basic gauges
        Console.WriteLine("Car Dashboard:");
        Console.WriteLine($"Speed: {speed} mph  {GetSpeedGauge(speed)}");
        Console.WriteLine($"RPM: {rpm} RPM  {GetRpmGauge(rpm)}");
        Console.WriteLine($"Headlights: {headlightsOn}");
        Console.WriteLine("Controls:");
        Console.WriteLine($" - Accelerate: {accelerating}");
        Console.WriteLine($" - Brake: {braking}");
    }

    private string GetSpeedGauge(int speed)
    {
        int gaugeLength = 10; // Adjust for desired gauge size
        double segment = 150.0 / gaugeLength; // Speed per gauge segment
        int filledSegments = (int)Math.Floor(speed / segment);
        return "[" + new string('=', filledSegments) + new string('-', gaugeLength - filledSegments) + "]";
    }

    private string GetRpmGauge(int rpm)
    {
        int gaugeLength = 15; // Adjust for desired gauge size
        double segment = 8000.0 / gaugeLength; // RPM per gauge segment
        int filledSegments = (int)Math.Floor(rpm / segment);
        return "[" + new string('=', filledSegments) + new string('-', gaugeLength - filledSegments) + "]";
    }

    public void RunSimulation()
    {
        while (true)
        {
            SimulateData();
            UpdateDisplay();

            // Read user input for control simulation
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    accelerating = true;
                    braking = false;
                    break;
                case ConsoleKey.S:
                    accelerating = false;
                    braking = true;
                    break;
                case ConsoleKey.H:
                    headlightsOn = !headlightsOn;
                    break;
                case ConsoleKey.Escape:
                    return; // Exit simulation
            }

            Thread.Sleep(100); // Simulate delay
        }
    }

    public static void Main(string[] args)
    {
        CarDashboard carDashboard = new CarDashboard();
        carDashboard.RunSimulation();
    }
}
