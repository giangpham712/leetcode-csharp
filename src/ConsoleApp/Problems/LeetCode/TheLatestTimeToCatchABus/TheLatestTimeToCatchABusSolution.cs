namespace ConsoleApp.Problems.LeetCode.TheLatestTimeToCatchABus;

public class TheLatestTimeToCatchABusSolution
{
    public int Solve(int[] buses, int[] passengers, int capacity)
    {
        Array.Sort(buses);
        Array.Sort(passengers);

        var busIndex = 0;
        var passengerIndex = 0;

        
        var latestTime = 1;
        var currentPassengers = 0;
        while (busIndex < buses.Length)
        {
            // If there are more passengers who can get on the current bus
            if (passengerIndex < passengers.Length && passengers[passengerIndex] <= buses[busIndex])
            {
                if (passengerIndex == 0 || passengers[passengerIndex - 1] != passengers[passengerIndex] - 1)
                {
                    latestTime = passengers[passengerIndex] - 1;
                }
                
                currentPassengers++;
                passengerIndex++;
                
                // If the bus is full, it will leave
                if (currentPassengers == capacity)
                {
                    currentPassengers = 0;
                    busIndex++;
                }
            }
            else
            {
                
                if (passengerIndex == 0 || passengers[passengerIndex - 1] != buses[busIndex])
                {
                    latestTime = buses[busIndex];
                }
                
                busIndex++;
                currentPassengers = 0;
            }
        }
        
        return latestTime;
    }
}