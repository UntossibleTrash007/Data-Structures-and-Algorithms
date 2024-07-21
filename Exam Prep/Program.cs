using System;

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
    Console.WriteLine("Here is our array:");
    for(int i = 0; i< array.Length; i++){
        Console.WriteLine(array[i]);
    }
    
    Console.WriteLine("Here is the lowest value:");
    Console.WriteLine(lowest);

    /*O(n) time complexity due to the for loop being a linear function*/

    InsertionSort(array);
}


public static void BubbleSort(int[] array){
    /*
    Bubble Sort                                          
    Notes: for bubble sort, don't forget to add a second for loop in the sort algorithm
    the first loop determines how many times the second loop has to run, the second loop must go through 
    one less value every time it runs
    */

    for(int i = 0; i < array.Length - 1; i++){
        for(int j = 0; j < array.Length - i - 1; j++){
            if(array[j] > array[j+1]){
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }


    Console.WriteLine("Buble Sorted Array:");
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }

    /*Hypothesis: Bubble sort will have a time complexity of O(n^2) because if the two for loops.
      It's parabolic*/

}

public static void SelectionSort(int[] array){
    /*
        Selection Sort
        1. Go through the array to find the lowest value
        2. Move the lowest value to the front of the unsorted part of the array
        3. Go through the array as many times as there are values in the array
    
    */

    //Loop that denotes how many times the array gets traversed
    for(int i = 0; i < array.Length -1; i++){
        int min = i;
        //loop that finds the smallest value in the array
        for(int j = i+1; j < array.Length; j++){
            if(array[j] < array[min]){
                min = j;
            }
        }
        //mimimum array value
        int minVal = array[min];
        //Loop that updates the values of the unsorted portion of the array
        for(int k = min; k>i; k--){
            array[k] = array[k-1];
        }
        //Swap the minimum value to the front of the unsorted portion of the array
        array[i] = minVal;
        

    }

    Console.WriteLine("The sorted array:");
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }
}

public static void InsertionSort(int[] array){
    /*Insertion Sort
    1. Take the first value from the unsorted part of the array
    2. Move the value into the correct place in the sorted part of the array
    3. go through the unsorted part of the array again as many times as there are values.
    */

    //Loop denoting how many times the array gets itterated through
    for(int i = 0; i < array.Length; i++){
        //insertIndex denotes the index of the value we are currently looking at
        //current denotes the value we are currently looking at
        //j denotes the previous element in the array that we compare current to to determine a swap
        int insertIndex = i;
        int current = array[i];
        int j = i-1;

        //The loop that checks the unsorted portion of the array to determine which values get switched
        while(j >=0 && array[j] > current){
            array[j+1] = array[j];
            insertIndex = j;
            j--;
        }

        //Swap the elements
        array[insertIndex] = current;
    }

    Console.WriteLine("the sorted array:");
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }

}

}

