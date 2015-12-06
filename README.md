# zen

README driven development:

Zen starts with the lambda calculus.

The identity function:

    λ x . x

Apply it to itself:

    (λ x . x)(λ x . x)

Church Numerals, Peano arithmetic, etc.

Add auto-currying and `let` and Clojure numbers:

    let add = λ a b . + a b
        inc = λ n . + 1 n
        dub = λ n . * 2 n
    in add (dub 3) (inc 2)      # returns 9

To expose something at the module level:

    fib = λ n . case n
      0 1
      1 1
      n (+ (fib (- n 1)))

This demonstrates the usage of the case statement.  Module level bindings
behave as if "declared" in Clojure -- meaning an function can recurse by
calling itself.

The case statment ends either based on indentation (as in the definition of
`fib` above) or when encountering the end of the line, like so:

    zero? = λ n. case n 0 true _ false

You can declare functions using the shorter form demonstrated in this
definition of `non-zero?` which is equivalent in spirit to the definition of
`zero?` above.

    λnon-zero? n. case n 0 false _ true

Behind the scenes everything is statically typed.

Defining the entry point to a command line app is done by binding `main` at the
module level to an IO action which takes an argument list (of strings) and
returns a byte.

    let Δusage = "Usage:
      main n        Show fibonacci number <n>.
      main a b      Add <a> and <b>
      main r g b    Show the color <r,g,b>
    "
        begin-color = ...
        end-color = ...
        Δshow-color (r,g,b) = print (str (color-on r g b)
                                         (color-off)
    in λmain args. case (count args)
      1 print (fib (to-int (first args)))
      2 print (add (to-int (first args))
                   (to-int (second args)))
      3 show-color (map to-int args)
      _ usage

NB. When the idented form of the case statement is used (as in `Δmain` above)
it is assumed that there is one case clause per line so the outermost set of
parentheses around the case body can be dropped.  When the inline form is used
the extra paranetheses must be used.

The delta symbol signifies an IO action and this is the abbreviated form
similar to `λadd` etc.  The long form of the above main would be:

      ...
    in main = λ args. case (count args)
      ...

While functions must take at least one argument (zero argument functions reduce
to constants), IO actions can take zero or more.

The `show-color` action shows destructuring.

Add Clojure keyword and all of Clojure's persistent data structures with
identical syntax (EDN) including first class support for `#queue []` syntax
from ClojureScript.

     let defaults = {:a 1 :b "string" :c "Copyright 2077. Whoever"}
     in → defaults
          dissoc :a :b
          assoc :name "John"

     # {:name "John" :c "Copyright 2077. Whoever"}

The above demonstrates the "thread-first" (→) macro.  Here is "thread-last" (⇒):

     ⇒ ["john" "jacob" "jingleheimer-schmidt"]
       filter (λ s . < (count s) 10)
       map upper-case
       reverse

     # ["JACOB" "JOHN"]

## References:

- http://plato.stanford.edu/entries/lambda-calculus/
- https://medium.com/@ayanonagon/the-y-combinator-no-not-that-one-7268d8d9c46#.9slkh6jwz
- https://en.wikipedia.org/wiki/Lambda_calculus#Logic_and_predicates
