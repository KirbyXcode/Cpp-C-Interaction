#pragma once
#define _DLLExport _declspec(dllexport)

extern "C" int _DLLExport unmanaged_add(int *a, size_t length);

extern "C" int _DLLExport managed_add(int **a, size_t length);