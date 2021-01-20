#pragma once
#include "SimpleMath.h"
using namespace std;

class Division :
	public SimpleMath
{
public:
	//Constructor declaration.
	Division();

	//Division function declarations.
	void setNumbers(double, double);
	double cmonDoMath();

	//Destructor declaration.
	~Division();
};

