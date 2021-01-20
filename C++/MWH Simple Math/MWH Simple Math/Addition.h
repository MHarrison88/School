#pragma once
#include "SimpleMath.h"
using namespace std;

class Addition :
	public SimpleMath
{
public:
	//Constructor declaration.
	Addition();

	//Addition function declarations.
	void setNumbers(double, double);
	double cmonDoMath();

	//Destructor declaration.
	~Addition();
};

