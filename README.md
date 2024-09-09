# fibonacci-sequence
The Fibonacci sequence is a series of numbers where each number is the sum of the next two numbers starting with 0 and 1. 

## Difference Between Loop and Recursion Models

- **Loop (Iterative)**:
  - Uses a loop to calculate each Fibonacci number up to the desired position.
  - Is more memory-efficient and faster for larger `n` due to avoiding the overhead of function calls.

- **Recursion**:
  - Uses function calls to calculate each Fibonacci number.
  - The number of function calls grows, going to higher memory usage and slower performance for larger `n`.


  ## Big O Notation

- **Iterative (Loop)**: The time complexity is \( O(n) \). Each Fibonacci number is computed in a single loop iteration, resulting in linear time complexity. The space complexity is \( O(1) \) because only a constant amount of extra space is used.

- **Recursive**: The time complexity is \( O(2^n) \). Each function call generates two additional calls, leading to an exponential growth in the number of calls. The space complexity is \( O(n) \) due to the call stack used for recursion.

