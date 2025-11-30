// Name: Sardik Kataria 
// UIN: 667287378
//Title: CS341 Homework4
// Description: In this homework we implement three functions that compute the sum of 4x+1 for a list of integers, transpose a list of tuples, and create a list of integers within a given range.

namespace homework

module hw04 =
   //
   // NOTE: all types, functions in the module must be indented.
   //

   //
   // sum4x1TR L
   //
   // Given a list L of integers, computes sum(4x+1) where
   // x represents each element in L.
   // 
   // Example: sum4x1TR [3; 1; 2] => 27
   // 
   // NOTE: write a tail-recursive version using a helper function;
   // do not change the API of the original sum4x1TR function.
   //
   let sum4x1TR L =
      let rec helper remaining acc =
         match remaining with
         | [] -> acc
         | x::xs -> helper xs (acc + (4 * x + 1))
      helper L 0

   //
   // sum4x1HO L
   //
   // Given a list L of integers, computes sum(4x+1) where
   // x represents each element in L.
   // 
   // Example: sum4x1HO [3; 1; 2] => 27
   // 
   // NOTE: write this using a higher-order approach, 
   // using one or more of only the following functions: 
   //    List.map, List.iter, List.filter, List.reduce.
   //
   let sum4x1HO L =
      let transformed = List.map (fun x -> 4 * x + 1) L
      match transformed with
      | [] -> 0
      | _ -> List.reduce (fun total value -> total + value) transformed

   //
   // transpose LT
   //
   // Given a list of tuples, where each tuple consists of 3 integers,
   // transpose the list so that the "rows" and "columns" are swapped. 
   // The result will be a list of lists.
   //
   // Example:
   //   transpose [ (1, 2, 3); (11, 12, 13) ]
   //     => [ [1; 11]; [2; 12]; [3; 13] ]
   //   transpose [] => [ []; []; [] ]
   //
   // You must solve using recursion; tail recursion is not necessary.
   //
   let rec transpose LT =
      match LT with
      | [] -> [ []; []; [] ]
      | (a, b, c)::rest ->
         let columns = transpose rest
         match columns with
         | [col1; col2; col3] -> [a::col1; b::col2; c::col3]
         | _ -> failwith "Unexpected structure in transpose"

   //
   // numbersInRange num1 num2
   //
   // Create and return a list containing all integers
   // within a given range.
   // If num2 is less than num1, the list should be in
   // decreasing order.
   // 
   // Examples: numbersInRange 1 5    => [1; 2; 3; 4; 5]
   //           numbersInRange 2 -1   => [2; 1; 0; -1]
   //           numbersInRange 10 10  => [10]
   // 
   // You can solve using recursion, or higher-order, or both; 
   // tail recursion is not necessary.
   //
   let numbersInRange num1 num2 =
      let rec ascend current finish =
         if current > finish then
            []
         else
            current :: ascend (current + 1) finish

      let rec descend current finish =
         if current < finish then
            []
         else
            current :: descend (current - 1) finish

      if num1 <= num2 then
         ascend num1 num2
      else
         descend num1 num2