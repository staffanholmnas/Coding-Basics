# Exercises

## Part 1

## Printing and reading

The basic structure of the program is given in the exercises:

```cs
using System;

namespace exercise_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            
        }
    }
}
```

The line **// Add your code here:** is a comment. The composer does not compose it, so you do not have to worry about it. You can remove it, if you want.

#### Exercise_01:
* Create a program that writes the text **Hello World!** into the console. The program contains the basic structure pictured above.

#### Exercise_02:
* Let's write some more. Bonnie Tyler once sang about feelings, that also apply to coding:  
**Once upon a time**  
**I was falling in love**  
**Now I'm only falling apart**  
Create a program using 3 Console.WriteLines, that prints these lyrics.

#### Exercise_03:
* Let's refine our program. Print the same message:  
**Once upon a time**  
**I was falling in love**  
**Now I'm only falling apart**  
This time, use only one Console.WriteLine

#### Exercise_04:
* The exercise has following structure:

```cs
using System;

namespace exercise_04
{
    class Program
    {
        public static void Main(string[] args)
        {
            string message = "Passport and floss!";
            Console.WriteLine(message);
        }
    }
}
```

Change it, so that it prints **Passport and a toothbrush!**
Do not change the line containing Console.WriteLine, only change the content of the variable!



#### Exercise_05:
* You will find following structure in the exercise:
  
```cs
using System;

namespace exercise_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Ada Lovelace";
            // Write your code here:
            
        }
    }
}
```

Modify the code, so that it prints **Hello Ada LoveLace!**
Do not modify the variable content!

#### Exercise_06
* Create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line. Example output with **Hello** as input (input marked with **>** for clarification):

```console
Give input!
> Hello
Hello
```

#### Exercise_07
* Create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line 3 times. Example output with **Hello** as input:

```console
Give input!
> Hello
Hello
Hello
Hello
```

#### Exercise_08
* Create a program, that asks user for their name and greets them. Example output with **Ada** as input:

```console
What is your name?
> Ada
Hello Ada!
```
Notice the exclamation mark.

#### Exercise_09
* Create a program, that simulates a small conversation. The program will tell three lines, and expects two user inputs. Example output:

```console
Hello, how are you?
> Fine, thanks.
That's interesting, tell me more
> I learn coding
Thank you for sharing!
```

#### Exercise_10
* Create a program, that asks the user for a name and a profession. Then make the program to write a little story with this information. Here is an example story with inputs **Ada** and **Data Scientist**:

```console
I will tell a story, but I need some information.
Give a name for main character:
> Ada
Give the character a profession:
> Data Scientist
Here is the story:
Once upon a time there was a Data Scientist called Ada
On her way to work, Ada often pondered what being Data Scientist meant to them.
When you work as a Data Scientist you meet interesting people.
Ada enjoys their work as Data Scientist, The end.
```

## Variables

#### Exercise_11
* The exercise comes with a template that prints the following:

```console
Days to summer:
100
Hours to lunch:
1
Coding is fun:
Are you sure?
```

Change the values of the variables, so the program will print

```console
Days to summer:
200
Hours to lunch:
3.5
Coding is fun:
It sure is!
```

#### Exercise_12
* Create a program, that asks the user for an integer. After user input, the program will print the integer. Example prints:

```console
Give a number
> 11
You gave 11
```

```console
Give a number
> 42
You gave 42
```

#### Exercise_13
* Create a program, that asks the user for a double. After user input, the program will print the double. Example prints:

```console
Give a number
> 11.11
You gave 11.11
```

```console
Give a number
> 41.999999
You gave 41.999999
```

#### Exercise_14
* Create a program, that asks the user for a boolean. After user input, the program will print the boolean. Example prints:

```console
Give me the truth!
> tRuE
True
```

```console
Give me the truth!
> false
False
```

#### Exercise_15
* Let's combine everything you know so far. Create program that asks the user for a string, an integer, a double and a boolean, and prints them like follows:

```console
Give a string:
> This is a masterpiece!
Give an integer:
> 42
Give a double:
> 3.1415
Give a boolean:
> True
Your string: This is a masterpiece!
Your integer: 42
Your double: 3.1415
Your boolean: True
```

## Calculations

#### Exercise_16

Create a program, which asks user for amount of days, and prints the total amount of seconds for that amount of days, gives the answer and quits.

Example print:
```console
How many days?
> 2
172800
```
```console
How many days?
> 7
604800
```

#### Exercise_17

Create a program, which asks the user for two integers, and calculates their sum.  

Remember, that the input is a string, so you have to convert it to integer!

Example output:

```console
Give the first number!
> 8
Give the second number!
> 3
The sum is 11
```

```console
Give the first number!
> 3
Give the second number!
> -1
The sum is 2
```

#### Exercise_18

Expand a little on the previous exercise. Now create a program, which asks for three integers, and calculates their sum.

```console
Give the first number!
> 3
Give the second number!
> -1
Give the third number!
> 2
The sum is 4
```

#### Exercise_19

Create a program, which asks the user for two integers and counts their sum. This time, also print the equation to the user, too.

```console
Give the first number!
> 3
Give the second number!
> 1
3 + 1 = 4
```

```console
Give the first number!
> 5
Give the second number!
> -1
3 + -1 = 2
```

#### Exercise_20

Create a program, which asks the user for two integers and multiplies them with each other.

```console
Give the first number!
> 3
Give the second number!
> 2
3 * 2 = 6
```

```console
Give the first number!
> 50
Give the second number!
> -2
50  * -2 = -100
```

#### Exercise_21

Create a program, which asks the user for two **integers** and calculates their **average** as a **double**.

```console
Give the first number!
> 3
Give the second number!
> 2
The average is 2.5
```

#### Exercise_22

Create a program, which asks the user for three **integers** and calculates their **average** as a **double**.

```console
Give the first number!
> 3
Give the second number!
> 2
Give the third number!
> 1
The average is 2.0
```

