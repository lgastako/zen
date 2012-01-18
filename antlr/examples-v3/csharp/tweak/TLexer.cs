// $ANTLR 3.1b1 T.g 2008-04-08 14:00:52

using System;
using Antlr.Runtime;
using Antlr.Runtime.Debug;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class TLexer : Lexer 
{
    public const int T__7 = 7;
    public const int T__12 = 12;
    public const int INT = 5;
    public const int T__8 = 8;
    public const int WS = 6;
    public const int EOF = -1;
    public const int T__13 = 13;
    public const int T__10 = 10;
    public const int T__9 = 9;
    public const int T__14 = 14;
    public const int T__11 = 11;
    public const int T__15 = 15;
    public const int ID = 4;

    // delegates
    // delegators

    public TLexer() 
    {
		InitializeCyclicDFAs();
    }
    public TLexer(ICharStream input)
		: this(input, null) {
    }
    public TLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "T.g";} 
    }

    // $ANTLR start T__7 
    public void mT__7() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__7;
            // T.g:7:6: ( 'method' )
            // T.g:7:8: 'method'
            {
            	Match("method"); 


            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__7

    // $ANTLR start T__8 
    public void mT__8() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__8;
            // T.g:8:6: ( '(' )
            // T.g:8:8: '('
            {
            	Match('('); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__8

    // $ANTLR start T__9 
    public void mT__9() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__9;
            // T.g:9:6: ( ')' )
            // T.g:9:8: ')'
            {
            	Match(')'); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__9

    // $ANTLR start T__10 
    public void mT__10() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__10;
            // T.g:10:7: ( '{' )
            // T.g:10:9: '{'
            {
            	Match('{'); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__10

    // $ANTLR start T__11 
    public void mT__11() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__11;
            // T.g:11:7: ( '}' )
            // T.g:11:9: '}'
            {
            	Match('}'); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__11

    // $ANTLR start T__12 
    public void mT__12() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__12;
            // T.g:12:7: ( '=' )
            // T.g:12:9: '='
            {
            	Match('='); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__12

    // $ANTLR start T__13 
    public void mT__13() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__13;
            // T.g:13:7: ( ';' )
            // T.g:13:9: ';'
            {
            	Match(';'); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__13

    // $ANTLR start T__14 
    public void mT__14() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__14;
            // T.g:14:7: ( '+' )
            // T.g:14:9: '+'
            {
            	Match('+'); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__14

    // $ANTLR start T__15 
    public void mT__15() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = T__15;
            // T.g:15:7: ( '*' )
            // T.g:15:9: '*'
            {
            	Match('*'); 

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end T__15

    // $ANTLR start ID 
    public void mID() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ID;
            // T.g:77:5: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // T.g:77:9: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// T.g:77:9: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // T.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ID

    // $ANTLR start INT 
    public void mINT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = INT;
            // T.g:79:5: ( ( '0' .. '9' )+ )
            // T.g:79:9: ( '0' .. '9' )+
            {
            	// T.g:79:9: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);
            	    
            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }
            	    
            	
            	    switch (alt2) 
            		{
            			case 1 :
            			    // T.g:79:10: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee =
            		                new EarlyExitException(2, input);
            		            throw eee;
            	    }
            	    cnt2++;
            	} while (true);
            	
            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements


            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end INT

    // $ANTLR start WS 
    public void mWS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WS;
            // T.g:81:5: ( ( ' ' | '\\t' | '\\n' )+ )
            // T.g:81:9: ( ' ' | '\\t' | '\\n' )+
            {
            	// T.g:81:9: ( ' ' | '\\t' | '\\n' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);
            	    
            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }
            	    
            	
            	    switch (alt3) 
            		{
            			case 1 :
            			    // T.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == ' ' ) 
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
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee =
            		                new EarlyExitException(3, input);
            		            throw eee;
            	    }
            	    cnt3++;
            	} while (true);
            	
            	loop3:
            		;	// Stops C# compiler whinging that label 'loop3' has no statements

            	state.channel=HIDDEN;

            
            }
    
            state.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WS

    override public void mTokens() // throws RecognitionException 
    {
        // T.g:1:8: ( T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | ID | INT | WS )
        int alt4 = 12;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // T.g:1:10: T__7
                {
                	mT__7(); 

                
                }
                break;
            case 2 :
                // T.g:1:15: T__8
                {
                	mT__8(); 

                
                }
                break;
            case 3 :
                // T.g:1:20: T__9
                {
                	mT__9(); 

                
                }
                break;
            case 4 :
                // T.g:1:25: T__10
                {
                	mT__10(); 

                
                }
                break;
            case 5 :
                // T.g:1:31: T__11
                {
                	mT__11(); 

                
                }
                break;
            case 6 :
                // T.g:1:37: T__12
                {
                	mT__12(); 

                
                }
                break;
            case 7 :
                // T.g:1:43: T__13
                {
                	mT__13(); 

                
                }
                break;
            case 8 :
                // T.g:1:49: T__14
                {
                	mT__14(); 

                
                }
                break;
            case 9 :
                // T.g:1:55: T__15
                {
                	mT__15(); 

                
                }
                break;
            case 10 :
                // T.g:1:61: ID
                {
                	mID(); 

                
                }
                break;
            case 11 :
                // T.g:1:64: INT
                {
                	mINT(); 

                
                }
                break;
            case 12 :
                // T.g:1:68: WS
                {
                	mWS(); 

                
                }
                break;
        
        }
    
    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	}

    static readonly short[] DFA4_eot = {
        -1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 10, 10, 
        10, 18, -1
        };
    static readonly short[] DFA4_eof = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1
        };
    static readonly int[] DFA4_min = {
        9, 101, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 116, 104, 111, 100, 65, 
        0
        };
    static readonly int[] DFA4_max = {
        125, 101, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 116, 104, 111, 100, 122, 
        0
        };
    static readonly short[] DFA4_accept = {
        -1, -1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, -1, -1, -1, -1, -1, 
        1
        };
    static readonly short[] DFA4_special = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
        -1, -1, -1
        };
    
    static readonly short[] dfa4_transition_null = null;

    static readonly short[] dfa4_transition0 = {
    	15
    	};
    static readonly short[] dfa4_transition1 = {
    	12, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, 12, -1, -1, -1, -1, -1, -1, -1, 2, 3, 9, 
    	    8, -1, -1, -1, -1, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, -1, 
    	    7, -1, 6, -1, -1, -1, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 
    	    10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, -1, 
    	    -1, -1, -1, -1, -1, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 
    	    10, 1, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 4, -1, 
    	    5
    	};
    static readonly short[] dfa4_transition2 = {
    	16
    	};
    static readonly short[] dfa4_transition3 = {
    	13
    	};
    static readonly short[] dfa4_transition4 = {
    	17
    	};
    static readonly short[] dfa4_transition5 = {
    	10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 
    	    10, 10, 10, 10, 10, 10, 10, 10, 10, -1, -1, -1, -1, -1, -1, 10, 
    	    10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 
    	    10, 10, 10, 10, 10, 10, 10, 10, 10
    	};
    static readonly short[] dfa4_transition6 = {
    	14
    	};
    
    static readonly short[][] DFA4_transition = {
    	dfa4_transition1,
    	dfa4_transition3,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition_null,
    	dfa4_transition6,
    	dfa4_transition0,
    	dfa4_transition2,
    	dfa4_transition4,
    	dfa4_transition5,
    	dfa4_transition_null
        };
    
    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer) : this(recognizer, null)
        {
        }
    
        public DFA4(BaseRecognizer recognizer, IDebugEventListener dbg) 
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept     = DFA4_accept;
            this.special    = DFA4_special;
            this.transition = DFA4_transition;
        }
    
        override public string Description
        {
            get { return "1:1: Tokens : ( T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | ID | INT | WS );"; }
        }
    
    }
    
 
    
}
