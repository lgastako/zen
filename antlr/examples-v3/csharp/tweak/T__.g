lexer grammar T;
options {
  language=Java;

}

T__7 : 'method' ;
T__8 : '(' ;
T__9 : ')' ;
T__10 : '{' ;
T__11 : '}' ;
T__12 : '=' ;
T__13 : ';' ;
T__14 : '+' ;
T__15 : '*' ;

// $ANTLR src "T.g" 78
ID  :   ('a'..'z'|'A'..'Z')+ ;

// $ANTLR src "T.g" 80
INT :   ('0'..'9')+ ;

// $ANTLR src "T.g" 82
WS  :   (' '|'\t'|'\n')+ {$channel=HIDDEN;}
    ;
