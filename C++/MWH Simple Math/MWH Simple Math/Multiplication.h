#pragma once
#include "SimpleMath.h"
using namespace std;

class Multiplication :
	public SimpleMath
{
public:
	//Constructor declaration.
	Multiplication();

	//Multiplication function declarations.
	void setNumbers(double, double);
	double cmonDoMath();

	//Destructor declaration.
	~Multiplication();
};

