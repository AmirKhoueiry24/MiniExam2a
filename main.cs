using System;
using System.Linq;
public class VolumeOfCylinder
{
    public static void Main()
    {
        Console.WriteLine("Enter Height of Cylinder:");
        double Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Radius of Cylinder:");
        double Radius = Convert.ToDouble(Console.ReadLine());
        double Volume = CalculateVolume(Height, Radius);
        Console.WriteLine("Volume of cylinder: " + Volume);
        Console.ReadKey();
    }
    private static double CalculateVolume(double Height, double Radius)
    {
        return Math.PI * (Radius * Radius) * Height;
    }
}