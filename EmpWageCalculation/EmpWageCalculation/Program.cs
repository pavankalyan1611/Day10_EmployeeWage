﻿using System;
using EmpWageCalculation;

Console.WriteLine("Welcome To Employee Wage Problem:\n");
EmpWageBuilder empWageBuilder = new EmpWageBuilder();
empWageBuilder.addCompanyEmpWage("Infosys", 20, 2, 10);
empWageBuilder.addCompanyEmpWage("IBM", 10, 4, 20);
empWageBuilder.computeEmpWage();

