#pragma once
#include "stdafx.h"
#include "Multiplication.h"

//Constructor definition.
Multiplication::Multiplication()
{
}

//Multiplication set function.
void Multiplication::setNumbers(double num1, double num2)
{
	answer = num1 * num2;
}

//Addition get function.
double Multiplication::cmonDoMath()
{
	return answer;
}

//Destructor definition.
Multiplication::~Multiplication()
{
}
