// $ANTLR 3.1b1 T.g 2008-04-08 14:00:51

using Hashtable			= System.Collections.Hashtable;
using IDictionary		= System.Collections.IDictionary;
using DictionaryEntry	= System.Collections.DictionaryEntry;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Debug;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



/** Convert the simple input to be java code; wrap in a class,
 *  convert method with "public void", add decls.  This shows how to insert
 *  extra text into a stream of tokens and how to replace a token
 *  with some text.  Calling toString() on the TokenRewriteStream
 *  in Main will print out the original input stream.
 *
 *  Note that you can do the instructions in any order as the
 *  rewrite instructions just get queued up and executed upon toString().
 */
public class TParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ID", 
		"INT", 
		"WS", 
		"'method'", 
		"'('", 
		"')'", 
		"'{'", 
		"'}'", 
		"'='", 
		"';'", 
		"'+'", 
		"'*'"
    };

    public const int T__7 = 7;
    public const int T__12 = 12;
    public const int INT = 5;
    public const int T__8 = 8;
    public const int WS = 6;
    public const int EOF = -1;
    public const int T__13 = 13;
    public const int T__10 = 10;
    public const int T__14 = 14;
    public const int T__9 = 9;
    public const int T__11 = 11;
    public const int T__15 = 15;
    public const int ID = 4;

    // delegates
    // delegators

    
    
        public TParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }
    
        public TParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
        }
        

    override public string[] TokenNames {
		get { return TParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "T.g"; }
    }

    
    TokenRewriteStream tokens; // avoid typecasts all over


    
    // $ANTLR start program
    // T.g:26:1: program : ( method )+ ;
    public void program() // throws RecognitionException [1]
    {   
        TParser.method_return method1 = null;
        
    
        
            tokens = (TokenRewriteStream)input; 
            IToken start = input.LT(1);
    
        try 
    	{
            // T.g:31:5: ( ( method )+ )
            // T.g:31:9: ( method )+
            {
            	// T.g:31:9: ( method )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( (LA1_0 == 7) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // T.g:31:9: method
            			    {
            			    	PushFollow(FOLLOW_method_in_program46);
            			    	method1 = method();
            			    	state.followingStackPointer--;


            			    
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

            	
            	        tokens.InsertBefore(start,"public class Wrapper {\n");
            	        // note the reference to the last token matched for method:
            	        tokens.InsertAfter(((method1 != null) ? ((IToken)method1.stop) : null), "\n}\n");
            	        

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end program

    public class method_return : ParserRuleReturnScope 
    {
    };
    
    // $ANTLR start method
    // T.g:39:1: method : m= 'method' ID '(' ')' body ;
    public TParser.method_return method() // throws RecognitionException [1]
    {   
        TParser.method_return retval = new TParser.method_return();
        retval.start = input.LT(1);
    
        IToken m = null;
    
        try 
    	{
            // T.g:40:5: (m= 'method' ID '(' ')' body )
            // T.g:40:9: m= 'method' ID '(' ')' body
            {
            	m = (IToken)input.LT(1);
            	Match(input,7,FOLLOW_7_in_method78); 
            	Match(input,ID,FOLLOW_ID_in_method80); 
            	Match(input,8,FOLLOW_8_in_method82); 
            	Match(input,9,FOLLOW_9_in_method84); 
            	PushFollow(FOLLOW_body_in_method86);
            	body();
            	state.followingStackPointer--;

            	tokens.Replace(m, "public void");

            
            }
    
            retval.stop = input.LT(-1);
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end method

    
    // $ANTLR start body
    // T.g:44:1: body : lcurly= '{' ( stat )* '}' ;
    public void body() // throws RecognitionException [1]
    {   
        body_stack.Push(new body_scope());
        IToken lcurly = null;
    
        
            $body::decls = new Hashtable();
    
        try 
    	{
            // T.g:55:5: (lcurly= '{' ( stat )* '}' )
            // T.g:55:9: lcurly= '{' ( stat )* '}'
            {
            	lcurly = (IToken)input.LT(1);
            	Match(input,10,FOLLOW_10_in_body127); 
            	// T.g:55:20: ( stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);
            	    
            	    if ( (LA2_0 == ID) )
            	    {
            	        alt2 = 1;
            	    }
            	    
            	
            	    switch (alt2) 
            		{
            			case 1 :
            			    // T.g:55:20: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_body129);
            			    	stat();
            			    	state.followingStackPointer--;


            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop2;
            	    }
            	} while (true);
            	
            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	Match(input,11,FOLLOW_11_in_body132); 
            	
            	        // dump declarations for all identifiers seen in statement list
            	        foreach(DictionaryEntry e in $body::decls) {
            	            tokens.InsertAfter(lcurly, "\nint "+e.Value+";");
            	        }
            	        

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            body_stack.Pop();
        }
        return ;
    }
    // $ANTLR end body

    
    // $ANTLR start stat
    // T.g:64:1: stat : ID '=' expr ';' ;
    public void stat() // throws RecognitionException [1]
    {   
        IToken ID2 = null;
    
        try 
    	{
            // T.g:64:5: ( ID '=' expr ';' )
            // T.g:64:9: ID '=' expr ';'
            {
            	ID2 = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_stat156); 
            	Match(input,12,FOLLOW_12_in_stat158); 
            	PushFollow(FOLLOW_expr_in_stat160);
            	expr();
            	state.followingStackPointer--;

            	Match(input,13,FOLLOW_13_in_stat162); 
            	$body::decls[ID2.Text] = ID2.Text;

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end stat

    
    // $ANTLR start expr
    // T.g:67:1: expr : mul ( '+' mul )* ;
    public void expr() // throws RecognitionException [1]
    {   
        try 
    	{
            // T.g:67:5: ( mul ( '+' mul )* )
            // T.g:67:9: mul ( '+' mul )*
            {
            	PushFollow(FOLLOW_mul_in_expr179);
            	mul();
            	state.followingStackPointer--;

            	// T.g:67:13: ( '+' mul )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);
            	    
            	    if ( (LA3_0 == 14) )
            	    {
            	        alt3 = 1;
            	    }
            	    
            	
            	    switch (alt3) 
            		{
            			case 1 :
            			    // T.g:67:14: '+' mul
            			    {
            			    	Match(input,14,FOLLOW_14_in_expr182); 
            			    	PushFollow(FOLLOW_mul_in_expr184);
            			    	mul();
            			    	state.followingStackPointer--;


            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop3;
            	    }
            	} while (true);
            	
            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end expr

    
    // $ANTLR start mul
    // T.g:70:1: mul : atom ( '*' atom )* ;
    public void mul() // throws RecognitionException [1]
    {   
        try 
    	{
            // T.g:70:5: ( atom ( '*' atom )* )
            // T.g:70:9: atom ( '*' atom )*
            {
            	PushFollow(FOLLOW_atom_in_mul202);
            	atom();
            	state.followingStackPointer--;

            	// T.g:70:14: ( '*' atom )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);
            	    
            	    if ( (LA4_0 == 15) )
            	    {
            	        alt4 = 1;
            	    }
            	    
            	
            	    switch (alt4) 
            		{
            			case 1 :
            			    // T.g:70:15: '*' atom
            			    {
            			    	Match(input,15,FOLLOW_15_in_mul205); 
            			    	PushFollow(FOLLOW_atom_in_mul207);
            			    	atom();
            			    	state.followingStackPointer--;


            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop4;
            	    }
            	} while (true);
            	
            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end mul

    
    // $ANTLR start atom
    // T.g:73:1: atom : ( ID | INT );
    public void atom() // throws RecognitionException [1]
    {   
        try 
    	{
            // T.g:73:5: ( ID | INT )
            // T.g:
            {
            	if ( (input.LA(1) >= ID && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end atom

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_method_in_program46 = new BitSet(new ulong[]{0x0000000000000082UL});
    public static readonly BitSet FOLLOW_7_in_method78 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_method80 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_8_in_method82 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_9_in_method84 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_body_in_method86 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_10_in_body127 = new BitSet(new ulong[]{0x0000000000000810UL});
    public static readonly BitSet FOLLOW_stat_in_body129 = new BitSet(new ulong[]{0x0000000000000810UL});
    public static readonly BitSet FOLLOW_11_in_body132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat156 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_stat158 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_expr_in_stat160 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_stat162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mul_in_expr179 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_14_in_expr182 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_mul_in_expr184 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_atom_in_mul202 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_15_in_mul205 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_atom_in_mul207 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_set_in_atom0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
