public static class Arrays
{
    /// <summary>
    /// The function first creates an array to hold the data and initializes a counter starting at 1.
    /// Then, a for loop iterates through the array based on its length.
    /// During each iteration, the given number is multiplied by the counter.
    /// The post-increment operator increases the counter after its current value is used.
    /// Since this is an array, I assign each result to its corresponding index instead of adding
    /// or inserting elements as I would with a list.
    /// Finally, the function returns the completed array.
    /// </summary>
    /// <param name="number">The number to be multiplied.</param>
    /// <param name="length">The number of multiples to generate.</param>
    /// <returns>An array containing the multiples of the provided number.</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] array = new double[length];
        int count = 1;

        for (int i = 0; i < length; i++)
        {
            var value = number * count++;
            array[i] = value;
        }
        // To solve this problem, i had to draw a sketch in a piece of paper of each process. i was struggling at first because
        // I wanted to replace the data but I learned and recalled in the process that an array behaves differently than a list
        // I preferred to use a for loop instead of a foreach, i found it cleaner and easier to understand.

        return array;
    }

    /// <summary>
    /// This function receives a list of integers and an amount indicating how many elements
    /// should be rotated to the right.
    /// First, the Count property determines the total number of elements in the list.
    /// Then, the starting index is calculated by subtracting the amount from the list's count.
    /// The GetRange() method creates a new list containing the selected elements.
    /// After that, the RemoveRange() method removes those elements from the original list.
    /// Finally, the InsertRange() method inserts the extracted elements at index 0,
    /// modifying the original list without returning a new one.
    /// </summary>
    /// <param name="data">The original list of integers to rotate.</param>
    /// <param name="amount">The number of positions to rotate the list to the right.</param>
    public static void RotateListRight(List<int> data, int amount)
    {
        int range = data.Count;
        List<int> extract = data.GetRange(range - amount, amount);
        data.RemoveRange(range - amount, amount);
        data.InsertRange(0, extract);


        // At first i also made a Sketch to get an idea of what to do, but i was confused if I had to provide the input as well as the list
        // The result was a little waste of time but I strengthened my understanding of Lists by adding, removing and inserting data.
    }
}
