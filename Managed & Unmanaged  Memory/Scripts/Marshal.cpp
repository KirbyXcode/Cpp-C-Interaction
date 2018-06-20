#include "Marshal.h"

int unmanaged_add(int *a, size_t length)
{
	for (size_t i = 0; i < length; i++)
	{
		a[i] = a[i] * 2;
	}

	return 20;
	//delete[] a;
	//a = NULL;
}

int managed_add(int **a, size_t length)
{
	*a = new int[length];

	return 2;
}
