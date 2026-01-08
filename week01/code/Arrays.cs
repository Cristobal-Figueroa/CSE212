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
        // Plan:
        // 1. Create an array with the requested length to store every result.
        // 2. Loop over each position and assign number * (index + 1) to build the consecutive multiples.
        // 3. Return the filled array once all values have been computed.
        var result = new double[length];
        for (var i = 0; i < length; i += 1)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // Plan:
        // 1. Determine the list length and reduce the rotation amount with modulo to skip full spins.
        // 2. If the resulting shift is zero, exit early because the list is already aligned.
        // 3. Copy the last 'shift' elements, remove them from the end, and insert them at the front.
        var count = data.Count;
        var shift = amount % count;
        if (shift == 0)
        {
            return;
        }

        var tail = data.GetRange(count - shift, shift);
        data.RemoveRange(count - shift, shift);
        data.InsertRange(0, tail);
    }
}
