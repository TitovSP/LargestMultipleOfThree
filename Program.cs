using System;
using System.Collections.Generic;
using System.Linq;

int[] digits = new int[] { 2, 9, 1, 6, 1, 6, 2, 2, 4, 3, 2, 8, 6, 1, 1, 7, 2, 3, 8, 6, 2, 6, 4, 8, 5, 0, 0, 3, 3, 7, 9, 1, 3, 4, 3, 8, 1, 7, 1, 3, 9, 7, 4, 2, 8, 6, 0, 6, 2, 7, 0, 5, 1, 9, 0, 7, 8, 0, 4, 5, 6, 2, 7, 9, 8, 4, 8, 6, 2, 2, 1, 9, 6, 1, 0, 1, 0, 3, 6, 1, 1, 8, 6, 1, 6, 9, 1, 3, 6, 4, 7, 7, 3, 2, 5, 3, 1, 7, 3, 9, 0, 9, 3, 2, 6, 8, 7, 2, 7, 9, 3, 5, 9, 7, 3, 7, 5, 0, 0, 3, 5, 3, 8, 3, 8, 2, 9, 6, 6, 9, 0, 5, 3, 1, 2, 8, 3, 0, 4, 9, 6, 7, 6, 4, 6, 6, 6, 6, 6, 5, 1, 8, 5, 3, 7, 8, 2, 7, 9, 8, 3, 9, 8, 1, 2, 6, 5, 4, 7, 6, 1, 9, 0, 7, 2, 1, 4, 4, 7, 5, 0, 9, 5, 0, 7, 7, 9, 2, 0, 9, 6, 7, 0, 8, 3, 1, 3, 4, 0, 4, 9, 4, 0, 9, 7, 8, 5, 8, 8, 7, 6, 4, 5, 8, 8, 9, 3, 4, 1, 3, 7, 5, 6, 1, 2, 7, 4, 1, 5, 8, 1, 2, 0, 7, 1, 7, 0, 0, 8, 8, 4, 7, 3, 2, 9, 2, 2, 0, 1, 2, 7, 9, 0, 1, 7, 0, 8, 2, 3, 7, 6, 6, 8, 6, 6, 4, 0, 1, 1, 6, 7, 1, 9, 3, 4, 3, 7, 8, 6, 7, 1, 7, 0, 7, 5, 6, 6, 8, 8, 3, 7, 5, 7, 6, 8, 0, 8, 7, 8, 2, 4, 6, 2, 6, 2, 7, 1, 0, 0, 4, 1, 7, 3, 2, 6, 5, 0, 4, 7, 2, 1, 7, 6, 5, 9, 7, 5, 2, 0, 9, 9, 0, 7, 3, 3, 9, 5, 6, 1, 6, 5, 2, 7, 9, 0, 0, 3, 3, 1, 2, 8, 0, 2, 6, 6, 8, 3, 9, 1, 4, 6, 5, 9, 1, 1, 1, 6, 4, 7, 0, 6, 1, 0, 1, 7, 0, 0, 7, 9, 2, 5, 3, 3, 8, 5, 6, 7, 2, 8, 4, 2, 4, 1, 9, 5, 5, 5, 9, 5, 7, 1, 1, 8, 7, 4, 0, 2, 3, 7, 2, 8, 1, 1, 8, 2, 0, 8, 2, 8, 7, 4, 5, 3, 8, 1, 5, 0, 7, 7, 3, 3, 1, 1, 7, 9, 6, 6, 9, 3, 1, 9, 1, 0, 9, 1, 8, 6, 9, 4, 2, 8, 1, 0, 9, 7, 7, 4, 1, 6, 3, 8, 6, 6, 3, 9, 0, 4, 7, 9, 9, 4, 9, 5, 1, 8, 7, 0, 8, 8, 6, 3, 8, 6, 1, 3, 1, 2, 2, 3, 4, 2, 4, 4, 7, 7, 9, 9, 2, 0, 4, 8, 6, 6, 2, 7, 1, 8, 5, 4, 3, 5, 5, 5, 2, 4, 7, 7, 3, 8, 1, 9, 9, 4, 4, 7, 9, 9, 3, 2, 2, 2, 8, 5, 4, 3, 5, 5, 4, 7, 9, 5, 7, 2, 9, 4, 8, 2, 3, 1, 2, 6, 5, 2, 5, 7, 5, 8, 2, 2, 5, 3, 6, 8, 4, 4, 6, 5, 6, 1, 1, 0, 5, 4, 3, 1, 4, 6, 1, 9, 5, 2, 4, 9, 0, 9, 2, 3, 4, 4, 8, 4, 5, 4, 1, 5, 5, 1, 2, 2, 9, 3, 0, 1, 6, 7, 4, 6, 5, 4, 9, 5, 4, 0, 8, 1, 9, 3, 4, 9, 7, 8, 6, 6, 4, 8, 6, 9, 3, 7, 7, 5, 8, 5, 8, 5, 1, 9, 1, 7, 6, 9, 3, 4, 5, 9, 4, 9, 9, 4, 4, 0, 6, 4, 2, 1, 9, 3, 5, 1, 3, 7, 1, 8, 4, 7, 2, 0, 9, 2, 0, 9, 3, 0, 4, 5, 6, 0, 2, 3, 5, 4, 0, 5, 9, 5, 2, 9, 5, 7, 8, 5, 9, 3, 9, 5, 6, 8, 4, 5, 3, 1, 6, 5, 8, 1, 6, 5, 7, 1, 7, 4, 3, 2, 5, 5, 1, 8, 4, 1, 4, 1, 2, 9, 8, 2, 4, 1, 1, 6, 5, 7, 7, 0, 5, 9, 7, 4, 3, 6, 1, 8, 7, 7, 4, 1, 7, 0, 3, 2, 9, 9, 4, 7, 5, 9, 4, 6, 0, 9, 7, 6, 4, 4, 6, 1, 1, 7, 1, 1, 2, 3, 3, 2, 4, 2, 8, 7, 1, 5, 4, 2, 0, 8, 4, 3, 2, 3, 7, 2, 3, 1, 6, 7, 6, 7, 5, 0, 1, 9, 9, 6, 9, 8, 7, 1, 1, 5, 4, 1, 6, 5, 1, 9, 4, 3, 2, 8, 2, 1, 3, 1, 9, 0, 7, 7, 7, 0, 4, 8, 6, 4, 2, 3, 6, 7, 4, 6, 9, 5, 9, 0, 6, 6, 3, 8, 0, 5, 5, 2, 5, 1, 5, 5, 1, 2, 9, 8, 4, 3, 6, 5, 0, 2, 8, 5, 2, 0, 5, 7, 0, 1, 5, 5, 5, 9, 5, 5, 2, 3, 2, 4, 2, 2, 0, 1, 9, 1, 5, 2, 7, 8, 4, 8, 4, 6, 8, 6, 2, 7, 8, 2, 3, 7, 8, 7, 9, 6, 9, 6, 8, 6, 8, 8, 2, 5, 3, 1, 1, 3, 3, 4, 3, 9, 2, 2, 7, 0, 8, 5, 7, 9, 3, 6, 2, 2, 6, 3, 1, 3, 5, 2, 5, 8, 3, 5, 9, 6, 8, 2, 6, 4, 2, 5, 4, 8, 5, 2, 3, 7, 9, 9, 3, 5, 3, 1, 4, 2, 8, 2, 6, 5, 9, 2, 1, 2, 9, 8, 5, 2, 3, 1, 7, 5, 6, 9, 9, 5, 1, 6, 8, 3, 6, 6, 0, 1, 5, 2, 8, 7, 6 };
Console.WriteLine(LargestMultipleOfThree(digits));
Console.ReadKey();

string LargestMultipleOfThree(int[] digits)
{
    string resultCombination = string.Empty;
    Array.Sort(digits);
    Array.Reverse(digits);
    var digitsList = digits.ToList();
    var remain = digits.Sum() % 3;

    if (remain == 0)
        resultCombination = digits.Select(x => x.ToString()).Aggregate((i, j) => i + j);
    else if (remain == 1)
    {
        int[] haved = new int[] { 1, 4, 7 };
        ArrayMix(haved, digitsList);
        if(resultCombination == string.Empty)
        {
            haved = new int[] { 2, 5, 8 };
            ArrayMix(haved, digitsList, true);
        }
    }
    else if (remain == 2)
    {
        int[] haved = new int[] { 2, 5, 8 };
        ArrayMix(haved, digitsList);
        if (resultCombination == string.Empty)
        {
            haved = new int[] { 1, 4, 7 };
            ArrayMix(haved, digitsList, true);
        }
    }

    if (resultCombination != string.Empty)
    {
        resultCombination = resultCombination.TrimStart('0');
        if (resultCombination == string.Empty)
            resultCombination = "0";
    }

    return resultCombination;

    void ArrayMix(int[] haved, IEnumerable<int> array, bool twice = false)
    {
        foreach (var h in haved)
        {
            var buffer = new List<int>(array);
            if(twice)
            {
                if (buffer.Remove(h))
                    if (buffer.Remove(h))
                        CombinationCheck(buffer);
            }
            else
            {
                if (buffer.Remove(h))
                    CombinationCheck(buffer); 
            }
            
            if (resultCombination != string.Empty)
                break;
        }
    }
    void CombinationCheck(IEnumerable<int> array, params int[] param)
    {
        List<int> current = new List<int>(param);

        if (array.Count() == 0)
            if (current.Count > 0 && current.Sum() % 3 == 0)
                resultCombination = current.Select(x => x.ToString()).Aggregate((i, j) => i + j); ;

        for (int i = 0; i < array.Count(); i++)
        {
            List<int> buffer = new List<int>(array);
            buffer.RemoveAt(i);
            current.Add(array.ElementAt(i));
            CombinationCheck(buffer, current.ToArray());

            if (resultCombination != string.Empty)
                break;
        }
    }
}

















