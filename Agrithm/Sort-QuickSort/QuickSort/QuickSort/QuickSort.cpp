// QuickSort.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "stdlib.h"
#define NUM 10
#define LOG_ENABLE 1

void quickSort(int* arr, int start, int end)
{
	if (arr == NULL)
		return;

	if (start >= end)
		return;

	int i = start, j = end;
	int key = arr[start];

	while (i < j)
	{
		while (i < j && key <= arr[j])
			j--;
		arr[i] = arr[j];

		if (LOG_ENABLE)
		{
			for (int index = 0; index < NUM; index++)
				printf("%d ", arr[index]);
			printf("key %d  i %d j %d\n", key, i, j);
		}

		while (i < j && key >= arr[i])
			i++;
		arr[j] = arr[i];

		if (LOG_ENABLE)
		{
			for (int index = 0; index < NUM; index++)
				printf("%d ", arr[index]);
			printf("key %d  i %d j %d\n", key, i, j);
		}
	}

	arr[i] = key;

	if (LOG_ENABLE)
	{
		for (int index = 0; index < NUM; index++)
			printf("%d ", arr[index]);
		printf("key %d  i %d j %d\n", key, i, j);
	}
	
	quickSort(arr, start, i-1);
	quickSort(arr, i+1, end);
}

int _tmain(int argc, _TCHAR* argv[])
{
	int array[NUM] = {346, 978, 9, 43, 456, 987, 978, 345, 1, 34};
	//int array[NUM] = { 10, 9, 8, 7, 6, 5, 4, 3, 1, 2 };

	printf("Please input %d integers\n", NUM);

	//for (int index = 0; index < NUM; index++){
	//	printf("%d", index);
	//	scanf_s("%d", &array[index]);
	//}
		
	quickSort(array, 0, NUM-1);
	
	for (int index = 0; index < NUM; index++){
		printf("%d ", array[index]);
	}

	system("PAUSE");
	
	return 0;
}

