grammar Zen2;
 

expr    : term ( ( PLUS | MINUS )  term )* ;
term    : factor ( ( MULT | DIV ) factor )* ;
factor  : NUMBER ;

WHITESPACE : 	( '\t' | ' ' | '\r' | '\n'| '\u000C' )+ { $channel = HIDDEN; };

NUMBER  : 	('0'..'9')+ ;
 
MULT 	:	 '*' ;
DIV	:	 '/' ;
MINUS   :	'-'  ;
PLUS    : 	'+'  ;