using System;
using StudyNotes;
namespace StudyNotes;
class Program{
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


}
}