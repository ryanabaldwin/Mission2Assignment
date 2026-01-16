namespace Mission2Assignment;

internal class RollDice
{
    public int[] RollDiceSim(int rolls)
    {
        Random rng = new Random();
        int[] counts = new int[13];
        
        for (int i = 0; i < rolls; i++)
        {
            int roll1 = rng.Next(1, 7);
            int roll2 = rng.Next(1, 7);
            int total = roll1 + roll2;
            
            if (total == 2)
            {
                counts[2]++;
            }
            if (total == 3)
            {
                counts[3]++;
            }
            if (total == 4)
            {
                counts[4]++;
            }
            if (total == 5)
            {
                counts[5]++;
            }
            if (total == 6)
            {
                counts[6]++;
            }
            if (total == 7)
            {
                counts[7]++;
            }
            if (total == 8)
            {
                counts[8]++;
            }
            if (total == 9)
            {
                counts[9]++;
            }
            if (total == 10)
            {
                counts[10]++;
            }
            if (total == 11)
            {
                counts[11]++;
            }
            if (total == 12)
            {
                counts[12]++;
            }
        }

        return counts;
    }
}