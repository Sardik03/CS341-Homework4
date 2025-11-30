// Name: Sardik Kataria 
// UIN: 667287378
//Title: CS341 Homework4
// Description: In this homework we implement three functions that compute the sum of 4x+1 for a list of integers, transpose a list of tuples, and create a list of integers within a given range.

namespace main

open homework

module Program =
   //##################################################################
   //
   // main
   //
   [<EntryPoint>]
   let main argv =
      printfn "Running test cases..."
      printfn ""

      // Test Case 1: does sum4x1TR work on a list with multiple elements?
      // Input: [3; 1; 2]
      // Expected Output: 27
      let L1 = [3; 1; 2]
      printfn "Test Case 1: does sum4x1TR work on a list with multiple elements?"
      let actualResult1 = hw04.sum4x1TR L1
      let expectedResult1 = 27
      if actualResult1 = expectedResult1 then
         printfn "Test Case 1 passed!"
         printfn "  sum4x1TR %A correctly returned: %A" L1 actualResult1
      else
         printfn "Test Case 1 failed."
         printfn "  sum4x1TR %A returned: %A" L1 actualResult1
         printfn "  The expected output is: %A" expectedResult1
      printfn ""

      // Test Case 2: sum4x1TR with empty list
      let L2 = []
      let result2 = hw04.sum4x1TR L2
      if result2 = 0 then
         printfn "Test Case 2 passed!"
         printfn "  sum4x1TR %A correctly returned: %A" L2 result2
      else
         printfn "Test Case 2 failed."
         printfn "  sum4x1TR %A returned: %A" L2 result2
         printfn "  The expected output is: %A" 0
      printfn ""

      // Test Case 3: sum4x1HO with multiple elements
      let L3 = [0; -1; 2]
      let result3 = hw04.sum4x1HO L3
      let expected3 = (4*0+1) + (4*(-1)+1) + (4*2+1)
      if result3 = expected3 then
         printfn "Test Case 3 passed!"
         printfn "  sum4x1HO %A correctly returned: %A" L3 result3
      else
         printfn "Test Case 3 failed."
         printfn "  sum4x1HO %A returned: %A" L3 result3
         printfn "  The expected output is: %A" expected3
      printfn ""

      // Test Case 4: sum4x1HO with empty list
      let L4 = []
      let result4 = hw04.sum4x1HO L4
      if result4 = 0 then
         printfn "Test Case 4 passed!"
         printfn "  sum4x1HO %A correctly returned: %A" L4 result4
      else
         printfn "Test Case 4 failed."
         printfn "  sum4x1HO %A returned: %A" L4 result4
         printfn "  The expected output is: %A" 0
      printfn ""

      // Test Case 5: transpose with two tuples
      let LT1 = [ (1, 2, 3); (11, 12, 13) ]
      let transposeResult1 = hw04.transpose LT1
      let expectedTranspose1 = [ [1; 11]; [2; 12]; [3; 13] ]
      if transposeResult1 = expectedTranspose1 then
         printfn "Test Case 5 passed!"
         printfn "  transpose %A correctly returned: %A" LT1 transposeResult1
      else
         printfn "Test Case 5 failed."
         printfn "  transpose %A returned: %A" LT1 transposeResult1
         printfn "  The expected output is: %A" expectedTranspose1
      printfn ""

      // Test Case 6: transpose empty list
      let LT2 = []
      let transposeResult2 = hw04.transpose LT2
      let expectedTranspose2 = [ []; []; [] ]
      if transposeResult2 = expectedTranspose2 then
         printfn "Test Case 6 passed!"
         printfn "  transpose %A correctly returned: %A" LT2 transposeResult2
      else
         printfn "Test Case 6 failed."
         printfn "  transpose %A returned: %A" LT2 transposeResult2
         printfn "  The expected output is: %A" expectedTranspose2
      printfn ""

      // Test Case 7: numbersInRange increasing
      let range1 = hw04.numbersInRange 1 5
      let expectedRange1 = [1; 2; 3; 4; 5]
      if range1 = expectedRange1 then
         printfn "Test Case 7 passed!"
         printfn "  numbersInRange 1 5 correctly returned: %A" range1
      else
         printfn "Test Case 7 failed."
         printfn "  numbersInRange 1 5 returned: %A" range1
         printfn "  The expected output is: %A" expectedRange1
      printfn ""

      // Test Case 8: numbersInRange decreasing
      let range2 = hw04.numbersInRange 3 -1
      let expectedRange2 = [3; 2; 1; 0; -1]
      if range2 = expectedRange2 then
         printfn "Test Case 8 passed!"
         printfn "  numbersInRange 3 -1 correctly returned: %A" range2
      else
         printfn "Test Case 8 failed."
         printfn "  numbersInRange 3 -1 returned: %A" range2
         printfn "  The expected output is: %A" expectedRange2
      printfn ""

      // Test Case 9: numbersInRange single value
      let range3 = hw04.numbersInRange 4 4
      let expectedRange3 = [4]
      if range3 = expectedRange3 then
         printfn "Test Case 9 passed!"
         printfn "  numbersInRange 4 4 correctly returned: %A" range3
      else
         printfn "Test Case 9 failed."
         printfn "  numbersInRange 4 4 returned: %A" range3
         printfn "  The expected output is: %A" expectedRange3
      printfn ""
      
      printfn ""
      printfn "Done!"
      0