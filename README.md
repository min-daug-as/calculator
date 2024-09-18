### Assignment Tasks for Tokenizer and Parser

| Task                                  | Complexity | Time Estimate | What We Are Looking For                                              |
|---------------------------------------|------------|---------------|----------------------------------------------------------------------|
| **Implement Multiplication Support (`*`)** | Low        | 15-20 mins     | Tokenization and correct parsing of multiplication operations. Ensure precedence is respected in expressions like `3 * 5 + 2`. |
| **Implement Subtraction Support (`-`)**   | Low        | 15-20 mins     | Tokenization and correct parsing of subtraction, ensuring it works in expressions like `5 - 3`. Handling of negative numbers (`-5 + 3`) is expected. |
| **Implement Division Support (`/`)**      | Low        | 15-20 mins     | Proper tokenization and parsing of division (`/`). Ensure correct division behavior in expressions like `6 / 2`. |
| **Implement Floating-Point Number Support** | Medium     | 30-45 mins     | Support tokenization and parsing of floating-point numbers (e.g., `3.14 + 2.5`). Ensure precision in arithmetic operations. |
| **Handle Whitespace Between Tokens**      | Low        | 15-20 mins     | Ensure that the parser works correctly regardless of spacing between tokens (`3 + 2` vs `3+2`). |
| **Support Parentheses (`(` and `)`)**     | High     | 30-60 mins     | Tokenization and correct parsing of expressions with parentheses, respecting operator precedence (`2 * (3 + 5)`). |
| **Implement Variable/Identifier Support** | High       | 60-90 mins     | Tokenization and parsing of variables (e.g., `x`, `y`) and their usage in expressions like `x + 5`. Should support assignment or evaluation of variables. |
| **Handle Invalid Character Exceptions**   | Medium     | 20-30 mins     | Ensure both the lexer and parser throw appropriate exceptions for invalid input (e.g., `5 + % 3`), showing proper error handling. |
| **Handle Negative Numbers**               | Low     | 15-20 mins     | Ensure that negative numbers are correctly parsed in expressions like `-5 + 3`, and not confused with subtraction. |
| **Support Comments (Single Line: `//`)**  | Medium       | 30-45 mins     | Ignore single-line comments while tokenizing and parsing (e.g., `5 + 3 // comment`). |
| **Handle Operator Precedence**            | High       | 45-60 mins     | Implement proper operator precedence in the parser (e.g., `3 + 5 * 2` should evaluate as `3 + (5 * 2)`). Requires understanding of precedence and associativity. |
| **Support Consecutive Operators**          | Medium     | 30-45 mins     | Ensure consecutive operators like `++`, `--` are handled appropriately or flagged as errors. |
| **Support Complex Expressions**           | High       | 45-60 mins    | Ability to parse and evaluate complex expressions with a combination of variables, parentheses, and different operators (`(a + 5) * (3 - b / 2)`). |
| **Improve Parser Efficiency**             | High       | 45-60 mins     | Optimize the parser for better performance, especially with long expressions. Focus on handling recursive or large arithmetic expressions efficiently. |

### Parser-Specific Tasks

1. **Handle Operator Precedence:** Since the provided parser only handles addition, the new tasks must focus on correctly implementing operator precedence (e.g., multiplication/division vs. addition/subtraction).
   
2. **Support Parentheses:** The parser needs to be updated to handle parentheses, allowing for correct evaluation of grouped expressions.

3. **Implement Variable/Identifier Support:** Tokenizing variables isn’t enough; the parser needs to be able to substitute or evaluate variables in expressions.

4. **Support Complex Expressions:** Involves more advanced parsing techniques, such as recursive descent or using a stack to handle operator precedence and parentheses.

5. **Improve Error Handling:** Ensure the parser throws clear exceptions when it encounters an invalid token or syntax error in the input.

### What to Look for in Candidate Submissions
- **Correct Parsing:** The candidate should demonstrate the ability to extend the parser to handle multiple arithmetic operations and ensure correct evaluation order.
- **Handling Operator Precedence:** Key to this task is ensuring the correct order of operations (PEMDAS/BODMAS), especially when handling complex expressions.
- **Testing with Complex Input:** Submissions should include test cases for various complex expressions with mixed operators, parentheses, and variables.
- **Error Handling:** Candidates should handle invalid inputs gracefully, raising appropriate exceptions when malformed expressions are encountered.
