// MWH Simple Math.cpp : Defines the entry point for the console application.
//

#pragma once
#include <iostream>
#include "stdafx.h"
#include "SimpleMath.h"
#include "Addition.h"
#include "Subtraction.h"
#include "Multiplication.h"
#include "Division.h"
using namespace std;

int main()
{
	#pragma region Object/Variable declaration

		//Objects and variables.
		SimpleMath sm;	
		Addition ad;
		Subtraction su;
		Multiplication mu;
		Division di;
		string userOp;
		SimpleMath *add = &ad;
		SimpleMath *sub = &su;
		SimpleMath *multi = &mu;
		SimpleMath *div = &di;

		string str{};
		int i{ 2 };

		//Number holding lists.
		vector<int> opList{};
		vector<int> userList{};

	#pragma endregion

	//Operator input collection.
	cout << "Enter an operator to begin: \n";
	cout << "+ for addition\n";
	cout << "- for subtraction\n";
	cout << "* for multiplication\n";
	cout << "/ for division\n";
	cout << "e to display operations and exit\n";
	cin >> userOp;
	cin.ignore();

	//Exit with "e" command.
	if (userOp == "e")
	{
		cout << "No operations were performed\n";
		system("pause");
		exit(0);
	}

	//User instructions.
	cout << "The operation '" << userOp << "' will be performed";
	cout << "\nEnter 2 numbers separated by a space. Enter anything else to display operations and exit.\n";

	//Loop for math operations.
	while (true)
	{
		//Ask for user input.
		getline(cin, str);
		istringstream ss(str);

		//Add user input to list.
		while (ss >> i)
		{
			opList.push_back(i);
			userList.push_back(i);
			if (ss.peek() == ' ') {
				ss.ignore();
			}
		}

		//If statements for operation choice.
		if (userOp == "+" && opList.size() == 2)
		{
			add->setNumbers(opList[0], opList[1]);			
			userList.push_back(add->cmonDoMath());
		}
		else if (userOp == "-" && opList.size() == 2)
		{
			sub->setNumbers(opList[0], opList[1]);			
			userList.push_back(sub->cmonDoMath());
		}
		else if (userOp == "*" && opList.size() == 2)
		{
			multi->setNumbers(opList[0], opList[1]);			
			userList.push_back(multi->cmonDoMath());
		}
		else if (userOp == "/" && opList.size() == 2)
		{
			div->setNumbers(opList[0], opList[1]);
			userList.push_back(div->cmonDoMath());
		}
		else
		{
			cout << "You have chosen to exit\n";
			int x = 0;

			//Answer display loop.
			while (userList.size() > x)
			{
				cout << userList[x] << " " << userOp << " " << userList[x + 1] << " = " << userList[x + 2] << endl;
				x = x + 3;
			}

			system("pause");
			exit(0);
		}

		//Start list over.
		opList.pop_back();
		opList.pop_back();
	}
    return 0;
}

