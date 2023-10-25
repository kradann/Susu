#include <stdio.h>
#include <stdlib.h>
#include <time.h>


void printArray(int array[], const int size);

int main()
{
    const int SIZE =10;
    srand(time(NULL));

    int numbers [SIZE];
    for (int i = 0; i < SIZE; ++i)
    {
        numbers[i] = rand() % 50;
    }
    printArray(numbers, SIZE);
    //innen folytasd
    int result [SIZE];
    int oddnumbers = 0;
    for (int i = 0; i<SIZE; i++)
    {
	if((numbers[i] %2) ==1)
	{
		result[i] = numbers[i];
		oddnumbers++;
	}
	else{
		result[i] = 0;
	}
    }
    printArray(result, SIZE);
    printf("páratlan számok száma %d\n",oddnumbers);
}

void printArray(int array[], const int size)
{
    for (int i = 0; i < size; ++i)
    {
	if(array[i] != 0)
	{
        	printf("%d, ", array[i]);
	}
    }
    printf("\n");
}
