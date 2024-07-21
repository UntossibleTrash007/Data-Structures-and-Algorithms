namespace StudyNotes;

class Sort{
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

/* Quick Sort
1. Choose a value in the array to be the pivot element
2. Order the rest of the array so that the lower values than the pivot element are on the left, and higher
values are on the right.
3. Swap the pivot element with the first element of the higher values so that the pivot element lands 
inbetwen the lower and higher values
4. do the same operations recursively for the sub arrays on the left and right side of the pivot element.
*/
public static void QuickSort(int[] array, int low, int high){
    //check to make sure the low and high values are as such
    if(low<high){
        //call the partition method to divide array and get pivot point
        int pivot = Partition(array, low, high);
        QuickSort(array, low, pivot -1);
        QuickSort(array, pivot +1, high);
    }
} 


public static int Partition(int[] array, int low, int high){
    //set pivot equal to the highest value
    int pivot = array[high];
    int i = low -1;

    //Split the array in two. Loop that checks if the current value is lower than the pivot and swaps them. 
    //Lower values, so gets put to the left
    for(int j = low; j < high; j++){
        if(array[j] <= pivot){
            i++;
            int placehold = array[i];
            array[i] = array[j];
            array[j] = placehold;
        }
    }

    //Check the other half of the split array and swaps around the pivot point. Returns the pivot point
    int temp = array[i+1];
    array[i+1] = array[high];
    array[high] = temp;
    return i+1;

}

//I believe this one is pretty self explanitory...
public static void LinearSearch(int[]array, int val){
    //Loop that compares each element of the array to the value that we want to find
    for(int i = 0; i < array.Length; i++){
        //If the value is found, say so
        if(array[i] == val){
            Console.WriteLine("Found!");
            return;
        }
    }
    //if the value is not found, say so
    Console.WriteLine("Element does not exist in this list");


    //this method can also be made a simple public bool but I just went autopilot and did a static void instead kekw
}

/*Binary Search
1. Check the value in the center of the array
2. If the target value is lower search the left half of the array. if the target is higher, search the right
3. Continue step 1 and two for the new reduced part of the array until the target value is found
***ONLY WORKS WITH PRESORTED ARRAYS!!!***
*/
public static void BinarySearch(int[] array, int val){
    int left = 0;
    int right = array.Length -1;

    while(left < right){
        int mid = (left + right)/2;
        if(array[mid] == val){
            Console.WriteLine("Found!");
            return;
        } else if(array[mid] < val){
            left = mid+1;
        } else if(array[mid] > val){
            right = mid-1;
        }
    }

    Console.WriteLine("Element does not exist in the array.");
    
}

}