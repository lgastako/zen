# zen

Zen is my programming language.  My goal is to inbue it with as much goodness
from as many other programing languages (and my brain) as possible (while
learning from their mistakes and sanding off their respective rough edges
wherever possible).

This README is the beginning of my README-driven develop of the language.  As
of this initial writing (Thanksgiving 2015) none of this actually exists.

## Goals

I am trying to implement a language that...
- is as clean and easy to read/maintain as python, elixir, coffeescript, etc.
- has the benefits of strong static typing ala Haskell

Zen:
- is functional (specifically based on the lambda calculus)
- is statically typed
- steals Clojure's numbers
- has no "nil" / "null" (except maybe in JAVA/CLJ interop, how to limit it to that?)
- has powerful (and easy!) concurrency primitives
- has python-like slicing
- has runtime assertions that can be compiled out
- has a powerful and consistent standard library
- eschews (or hides) esoteric PLT BS

Goals:
- Great thorough documentation with great examples
- Amazing unicode support

## Introduction

At it's core Zen consists of an implementation of the lambda calculus
affectionately called "Z".

Zen comprises a set of additions to Z and associated tooling designed to make
programming in it not just managable but fun and productive.

## Z

Any discussion of the lambda calculus worth it's salt begins with the identity
function.

### The Identity Function

The identity function in Z looks like this:

    λ x . x

As we all know, the identity function returns it's argument unchanged.  All
functions in Z are anonymous.  (Don't worry, Zen adds named functions).

Function application is accomplished by adjacency (with appropriate
disamibiguating parens:

For example, to invoke the identity function above on itself, one would write:

    (λ x . x)(λ x . x)

As Z is intended to be a minimal implementation of the lambda calculus it does
not contain such niceties as numbers.

As mandated by the PLT Overseers, we will now commence a discussion of how to
implemenet integers via Church Numerals.  But don't worry, Zen adds a powerful
numeric tower on top of Z.

### Church Numerals

In the following, `s` stands for successor and `z` stands for zero.

0 = λ s . λ  z . z       # the function s applied to the argument z zero times
1 = λ s . λ z . s z      # the function s applied once
2 = λ s . λ z . s (s z)  # the function s applied twice

Given this encoding we can define an "inc" function which adds 1 to it's
argument like so:

    λ n . λ s . λ z . s (n s z)

And an add function like so:

    λ a . λ b . λ s . λ z . a s (b s z)

### Zen

Like the lambda calculus, functions in Z always take exactly one argument, like
all of the functions discussed in the Z section.

Zen adds

Consider the following "add" functions in various languages:

```javascript
function(a, b) {
    return a + b;
}
```
```java
static int add(Integer a, Integer b) {
    return a + b;
}
```
```python
def add(a, b):
    return a + b
```
```clojure
(fn [a b] (+ a b))
```
```haskell
add a b = a + b
```

This would be the (approximately) equivalent "add" function in Z:

    λ a . λ b . + a b

All of these Z expressions define (approximately) equivalent "add" functions:

    λ a . λ b . + a b

    λ a . λ b . a + b

    λ a b . a + b

Here we see our first hint that everything is not what it seems.  The lambda
calculus does not define a math notation like `a + b`.


This expression defines a function which takes an argument `a` and returns a
function that takes an argument `b` and adds the two numbers together.

In order to understand what's going on here you need to know that everything is
a function in Zen.  Specifically, numbers are functions.
