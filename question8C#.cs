using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        arrayList.Add("Apple");
        arrayList.Add("Banana");
        arrayList.Add("Cherry");
        arrayList.Add(42);

        // Displaying elements in the ArrayList
        Console.WriteLine("ArrayList contents:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

          // Finding the index of "Banana"
        int index = FindIndexOfItem(arrayList, "Banana");
        if (index != -1)
        {
            Console.WriteLine($"\n'Banana' found at index: {index}");
        }
        else
        {
            Console.WriteLine("\n'Banana' not found in the ArrayList.");
        }

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        dictionary.Add("Apple", 1);
        dictionary.Add("Banana", 2);
        dictionary.Add("Cherry", 3);

        // Displaying elements in the Dictionary
        Console.WriteLine("\nDictionary contents:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Accessing a value by key
        if (dictionary.TryGetValue("Banana", out int value))
        {
            Console.WriteLine($"\nValue for 'Banana': {value}");
        }
        else
        {
            Console.WriteLine("\nKey 'Banana' not found.");
        }
    }
    // Function to find the index of an item in the ArrayList
    static int FindIndexOfItem(ArrayList list, object item)
    {
        return list.IndexOf(item);
    }
}