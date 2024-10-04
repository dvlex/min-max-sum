# Hacker Rank - 1 Month Preparation Kit
## Mini-Max Sum

### Introduction

This is a series of exercises included in the "1 Month Preparation Kit" within HackerRank preparation kits. I am developing these solutions inside devcontainers to solve the different challenges in various programming languages that I know, such as:
- C#
- Python
- TypeScript
- Ruby

Additionally, I will assign different difficulty levels to each challenge, starting with console applications. Once the entire series is completed, I will display the results in a web application.

### Prerequisites

To run this devcontainer, you need:
- Linux, Mac, or Windows with WSL
- Docker
- Visual Studio Code
- Git

### Usage

Open this repository in VSCode (in CLI, open the repo folder and type `code .`). Press Ctrl + Shift + P, and type "Reopen in Container" to enter the devcontainer. Once inside the devcontainer, navigate to the file `Program.cs` and run it using the play button above.

### Challenge

Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

**Example**

The minimum sum is and the maximum sum is . The function prints:

```
16 24
```

**Function Description**

Complete the `miniMaxSum` function in the editor below.

`miniMaxSum` has the following parameter(s):
- `arr`: an array of integers

**Print**

Print two space-separated integers on one line: the minimum sum and the maximum sum of four out of five elements.

**Input Format**

A single line of five space-separated integers.

**Constraints**

**Output Format**

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32-bit integer.)

**Sample Input**

```
1 2 3 4 5
```

**Sample Output**

```
10 14
```

**Explanation**

The numbers are 1, 2, 3, 4, and 5. Calculate the following sums using four of the five integers:
- Sum everything except 1, the sum is 14.
- Sum everything except 2, the sum is 13.
- Sum everything except 3, the sum is 12.
- Sum everything except 4, the sum is 11.
- Sum everything except 5, the sum is 10.

Hints: Beware of integer overflow! Use a 64-bit integer.

### Solution

Reading the challenge, I found that the first step is to sort the list. This allows summing the first four elements, which are the lowest values, and summing the last four elements, which are the highest values, to obtain both the minimum and maximum sums possible. Finally, display the two results. Initially, I used the data type `int`, but this failed some tests on the HackerRank server. I then noticed that the constraints include array elements ranging from 1 to 10^9, which means a 32-bit integer might not suffice. Therefore, I used a 64-bit integer, and this worked perfectly when submitted to HackerRank.

### Evidence

