public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Initialize a result array with the the specified length.
        double[] result = new double[length];

        // 2. Use a "for" loop to iterate through the "result" array.
        for (int i = 0; i < length; i++)
        {
            // 3. Calculate the multiple and store it in the result array.
            result[i] = number * (i + 1);           
        }

        // 4. Return the result array.
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Set a newList with the same capacity as the original data.
        List<int> newList = new List<int>(data.Count);
        // 2. Determine the starting index for the rotation.
        int currentIndex = data.Count - amount;

        // 3. Use a "for" loop to iterate through the original data.
        for (int i = 0; i < data.Count; i++)
        {
            // 4. Use the modulo operator (%) to take the remainder as the index of the original data, and obtain the new rotated list value.
            int value = data[(i + currentIndex) % data.Count];  

            // 5. Add the value to the newList.
            newList.Add(value);
        }

        // 6. Update the original data by clearing it and adding all elements from newList.
        data.Clear();
        data.AddRange(newList);
    }
}
