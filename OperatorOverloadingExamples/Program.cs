

//Operator Overloading 

//This is done with the overload keyword followed by the operator being defined; operator+
//Similar to any method, an overloaded operator has a return type and a parameter list.

using OperatorOverloadingExamples;

Box b1 = new Box(14, 3);
Box b2 = new Box(5, 7);
Box b3 = b1 + b2;

Console.WriteLine($" The height of Box 3 is: {b3.Height}");
Console.WriteLine($"The width of Box 3 is: { b3.Width}");