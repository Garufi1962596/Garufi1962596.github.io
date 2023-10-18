
# Cheatsheet

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


# In JS

## Array 
    
    const arr = [1, 2, 3, 4];
    const element = arr[2]; // to get the element at index 2

    arr[1] = 5; // Set the element at index 1 to 5

    for (let i = 0; i < arr.length; i++) { // loop using for 
        if (arr[i] === 3) {
            break; // Exit the loop
        }
        if (arr[i] === 2) {
            continue; // Skip the current iteration and continue the loop
        }
        // Access arr[i] here
    }

    arr.forEach(item => {  // loop using foreach
        // Access 'item' here
    });


    arr.push(5); // Adds 5 to the end of the array
    arr.unshift(0); // Adds 0 to the beginning of the array

    arr.pop(); // Removes the last element
    arr.shift(); // Removes the first element

    const exists = arr.includes(3); // Checks if 3 exists in the array

## List

In JavaScript, there is no built-in data structure called "List" as there is in some other programming languages like C#. Instead, you typically use arrays to achieve similar functionality. 

## Dictionary

    const dictionary = {
        key1: 'value1',
        key2: 'value2',
        key3: 'value3'
    };

    const value = dictionary.key2; // get the value associated with key2 

    dictionary.key4 = 'value4'; // Set the value for key4

    for (const key in dictionary) { //Loop 
        const value = dictionary[key];
        // Access key and value here
    }

    dictionary.newKey = 'newValue'; // Add or updates a key-value pair

    delete dictionary.key1; // Remove the key1-value1 pair

    const hasKey = dictionary.hasOwnProperty('key2'); // Checks if key2 exists
    const keyExists = 'key3' in dictionary; // Checks if key3 exists

    function valueExists(obj, targetValue) {
        for (const key in obj) {
            if (obj[key] === targetValue) {
                return true;
            }
        }
        return false;
    }
    const valueExistsInDict = valueExists(dictionary, 'value3'); // Checks if 'value3' exists in the dictionary

## SortedList 


JavaScript doesn't have a built-in data structure called "sorted list," but you can implement your own using arrays. 

    // Using push (appends at the end)
    sortedList.push(35);
    
    // Using splice (inserts at the correct position)
    const indexToInsert = sortedList.findIndex((el) => el > 25);
    sortedList.splice(indexToInsert, 0, 25);
    
    // Using the spread operator (adds and sorts the list)
    sortedList = [...sortedList, 33].sort((a, b) => a - b);

    const indexToRemove = sortedList.indexOf(40);
    if (indexToRemove !== -1) {
        sortedList.splice(indexToRemove, 1); // Removes the element at the index
    }

## Hashset

In JavaScript, there is no native "hashset" data structure, but you can implement similar functionality using objects or Sets

    // Create a Hashset-Like Structure Using Objects
    const hashset = {};

    // Add values (keys) to the hashset
    hashset['apple'] = true;
    hashset['banana'] = true;

    const hasApple = 'apple' in hashset; // Check for the Existence of Values

    for (const key in hashset) { // loop
        if (!hashset.hasOwnProperty(key)) continue; // Skip non-own properties
        
        if (key === 'banana') break; // Break the loop when 'banana' is found
        // Access the value using hashset[key]
    }

    hashset['grape'] = true;    // add an element to the hashset

    delete hashset['banana']; // to remove 
    
    // or using a Set
    const hashset = new Set();

    // Add values to the hashset
    hashset.add('apple');

    const hasApple = hashset.has('apple'); // Check for the Existence of Values
    const hasGrape = hashset.has('grape'); 

       hashset.forEach((value) => {
            if (value === 'banana') return; // Skip 'banana'
            // Access the value
       });

    hashset.add('grape');  // add an element to the hashset
 
    hashset.delete('banana'); // to remove

## SortedSet

In JavaScript, there's no built-in "SortedSet" data structure. However, you can achieve similar functionality using Arrays and custom logic to maintain sorted order. 

    const sortedSet = [];

    // Add values in sorted order
    sortedSet.push('apple');
    sortedSet.sort(); // Keep the array sorted

    for (let i = 0; i < sortedSet.length; i++) { //Loop
        if (value === 'banana') break; // Break when 'banana' is found
        if (value === 'grape') continue; // Skip 'grape'
        console.log(sortedSet[i]);
    }

    for (const value of sortedSet) { // loop
        console.log(value);
    }

    const index = sortedSet.indexOf('banana'); // remove
    if (index !== -1) {
        sortedSet.splice(index, 1);
    }
    
    const hasApple = sortedSet.includes('apple'); // Check for the Existence of Values

## Queue

In JavaScript, you can simulate a queue (FIFO - First-In-First-Out) using arrays.

    const queue = [];

    const frontItem = queue[0]; // Retrieves 'item2'
    
    // Enqueue (add an item to the back of the queue)
    queue.push('item1');
    queue.push('item2');

    const item = queue.shift(); // Removes and returns the first item (item1) //remove

    const isEmpty = queue.length === 0; // Check if the queue is empty

    for (const item of queue) {
        if (item === 'item2') break; // Break when 'item2' is found
        if (item === 'item1') continue; // Skip 'item1'
        console.log(item);
    }

## Stack 

In JavaScript, you can simulate a stack (LIFO - Last-In-First-Out) using arrays.

    const stack = [];

    const topItem = stack[1]; // get

    for (const item of stack) {
        if (item === 'item2') break; // Break when 'item2' is found
        if (item === 'item1') continue; // Skip 'item1'
        console.log(item);
    }

    // Push (add an item to the top of the stack)
    stack.push('item1');

    const item = stack.pop(); // Removes and returns the last item 

    const isEmpty = stack.length === 0; // Check if the stack is empty

    const index = stack.indexOf(elementToFind); // check if there is the element

## LinkedList

n JavaScript, there is no built-in linked list data structure like you might find in some other languages. However, you can simulate a singly linked list using objects or classes.

    class ListNode {
        constructor(value) {
            this.value = value;
            this.next = null;
        }
    }
    
    const linkedList = new ListNode('item1');
    linkedList.next = new ListNode('item2');
    linkedList.next.next = new ListNode('item3');

    const item2 = linkedList.next; // get the second item

    linkedList.value = 'newItem1'; // Updates the value of the first item

    let current = linkedList; // You can use regular loops or recursion with break and continue statements similarly to array
    while (current) {
        console.log(current.value);
        current = current.next;
    }

    current.next = new ListNode('newItem'); // to add an element 
     
    let current = linkedList; // remove
    let previous = null;
    const targetValue = 'item2';
    while (current) {
        if (current.value === targetValue) {
            if (previous) {
                previous.next = current.next;
            }
            // Handle head node removal separately if needed
            break;
        }
        previous = current;
        current = current.next;
    }

    function contains(list, targetValue) { //Check the Existence of Key/Value
        let current = list;
        while (current) {
            if (current.value === targetValue) {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    const hasItem2 = contains(linkedList, 'item2');

    
    

    
    






    













    





     
     












    
