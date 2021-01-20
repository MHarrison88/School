#pragma once
#include <iostream>
#include <sstream>
#include <fstream>
#include <istream>
#include <string>
#include <vector>
#include <cinttypes>
using std::string;

class SimpleMath
{
	//Inherited answers variable.
	protected:
		double answer{};

	public:

		//Construtor declaration.
		SimpleMath();

		//Base virtualmath function declaration.
		virtual void setNumbers(double, double);
		virtual double cmonDoMath();

		//Destructor declaration
		~SimpleMath();
};

