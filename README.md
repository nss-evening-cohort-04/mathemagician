# Mathmagician

Student will use Principles of Object Oriented Programming to implement a program that prints out a list of numbers.

## Setup

1. Create a new Visual Studio console solution named *MathMagician*.
1. Create a matching project in your solution for unit tests (i.e. *MathMagicianTests*).

## Instructions

### Acceptance Criteria

1. Console app that prints out lists of numbers
2. Accepts a one word command.
3. Prints out a list of numbers specified by the command given.

### Commands (Case insensitive )

1. Integers
2. Primes
3. Fibonacci
4. Even
5. Odd

## Desired Workflow

```shell
What would you like for me to do?
```

User enters a command, then presses enter.

```shell
How many should I print?
```

User enters how many numbers should be printed.

```shell
Cool, I'm going to print [some amount] [some command] numbers.
```
Then prints the the requested list of numbers space separated on the following line.

If an unknown command is entered, then the Mathmagician will say, "Whoops!".
If the user requests your program to print more than 30 numbers, then your program will say, "Enter a number less than 30" then exit.

### Step 0

With your instructor, implement part of the "Desired Workflow" in your `Program.cs`.

### Step 1

In your implementation project, you will create the following classes:

- NaturalNumber (Should implement the `Integer` interface)
- EvenNumber
- OddNumber
- FibonacciNumber
- PrimeNumber (Extra Credit)

### Step 2

In your UnitTest project, create the following UnitTest classes:

- NaturalNumberTests
- EvenNumberTests
- OddNumberTests
- FibonacciNumberTests
- PrimeNumberTests (Extra Credit)

### Step 3 & 4

Pick one class to start:

1. Inherit from another Number class that makes sense, applying the correct privilege level.
2. Add the `virtual` keyword on the parent class method. (determine if it applies)
3. Use the `override` keyword on the child class method. (determine if it applies)
4. For each required method in the `*Number` class you chose, you are required to write a Unit Test proving your implementation works. Do not write any implementation code until you have a unit test that fails for the method you are working on.
5. Now you'll write the implementation code for your method. After each attempt, re-run your tests.
6. Rinse & Repeat


### Step 5

After implementing your first class, hook it up to your `Program.cs`
