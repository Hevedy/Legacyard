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
Name:         Transform.cpp
Description:  Transforms, inverts...
-------------------------------------------------------------------------
History:
- 27:11:2013        : Created by Hevedy

*************************************************************************/

#include "Transform.h"
#include <sstream>
#include <iostream>
#include <stdarg.h>
#include <algorithm>

using namespace std;

/*
================
Basics transforms
================
*/
Transform::Transform() {
	_return_d = 0.0;
	_return_l = 0;
	_return_s = "";
	_osstring << 0;
}

int Transform::Invert(int a) {
	int sign, inv;
	inv = 0;
	sign = a>0?1:-1;
	a = a * sign;

	while (a > 0) {
		inv = inv * 10 + (a%10);
		a = a / 10;
	}

	return inv * sign;
}

string Transform::Invert(string a) { return string (a.rbegin(), a.rend()); }

int Transform::Center(int a, int b) { return a - b; }
double Transform::Center(double a, double b) { return a - b; }

int Transform::getSize(string a) { return a.size(); }
int Transform::getSize(int a) { _osstring << a; _return_s = _osstring.str(); return _return_s.size() - 1; }
int Transform::getSize(double a) { _osstring << a; _return_s = _osstring.str(); return _return_s.size() - 1; }
