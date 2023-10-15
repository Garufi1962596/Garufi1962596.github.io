
# In C#

## Array

    int[] myArray = new int[] { 1, 2, 3, 4, 5 };
    int value = myArray[2];  // Gets the value at index 2 (which is 3).
 
    int[] myArray = new int[] { 1, 2, 3, 4, 5 };
    myArray[2] = 42;  // Sets the value at index 2 to 42.
  
    for (int i = 0; i < myArray.Length; i++) // Loop using for 
    {
      int value = myArray[i];
      // Process value
    }
  
    foreach (int value in myArray) // Loop using foreach
    {
      if (value == 3)
    {
        break;  // Exit the loop when the value is 3.
    }
    else if (value == 2)
    {
        continue;  // Skip processing when the value is 2.
    }
    }
 
     int index = Array.IndexOf(myArray, 3); //check existence using Array.IndexOf
     bool exists = index != -1;
     bool exists = myArray.Contains(3); //check existence using Array.Contains
 
You cannot directly add or remove elements in a traditional array. Arrays have a fixed length. If you need to add or remove elements dynamically, consider using a List or other dynamic data structures.
 
bool exists = Array.Exists(myArray, element => element == 3); //check existence using Array.exists

## List

    List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
    int value = myList[2];  // Gets the value at index 2 (which is 3).

    List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
    myList[2] = 42;  // Sets the value at index 2 to 42.

    for (int i = 0; i < myList.Count; i++) // loop using for
    {
        int value = myList[i];
        // Process value
    }

    foreach (int value in myList) //loop using foreach
    {
        if (value == 3)
    {
        break;  // Exit the loop when the value is 3.
    }
    else if (value == 2)
    {
        continue;  // Skip processing when the value is 2.
    }
    }

    myList.Add(6);  // Adds the value 6 to the end of the list.

    myList.Remove(3);  // Removes the first occurrence of the value 3.

    bool exists = myList.Contains(3);  // Checks if the list contains the value 3.

## Dictionary

    Dictionary<string, int> myDict = new Dictionary<string, int>();
    int value = myDict["someKey"];  // Gets the value associated with "someKey".

    myDict["someKey"] = 42;  // Sets the value associated with "someKey" to 42.

    foreach (KeyValuePair<string, int> kvp in myDict)  //loop
    {
        string key = kvp.Key;
        int value = kvp.Value;
        if (kvp.Key == "someKey")
        {
            break;  // Exit the loop when the key is "someKey".
        }
        else if (kvp.Value == 42)
        {
            continue;  // Skip processing when the value is 42.
        }
        // Process other key-value pairs
    }

    myDict.Add("newKey", 123);  // Adds a new key-value pair to the dictionary.

    myDict.Remove("someKey");  // Removes the key-value pair associated with "someKey".

    bool exists = myDict.ContainsKey("someKey");  // Checks if "someKey" exists in the dictionary.

    bool exists = myDict.ContainsValue(42);  // Checks if the value 42 exists in the dictionary.

## Sorted List

    SortedList<string, int> sortedList = new SortedList<string, int>();
    int value = sortedList["someKey"];  // Gets the value associated with "someKey".

    sortedList["someKey"] = 42;  // Sets the value associated with "someKey" to 42.

    foreach (KeyValuePair<string, int> kvp in sortedList)
      {
          string key = kvp.Key;
          int value = kvp.Value;
          if (kvp.Key == "someKey")
          {
            break;  // Exit the loop when the key is "someKey".
          }
          else if (kvp.Value == 42)
          {
            continue;  // Skip processing when the value is 42.
          }
      }
    
    sortedList.Add("newKey", 123);  // Adds a new key-value pair to the sorted list.

    sortedList.Remove("someKey");  // Removes the key-value pair associated with "someKey".

    bool exists = sortedList.ContainsKey("someKey");  // Checks if "someKey" exists in the sorted list.

    bool exists = sortedList.ContainsValue(42);  // Checks if the value 42 exists in the sorted list.


##  Hashset

     foreach (var item in hashSet) // Loop
     {
        if (item == 42)
        {
            break; // Break out of the loop
        }
        
        if (item == 24)
        {
            continue; // Skip the current iteration and continue with the next element
        }
    
        Console.WriteLine(item);
     }

     HashSet<int> hashSet = new HashSet<int>();
     hashSet.Add(42); //to add an element to the hashSet

     hashSet.Remove(42); //to remove an element from the hashSet

     bool exists = hashSet.Contains(42);  // Checks if the value 42 exists in the hashSet

In a HashSet<T>, you cannot directly "get" or "set" elements in the same way you can with lists or arrays, because a HashSet doesn't have indexed access to its elements. 

## SortedSet

      foreach (int item in sortedSet) // Loop
      {
          if (item == 42)
          {
              break; // Exit the loop
          }
          if (item % 2 == 0)
          {
              continue; // Skip even numbers and continue the loop
          }
          // Do something with 'item'
      }

      SortedSet<int> sortedSet = new SortedSet<int>(); // to add an element to sortedSet
      sortedSet.Add(42);

      sortedSet.Remove(42); // to remove an element from sortedSet

      bool exists = sortedSet.Contains(42); // Checks if the value 42 exists in the sortedSet

  You can get elements from a SortedSet, but it's read-only. There's no direct way to set elements because a SortedSet is intended to maintain its sorted order.

  ## Queue

    string frontItem = queue.Peek(); // to get an element from the queue
    
    foreach (string item in queue) //Loop
    {
        if (item == "Item 2")
        {
            break; // Exit the loop
        }
        if (item.Length < 5)
        {
            continue; // Skip items with length less than 5 and continue the loop
        }
        // Do something with 'item'
    }

    Queue<string> queue = new Queue<string>(); // to add an element to the queue
    queue.Enqueue("Item 1");

    string item = queue.Dequeue(); // to remove an element from the queue

    bool exists = queue.Contains("Item 1"); // Checks if the value 1 exists in the queue

 In a standard Queue, you can't directly set elements. It follows the FIFO principle, and you can only enqueue and dequeue elements.

 ## Stack

    string topItem = stack.Peek(); // Inspect the top element, to get an element from the stack without removing it
    
    foreach (string item in stack) // Loop
    {
        if (item == "Item 2")
        {
            break; // Exit the loop
        }
        if (item.Length < 5)
        {
            continue; // Skip items with length less than 5 and continue the loop
        }
        // Do something with 'item'
    }

    Stack<string> stack = new Stack<string>(); // to add an element to the stack
    stack.Push("Item 1");

    string item = stack.Pop(); // to remove an element form the stack

    bool exists = stack.Contains("Item 1"); // Checks if the value 1 exists in the stack

In a standard Stack, you can't directly set elements. You can only push and pop elements based on the LIFO behavior.

## LinkedList

    int firstItem = linkedList.First.Value; // to get an element from the linkedList 
    int lastItem = linkedList.Last.Value;

    linkedList.First.Value = 42; // to set an element in linkedList

    foreach (int item in linkedList) // Loop
    {
        if (item == 2)
        {
            break; // Exit the loop
        }
        if (item < 0)
        {
            continue; // Skip negative items and continue the loop
        }
        // Do something with 'item'
    }

    LinkedList<int> linkedList = new LinkedList<int>(); // to add an element to the linkedList
    linkedList.AddLast(1);

    linkedList.Remove(1); // to remove an element from the linkedList
    linkedList.RemoveFirst();
    linkedList.RemoveLast();

    bool exists = linkedList.Contains(2); // Checks if the value 2 exists in the linckedList







    





     
     












    
