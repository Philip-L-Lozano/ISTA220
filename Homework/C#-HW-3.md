### Philip Lozano
### C# Homework 3
### 20 January 2021

1. A method is a named block of code that optionally... A program causes the statements to be 
executed by calling the method and specifying any required method arguments. In C#, every executed instruction 
is performed in the context of a method. The Main method is the entry point for every C# application and it is 
called by the common language runtime (CLR) when the program is started.

2. A function (expression) is a named block of code that returns a value. A subroutine (statement) takes an 
action and does not return a value.

3. The returnType is the name of a type and specifi es the kind of information the method returns
as a result of its processing. This can be any type, such as int or string. If you’re writing a method
that does not return a value, you must use the keyword void in place of the return type.

4. C# supports a simplified form for methods that comprise a single expression. There is actually no difference 
in functionality between using an ordinary method and an expression-bodied method; an expression-bodied method 
is merely a syntactic convenience but can remove uneecessary code and make code easier to read.

5. The scope of a variable is simply the region of the program in which that variable is usable. Scope applies to 
methods as well as variables. The scope of an identifier (of a variable or method) is linked to the location of the 
declaration that introduces the identifier in the program.

6. In a method, you must declare a variable before you can use it. Fields are a little different. A method can 
use a field before the statement that defines the field; the compiler sorts out the details for you.

7. Defining overloaded methods allows you to implement different versions of a method that take different 
parameters. When you build an application that uses overloaded methods, the compiler determines which specific 
instances of each method it should use to satisfy each method call. This is a common feature of many object-oriented 
languages, not just C#.

8. Write the name of the method followed by any arguments between parentheses.

9.  Write the method within a class. Specify the method name, parameter list,
and return type, followed by the body of the method between braces. 
    int addValues(int leftHandSide, int rightHandSide) { ... }

10. Provide a default value for the parameter in the method declaration.
    void optMethod(int first, double second = 0.0, string third = "Hello") { ... }

11. Specify the name of the parameter in the method call. 
    optMethod(first : 100, third : "World");
	
12. You can return a value from a method by writing a *return* statement within a method.
	return leftHandSide + rightHandSide;
	
	You can return multiple values from a method by writing a *return* statement that returns a tuple.
	return (division, remainder);
	
13. A tuple is a data structure that has a specific number and sequence of elements. 

14. Recursion is a procedure that continues to call itself.

15. The compiler runs the *optMethod* thats version most closely matches the method call's parameter version.

16. CLR = Common Language Runtime. COM = Component Object Model. 
	The CLR is what handles the conversion relationship between assembly code and machine code in C#. The CLR is
	heavily dependent on the COM which allows windows applications and services to run outside of the .NET framework.