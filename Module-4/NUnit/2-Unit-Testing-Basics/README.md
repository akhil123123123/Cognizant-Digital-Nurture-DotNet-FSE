# Unit Testing Basics

## Overview

Unit testing is the process of testing individual units of code independently. A unit may be a method, function, or class. The main goal is to ensure every unit behaves correctly.

NUnit provides attributes and assertions that make writing unit tests simple and effective.

---

## Characteristics of Good Unit Tests

A good unit test should be:

- Simple
- Independent
- Repeatable
- Fast
- Reliable

---

## What Should Be Tested?

Developers should test:

- Business logic
- Mathematical calculations
- Validation methods
- Utility functions

Avoid testing external systems such as databases or APIs directly in unit tests.

---

## Black Box Testing

In Black Box Testing, the internal implementation is ignored.

The tester only provides input and verifies the expected output.

Example:

Input:

```
5 + 10
```

Expected Output:

```
15
```

---

## Setup and TearDown

### Setup

Runs before every test.

Used to initialize objects.

### TearDown

Runs after every test.

Used to release resources.

---

## Parameterized Tests

Parameterized tests execute the same test using multiple inputs.

Advantages:

- Less duplicate code.
- Better test coverage.
- Easy maintenance.

---

## Ignoring Tests

Sometimes a test is temporarily disabled.

Reasons:

- Feature not completed.
- Known bug.
- Dependency unavailable.

---

## Writing Reliable Tests

Reliable tests should:

- Produce the same result every time.
- Not depend on databases or internet.
- Execute quickly.
- Be easy to understand.

---

## Conclusion

Unit testing increases software quality by ensuring each method behaves correctly. Writing clean and reliable tests helps developers maintain applications more efficiently.