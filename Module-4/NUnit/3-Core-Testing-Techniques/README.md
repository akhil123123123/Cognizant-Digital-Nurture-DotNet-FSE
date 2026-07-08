# Core Testing Techniques

## Overview

NUnit supports various testing techniques that help verify different parts of an application. Developers can test strings, arrays, collections, return values, exceptions, and much more.

---

## Testing Strings

String operations such as comparison, concatenation, and validation can be tested easily.

Example scenarios:

- Compare two strings.
- Check string length.
- Verify substring.

---

## Testing Arrays and Collections

Applications frequently use arrays and collections.

Unit tests verify:

- Number of elements.
- Correct order.
- Presence of values.
- Empty collections.

---

## Testing Return Values

Methods returning values should always be verified.

Examples:

- Integer
- Boolean
- String
- Object

The returned value should match the expected result.

---

## Testing Void Methods

Void methods do not return any value.

Instead of checking output, developers verify whether the method successfully performs its intended operation.

---

## Testing Exceptions

Applications should correctly handle invalid inputs.

NUnit allows developers to verify whether a method throws the expected exception.

Common exceptions:

- ArgumentException
- NullReferenceException
- DivideByZeroException

---

## Code Coverage

Code Coverage measures how much application code is executed during testing.

Higher code coverage generally indicates better testing, although quality of tests is more important than percentage alone.

Benefits:

- Finds untested code.
- Improves software reliability.
- Reduces production bugs.

---

## Best Practices

- Write independent tests.
- Use meaningful test names.
- Keep tests simple.
- Test one scenario per test.
- Avoid duplicate code.

---

## Conclusion

Core testing techniques help developers build stable, reliable, and maintainable applications. NUnit provides powerful features that simplify writing effective unit tests.