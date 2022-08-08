string[] sourceArray = new string[4] { "hello", "world", "2", ":-)" };
const int SIZE = 3;

void PrintStringArray(string[] intputData)
{
    Console.WriteLine("[" + string.Join(", ", intputData) + "]");
}

string[] CutLargeWords(string[] inputArray, int condition)
{
    string[] resultArray = new string[0];
    int indexOfResultArray = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            Array.Resize(ref resultArray, resultArray.Length + 1);
            resultArray[indexOfResultArray] = sourceArray[i];
            indexOfResultArray++;
        }
    }

    return resultArray;
}

string[] modifiedArray = CutLargeWords(sourceArray, SIZE);
PrintStringArray(modifiedArray);