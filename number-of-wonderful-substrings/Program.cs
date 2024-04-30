using System;

class WonderfulSubstrings
{
    public static long CountWonderfulSubstrings(string word)
    {
        // Initialize an array to keep track of state counts
        long[] stateCount = new long[1024]; // Only 1024 possible states (2^10)
        stateCount[0] = 1;

        int currentState = 0;
        long count = 0;

        // Iterate through each character in the word
        for (int i = 0; i < word.Length; i++)
        {
            // Update the current state by toggling the bit for the current character
            currentState ^= 1 << (word[i] - 'a');
            
            // Count how many wonderful substrings can be formed with the current state
            count += stateCount[currentState];

            // Check all possible odd-count cases by flipping each bit in the current state
            for (int j = 0; j < 10; j++)
            {
                int toggledState = currentState ^ (1 << j);
                count += stateCount[toggledState];
            }

            // Increment the state count for the current state
            stateCount[currentState]++;
        }

        // Return the total count of wonderful substrings
        return count;
    }

    static void Main()
    {
        // Example test cases
        Console.WriteLine(CountWonderfulSubstrings("aba"));  // Output: 4
        Console.WriteLine(CountWonderfulSubstrings("aabb")); // Output: 9
        Console.WriteLine(CountWonderfulSubstrings("he"));   // Output: 2
        
        // Test with the given large input example
        string longString = new string('c', 100000);
        Console.WriteLine(CountWonderfulSubstrings(longString)); // Expected Output: 4375050000
    }
}
