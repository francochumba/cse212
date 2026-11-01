public static class Arrays
{
    /// <summary>
    /// the function creates an array to hold the data, sets the counter that starts at 1 for it's augmentation
    /// and a for loop to iterate the length of the multiplication
    /// I added an post-increment operator to simplify the counting
    /// because it is an array, I assigned the value of each index instead of adding or inserting values like a list.
    /// </summary>
    /// <param name="number"> calls the number to be multiplied</param>
    /// <param name="length"> how many multiples will have</param>
    /// <returns> returns the multiples of the number provided according to its length</returns>
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
    /// this function calls the sequence of numbers provided by the tests, and a specific number to rotate the list.
    /// it calculates the range of the numbers to be "extracted", removed the selected elements of the list and insert them
    /// at the beginning of the list.
    /// </summary>
    /// <param name="data"> the list of numbers provided by the tester</param>
    /// <param name="amount"> the amount of numbers rotated at the beginning of the list</param>    
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
