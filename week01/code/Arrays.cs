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
        // 1. Create an array of doubles with the size of length.
        // 2. Use a for loop to iterate from 0 to length - 1.
        // 3. In each iteration, calculate the multiple of the number by multiplying it with (i + 1).
        // 4. Store the result in the corresponding index of the array.
        // 5. Return the array after the loop completes.

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;

        // replace this return statement with your own
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
        // 1. Check if the amount is greater than 0 and less than or equal to the count of the list.
        // 2. If not, return without making any changes.
        // 3. Calculate the effective rotation amount by taking the modulus of the amount with the count of the list.
        // 4. Create a temporary list to store the last 'amount' elements of the original list.
        // 5. Remove the last 'amount' elements of the original list.
        // 6. Add the temporary list to the beginning of the original list.
        // 7. Return.

        if (amount <= 0 || amount > data.Count)
        {
            return;
        }
        int effectiveAmount = amount % data.Count;

        List<int> temp = new List<int>(data.GetRange(data.Count - effectiveAmount, effectiveAmount));
        data.RemoveRange(data.Count - effectiveAmount, effectiveAmount);
        data.InsertRange(0, temp);
        // Note: The above code uses List<T>.GetRange() to create a sublist and List<T>.RemoveRange() to remove elements.
    }




}
