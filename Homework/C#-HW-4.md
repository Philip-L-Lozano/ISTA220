### Philip Lozano
### C# Homework 4
### 21 January 2021

1. There are only 2 possible value of a boolean expression: *True* or *False*.

2a. Equality operators: 
	1. == equal to 
	2. != not equal to
	
2b. Relational operators:
	1. <  less than
	2. <= less than or equal to
	3. >  greater than
	4. >= greater than or equal to
	
2c. Logical Operators:
	1. && and 
	2. || or
	
2d. All of these operators yield Boolean results however, equality operators checksum values, ralational 
operators compare values, and logical operators compare two values that are already Boolean themselves.

3. *Short Circuiting* is the act of the Boolean operators bypassing operands that do not need to be evaluated to
reach the correct result. 

4. If the left operand of the && operator evaluates to false, the result of the entire expression must be false,
regardless of the value of the right operand. Similarly, if the value of the left operand of the || operator 
evaluates to true, the result of the entire expression must be true, irrespective of the value of the right operand.

5. () has the highest precedence. = has the lowest.

6. Without curly braces in an *if-else* construction, a Boolean will only associate a single line of code 
with the *if* statement. Curly braces should always be used even with single lines as a habit and best practice.

7. Omitting *break* in a switch statement allows for the potential for fall through between multiple switch statements.

8. *switch* - is a selection statement that chooses a single switch section to execute from a list of candidates based 
	on a pattern match. The *switch* statement  is often used as an alternative to an if-else construct if a single 
	expression is tested against three or more conditions.
	
	*case* - a label in a switch that specifies a pattern to compare to the match expression.
	
	*break* - prevents fall through between multiple *switch* statements.
	
	*default* - Control in a *switch* statement is transfered to the section with the *default* 
	case label if no case label pattern matches the match expression.
	
9.  recurr1() - is an assignment to an int.
	recurr2() - 
	
10. if (a+b+c+d+e) > 100 then 

11a. if (notA or notB) then (notAB)
11b. if (notAB) then (not A or NotB)