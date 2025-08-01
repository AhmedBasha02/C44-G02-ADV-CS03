using System.Collections;
using System.Collections.Generic;

namespace Session_3_ADV_C__Assignment
{
    internal class Program
    {
        #region Q1
        public static int FirstNonRepeatedCharIndex(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            // First pass: Count frequencies
            foreach (char ch in input)
            {
                if (frequencyMap.ContainsKey(ch))
                    frequencyMap[ch]++;
                else
                    frequencyMap[ch] = 1;
            }

            // Second pass: Find first character with frequency 1
            for (int i = 0; i < input.Length; i++)
            {
                if (frequencyMap[input[i]] == 1)
                    return i;
            }

            return -1;
        }

        #endregion

        #region Q5
        public static List<List<string>> GroupAnagrams(string[] words)
        {
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                // Convert word to a character array and sort it
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sortedKey = new string(charArray);

                // Use sortedKey as dictionary key
                if (!anagramGroups.ContainsKey(sortedKey))
                    anagramGroups[sortedKey] = new List<string>();

                anagramGroups[sortedKey].Add(word);
            }

            // Convert values to a list of lists
            return new List<List<string>>(anagramGroups.Values);
        }

        #endregion
        static void Main(string[] args)
        {

            #region Q1

            //Console.WriteLine(FirstNonRepeatedCharIndex("level"));       // Output: 2 ('v')
            //Console.WriteLine(FirstNonRepeatedCharIndex("aabbcc"));      // Output: -1
            //Console.WriteLine(FirstNonRepeatedCharIndex("programming")); // Output: 0 ('p')
            //Console.WriteLine(FirstNonRepeatedCharIndex("xxyyzzq"));     // Output: 6 ('q')

            #endregion

            #region Q2

            //int[] array = { 4, 2, 4, 5, 2, 4 };
            //Hashtable frequency = new Hashtable();

            //foreach (int item in array)
            //{
            //    if (frequency.ContainsKey(item))
            //    {
            //        frequency[item] = (int?)frequency[item] + 1;
            //    }
            //    else
            //    {
            //        frequency[item] = 1;
            //    }

            //}
            //foreach (DictionaryEntry entry in frequency)
            //{
            //    Console.WriteLine($"Value: {entry.Key}, Frequency: {entry.Value}");
            //}


            #endregion

            #region Q3

            //Hashtable scores = new Hashtable()
            //{
            //   { "Ahmed", 80 },
            //   { "Sara", 95 },
            //   { "Omar", 70 }
            //};

            //string? maxKey = "";
            //int? maxValue = 0;

            //foreach (DictionaryEntry entry in scores)
            //{
            //    if ((int?)entry.Value > maxValue)
            //    {
            //        maxValue = (int?)entry.Value;
            //        maxKey = (string)entry.Key;
            //    }
            //}

            //Console.WriteLine($"Key with highest value is : {maxKey} , {maxValue}");


            #endregion

            #region Q4

            //Hashtable fruit = new Hashtable()
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" }
            //};

            //Console.Write("Enter Value that related to some keys : ");
            //string? Value = Console.ReadLine();
            //Console.WriteLine();

            //bool search = false;

            //foreach (DictionaryEntry entry in fruit)
            //{

            //        if ((string?)entry.Value == Value )
            //        {
            //            Console.WriteLine(entry.Key);
            //            search = true;
            //        }

            //}
            //if (!search)
            //{
            //    Console.WriteLine("Key not found");
            //}



            #endregion

            #region Q5

            //string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //var result = GroupAnagrams(input);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(string.Join(", ", group));
            //}

            #endregion

            #region Q6

            //SortedDictionary<int, string> studentDirectory = new SortedDictionary<int, string>();

            //// Adding students
            //studentDirectory.Add(102, "Ali");
            //studentDirectory.Add(101, "Sara");
            //studentDirectory.Add(103, "Mina");

            //// Removing a student
            //studentDirectory.Remove(101);

            //// Retrieving a student name by ID
            //if (studentDirectory.ContainsKey(102))
            //    Console.WriteLine($"Student 102: {studentDirectory[102]}");

            //// Displaying all students in sorted order
            //foreach (var entry in studentDirectory)
            //    Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");


            #endregion

            #region Q7

            //SortedList<int, string> employeeDirectory = new SortedList<int, string>();

            //// Adding employees
            //employeeDirectory.Add(2003, "Omar");
            //employeeDirectory.Add(2001, "Laila");
            //employeeDirectory.Add(2002, "Ziad");

            //// Retrieving employee by ID
            //Console.WriteLine($"Employee 2002: {employeeDirectory[2002]}");

            //// Displaying all employees sorted by ID
            //foreach (var entry in employeeDirectory)
            //    Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");

            #endregion

            #region Q8

            //List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };
            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            //// Displaying unique values
            //foreach (int number in uniqueNumbers)
            //    Console.WriteLine(number);

            #endregion

            #region Q9
            //Hashtable original = new Hashtable()
            //{
            //    { "Egypt", "Cairo" },
            //    { "France", "Paris" },
            //    { "Japan", "Tokyo" }
            //};

            //Hashtable swapped = new Hashtable();

            //foreach (DictionaryEntry entry in original)
            //{
            //    // Swap key and value
            //    swapped[entry.Value] = entry.Key;
            //}

            //Console.WriteLine("Swapped Hashtable:");
            //foreach (DictionaryEntry entry in swapped)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}


            #endregion

            #region Q10

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            //HashSet<int> setB = new HashSet<int> { 3, 4, 5 };

            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);

            //foreach (int item in unionSet)
            //    Console.WriteLine(item);

            #endregion

            #region Q11

            //Dictionary<string, int> data = new Dictionary<string, int>
            // {
            //     { "apple", 1 },
            //     { "animal", 2 },
            //     { "airport", 3 },
            //     { "banana", 4 }
            // };

            //char targetChar = 'a';
            //int count = 0;

            //foreach (var key in data.Keys)
            //{
            //    if (!string.IsNullOrEmpty(key) && key[0] == targetChar)
            //        count++;
            //}

            //Console.WriteLine($"Number of keys starting with '{targetChar}': {count}");

            #endregion

            #region Q12

            //SortedSet<int> sortedSet = new SortedSet<int> { 3, 6, 9, 12, 15 };
            //int target = 8;

            //List<int> greaterValues = new List<int>();

            //foreach (int item in sortedSet)
            //{
            //    if (item > target)
            //        greaterValues.Add(item);
            //}

            //foreach (int value in greaterValues)
            //    Console.WriteLine(value);

            #endregion

            #region Q13

            //SortedList<int, int> sortedList = new SortedList<int, int>
            //{
            //    { 101, 15 },
            //    { 102, 18 },
            //    { 103, 21 },
            //    { 104, 24 }
            //};

            //List<int> evenValueKeys = new List<int>();

            //foreach (var pair in sortedList)
            //{
            //    if (pair.Value % 2 == 0)
            //        evenValueKeys.Add(pair.Key);
            //}

            //foreach (int key in evenValueKeys)
            //    Console.WriteLine($"Key with even value: {key}");

            #endregion
        }
    }
}
