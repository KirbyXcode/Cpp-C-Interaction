#pragma once

#define _DLLExport _declspec(dllexport)

//class InteractionTest
//{
//public:
//	static extern "C" int _DLLExport Add(int a, int b);
//
////public:
////	int Add(int a, int b);
//	//extern "C" int _DLLExport Add(int a, int b);
//};

extern "C" int _DLLExport Add(int a, int b);

