// Switch the places of the maximum and minimum elements in an array
//
// PseudoCode
// 1. Start
// 2. Initialize max and min values
// 3. Loop through the array to find the maximum and minimum elements
// 4. Swap the elements at the maximum and minimum indices
// 5. End

int[] array = [7, 53, 3, 44, 753, 2, 92, 302];

int max = int.MinValue;
int min = int.MaxValue;
int maxIndex = 0;
int minIndex = 0;

for (var i = 0; i < array.Length; i++)
{
    var num = array[i];
    if (num > max)
    {
        max = num;
        maxIndex = i;
    }
    if (num < min) {
        min = num;
        minIndex = i;
    }
}

int temp = array[maxIndex];
array[maxIndex] = array[minIndex];
array[minIndex] = temp;

foreach (var num in array) {
    Console.WriteLine(num);
}
