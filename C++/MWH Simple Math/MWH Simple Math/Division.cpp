#pragma once
#include "stdafx.h"
#include "Division.h"

//Constructor definition.
Division::Division()
{
}



//Multiplication set function.
void Division::setNumbers(double num1, double num2)
{
	if (num2 != 0)
	{
		answer = num1 / num2;
	}
	else
	{
		//Error catch.
		cout << "Don't divide by 0! Continue entries...\n";
		 answer = 0;
	}
}

//Addition get function.
double Division::cmonDoMath()
{
	return answer;
}

//Destructor definition.
Division::~Division()
{
}
