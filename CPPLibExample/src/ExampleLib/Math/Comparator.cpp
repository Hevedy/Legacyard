/*************************************************************************
ExampleLib - Source File

Copyright (C) 2013-2017 Hevedy <github.com/Hevedy>

This software is provided 'as-is', without any express or implied
warranty. In no event will the authors be held liable for any damages
arising from the use of this software.

Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:

   1. The origin of this software must not be misrepresented; you must not
   claim that you wrote the original software. If you use this software
   in a product, an acknowledgment in the product documentation would be
   appreciated but is not required.
   2. Altered source versions must be plainly marked as such, and must not be
   misrepresented as being the original software.
   3. This notice may not be removed or altered from any source
   distribution.
*************************************************************************/
/*************************************************************************
Name:         Comparator.cpp
Description:  Comparators and equals
-------------------------------------------------------------------------
History:
- 26:11:2013        : Created by Hevedy

*************************************************************************/

#include "Comparator.h"
#include <iostream>
#include <stdarg.h>

using namespace std;

/*
================
Comparators for 2 inputs
================
*/
bool Comparator::isEqual(double a, double b) { return a == b ? true : false; }
double Comparator::ComparatorMin(double a, double b) { return _return_d = a < b ? a : b; }
double Comparator::ComparatorMax(double a, double b) { return _return_d = a > b ? a : b; }

/*
================
Comparators for multiple inputs
================
*/
double Comparator::ComparatorGetSmall(const double a, ...) {


	return _return_l;
}

double Comparator::ComparatorGetBig(const double a, ...) {


	return _return_l;
}