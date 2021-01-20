#pragma once
#include "stdafx.h"
#include "Addition.h"

//Constructor definition.
Addition::Addition()
{
}

//Addition set function.
void Addition::setNumbers(double num1, double num2)
{
	answer = num1 + num2;
}

//Addition get function.
double Addition::cmonDoMath()
{
	return answer;
}

//Destructor definition.
Addition::~Addition()
{
}

