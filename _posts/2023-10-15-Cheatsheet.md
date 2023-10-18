
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

In JavaScript, there is no built-in data structure called "List" as there is in some other programming languages like C#.

          class MyList {
            constructor() {
              this.items = [];
            }
        
          // Add an element to the list
          add(item) {
            this.items.push(item);
          }
        
          // Remove an element from the list
          remove(item) {
            const index = this.items.indexOf(item);
            if (index !== -1) {
              this.items.splice(index, 1);
            }
          }
        
          // Get an element at a specific index
          get(index) {
            return this.items[index];
          }
        
          // Set an element at a specific index
          set(index, item) {
            this.items[index] = item;
          }
        
          // Check if an element exists in the list
          exists(item) {
            return this.items.includes(item);
          }
        
          // Loop through the list with break/continue
          loopWithBreakAndContinue() {
            for (let i = 0; i < this.items.length; i++) {
              const currentItem = this.items[i];
        
              // Use break to exit the loop
              if (currentItem === "Item 2") {
                break;
              }
        
              // Use continue to skip the current iteration
              if (currentItem === "Item 3") {
                continue;
              }
        
              console.log(currentItem);
            }
          }
        }


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

     class SortedList {
         constructor() {
             this.items = [];
         }
    
      // Add an element to the sorted list while maintaining the sort order
      add(item) {
        this.items.push(item);
        this.items.sort((a, b) => a - b); // Sort the items in ascending order
      }
    
      // Remove an element from the sorted list
      remove(item) {
        const index = this.items.indexOf(item);
        if (index !== -1) {
          this.items.splice(index, 1);
        }
      }
    
      // Get an element at a specific index
      get(index) {
        return this.items[index];
      }
    
      // Set an element at a specific index 
      set(index, item) {
        this.items[index] = item;
      }
    
      // Check if an element exists in the sorted list
      exists(item) {
        return this.items.includes(item);
      }
    
      // Loop through the sorted list with break/continue
      loopWithBreakAndContinue() {
        for (let i = 0; i < this.items.length; i++) {
          const currentItem = this.items[i];
    
          // Use break to exit the loop
          if (currentItem === 3) {
            break;
          }
    
          // Use continue to skip the current iteration
          if (currentItem === 2) {
            continue;
          }
    
          console.log(currentItem);
        }
      }
    }
    


## Hashset

In JavaScript, there is no native "hashset" data structure, but you can implement similar functionality using objects or Sets

    class HashSet {
      constructor() {
        this.set = new Set();
      }
    
      // Add a value to the HashSet
      add(value) {
        this.set.add(value);
      }
    
      // Remove a value from the HashSet
      remove(value) {
        this.set.delete(value);
      }
    
      // Check if a value exists in the HashSet
      exists(value) {
        return this.set.has(value);
      }
    
      // Loop through the HashSet with break/continue
      loopWithBreakAndContinue() {
        for (const value of this.set) {
          // Use break to exit the loop
          if (value === 3) {
            break;
          }
    
          // Use continue to skip the current iteration
          if (value === 2) {
            continue;
          }
    
          console.log(value);
        }
      }
    }

## SortedSet

In JavaScript, there's no built-in "SortedSet" data structure. However, you can achieve similar functionality using Arrays and custom logic to maintain sorted order. 

    class SortedSet {
          constructor() {
            this.items = [];
          }
        
          // Add a value to the SortedSet while maintaining the sorted order
          add(value) {
            if (!this.exists(value)) {
              this.items.push(value);
              this.items.sort((a, b) => a - b); // Sort the items in ascending order
            }
          }
        
          // Remove a value from the SortedSet
          remove(value) {
            const index = this.items.indexOf(value);
            if (index !== -1) {
              this.items.splice(index, 1);
            }
          }
        
          // Check if a value exists in the SortedSet
          exists(value) {
            return this.items.includes(value);
          }
        
          // Get all values in the SortedSet
          getAll() {
            return this.items.slice(); // Return a copy to prevent direct manipulation
          }
        
          // Loop through the SortedSet with break/continue
          loopWithBreakAndContinue() {
            for (const value of this.items) {
              // Use break to exit the loop
              if (value === 3) {
                break;
              }
        
              // Use continue to skip the current iteration
              if (value === 2) {
                continue;
              }
        
              console.log(value);
            }
          }
        }

## Queue

In JavaScript, you can simulate a queue (FIFO - First-In-First-Out) using arrays.

    class Queue {
          constructor() {
            this.items = [];
          }
        
          // Add an item to the end of the queue
          enqueue(item) {
            this.items.push(item);
          }
        
          // Remove and return the item from the front of the queue
          dequeue() {
            if (!this.isEmpty()) {
              return this.items.shift();
            }
            return undefined; // Queue is empty
          }
        
          // Get the item at the front of the queue without removing it
          peek() {
            if (!this.isEmpty()) {
              return this.items[0];
            }
            return undefined; // Queue is empty
          }
        
          // Check if the queue is empty
          isEmpty() {
            return this.items.length === 0;
          }
        
          // Loop through the queue with break/continue
          loopWithBreakAndContinue() {
            for (let i = 0; i < this.items.length; i++) {
              const currentItem = this.items[i];
        
              // Use break to exit the loop
              if (currentItem === 3) {
                break;
              }
        
              // Use continue to skip the current iteration
              if (currentItem === 2) {
                continue;
              }
        
              console.log(currentItem);
            }
          }
        }
        
## Stack 

In JavaScript, you can simulate a stack (LIFO - Last-In-First-Out) using arrays.

    class Stack {
          constructor() {
            this.items = [];
          }
        
          // Push an item into the stack
          push(item) {
            this.items.push(item);
          }
        
          // Pop and return the item from the top of the stack
          pop() {
            if (!this.isEmpty()) {
              return this.items.pop();
            }
            return undefined; // Stack is empty
          }
        
          // Peek at the item on the top of the stack without removing it
          peek() {
            if (!this.isEmpty()) {
              return this.items[this.items.length - 1];
            }
            return undefined; // Stack is empty
          }
        
          // Check if the stack is empty
          isEmpty() {
            return this.items.length === 0;
          }
        
          // Loop through the stack with break/continue
          loopWithBreakAndContinue() {
            for (let i = this.items.length - 1; i >= 0; i--) {
              const currentItem = this.items[i];
        
              // Use break to exit the loop
              if (currentItem === 3) {
                break;
              }
        
              // Use continue to skip the current iteration
              if (currentItem === 2) {
                continue;
              }
        
              console.log(currentItem);
            }
          }
        }

## LinkedList

In JavaScript, there is no built-in linked list data structure like you might find in some other languages. However, you can simulate a singly linked list using objects or classes.

      class Node {
      constructor(value) {
        this.value = value;
        this.next = null;
      }
    }
    
    class LinkedList {
      constructor() {
        this.head = null;
        this.length = 0;
      }
    
      // Add a value to the end of the linked list
      add(value) {
        const newNode = new Node(value);
        if (!this.head) {
          this.head = newNode;
        } else {
          let current = this.head;
          while (current.next) {
            current = current.next;
          }
          current.next = newNode;
        }
        this.length++;
      }
    
      // Remove a value from the linked list
      remove(value) {
        if (!this.head) {
          return;
        }
    
        if (this.head.value === value) {
          this.head = this.head.next;
          this.length--;
        } else {
          let current = this.head;
          while (current.next) {
            if (current.next.value === value) {
              current.next = current.next.next;
              this.length--;
              return;
            }
            current = current.next;
          }
        }
      }
    
      // Get a value at a specific index
      get(index) {
        if (index < 0 || index >= this.length) {
          return undefined;
        }
    
        let current = this.head;
        for (let i = 0; i < index; i++) {
          current = current.next;
        }
        return current.value;
      }
    
      // Set a value at a specific index
      set(index, value) {
        if (index < 0 || index >= this.length) {
          return;
        }
    
        let current = this.head;
        for (let i = 0; i < index; i++) {
          current = current.next;
        }
        current.value = value;
      }
    
      // Check if a value exists in the linked list
      exists(value) {
        let current = this.head;
        while (current) {
          if (current.value === value) {
            return true;
          }
          current = current.next;
        }
        return false;
      }
    
      // Loop through the linked list with break/continue
      loopWithBreakAndContinue() {
        let current = this.head;
        while (current) {
          const value = current.value;
    
          // Use break to exit the loop
          if (value === 3) {
            break;
          }
    
          // Use continue to skip the current iteration
          if (value === 2) {
            current = current.next;
            continue;
          }
    
          console.log(value);
          current = current.next;
        }
      }
    }
