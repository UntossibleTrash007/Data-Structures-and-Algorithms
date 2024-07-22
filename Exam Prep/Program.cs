using System;
using StudyNotes;
namespace StudyNotes;

public class Program{
    static void Main(string[] args){

    //Finding the lowest value in an array
    int[] array = new int[10];
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(1, 100);
    }
    
    int lowest = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] < lowest){
            lowest = array[i];
        }
    }

    int highest = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] > highest){
            highest = array[i];
        }
    }
    Console.WriteLine("Here is our array:");
    for(int i = 0; i< array.Length; i++){
        Console.WriteLine(array[i]);
    }
    
    Console.WriteLine("Here is the lowest value:");
    Console.WriteLine(lowest);
    Console.WriteLine("Here is the highest value:");
    Console.WriteLine(highest);

    /*O(n) time complexity due to the for loop being a linear function*/

    Sort.QuickSort(array, 0, array.Length - 1);

    int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    Sort.BinarySearch(testArray, 3);

    //LinkedList testing

    LinkedList<int> test = new();
    LinkedList<int> test2 = new();

    //AddBack Implementation
    for(int i = 0; i <10; i++){
        Node<int> newNode = new(rnd.Next(1,50));
        test.AddBack(newNode);
    }
    Console.WriteLine("Values in test list");
    foreach(var num in test){
        Console.WriteLine(num);
    }

    //AddFront implementation
    for(int i = 0; i < 10; i++){
        Node<int> newNode = new(rnd.Next(1,50));
        test2.AddFirst(newNode);
    }
    Console.WriteLine("Values in test2:");
    foreach(var num in test2){
        Console.WriteLine(num);
    }

    Console.WriteLine("Removing the last node");
    test.RemoveLast();
    Console.WriteLine("Values in test list");
    foreach(var num in test){
        Console.WriteLine(num);
    }

    Console.WriteLine("Removing an element from the list:");
    test.Remove(test.head.Next);
    Console.WriteLine("values in the test list:");
    foreach(var num in test){
        Console.WriteLine(num);
    }


}
}