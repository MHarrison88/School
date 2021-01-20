#pragma once
#include "SimpleMath.h"
using namespace std;

class Subtraction :
	public SimpleMath
{
public:
	//Constructor declaration.
	Subtraction();

	//Subtraction function declarations.
	void setNumbers(double, double);
	double cmonDoMath();

	//Destructor declaration.
	~Subtraction();
};

