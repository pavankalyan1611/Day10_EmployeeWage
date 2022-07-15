using System;
using EmpWageCalculation;

Console.WriteLine("Welcome To Employee Wage Problem:\n");
// creating Objects
EmpWages dmart = new EmpWages("Dmart", 20, 20, 100);
Console.WriteLine(dmart.ComputeEmpWage());

EmpWages reliance = new EmpWages("Reliance", 10, 20, 110);
Console.WriteLine(reliance.ComputeEmpWage());

