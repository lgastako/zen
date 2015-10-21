Function syntax from CoffeeScript:
	add = (a, b) -> a + b

Value of function is value of last expression in function body, ala ruby, Coffee, etc.
	three = () ->
		1
		2
		3

Semicolons to stack statements on a line, the last example can be rewritten as:

	three = () -> 1; 2; 3

Of course both should be optimized by the compiler down to:

	three = 3

Function application is left to right ala haskell:

	f g h x    // is equivalent to  f (g (h x))

As you may have noticed, we use shell style comments. # everything after the pound is ignored

Every statement returns a value, including e.g. "if":

	s = if len(a) > len(b) then a else b

Classes are simple:

	class Person
		first:Str
		last:Str
		full = -> first + " " + last

All parameters to functions (and methods etc) are named, so for example, you could do
something like:

	sayHappyBirthday = (name="Dave", age=21)  # -> puts "Hello #{name}, congratulations on turning #{age}!"

	sayHappyBirthday                          # -> "Hello Dave, congratulations on turning 21"
	sayHappyBirthday age=36                   # -> "Hello Dave, congratulations on turning 36"
	sayHappyBirthday name="Bob"               # -> "Hello Bob, congratulations on turning 21"
	sayHappyBirthday name="Bob" age=63        # -> "Hello Bob, congratulations on turning 63"
	sayHappyBirthday age=36 name="John"       # -> "Hello John, congratulations on turning 36"


[TODO: Discuss constructors, default constructors, merged constructors]

Construction occurs via the new keyword:

	person = new Person

Instance and class methods use python-like self and cls parameter names but the
parameter names themselves are meaningful:

	class Foo
		req n:Int
		add = (a, b) -> a + b
		addN = (self, a) -> a + self.n
		addCls = (cls, a) -> a + a  # cls ignored, lame example. TODO fix

String interpolation ala CoffeeScript, etc.

	val name = "John"
	puts "Hello, #{name}!"

Also % formatting ala python:

	puts "Hello, %s!" % name

No nulls!  There is no null or bottom in the language.  There is Maybe which is
added on top via the stdlib:

	class Person
		first:Str
		dob:Maybe of Date

		_calcAge = (date) -> date.asUTC / 1000 / 60 / 60 / 24 / 365
		age = ():Maybe of Int -> dob.map(_calcAge)

Everything is objects, like Java, Ruby, etc. but better.
Everything is in a Kernel namespace object like ruby:

	sayHello = (name) -> puts "Hello #{name}!"
	Kernel.sayHello "John"  # -> "Hello John!"

Type inference.  The sayHello function defined above is actually fully specified like so:

	sayHello = (name:Str):unit -> puts "Hello #{name}!"

which says that it is a function taking a single parameter named "name" which is of type "Str"
and returns type "unit".  All of these are inferred in the earlier annotation-less version.

Actually, this isn't true.  Since the only use of name is in the string interpolation and that
could be any object, it actually gets the type:

	sayHello = (name:Obj):unit

The compiler is able to tell that the return type is unit because the last statement in
the function is the call to puts which returns type unit.  It can't tell that name is a
string though because it's never used in a way that constrains it to being a string, in
fact the method as written will work on any object because they all have a default
toStr implementation.  If you want to constrain your function to only taking strings you
could specify just the type for name, e.g.:

	sayHello = (name:Str) -> puts "Hello #{name}!"

On the other hand, if there were a usage that constrained name to being a string then
the compiler would infer the type automatically, e.g. this definition gets the
proper types as expected since only Strings can be added to other strings (and
the " " empty string is enough to pin down both parameter types and the "Mr. " +
further pins down the type of the lastName parameter.

	sayHello = (firstName, lastName) ->
		val name = case firstName, lastName of
		    			Just firstName, Just lastName: firstName + " " + lastName
		    			Just firstName, None: firstName
		    			None, Just lastName: "Mr. " + lastName
						None, None: "User"
		puts "Hello #{name}!"

Bindings are names like in python.  Var bindings can be rebound, val bindings can not (ala Scala).

Function composition uses the * operator:

	double = (n) -> n * n
	triple = (n) -> n * n * n
	quadruple = double * double
	sextuple = double * triple

Meaningful whitespace ala python.  May be all tabs or all spaces.  May require exactly 4 spaces.  Haven't
decided yet.

Destructuring / Pattern matching.

Inheritance is single, but you can get multiple by using class composition:

	class Walker
		position:Int
		Walker = (self) -> self.position = 0
		walk = () -> position += 1

	class Talker
		req message:Str
		talk = () -> message

	WalkerTalker = Walker * Talker

	v = new WalkerTalker
	do v.walk  # -> 1
	do v.walk  # -> 2
	do v.talk  # -> ""

Operator overloading ala haskell with Coffee syntax:

	class Foo
	  	req score:Int
    	(+) = (self, b:Foo) -> self.score + b.score

All methods are really multimethods and we use multiple dispatch:

	class Foo
		req name:Str
		req score:Int
		bar = (self, a:Int, b:Int):Int -> a + b + score
		bar = (self, a:Str):Str -> "My name is #{name}, another name is #{a}."
		bar = (self, a:Obj):Str -> "We got an obj.  I don't even care what my name is."

	foo = new Foo "John" 4
	foo.bar(5, 6)            # -> 15
	foo.bar("Dave")          # -> "My name is John, another name is dave."
	foo.bar([1, 2, 3])       # -> "We got an obj.  I don't even care what my name is."

In fact, we even dispatch on return type:

	class Foo
		req score:Int
		bar = (self, n:Int):Int -> score + n
		bar = (self, n:Int):Str -> "(as a string: " + (toStr (bar n)) + ")"

	foo = new Foo 4
	foo.bar 6									# compile error, no clues as to return type.
	puts "The bar is " + foo.bar 6  			# will be return type string
	val z = 8 * foo.bar(6)						# will be return type Int

	# Watch out for gotchas:
	puts "The bar is %d" % foo.bar 6			# "The bar is 10"
	puts "The bar is %s" % foo.bar 6			# "(as a string: 10)"
	puts "The bar is #{foo.bar 6}"				# Compile error, it's unclear which is expected.


Currying is automatic:

	add = (a:Int, b:Int) -> a + b
	add1 = add 1
	add1 2										# -> 3

Can use point free style:

	even = (n) -> n % 2 == 0
	odd = not even

	even 2  									# -> true
	even 3  									# -> false
	odd  2  									# -> false
	odd  3  									# -> true


Scoping / Closures:

At the top level, it's really like you are extending the Kernel object....

	val AGE_LIMIT = 21

In this case, the value "AGE_LIMIT" is (a) "global" ("constant") in the current module.

	val AGE_LIMIT = 21
	val checkAge = (age) -> age > AGE_LIMIT

The function checkAge is declared at the module level which means the only environment
it closes over is the module environment, but that's ok because that's all we need
for this function.

Nested functions close over each parent scope:

	val AGE_LIMIT = 21
	val checkAge = (age) -> age > AGE_LIMIT
	val checkAgeOfCurrentUser = ->
		user = getCurrentUser()
		val actualCheck = -> checkAge user.age
		do actualCheck

Note I wrote this (terrible example which TODO should be replaced) out verbosely for
purposes of edification but it could be simplified to the following:

	val AGE_LIMIT = 21
	val checkAge = (age) -> age > AGE_LIMIT
	val checkAgeOfCurrentUser = ->
		user = getCurrentUser()
		do -> checkAge user.age

Of course in terms of functionality the double closure is not necessary (again, horrible example),
so the same functionality could be accomplished via the simplier:

	val AGE_LIMIT = 21
	val checkAge = (age) -> age > AGE_LIMIT
	val checkAgeOfCurrentUser = ->
		checkAge getCurrentUser().age

You can declare-and-call an anonymous function to get your own scope ala javascript:

	val AGE_LIMIT = 21
	val checkAge = (age, limit=AGE_LIMIT) -> age > limit
	val checkAgeOfCurrentUser = ->
		user = getCurrentUser()
		do (() ->
			AGE_LIMIT = 99
			a = checkAge user.Age, AGE_LIMIT
			b = checkAge user.Age)

However you can also just use let (which is basically just syntactic sugar for the same):

	val AGE_LIMIT = 21
	val checkAge = (age, limit=AGE_LIMIT) -> age > limit
	val checkAgeOfCurrentUser = ->
		user = getCurrentUser()
		let AGE_LIMIT = 99,
			_ignoredValue = 6
		in
			a = checkAge user.Age, AGE_LIMIT
			b = checkAge user.Age

Again, poor example, but we redeclare AGE_LIMIT as 99 but it's already closed over in the definition of checkAge
so in the first call (assignment to 'a'), the local AGE_LIMIT value of 99 is used and passed as the second
parameter which in turn gets bound to "limit" in the function call.  In the second call (assignment to 'b'),
the AGE_LIMIT variable is closed over in the current scope but the call does not pass it in, so when the
checkAge function executes it uses the value from the environment it was defined in an binds limit to 21.

All strings are multi-line.  You can use double quotes or triple quotes ('"' or '"""').  Can you use single quotes? Dunno yet.

Variable arguments work like python with splat and double splat:

	foo = (a, b, *rest) -> a + b + sum rest

As is the inverse:

	foo = (a, b, c) -> a + b * c

	params = [5, 6, 7]

	foo *params                   # -> 47
	foo 5 *[6, 7]                 # -> 47
	foo *[5, 6], 7                # -> 47

And kwargs the same:

	params =
		b: 6
		c: 7
		a: 5

	foo **params                   # -> 47
	foo **{"b": 6, "c": 7, "a":5}  # -> 47
	foo 5 **{"b": 6, "c": 7}       # -> 47
	# Note kwargs can come before positional args
	foo **{"b": 6, "c": 7} 5       # -> 47

- Open issues:
      modules
        -> gotta beat java AND python terribleness.
           - instead of foo/__init__.py and foo/bar.py, we have foo.py and foo/bar.py.  This way if no submodules, no subdirs, etc.  No __ files required.  Just put paths in loadpath.
           - packages can come from two parts of path ala java.  good/bad?
      packaging system
        -> gotta make it super easy to get started
      native xml syntax?  native json syntax?
	  arithmetic -> use gmp and all integers boundless.  what about floats? what about implicit conversions, etc
	  mixins?
	  enums?
	  tuples?  I think we want tuples for multiple return values.  python tuple syntax conflicts with coffee function syntax?
	  concurrency
	  jdbc like database access

	  I really don't like the "do x" vs "x()" dichotomy from CoffeeScript.  But I also don't like the idea
	  of having to use something like &foo.bar to pass around functions, especially if we're supposed to be
	  all functional and whatnot.  How can we avoid the confusion on this issue in a clever way?
