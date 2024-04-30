# Intuition
The goal is to count the number of wonderful non-empty substrings in the given word. A wonderful substring is a substring in which at most one character appears an odd number of times. We can leverage a sliding window approach, state tracking, and bit manipulation to efficiently identify and count these substrings.

# Approach
1. State Representation: Represent the frequency of each character (a-j) in a substring using a 10-bit integer, where each bit corresponds to one of the 10 lowercase letters (a-j). Toggle the bit of the corresponding character to update the state.
2. State Tracking: Use an array (stateCount) to track how many times each state has occurred. Initialize with an array of size 1024 (2^10 possible states for the 10 lowercase letters) and set the initial state (0) with a count of 1.
3. Iterate Through the Word: As we iterate through the word, update the current state based on the character encountered.
4. Count Wonderful Substrings: For each state and its toggled versions (flipping each bit), check how many times the state has occurred previously. This helps us count the wonderful substrings efficiently.
5. Update State Count: After counting, increment the count of the current state in stateCount.
6. Return Total Count: Return the total count of wonderful substrings accumulated.
# Complexity
- Time complexity: The time complexity of the approach is O(n), where n is the length of the input word. This is because we iterate through each character in the word, updating the state, and checking for wonderful substrings.
- Space complexity: The space complexity of the approach is O(1) because the array stateCount is fixed in size (1024 elements) due to the limited number of possible states (2^10). This array does not depend on the length of the input word.
