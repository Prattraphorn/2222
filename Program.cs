using System;

class Program {
    static void Main() {
        
        Console.Write("Enter the amount of water: ");
        float water = float.Parse(Console.ReadLine());

        Console.Write("Enter the demand: ");
        float demand = float.Parse(Console.ReadLine());

        Console.Write("Enter the amount to refill: ");
        float refill = float.Parse(Console.ReadLine());

        if (refill > water) {
            Console.WriteLine("Overflow water");
        }
        else {
            float remainingWater = water - demand + refill;
            float threshold = refill * 2;

            if (remainingWater >= threshold) {
                Console.WriteLine("Enough water! " + remainingWater + " left");
            }
            else {
                Console.WriteLine("Not enough water");
            }
        }
    }
}
