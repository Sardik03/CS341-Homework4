# CS341-Homework4 (F#)
In this homework we implement three functions that compute the sum of 4x+1 for a list of integers, transpose a list of tuples, and create a list of integers within a given range.

# CS 341 – Homework 4 (F#)

**Author:** Sardik Kataria  
**UIN:** 667287378  
**Language:** F#  

This project contains my implementation for Homework 4 in CS 341.  
The assignment focuses on functional programming in F#, including tail recursion, higher-order functions, recursion with pattern matching, and list processing.

## 🧩 Functions Implemented

### **1. sum4x1TR (Tail-Recursive Version)**
Computes the sum of `4x + 1` for every element in a list using a tail-recursive helper function.

**Example:**  
`sum4x1TR [3; 1; 2]` → `27`

**How it works:**
- Uses a helper function with an accumulator.
- Runs through the list and keeps a running total.
- Tail-recursive and memory-efficient.

### **2. sum4x1HO (Higher-Order Version)**
Performs the same calculation as `sum4x1TR` but uses higher-order functions.

**Uses:**  
- `List.map` to turn each `x` into `4x + 1`  
- `List.reduce` to sum all mapped values  

**Example:**  
`sum4x1HO [0; -1; 2]` → `(1) + (-3) + (9) = 7`


### **3. transpose**
Takes a list of 3-tuples and transposes them into three separate lists.

**Example:**  
Input: `[ (1, 2, 3); (11, 12, 13) ]`  
Output: `[ [1; 11]; [2; 12]; [3; 13] ]`

**Empty case:**  
`transpose []` → `[ []; []; [] ]`

Uses recursion and pattern matching to build column lists.


### **4. numbersInRange**
Creates a list of integers from `num1` to `num2`.

- If `num1 <= num2` → increasing list  
- If `num1 > num2` → decreasing list  

**Examples:**  
- `numbersInRange 1 5` → `[1; 2; 3; 4; 5]`  
- `numbersInRange 3 -1` → `[3; 2; 1; 0; -1]`  
- `numbersInRange 10 10` → `[10]`

Uses two helper functions (`ascend` and `descend`) for clean logic.


## 📁 File Structure

---

## ▶️ How to Run the Program

Make sure you have **.NET SDK** installed.

1. Clone this repository or download the files.
2. Open a terminal inside the folder.
3. Run:

```bash
dotnet run
