#pragma once
#include "stdafx.h"
#include "Subtraction.h"

//Constructor definition.
Subtraction::Subtraction()
{
}

//Subtraction set function.
void Subtraction::setNumbers(double num1, double num2)
{
	answer = num1 - num2;
}

//Subtraction get function.
double Subtraction::cmonDoMath()
{
	return answer;
}

//Destructor definition.
Subtraction::~Subtraction()
{
}
