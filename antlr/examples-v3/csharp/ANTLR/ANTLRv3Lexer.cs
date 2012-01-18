// $ANTLR 3.1b2 ANTLRv3.g 2008-08-11 12:00:46

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class ANTLRv3Lexer : Lexer {
    public const int CLOSURE = 10;
    public const int DOUBLE_QUOTE_STRING_LITERAL = 50;
    public const int TEMPLATE = 30;
    public const int ARGLIST = 22;
    public const int PARSER_GRAMMAR = 25;
    public const int BANG = 39;
    public const int T__73 = 73;
    public const int GATED_SEMPRED = 33;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int ACTION_ESC = 62;
    public const int LEXER = 6;
    public const int STRING_LITERAL = 43;
    public const int OPTIONAL = 9;
    public const int ACTION_CHAR_LITERAL = 60;
    public const int DOUBLE_ANGLE_STRING_LITERAL = 51;
    public const int RANGE = 13;
    public const int T__89 = 89;
    public const int WS = 64;
    public const int T__79 = 79;
    public const int ARG_ACTION = 48;
    public const int T__66 = 66;
    public const int TOKEN_REF = 42;
    public const int T__92 = 92;
    public const int WS_LOOP = 63;
    public const int T__88 = 88;
    public const int XDIGIT = 57;
    public const int TREE_BEGIN = 37;
    public const int T__90 = 90;
    public const int INITACTION = 28;
    public const int POSITIVE_CLOSURE = 11;
    public const int T__91 = 91;
    public const int T__85 = 85;
    public const int RET = 23;
    public const int CHAR_RANGE = 14;
    public const int LITERAL_CHAR = 55;
    public const int DOC_COMMENT = 4;
    public const int T__93 = 93;
    public const int NESTED_ACTION = 61;
    public const int T__86 = 86;
    public const int T__80 = 80;
    public const int T__69 = 69;
    public const int RULE = 7;
    public const int T__65 = 65;
    public const int LABEL = 29;
    public const int SYN_SEMPRED = 34;
    public const int BACKTRACK_SEMPRED = 35;
    public const int REWRITE = 40;
    public const int T__67 = 67;
    public const int TREE_GRAMMAR = 26;
    public const int T__87 = 87;
    public const int BLOCK = 8;
    public const int T__74 = 74;
    public const int ALT = 16;
    public const int T__68 = 68;
    public const int CHAR_LITERAL = 44;
    public const int FRAGMENT = 36;
    public const int INT = 47;
    public const int PARSER = 5;
    public const int EPSILON = 15;
    public const int SCOPE = 31;
    public const int TOKENS = 41;
    public const int OPTIONS = 46;
    public const int EOR = 17;
    public const int ML_COMMENT = 54;
    public const int SRC = 52;
    public const int SL_COMMENT = 53;
    public const int ID = 20;
    public const int COMBINED_GRAMMAR = 27;
    public const int EOB = 18;
    public const int T__78 = 78;
    public const int SYNPRED = 12;
    public const int EOA = 19;
    public const int ACTION = 45;
    public const int T__77 = 77;
    public const int ESC = 56;
    public const int RULE_REF = 49;
    public const int T__84 = 84;
    public const int SEMPRED = 32;
    public const int NESTED_ARG_ACTION = 58;
    public const int ROOT = 38;
    public const int T__75 = 75;
    public const int ACTION_STRING_LITERAL = 59;
    public const int ARG = 21;
    public const int EOF = -1;
    public const int T__76 = 76;
    public const int T__82 = 82;
    public const int T__81 = 81;
    public const int T__83 = 83;
    public const int T__71 = 71;
    public const int LEXER_GRAMMAR = 24;

    // delegates
    // delegators

    public ANTLRv3Lexer() 
    {
		InitializeCyclicDFAs();
    }
    public ANTLRv3Lexer(ICharStream input)
		: this(input, null) {
    }
    public ANTLRv3Lexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "ANTLRv3.g";} 
    }

    // $ANTLR start "SCOPE"
    public void mSCOPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SCOPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:7:7: ( 'scope' )
            // ANTLRv3.g:7:9: 'scope'
            {
            	Match("scope"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SCOPE"

    // $ANTLR start "FRAGMENT"
    public void mFRAGMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FRAGMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:8:10: ( 'fragment' )
            // ANTLRv3.g:8:12: 'fragment'
            {
            	Match("fragment"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FRAGMENT"

    // $ANTLR start "TREE_BEGIN"
    public void mTREE_BEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TREE_BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:9:12: ( '^(' )
            // ANTLRv3.g:9:14: '^('
            {
            	Match("^("); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TREE_BEGIN"

    // $ANTLR start "ROOT"
    public void mROOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ROOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:10:6: ( '^' )
            // ANTLRv3.g:10:8: '^'
            {
            	Match('^'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ROOT"

    // $ANTLR start "BANG"
    public void mBANG() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BANG;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:11:6: ( '!' )
            // ANTLRv3.g:11:8: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BANG"

    // $ANTLR start "RANGE"
    public void mRANGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RANGE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:12:7: ( '..' )
            // ANTLRv3.g:12:9: '..'
            {
            	Match(".."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RANGE"

    // $ANTLR start "REWRITE"
    public void mREWRITE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REWRITE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:13:9: ( '->' )
            // ANTLRv3.g:13:11: '->'
            {
            	Match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REWRITE"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:14:7: ( 'lexer' )
            // ANTLRv3.g:14:9: 'lexer'
            {
            	Match("lexer"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:15:7: ( 'parser' )
            // ANTLRv3.g:15:9: 'parser'
            {
            	Match("parser"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:16:7: ( 'tree' )
            // ANTLRv3.g:16:9: 'tree'
            {
            	Match("tree"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:17:7: ( 'grammar' )
            // ANTLRv3.g:17:9: 'grammar'
            {
            	Match("grammar"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:18:7: ( ';' )
            // ANTLRv3.g:18:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:19:7: ( '}' )
            // ANTLRv3.g:19:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:20:7: ( '=' )
            // ANTLRv3.g:20:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:21:7: ( '@' )
            // ANTLRv3.g:21:9: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:22:7: ( '::' )
            // ANTLRv3.g:22:9: '::'
            {
            	Match("::"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:23:7: ( '*' )
            // ANTLRv3.g:23:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:24:7: ( 'protected' )
            // ANTLRv3.g:24:9: 'protected'
            {
            	Match("protected"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:25:7: ( 'public' )
            // ANTLRv3.g:25:9: 'public'
            {
            	Match("public"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:26:7: ( 'private' )
            // ANTLRv3.g:26:9: 'private'
            {
            	Match("private"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:27:7: ( 'returns' )
            // ANTLRv3.g:27:9: 'returns'
            {
            	Match("returns"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:28:7: ( ':' )
            // ANTLRv3.g:28:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:29:7: ( 'throws' )
            // ANTLRv3.g:29:9: 'throws'
            {
            	Match("throws"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:30:7: ( ',' )
            // ANTLRv3.g:30:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public void mT__82() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__82;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:31:7: ( '(' )
            // ANTLRv3.g:31:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public void mT__83() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__83;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:32:7: ( '|' )
            // ANTLRv3.g:32:9: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public void mT__84() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__84;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:33:7: ( ')' )
            // ANTLRv3.g:33:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__84"

    // $ANTLR start "T__85"
    public void mT__85() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__85;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:34:7: ( 'catch' )
            // ANTLRv3.g:34:9: 'catch'
            {
            	Match("catch"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__85"

    // $ANTLR start "T__86"
    public void mT__86() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__86;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:35:7: ( 'finally' )
            // ANTLRv3.g:35:9: 'finally'
            {
            	Match("finally"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__86"

    // $ANTLR start "T__87"
    public void mT__87() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__87;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:36:7: ( '+=' )
            // ANTLRv3.g:36:9: '+='
            {
            	Match("+="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__87"

    // $ANTLR start "T__88"
    public void mT__88() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__88;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:37:7: ( '=>' )
            // ANTLRv3.g:37:9: '=>'
            {
            	Match("=>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__88"

    // $ANTLR start "T__89"
    public void mT__89() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__89;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:38:7: ( '~' )
            // ANTLRv3.g:38:9: '~'
            {
            	Match('~'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__89"

    // $ANTLR start "T__90"
    public void mT__90() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__90;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:39:7: ( '?' )
            // ANTLRv3.g:39:9: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__90"

    // $ANTLR start "T__91"
    public void mT__91() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__91;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:40:7: ( '+' )
            // ANTLRv3.g:40:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__91"

    // $ANTLR start "T__92"
    public void mT__92() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__92;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:41:7: ( '.' )
            // ANTLRv3.g:41:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__92"

    // $ANTLR start "T__93"
    public void mT__93() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__93;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:42:7: ( '$' )
            // ANTLRv3.g:42:9: '$'
            {
            	Match('$'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__93"

    // $ANTLR start "SL_COMMENT"
    public void mSL_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SL_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:453:3: ( '//' ( ' $ANTLR ' SRC | (~ ( '\\r' | '\\n' ) )* ) ( '\\r' )? '\\n' )
            // ANTLRv3.g:453:5: '//' ( ' $ANTLR ' SRC | (~ ( '\\r' | '\\n' ) )* ) ( '\\r' )? '\\n'
            {
            	Match("//"); 

            	// ANTLRv3.g:454:5: ( ' $ANTLR ' SRC | (~ ( '\\r' | '\\n' ) )* )
            	int alt2 = 2;
            	alt2 = dfa2.Predict(input);
            	switch (alt2) 
            	{
            	    case 1 :
            	        // ANTLRv3.g:454:7: ' $ANTLR ' SRC
            	        {
            	        	Match(" $ANTLR "); 

            	        	mSRC(); 

            	        }
            	        break;
            	    case 2 :
            	        // ANTLRv3.g:455:6: (~ ( '\\r' | '\\n' ) )*
            	        {
            	        	// ANTLRv3.g:455:6: (~ ( '\\r' | '\\n' ) )*
            	        	do 
            	        	{
            	        	    int alt1 = 2;
            	        	    int LA1_0 = input.LA(1);

            	        	    if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t') || (LA1_0 >= '\u000B' && LA1_0 <= '\f') || (LA1_0 >= '\u000E' && LA1_0 <= '\uFFFE')) )
            	        	    {
            	        	        alt1 = 1;
            	        	    }


            	        	    switch (alt1) 
            	        		{
            	        			case 1 :
            	        			    // ANTLRv3.g:455:6: ~ ( '\\r' | '\\n' )
            	        			    {
            	        			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFE') ) 
            	        			    	{
            	        			    	    input.Consume();

            	        			    	}
            	        			    	else 
            	        			    	{
            	        			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        			    	    Recover(mse);
            	        			    	    throw mse;}


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop1;
            	        	    }
            	        	} while (true);

            	        	loop1:
            	        		;	// Stops C# compiler whining that label 'loop1' has no statements


            	        }
            	        break;

            	}

            	// ANTLRv3.g:457:3: ( '\\r' )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == '\r') )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // ANTLRv3.g:457:3: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SL_COMMENT"

    // $ANTLR start "ML_COMMENT"
    public void mML_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ML_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:462:2: ( '/*' ( . )* '*/' )
            // ANTLRv3.g:462:4: '/*' ( . )* '*/'
            {
            	Match("/*"); 

            	if (input.LA(1)=='*') _type=DOC_COMMENT; else _channel=HIDDEN;
            	// ANTLRv3.g:462:74: ( . )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == '*') )
            	    {
            	        int LA4_1 = input.LA(2);

            	        if ( (LA4_1 == '/') )
            	        {
            	            alt4 = 2;
            	        }
            	        else if ( ((LA4_1 >= '\u0000' && LA4_1 <= '.') || (LA4_1 >= '0' && LA4_1 <= '\uFFFE')) )
            	        {
            	            alt4 = 1;
            	        }


            	    }
            	    else if ( ((LA4_0 >= '\u0000' && LA4_0 <= ')') || (LA4_0 >= '+' && LA4_0 <= '\uFFFE')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // ANTLRv3.g:462:74: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	Match("*/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ML_COMMENT"

    // $ANTLR start "CHAR_LITERAL"
    public void mCHAR_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:466:2: ( '\\'' LITERAL_CHAR '\\'' )
            // ANTLRv3.g:466:4: '\\'' LITERAL_CHAR '\\''
            {
            	Match('\''); 
            	mLITERAL_CHAR(); 
            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR_LITERAL"

    // $ANTLR start "STRING_LITERAL"
    public void mSTRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:470:2: ( '\\'' LITERAL_CHAR ( LITERAL_CHAR )* '\\'' )
            // ANTLRv3.g:470:4: '\\'' LITERAL_CHAR ( LITERAL_CHAR )* '\\''
            {
            	Match('\''); 
            	mLITERAL_CHAR(); 
            	// ANTLRv3.g:470:22: ( LITERAL_CHAR )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '\u0000' && LA5_0 <= '&') || (LA5_0 >= '(' && LA5_0 <= '\uFFFE')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // ANTLRv3.g:470:22: LITERAL_CHAR
            			    {
            			    	mLITERAL_CHAR(); 

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING_LITERAL"

    // $ANTLR start "LITERAL_CHAR"
    public void mLITERAL_CHAR() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:475:2: ( ESC | ~ ( '\\'' | '\\\\' ) )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == '\\') )
            {
                alt6 = 1;
            }
            else if ( ((LA6_0 >= '\u0000' && LA6_0 <= '&') || (LA6_0 >= '(' && LA6_0 <= '[') || (LA6_0 >= ']' && LA6_0 <= '\uFFFE')) )
            {
                alt6 = 2;
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // ANTLRv3.g:475:4: ESC
                    {
                    	mESC(); 

                    }
                    break;
                case 2 :
                    // ANTLRv3.g:476:4: ~ ( '\\'' | '\\\\' )
                    {
                    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LITERAL_CHAR"

    // $ANTLR start "DOUBLE_QUOTE_STRING_LITERAL"
    public void mDOUBLE_QUOTE_STRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE_QUOTE_STRING_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:480:2: ( '\"' ( ESC | ~ ( '\\\\' | '\"' ) )* '\"' )
            // ANTLRv3.g:480:4: '\"' ( ESC | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// ANTLRv3.g:480:8: ( ESC | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt7 = 3;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == '\\') )
            	    {
            	        alt7 = 1;
            	    }
            	    else if ( ((LA7_0 >= '\u0000' && LA7_0 <= '!') || (LA7_0 >= '#' && LA7_0 <= '[') || (LA7_0 >= ']' && LA7_0 <= '\uFFFE')) )
            	    {
            	        alt7 = 2;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // ANTLRv3.g:480:9: ESC
            			    {
            			    	mESC(); 

            			    }
            			    break;
            			case 2 :
            			    // ANTLRv3.g:480:15: ~ ( '\\\\' | '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE_QUOTE_STRING_LITERAL"

    // $ANTLR start "DOUBLE_ANGLE_STRING_LITERAL"
    public void mDOUBLE_ANGLE_STRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE_ANGLE_STRING_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:484:2: ( '<<' ( . )* '>>' )
            // ANTLRv3.g:484:4: '<<' ( . )* '>>'
            {
            	Match("<<"); 

            	// ANTLRv3.g:484:9: ( . )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == '>') )
            	    {
            	        int LA8_1 = input.LA(2);

            	        if ( (LA8_1 == '>') )
            	        {
            	            alt8 = 2;
            	        }
            	        else if ( ((LA8_1 >= '\u0000' && LA8_1 <= '=') || (LA8_1 >= '?' && LA8_1 <= '\uFFFE')) )
            	        {
            	            alt8 = 1;
            	        }


            	    }
            	    else if ( ((LA8_0 >= '\u0000' && LA8_0 <= '=') || (LA8_0 >= '?' && LA8_0 <= '\uFFFE')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // ANTLRv3.g:484:9: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	Match(">>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE_ANGLE_STRING_LITERAL"

    // $ANTLR start "ESC"
    public void mESC() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:488:5: ( '\\\\' ( 'n' | 'r' | 't' | 'b' | 'f' | '\"' | '\\'' | '\\\\' | '>' | 'u' XDIGIT XDIGIT XDIGIT XDIGIT | . ) )
            // ANTLRv3.g:488:7: '\\\\' ( 'n' | 'r' | 't' | 'b' | 'f' | '\"' | '\\'' | '\\\\' | '>' | 'u' XDIGIT XDIGIT XDIGIT XDIGIT | . )
            {
            	Match('\\'); 
            	// ANTLRv3.g:489:3: ( 'n' | 'r' | 't' | 'b' | 'f' | '\"' | '\\'' | '\\\\' | '>' | 'u' XDIGIT XDIGIT XDIGIT XDIGIT | . )
            	int alt9 = 11;
            	alt9 = dfa9.Predict(input);
            	switch (alt9) 
            	{
            	    case 1 :
            	        // ANTLRv3.g:489:5: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 2 :
            	        // ANTLRv3.g:490:5: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 3 :
            	        // ANTLRv3.g:491:5: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // ANTLRv3.g:492:5: 'b'
            	        {
            	        	Match('b'); 

            	        }
            	        break;
            	    case 5 :
            	        // ANTLRv3.g:493:5: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 6 :
            	        // ANTLRv3.g:494:5: '\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 7 :
            	        // ANTLRv3.g:495:5: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 8 :
            	        // ANTLRv3.g:496:5: '\\\\'
            	        {
            	        	Match('\\'); 

            	        }
            	        break;
            	    case 9 :
            	        // ANTLRv3.g:497:5: '>'
            	        {
            	        	Match('>'); 

            	        }
            	        break;
            	    case 10 :
            	        // ANTLRv3.g:498:5: 'u' XDIGIT XDIGIT XDIGIT XDIGIT
            	        {
            	        	Match('u'); 
            	        	mXDIGIT(); 
            	        	mXDIGIT(); 
            	        	mXDIGIT(); 
            	        	mXDIGIT(); 

            	        }
            	        break;
            	    case 11 :
            	        // ANTLRv3.g:499:5: .
            	        {
            	        	MatchAny(); 

            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESC"

    // $ANTLR start "XDIGIT"
    public void mXDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:504:8: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            // ANTLRv3.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "XDIGIT"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:510:5: ( ( '0' .. '9' )+ )
            // ANTLRv3.g:510:7: ( '0' .. '9' )+
            {
            	// ANTLRv3.g:510:7: ( '0' .. '9' )+
            	int cnt10 = 0;
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // ANTLRv3.g:510:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt10 >= 1 ) goto loop10;
            		            EarlyExitException eee =
            		                new EarlyExitException(10, input);
            		            throw eee;
            	    }
            	    cnt10++;
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "ARG_ACTION"
    public void mARG_ACTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARG_ACTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:514:2: ( NESTED_ARG_ACTION )
            // ANTLRv3.g:514:4: NESTED_ARG_ACTION
            {
            	mNESTED_ARG_ACTION(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARG_ACTION"

    // $ANTLR start "NESTED_ARG_ACTION"
    public void mNESTED_ARG_ACTION() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:518:19: ( '[' ( options {greedy=false; k=1; } : NESTED_ARG_ACTION | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )* ']' )
            // ANTLRv3.g:519:2: '[' ( options {greedy=false; k=1; } : NESTED_ARG_ACTION | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )* ']'
            {
            	Match('['); 
            	// ANTLRv3.g:520:2: ( options {greedy=false; k=1; } : NESTED_ARG_ACTION | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )*
            	do 
            	{
            	    int alt11 = 5;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == ']') )
            	    {
            	        alt11 = 5;
            	    }
            	    else if ( (LA11_0 == '[') )
            	    {
            	        alt11 = 1;
            	    }
            	    else if ( (LA11_0 == '\"') )
            	    {
            	        alt11 = 2;
            	    }
            	    else if ( (LA11_0 == '\'') )
            	    {
            	        alt11 = 3;
            	    }
            	    else if ( ((LA11_0 >= '\u0000' && LA11_0 <= '!') || (LA11_0 >= '#' && LA11_0 <= '&') || (LA11_0 >= '(' && LA11_0 <= 'Z') || LA11_0 == '\\' || (LA11_0 >= '^' && LA11_0 <= '\uFFFE')) )
            	    {
            	        alt11 = 4;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // ANTLRv3.g:521:4: NESTED_ARG_ACTION
            			    {
            			    	mNESTED_ARG_ACTION(); 

            			    }
            			    break;
            			case 2 :
            			    // ANTLRv3.g:522:4: ACTION_STRING_LITERAL
            			    {
            			    	mACTION_STRING_LITERAL(); 

            			    }
            			    break;
            			case 3 :
            			    // ANTLRv3.g:523:4: ACTION_CHAR_LITERAL
            			    {
            			    	mACTION_CHAR_LITERAL(); 

            			    }
            			    break;
            			case 4 :
            			    // ANTLRv3.g:524:4: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	Match(']'); 
            	Text = Text.Substring(1, Text.Length-1);

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NESTED_ARG_ACTION"

    // $ANTLR start "ACTION"
    public void mACTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ACTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:531:2: ( NESTED_ACTION ( '?' )? )
            // ANTLRv3.g:531:4: NESTED_ACTION ( '?' )?
            {
            	mNESTED_ACTION(); 
            	// ANTLRv3.g:531:18: ( '?' )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '?') )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // ANTLRv3.g:531:20: '?'
            	        {
            	        	Match('?'); 
            	        	_type = SEMPRED;

            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION"

    // $ANTLR start "NESTED_ACTION"
    public void mNESTED_ACTION() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:535:15: ( '{' ( options {greedy=false; k=2; } : NESTED_ACTION | SL_COMMENT | ML_COMMENT | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )* '}' )
            // ANTLRv3.g:536:2: '{' ( options {greedy=false; k=2; } : NESTED_ACTION | SL_COMMENT | ML_COMMENT | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )* '}'
            {
            	Match('{'); 
            	// ANTLRv3.g:537:2: ( options {greedy=false; k=2; } : NESTED_ACTION | SL_COMMENT | ML_COMMENT | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )*
            	do 
            	{
            	    int alt13 = 7;
            	    alt13 = dfa13.Predict(input);
            	    switch (alt13) 
            		{
            			case 1 :
            			    // ANTLRv3.g:538:4: NESTED_ACTION
            			    {
            			    	mNESTED_ACTION(); 

            			    }
            			    break;
            			case 2 :
            			    // ANTLRv3.g:539:4: SL_COMMENT
            			    {
            			    	mSL_COMMENT(); 

            			    }
            			    break;
            			case 3 :
            			    // ANTLRv3.g:540:4: ML_COMMENT
            			    {
            			    	mML_COMMENT(); 

            			    }
            			    break;
            			case 4 :
            			    // ANTLRv3.g:541:4: ACTION_STRING_LITERAL
            			    {
            			    	mACTION_STRING_LITERAL(); 

            			    }
            			    break;
            			case 5 :
            			    // ANTLRv3.g:542:4: ACTION_CHAR_LITERAL
            			    {
            			    	mACTION_CHAR_LITERAL(); 

            			    }
            			    break;
            			case 6 :
            			    // ANTLRv3.g:543:4: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	Match('}'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NESTED_ACTION"

    // $ANTLR start "ACTION_CHAR_LITERAL"
    public void mACTION_CHAR_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:550:2: ( '\\'' ( ACTION_ESC | ~ ( '\\\\' | '\\'' ) ) '\\'' )
            // ANTLRv3.g:550:4: '\\'' ( ACTION_ESC | ~ ( '\\\\' | '\\'' ) ) '\\''
            {
            	Match('\''); 
            	// ANTLRv3.g:550:9: ( ACTION_ESC | ~ ( '\\\\' | '\\'' ) )
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == '\\') )
            	{
            	    alt14 = 1;
            	}
            	else if ( ((LA14_0 >= '\u0000' && LA14_0 <= '&') || (LA14_0 >= '(' && LA14_0 <= '[') || (LA14_0 >= ']' && LA14_0 <= '\uFFFE')) )
            	{
            	    alt14 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // ANTLRv3.g:550:10: ACTION_ESC
            	        {
            	        	mACTION_ESC(); 

            	        }
            	        break;
            	    case 2 :
            	        // ANTLRv3.g:550:21: ~ ( '\\\\' | '\\'' )
            	        {
            	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE') ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	Match('\''); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_CHAR_LITERAL"

    // $ANTLR start "ACTION_STRING_LITERAL"
    public void mACTION_STRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:555:2: ( '\"' ( ACTION_ESC | ~ ( '\\\\' | '\"' ) )* '\"' )
            // ANTLRv3.g:555:4: '\"' ( ACTION_ESC | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// ANTLRv3.g:555:8: ( ACTION_ESC | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt15 = 3;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == '\\') )
            	    {
            	        alt15 = 1;
            	    }
            	    else if ( ((LA15_0 >= '\u0000' && LA15_0 <= '!') || (LA15_0 >= '#' && LA15_0 <= '[') || (LA15_0 >= ']' && LA15_0 <= '\uFFFE')) )
            	    {
            	        alt15 = 2;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // ANTLRv3.g:555:9: ACTION_ESC
            			    {
            			    	mACTION_ESC(); 

            			    }
            			    break;
            			case 2 :
            			    // ANTLRv3.g:555:20: ~ ( '\\\\' | '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	Match('\"'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_STRING_LITERAL"

    // $ANTLR start "ACTION_ESC"
    public void mACTION_ESC() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:560:2: ( '\\\\\\'' | '\\\\' '\"' | '\\\\' ~ ( '\\'' | '\"' ) )
            int alt16 = 3;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == '\\') )
            {
                int LA16_1 = input.LA(2);

                if ( (LA16_1 == '\'') )
                {
                    alt16 = 1;
                }
                else if ( (LA16_1 == '\"') )
                {
                    alt16 = 2;
                }
                else if ( ((LA16_1 >= '\u0000' && LA16_1 <= '!') || (LA16_1 >= '#' && LA16_1 <= '&') || (LA16_1 >= '(' && LA16_1 <= '\uFFFE')) )
                {
                    alt16 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d16s1 =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae_d16s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // ANTLRv3.g:560:4: '\\\\\\''
                    {
                    	Match("\\\'"); 


                    }
                    break;
                case 2 :
                    // ANTLRv3.g:561:4: '\\\\' '\"'
                    {
                    	Match('\\'); 
                    	Match('\"'); 

                    }
                    break;
                case 3 :
                    // ANTLRv3.g:562:4: '\\\\' ~ ( '\\'' | '\"' )
                    {
                    	Match('\\'); 
                    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFE') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ACTION_ESC"

    // $ANTLR start "TOKEN_REF"
    public void mTOKEN_REF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TOKEN_REF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:566:2: ( 'A' .. 'Z' ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
            // ANTLRv3.g:566:4: 'A' .. 'Z' ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            {
            	MatchRange('A','Z'); 
            	// ANTLRv3.g:566:13: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= '0' && LA17_0 <= '9') || (LA17_0 >= 'A' && LA17_0 <= 'Z') || LA17_0 == '_' || (LA17_0 >= 'a' && LA17_0 <= 'z')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // ANTLRv3.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TOKEN_REF"

    // $ANTLR start "RULE_REF"
    public void mRULE_REF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RULE_REF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:570:2: ( 'a' .. 'z' ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
            // ANTLRv3.g:570:4: 'a' .. 'z' ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            {
            	MatchRange('a','z'); 
            	// ANTLRv3.g:570:13: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= '0' && LA18_0 <= '9') || (LA18_0 >= 'A' && LA18_0 <= 'Z') || LA18_0 == '_' || (LA18_0 >= 'a' && LA18_0 <= 'z')) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // ANTLRv3.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RULE_REF"

    // $ANTLR start "OPTIONS"
    public void mOPTIONS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPTIONS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:577:2: ( 'options' WS_LOOP '{' )
            // ANTLRv3.g:577:4: 'options' WS_LOOP '{'
            {
            	Match("options"); 

            	mWS_LOOP(); 
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPTIONS"

    // $ANTLR start "TOKENS"
    public void mTOKENS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TOKENS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:581:2: ( 'tokens' WS_LOOP '{' )
            // ANTLRv3.g:581:4: 'tokens' WS_LOOP '{'
            {
            	Match("tokens"); 

            	mWS_LOOP(); 
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TOKENS"

    // $ANTLR start "SRC"
    public void mSRC() // throws RecognitionException [2]
    {
    		try
    		{
            IToken file = null;
            IToken line = null;

            // ANTLRv3.g:589:5: ( 'src' ' ' file= ACTION_STRING_LITERAL ' ' line= INT )
            // ANTLRv3.g:589:7: 'src' ' ' file= ACTION_STRING_LITERAL ' ' line= INT
            {
            	Match("src"); 

            	Match(' '); 
            	int fileStart988 = CharIndex;
            	mACTION_STRING_LITERAL(); 
            	file = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, fileStart988, CharIndex-1);
            	Match(' '); 
            	int lineStart994 = CharIndex;
            	mINT(); 
            	line = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, lineStart994, CharIndex-1);

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "SRC"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // ANTLRv3.g:592:4: ( ( ' ' | '\\t' | ( '\\r' )? '\\n' )+ )
            // ANTLRv3.g:592:6: ( ' ' | '\\t' | ( '\\r' )? '\\n' )+
            {
            	// ANTLRv3.g:592:6: ( ' ' | '\\t' | ( '\\r' )? '\\n' )+
            	int cnt20 = 0;
            	do 
            	{
            	    int alt20 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case ' ':
            	    	{
            	        alt20 = 1;
            	        }
            	        break;
            	    case '\t':
            	    	{
            	        alt20 = 2;
            	        }
            	        break;
            	    case '\n':
            	    case '\r':
            	    	{
            	        alt20 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt20) 
            		{
            			case 1 :
            			    // ANTLRv3.g:592:8: ' '
            			    {
            			    	Match(' '); 

            			    }
            			    break;
            			case 2 :
            			    // ANTLRv3.g:593:5: '\\t'
            			    {
            			    	Match('\t'); 

            			    }
            			    break;
            			case 3 :
            			    // ANTLRv3.g:594:5: ( '\\r' )? '\\n'
            			    {
            			    	// ANTLRv3.g:594:5: ( '\\r' )?
            			    	int alt19 = 2;
            			    	int LA19_0 = input.LA(1);

            			    	if ( (LA19_0 == '\r') )
            			    	{
            			    	    alt19 = 1;
            			    	}
            			    	switch (alt19) 
            			    	{
            			    	    case 1 :
            			    	        // ANTLRv3.g:594:5: '\\r'
            			    	        {
            			    	        	Match('\r'); 

            			    	        }
            			    	        break;

            			    	}

            			    	Match('\n'); 

            			    }
            			    break;

            			default:
            			    if ( cnt20 >= 1 ) goto loop20;
            		            EarlyExitException eee =
            		                new EarlyExitException(20, input);
            		            throw eee;
            	    }
            	    cnt20++;
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whinging that label 'loop20' has no statements

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "WS_LOOP"
    public void mWS_LOOP() // throws RecognitionException [2]
    {
    		try
    		{
            // ANTLRv3.g:601:2: ( ( WS | SL_COMMENT | ML_COMMENT )* )
            // ANTLRv3.g:601:4: ( WS | SL_COMMENT | ML_COMMENT )*
            {
            	// ANTLRv3.g:601:4: ( WS | SL_COMMENT | ML_COMMENT )*
            	do 
            	{
            	    int alt21 = 4;
            	    int LA21_0 = input.LA(1);

            	    if ( ((LA21_0 >= '\t' && LA21_0 <= '\n') || LA21_0 == '\r' || LA21_0 == ' ') )
            	    {
            	        alt21 = 1;
            	    }
            	    else if ( (LA21_0 == '/') )
            	    {
            	        int LA21_3 = input.LA(2);

            	        if ( (LA21_3 == '/') )
            	        {
            	            alt21 = 2;
            	        }
            	        else if ( (LA21_3 == '*') )
            	        {
            	            alt21 = 3;
            	        }


            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // ANTLRv3.g:601:6: WS
            			    {
            			    	mWS(); 

            			    }
            			    break;
            			case 2 :
            			    // ANTLRv3.g:602:5: SL_COMMENT
            			    {
            			    	mSL_COMMENT(); 

            			    }
            			    break;
            			case 3 :
            			    // ANTLRv3.g:603:5: ML_COMMENT
            			    {
            			    	mML_COMMENT(); 

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS_LOOP"

    override public void mTokens() // throws RecognitionException 
    {
        // ANTLRv3.g:1:8: ( SCOPE | FRAGMENT | TREE_BEGIN | ROOT | BANG | RANGE | REWRITE | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | SL_COMMENT | ML_COMMENT | CHAR_LITERAL | STRING_LITERAL | DOUBLE_QUOTE_STRING_LITERAL | DOUBLE_ANGLE_STRING_LITERAL | INT | ARG_ACTION | ACTION | TOKEN_REF | RULE_REF | OPTIONS | TOKENS | WS )
        int alt22 = 50;
        alt22 = dfa22.Predict(input);
        switch (alt22) 
        {
            case 1 :
                // ANTLRv3.g:1:10: SCOPE
                {
                	mSCOPE(); 

                }
                break;
            case 2 :
                // ANTLRv3.g:1:16: FRAGMENT
                {
                	mFRAGMENT(); 

                }
                break;
            case 3 :
                // ANTLRv3.g:1:25: TREE_BEGIN
                {
                	mTREE_BEGIN(); 

                }
                break;
            case 4 :
                // ANTLRv3.g:1:36: ROOT
                {
                	mROOT(); 

                }
                break;
            case 5 :
                // ANTLRv3.g:1:41: BANG
                {
                	mBANG(); 

                }
                break;
            case 6 :
                // ANTLRv3.g:1:46: RANGE
                {
                	mRANGE(); 

                }
                break;
            case 7 :
                // ANTLRv3.g:1:52: REWRITE
                {
                	mREWRITE(); 

                }
                break;
            case 8 :
                // ANTLRv3.g:1:60: T__65
                {
                	mT__65(); 

                }
                break;
            case 9 :
                // ANTLRv3.g:1:66: T__66
                {
                	mT__66(); 

                }
                break;
            case 10 :
                // ANTLRv3.g:1:72: T__67
                {
                	mT__67(); 

                }
                break;
            case 11 :
                // ANTLRv3.g:1:78: T__68
                {
                	mT__68(); 

                }
                break;
            case 12 :
                // ANTLRv3.g:1:84: T__69
                {
                	mT__69(); 

                }
                break;
            case 13 :
                // ANTLRv3.g:1:90: T__70
                {
                	mT__70(); 

                }
                break;
            case 14 :
                // ANTLRv3.g:1:96: T__71
                {
                	mT__71(); 

                }
                break;
            case 15 :
                // ANTLRv3.g:1:102: T__72
                {
                	mT__72(); 

                }
                break;
            case 16 :
                // ANTLRv3.g:1:108: T__73
                {
                	mT__73(); 

                }
                break;
            case 17 :
                // ANTLRv3.g:1:114: T__74
                {
                	mT__74(); 

                }
                break;
            case 18 :
                // ANTLRv3.g:1:120: T__75
                {
                	mT__75(); 

                }
                break;
            case 19 :
                // ANTLRv3.g:1:126: T__76
                {
                	mT__76(); 

                }
                break;
            case 20 :
                // ANTLRv3.g:1:132: T__77
                {
                	mT__77(); 

                }
                break;
            case 21 :
                // ANTLRv3.g:1:138: T__78
                {
                	mT__78(); 

                }
                break;
            case 22 :
                // ANTLRv3.g:1:144: T__79
                {
                	mT__79(); 

                }
                break;
            case 23 :
                // ANTLRv3.g:1:150: T__80
                {
                	mT__80(); 

                }
                break;
            case 24 :
                // ANTLRv3.g:1:156: T__81
                {
                	mT__81(); 

                }
                break;
            case 25 :
                // ANTLRv3.g:1:162: T__82
                {
                	mT__82(); 

                }
                break;
            case 26 :
                // ANTLRv3.g:1:168: T__83
                {
                	mT__83(); 

                }
                break;
            case 27 :
                // ANTLRv3.g:1:174: T__84
                {
                	mT__84(); 

                }
                break;
            case 28 :
                // ANTLRv3.g:1:180: T__85
                {
                	mT__85(); 

                }
                break;
            case 29 :
                // ANTLRv3.g:1:186: T__86
                {
                	mT__86(); 

                }
                break;
            case 30 :
                // ANTLRv3.g:1:192: T__87
                {
                	mT__87(); 

                }
                break;
            case 31 :
                // ANTLRv3.g:1:198: T__88
                {
                	mT__88(); 

                }
                break;
            case 32 :
                // ANTLRv3.g:1:204: T__89
                {
                	mT__89(); 

                }
                break;
            case 33 :
                // ANTLRv3.g:1:210: T__90
                {
                	mT__90(); 

                }
                break;
            case 34 :
                // ANTLRv3.g:1:216: T__91
                {
                	mT__91(); 

                }
                break;
            case 35 :
                // ANTLRv3.g:1:222: T__92
                {
                	mT__92(); 

                }
                break;
            case 36 :
                // ANTLRv3.g:1:228: T__93
                {
                	mT__93(); 

                }
                break;
            case 37 :
                // ANTLRv3.g:1:234: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 38 :
                // ANTLRv3.g:1:245: ML_COMMENT
                {
                	mML_COMMENT(); 

                }
                break;
            case 39 :
                // ANTLRv3.g:1:256: CHAR_LITERAL
                {
                	mCHAR_LITERAL(); 

                }
                break;
            case 40 :
                // ANTLRv3.g:1:269: STRING_LITERAL
                {
                	mSTRING_LITERAL(); 

                }
                break;
            case 41 :
                // ANTLRv3.g:1:284: DOUBLE_QUOTE_STRING_LITERAL
                {
                	mDOUBLE_QUOTE_STRING_LITERAL(); 

                }
                break;
            case 42 :
                // ANTLRv3.g:1:312: DOUBLE_ANGLE_STRING_LITERAL
                {
                	mDOUBLE_ANGLE_STRING_LITERAL(); 

                }
                break;
            case 43 :
                // ANTLRv3.g:1:340: INT
                {
                	mINT(); 

                }
                break;
            case 44 :
                // ANTLRv3.g:1:344: ARG_ACTION
                {
                	mARG_ACTION(); 

                }
                break;
            case 45 :
                // ANTLRv3.g:1:355: ACTION
                {
                	mACTION(); 

                }
                break;
            case 46 :
                // ANTLRv3.g:1:362: TOKEN_REF
                {
                	mTOKEN_REF(); 

                }
                break;
            case 47 :
                // ANTLRv3.g:1:372: RULE_REF
                {
                	mRULE_REF(); 

                }
                break;
            case 48 :
                // ANTLRv3.g:1:381: OPTIONS
                {
                	mOPTIONS(); 

                }
                break;
            case 49 :
                // ANTLRv3.g:1:389: TOKENS
                {
                	mTOKENS(); 

                }
                break;
            case 50 :
                // ANTLRv3.g:1:396: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA2 dfa2;
    protected DFA9 dfa9;
    protected DFA13 dfa13;
    protected DFA22 dfa22;
	private void InitializeCyclicDFAs()
	{
	    this.dfa2 = new DFA2(this);
	    this.dfa9 = new DFA9(this);
	    this.dfa13 = new DFA13(this);
	    this.dfa22 = new DFA22(this);




	}

    const string DFA2_eotS =
        "\x12\uffff\x01\x02\x04\uffff\x01\x02\x04\uffff";
    const string DFA2_eofS =
        "\x1c\uffff";
    const string DFA2_minS =
        "\x02\x00\x01\uffff\x16\x00\x01\uffff\x01\x00\x01\uffff";
    const string DFA2_maxS =
        "\x02\ufffe\x01\uffff\x16\ufffe\x01\uffff\x01\ufffe\x01\uffff";
    const string DFA2_acceptS =
        "\x02\uffff\x01\x02\x16\uffff\x01\x01\x01\uffff\x01\x01";
    const string DFA2_specialS =
        "\x1c\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x20\x02\x01\x01\uffde\x02",
            "\x24\x02\x01\x03\uffda\x02",
            "",
            "\x41\x02\x01\x04\uffbd\x02",
            "\x4e\x02\x01\x05\uffb0\x02",
            "\x54\x02\x01\x06\uffaa\x02",
            "\x4c\x02\x01\x07\uffb2\x02",
            "\x52\x02\x01\x08\uffac\x02",
            "\x20\x02\x01\x09\uffde\x02",
            "\x73\x02\x01\x0a\uff8b\x02",
            "\x72\x02\x01\x0b\uff8c\x02",
            "\x63\x02\x01\x0c\uff9b\x02",
            "\x20\x02\x01\x0d\uffde\x02",
            "\x22\x02\x01\x0e\uffdc\x02",
            "\x0a\x13\x01\x12\x02\x13\x01\x10\x14\x13\x01\x11\x39\x13\x01"+
            "\x0f\uffa2\x13",
            "\x0a\x18\x01\x17\x02\x18\x01\x16\x14\x18\x01\x15\x04\x18\x01"+
            "\x14\uffd7\x18",
            "\x0a\x19\x01\x12\ufff4\x19",
            "\x20\x02\x01\x1a\uffde\x02",
            "\uffff\x19",
            "\x0a\x13\x01\x12\x02\x13\x01\x10\x14\x13\x01\x11\x39\x13\x01"+
            "\x0f\uffa2\x13",
            "\x0a\x13\x01\x12\x02\x13\x01\x10\x14\x13\x01\x11\x39\x13\x01"+
            "\x0f\uffa2\x13",
            "\x0a\x13\x01\x12\x02\x13\x01\x10\x14\x13\x01\x11\x39\x13\x01"+
            "\x0f\uffa2\x13",
            "\x0a\x19\x01\x12\ufff4\x19",
            "\uffff\x19",
            "\x0a\x13\x01\x12\x02\x13\x01\x10\x14\x13\x01\x11\x39\x13\x01"+
            "\x0f\uffa2\x13",
            "",
            "\x30\x02\x0a\x1b\uffc5\x02",
            ""
    };

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "454:5: ( ' $ANTLR ' SRC | (~ ( '\\r' | '\\n' ) )* )"; }
        }

    }

    const string DFA9_eotS =
        "\x0a\uffff\x01\x0b\x02\uffff";
    const string DFA9_eofS =
        "\x0d\uffff";
    const string DFA9_minS =
        "\x01\x00\x09\uffff\x01\x30\x02\uffff";
    const string DFA9_maxS =
        "\x01\ufffe\x09\uffff\x01\x66\x02\uffff";
    const string DFA9_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07"+
        "\x01\x08\x01\x09\x01\uffff\x01\x0b\x01\x0a";
    const string DFA9_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x22\x0b\x01\x06\x04\x0b\x01\x07\x16\x0b\x01\x09\x1d\x0b\x01"+
            "\x08\x05\x0b\x01\x04\x03\x0b\x01\x05\x07\x0b\x01\x01\x03\x0b"+
            "\x01\x02\x01\x0b\x01\x03\x01\x0a\uff89\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x0c\x07\uffff\x06\x0c\x1a\uffff\x06\x0c",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "489:3: ( 'n' | 'r' | 't' | 'b' | 'f' | '\"' | '\\'' | '\\\\' | '>' | 'u' XDIGIT XDIGIT XDIGIT XDIGIT | . )"; }
        }

    }

    const string DFA13_eotS =
        "\x1c\uffff";
    const string DFA13_eofS =
        "\x1c\uffff";
    const string DFA13_minS =
        "\x01\x00\x02\uffff\x03\x00\x16\uffff";
    const string DFA13_maxS =
        "\x01\ufffe\x02\uffff\x03\ufffe\x16\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x07\x01\x01\x03\uffff\x01\x06\x01\x02\x01\x03\x05"+
        "\uffff\x07\x04\x06\x05\x01\uffff";
    const string DFA13_specialS =
        "\x1c\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x22\x06\x01\x04\x04\x06\x01\x05\x07\x06\x01\x03\x4b\x06\x01"+
            "\x02\x01\x06\x01\x01\uff81\x06",
            "",
            "",
            "\x2a\x06\x01\x08\x04\x06\x01\x07\uffcf\x06",
            "\x22\x14\x01\x10\x04\x14\x01\x13\x07\x14\x01\x12\x2c\x14\x01"+
            "\x0e\x1e\x14\x01\x11\x01\x14\x01\x0f\uff81\x14",
            "\x22\x1a\x01\x19\x04\x1a\x01\x06\x07\x1a\x01\x18\x2c\x1a\x01"+
            "\x15\x1e\x1a\x01\x17\x01\x1a\x01\x16\uff81\x1a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 537:2: ( options {greedy=false; k=2; } : NESTED_ACTION | SL_COMMENT | ML_COMMENT | ACTION_STRING_LITERAL | ACTION_CHAR_LITERAL | . )*"; }
        }

    }

    const string DFA22_eotS =
        "\x01\uffff\x02\x24\x01\x2a\x01\uffff\x01\x2c\x01\uffff\x04\x24\x02"+
        "\uffff\x01\x36\x01\uffff\x01\x38\x01\uffff\x01\x24\x04\uffff\x01"+
        "\x24\x01\x3c\x0b\uffff\x01\x24\x02\uffff\x03\x24\x04\uffff\x08\x24"+
        "\x04\uffff\x02\x24\x06\uffff\x0f\x24\x0d\uffff\x09\x24\x01\x77\x05"+
        "\x24\x02\uffff\x01\x24\x01\x7f\x02\x24\x01\u0082\x04\x24\x01\uffff"+
        "\x04\x24\x01\u008b\x01\uffff\x01\x24\x01\uffff\x02\x24\x01\uffff"+
        "\x01\u0090\x02\x24\x01\u0093\x01\u0094\x03\x24\x02\uffff\x02\x24"+
        "\x01\u009b\x01\uffff\x01\x24\x01\u009d\x03\uffff\x01\u009e\x01\u009f"+
        "\x01\uffff\x01\x24\x01\u00a1\x01\uffff\x01\x24\x05\uffff\x01\u00a3"+
        "\x01\uffff";
    const string DFA22_eofS =
        "\u00a4\uffff";
    const string DFA22_minS =
        "\x01\x09\x01\x63\x01\x69\x01\x28\x01\uffff\x01\x2e\x01\uffff\x01"+
        "\x65\x01\x61\x01\x68\x01\x72\x02\uffff\x01\x3e\x01\uffff\x01\x3a"+
        "\x01\uffff\x01\x65\x04\uffff\x01\x61\x01\x3d\x03\uffff\x01\x2a\x01"+
        "\x00\x06\uffff\x01\x70\x02\uffff\x01\x6f\x01\x61\x01\x6e\x04\uffff"+
        "\x01\x78\x01\x72\x01\x69\x01\x62\x01\x65\x01\x72\x01\x6b\x01\x61"+
        "\x04\uffff\x02\x74\x04\uffff\x02\x00\x01\x74\x01\x70\x01\x67\x01"+
        "\x61\x01\x65\x01\x73\x01\x74\x01\x76\x01\x6c\x01\x65\x01\x6f\x01"+
        "\x65\x01\x6d\x01\x75\x01\x63\x0b\x00\x02\uffff\x01\x69\x01\x65\x01"+
        "\x6d\x01\x6c\x01\x72\x02\x65\x01\x61\x01\x69\x01\x30\x01\x77\x01"+
        "\x6e\x01\x6d\x01\x72\x01\x68\x01\x00\x01\uffff\x01\x6f\x01\x30\x01"+
        "\x65\x01\x6c\x01\x30\x01\x72\x01\x63\x01\x74\x01\x63\x01\uffff\x02"+
        "\x73\x01\x61\x01\x6e\x01\x30\x01\x00\x01\x6e\x01\uffff\x01\x6e\x01"+
        "\x79\x01\uffff\x01\x30\x01\x74\x01\x65\x02\x30\x01\x09\x01\x72\x01"+
        "\x73\x01\uffff\x01\x00\x01\x73\x01\x74\x01\x30\x01\uffff\x01\x65"+
        "\x01\x30\x03\uffff\x02\x30\x01\x00\x01\x09\x01\x30\x01\uffff\x01"+
        "\x64\x05\uffff\x01\x30\x01\uffff";
    const string DFA22_maxS =
        "\x01\x7e\x01\x63\x01\x72\x01\x28\x01\uffff\x01\x2e\x01\uffff\x01"+
        "\x65\x01\x75\x02\x72\x02\uffff\x01\x3e\x01\uffff\x01\x3a\x01\uffff"+
        "\x01\x65\x04\uffff\x01\x61\x01\x3d\x03\uffff\x01\x2f\x01\ufffe\x06"+
        "\uffff\x01\x70\x02\uffff\x01\x6f\x01\x61\x01\x6e\x04\uffff\x01\x78"+
        "\x01\x72\x01\x6f\x01\x62\x01\x65\x01\x72\x01\x6b\x01\x61\x04\uffff"+
        "\x02\x74\x04\uffff\x02\ufffe\x01\x74\x01\x70\x01\x67\x01\x61\x01"+
        "\x65\x01\x73\x01\x74\x01\x76\x01\x6c\x01\x65\x01\x6f\x01\x65\x01"+
        "\x6d\x01\x75\x01\x63\x0b\ufffe\x02\uffff\x01\x69\x01\x65\x01\x6d"+
        "\x01\x6c\x01\x72\x02\x65\x01\x61\x01\x69\x01\x7a\x01\x77\x01\x6e"+
        "\x01\x6d\x01\x72\x01\x68\x01\ufffe\x01\uffff\x01\x6f\x01\x7a\x01"+
        "\x65\x01\x6c\x01\x7a\x01\x72\x01\x63\x01\x74\x01\x63\x01\uffff\x02"+
        "\x73\x01\x61\x01\x6e\x01\x7a\x01\ufffe\x01\x6e\x01\uffff\x01\x6e"+
        "\x01\x79\x01\uffff\x01\x7a\x01\x74\x01\x65\x02\x7a\x01\x7b\x01\x72"+
        "\x01\x73\x01\uffff\x01\ufffe\x01\x73\x01\x74\x01\x7a\x01\uffff\x01"+
        "\x65\x01\x7a\x03\uffff\x02\x7a\x01\ufffe\x01\x7b\x01\x7a\x01\uffff"+
        "\x01\x64\x05\uffff\x01\x7a\x01\uffff";
    const string DFA22_acceptS =
        "\x04\uffff\x01\x05\x01\uffff\x01\x07\x04\uffff\x01\x0c\x01\x0d\x01"+
        "\uffff\x01\x0f\x01\uffff\x01\x11\x01\uffff\x01\x18\x01\x19\x01\x1a"+
        "\x01\x1b\x02\uffff\x01\x20\x01\x21\x01\x24\x02\uffff\x01\x29\x01"+
        "\x2a\x01\x2b\x01\x2c\x01\x2d\x01\x2e\x01\uffff\x01\x2f\x01\x32\x03"+
        "\uffff\x01\x03\x01\x04\x01\x06\x01\x23\x08\uffff\x01\x1f\x01\x0e"+
        "\x01\x10\x01\x16\x02\uffff\x01\x1e\x01\x22\x01\x25\x01\x26\x1c\uffff"+
        "\x01\x28\x01\x27\x10\uffff\x01\x27\x09\uffff\x01\x0a\x07\uffff\x01"+
        "\x01\x02\uffff\x01\x08\x08\uffff\x01\x1c\x04\uffff\x01\x09\x02\uffff"+
        "\x01\x13\x01\x17\x01\x31\x05\uffff\x01\x1d\x01\uffff\x01\x14\x01"+
        "\x0b\x01\x15\x01\x30\x01\x02\x01\uffff\x01\x12";
    const string DFA22_specialS =
        "\u00a4\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x02\x25\x02\uffff\x01\x25\x12\uffff\x01\x25\x01\x04\x01\x1d"+
            "\x01\uffff\x01\x1a\x02\uffff\x01\x1c\x01\x13\x01\x15\x01\x10"+
            "\x01\x17\x01\x12\x01\x06\x01\x05\x01\x1b\x0a\x1f\x01\x0f\x01"+
            "\x0b\x01\x1e\x01\x0d\x01\uffff\x01\x19\x01\x0e\x1a\x22\x01\x20"+
            "\x02\uffff\x01\x03\x02\uffff\x02\x24\x01\x16\x02\x24\x01\x02"+
            "\x01\x0a\x04\x24\x01\x07\x02\x24\x01\x23\x01\x08\x01\x24\x01"+
            "\x11\x01\x01\x01\x09\x06\x24\x01\x21\x01\x14\x01\x0c\x01\x18",
            "\x01\x26",
            "\x01\x28\x08\uffff\x01\x27",
            "\x01\x29",
            "",
            "\x01\x2b",
            "",
            "\x01\x2d",
            "\x01\x2e\x10\uffff\x01\x2f\x02\uffff\x01\x30",
            "\x01\x32\x06\uffff\x01\x33\x02\uffff\x01\x31",
            "\x01\x34",
            "",
            "",
            "\x01\x35",
            "",
            "\x01\x37",
            "",
            "\x01\x39",
            "",
            "",
            "",
            "",
            "\x01\x3a",
            "\x01\x3b",
            "",
            "",
            "",
            "\x01\x3e\x04\uffff\x01\x3d",
            "\x27\x40\x01\uffff\x34\x40\x01\x3f\uffa2\x40",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x41",
            "",
            "",
            "\x01\x42",
            "\x01\x43",
            "\x01\x44",
            "",
            "",
            "",
            "",
            "\x01\x45",
            "\x01\x46",
            "\x01\x48\x05\uffff\x01\x47",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "",
            "",
            "",
            "",
            "\x01\x4e",
            "\x01\x4f",
            "",
            "",
            "",
            "",
            "\x22\x5a\x01\x55\x04\x5a\x01\x56\x16\x5a\x01\x58\x1d\x5a\x01"+
            "\x57\x05\x5a\x01\x53\x03\x5a\x01\x54\x07\x5a\x01\x50\x03\x5a"+
            "\x01\x51\x01\x5a\x01\x52\x01\x59\uff89\x5a",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x27\x5b\x01\x5c\x08\x5b\x0a\x6c\x07\x5b\x06\x6c\x1a\x5b\x06"+
            "\x6c\uff98\x5b",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "",
            "",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x30\x5b\x0a\x7d\x07\x5b\x06\x7d\x1a\x5b\x06\x7d\uff98\x5b",
            "",
            "\x01\x7e",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0080",
            "\x01\u0081",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0083",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x30\x5b\x0a\u008c\x07\x5b\x06\u008c\x1a\x5b\x06\u008c\uff98"+
            "\x5b",
            "\x01\u008d",
            "",
            "\x01\u008e",
            "\x01\u008f",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0091",
            "\x01\u0092",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x02\u0095\x02\uffff\x01\u0095\x12\uffff\x01\u0095\x0e\uffff"+
            "\x01\u0095\x4b\uffff\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "",
            "\x30\x5b\x0a\u0098\x07\x5b\x06\u0098\x1a\x5b\x06\u0098\uff98"+
            "\x5b",
            "\x01\u0099",
            "\x01\u009a",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "\x01\u009c",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x27\x5b\x01\x5c\uffd7\x5b",
            "\x02\u00a0\x02\uffff\x01\u00a0\x12\uffff\x01\u00a0\x0e\uffff"+
            "\x01\u00a0\x4b\uffff\x01\u00a0",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "\x01\u00a2",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            ""
    };

    static readonly short[] DFA22_eot = DFA.UnpackEncodedString(DFA22_eotS);
    static readonly short[] DFA22_eof = DFA.UnpackEncodedString(DFA22_eofS);
    static readonly char[] DFA22_min = DFA.UnpackEncodedStringToUnsignedChars(DFA22_minS);
    static readonly char[] DFA22_max = DFA.UnpackEncodedStringToUnsignedChars(DFA22_maxS);
    static readonly short[] DFA22_accept = DFA.UnpackEncodedString(DFA22_acceptS);
    static readonly short[] DFA22_special = DFA.UnpackEncodedString(DFA22_specialS);
    static readonly short[][] DFA22_transition = DFA.UnpackEncodedStringArray(DFA22_transitionS);

    protected class DFA22 : DFA
    {
        public DFA22(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( SCOPE | FRAGMENT | TREE_BEGIN | ROOT | BANG | RANGE | REWRITE | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | SL_COMMENT | ML_COMMENT | CHAR_LITERAL | STRING_LITERAL | DOUBLE_QUOTE_STRING_LITERAL | DOUBLE_ANGLE_STRING_LITERAL | INT | ARG_ACTION | ACTION | TOKEN_REF | RULE_REF | OPTIONS | TOKENS | WS );"; }
        }

    }

 
    
}
