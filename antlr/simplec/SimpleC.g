gunit SimpleC;

//test rule:variable with 2 tests
variable:
"int x" FAIL     //expect failure, because of missing ';' in the input string

"int x;" -> OK

//test rule:functionHeader with 1 test
functionHeader:
"void bar(int x)" returns ["int"]  //expect a return string "int" from rule

//test rule:program with 3 tests, input starts immediately after the initial << so the first test is a blank line
program:
<<
char c;
int x;
>> OK        //expect success (no error messages from ANTLR)

input OK     //expect success

input -> ""  //expect standard output "" from rule


// test lexical rules
ID:
"abc123" OK    //expect success
"XYZ@999" OK   //expect success
"123abc" FAIL  //expect failure

INT:
"00000" OK
"123456789" OK
