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
Name:         Random.cpp
Description:  Random generator
-------------------------------------------------------------------------
History:
- 26:11:2013        : Created by Hevedy

*************************************************************************/

#include "Random.h"
#include <iostream>
#include <stdarg.h>
#include<cstdlib>
#include<ctime>

using namespace std;

/*
================
Basics random generators
================
*/
Random::Random() {
	_return_i = 0;
	_return_d = 0.0;
	_return_l = 0;
	_return_s = "";
}

int Random::RandomBasic() {
	srand(time(NULL));
	_return_i = rand();

	return _return_i;
}

int Random::RandomBasic(int a) {
	srand(time(NULL));
	_return_i = rand() % a;

	return _return_i;
}

int Random::RandomZone(int a, int b) {
	srand(time(NULL));
	_return_i = rand() % ((a + 1) - b) + b;

	return _return_i;
}