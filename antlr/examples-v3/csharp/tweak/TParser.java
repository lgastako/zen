// $ANTLR 3.1b1 T.g 2008-04-08 14:01:46

using Hashtable			= System.Collections.Hashtable;
using IDictionary		= System.Collections.IDictionary;
using DictionaryEntry	= System.Collections.DictionaryEntry;


import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

/** Convert the simple input to be java code; wrap in a class,
 *  convert method with "public void", add decls.  This shows how to insert
 *  extra text into a stream of tokens and how to replace a token
 *  with some text.  Calling toString() on the TokenRewriteStream
 *  in Main will print out the original input stream.
 *
 *  Note that you can do the instructions in any order as the
 *  rewrite instructions just get queued up and executed upon toString().
 */
public class TParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "ID", "INT", "WS", "'method'", "'('", "')'", "'{'", "'}'", "'='", "';'", "'+'", "'*'"
    };
    public static final int T__7=7;
    public static final int T__12=12;
    public static final int INT=5;
    public static final int T__8=8;
    public static final int WS=6;
    public static final int EOF=-1;
    public static final int T__13=13;
    public static final int T__10=10;
    public static final int T__14=14;
    public static final int T__9=9;
    public static final int T__11=11;
    public static final int T__15=15;
    public static final int ID=4;

    // delegates
    // delegators


        public TParser(TokenStream input) {
            this(input, new RecognizerSharedState());
        }
        public TParser(TokenStream input, RecognizerSharedState state) {
            super(input, state);
        }
        

    public String[] getTokenNames() { return TParser.tokenNames; }
    public String getGrammarFileName() { return "T.g"; }

    
    TokenRewriteStream tokens; // avoid typecasts all over



    // $ANTLR start program
    // T.g:27:1: program : ( method )+ ;
    public final void program() throws RecognitionException {
        TParser.method_return method1 = null;


        
            tokens = (TokenRewriteStream)input; 
            IToken start = input.LT(1);

        try {
            // T.g:32:5: ( ( method )+ )
            // T.g:32:9: ( method )+
            {
            // T.g:32:9: ( method )+
            int cnt1=0;
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( (LA1_0==7) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // T.g:32:9: method
            	    {
            	    pushFollow(FOLLOW_method_in_program47);
            	    method1=method();

            	    state._fsp--;



            	    }
            	    break;

            	default :
            	    if ( cnt1 >= 1 ) break loop1;
                        EarlyExitException eee =
                            new EarlyExitException(1, input);
                        throw eee;
                }
                cnt1++;
            } while (true);

            
                    tokens.InsertBefore(start,"public class Wrapper {\n");
                    // note the reference to the last token matched for method:
                    tokens.InsertAfter((method1!=null?((Token)method1.stop):null), "\n}\n");
                    


            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end program

    public static class method_return extends ParserRuleReturnScope {
    };

    // $ANTLR start method
    // T.g:40:1: method : m= 'method' ID '(' ')' body ;
    public final TParser.method_return method() throws RecognitionException {
        TParser.method_return retval = new TParser.method_return();
        retval.start = input.LT(1);

        Token m=null;

        try {
            // T.g:41:5: (m= 'method' ID '(' ')' body )
            // T.g:41:9: m= 'method' ID '(' ')' body
            {
            m=(Token)input.LT(1);
            match(input,7,FOLLOW_7_in_method79); 
            match(input,ID,FOLLOW_ID_in_method81); 
            match(input,8,FOLLOW_8_in_method83); 
            match(input,9,FOLLOW_9_in_method85); 
            pushFollow(FOLLOW_body_in_method87);
            body();

            state._fsp--;

            tokens.Replace(m, "public void");


            }

            retval.stop = input.LT(-1);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return retval;
    }
    // $ANTLR end method


    // $ANTLR start body
    // T.g:45:1: body : lcurly= '{' ( stat )* '}' ;
    public final void body() throws RecognitionException {
        body_stack.push(new body_scope());
        Token lcurly=null;

        
            $body::decls = new Hashtable();

        try {
            // T.g:56:5: (lcurly= '{' ( stat )* '}' )
            // T.g:56:9: lcurly= '{' ( stat )* '}'
            {
            lcurly=(Token)input.LT(1);
            match(input,10,FOLLOW_10_in_body128); 
            // T.g:56:20: ( stat )*
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( (LA2_0==ID) ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // T.g:56:20: stat
            	    {
            	    pushFollow(FOLLOW_stat_in_body130);
            	    stat();

            	    state._fsp--;



            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);

            match(input,11,FOLLOW_11_in_body133); 
            
                    // dump declarations for all identifiers seen in statement list
                    foreach(DictionaryEntry e in $body::decls) {
                        tokens.InsertAfter(lcurly, "\nint "+e.Value+";");
                    }
                    


            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
            body_stack.pop();
        }
        return ;
    }
    // $ANTLR end body


    // $ANTLR start stat
    // T.g:65:1: stat : ID '=' expr ';' ;
    public final void stat() throws RecognitionException {
        Token ID2=null;

        try {
            // T.g:65:5: ( ID '=' expr ';' )
            // T.g:65:9: ID '=' expr ';'
            {
            ID2=(Token)input.LT(1);
            match(input,ID,FOLLOW_ID_in_stat157); 
            match(input,12,FOLLOW_12_in_stat159); 
            pushFollow(FOLLOW_expr_in_stat161);
            expr();

            state._fsp--;

            match(input,13,FOLLOW_13_in_stat163); 
            $body::decls[ID2.Text] = ID2.Text;


            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end stat


    // $ANTLR start expr
    // T.g:68:1: expr : mul ( '+' mul )* ;
    public final void expr() throws RecognitionException {
        try {
            // T.g:68:5: ( mul ( '+' mul )* )
            // T.g:68:9: mul ( '+' mul )*
            {
            pushFollow(FOLLOW_mul_in_expr180);
            mul();

            state._fsp--;

            // T.g:68:13: ( '+' mul )*
            loop3:
            do {
                int alt3=2;
                int LA3_0 = input.LA(1);

                if ( (LA3_0==14) ) {
                    alt3=1;
                }


                switch (alt3) {
            	case 1 :
            	    // T.g:68:14: '+' mul
            	    {
            	    match(input,14,FOLLOW_14_in_expr183); 
            	    pushFollow(FOLLOW_mul_in_expr185);
            	    mul();

            	    state._fsp--;



            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);



            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end expr


    // $ANTLR start mul
    // T.g:71:1: mul : atom ( '*' atom )* ;
    public final void mul() throws RecognitionException {
        try {
            // T.g:71:5: ( atom ( '*' atom )* )
            // T.g:71:9: atom ( '*' atom )*
            {
            pushFollow(FOLLOW_atom_in_mul203);
            atom();

            state._fsp--;

            // T.g:71:14: ( '*' atom )*
            loop4:
            do {
                int alt4=2;
                int LA4_0 = input.LA(1);

                if ( (LA4_0==15) ) {
                    alt4=1;
                }


                switch (alt4) {
            	case 1 :
            	    // T.g:71:15: '*' atom
            	    {
            	    match(input,15,FOLLOW_15_in_mul206); 
            	    pushFollow(FOLLOW_atom_in_mul208);
            	    atom();

            	    state._fsp--;



            	    }
            	    break;

            	default :
            	    break loop4;
                }
            } while (true);



            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end mul


    // $ANTLR start atom
    // T.g:74:1: atom : ( ID | INT );
    public final void atom() throws RecognitionException {
        try {
            // T.g:74:5: ( ID | INT )
            // T.g:
            {
            if ( (input.LA(1)>=ID && input.LA(1)<=INT) ) {
                input.consume();
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end atom

    // Delegated rules


 

    public static final BitSet FOLLOW_method_in_program47 = new BitSet(new long[]{0x0000000000000082L});
    public static final BitSet FOLLOW_7_in_method79 = new BitSet(new long[]{0x0000000000000010L});
    public static final BitSet FOLLOW_ID_in_method81 = new BitSet(new long[]{0x0000000000000100L});
    public static final BitSet FOLLOW_8_in_method83 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_9_in_method85 = new BitSet(new long[]{0x0000000000000400L});
    public static final BitSet FOLLOW_body_in_method87 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_10_in_body128 = new BitSet(new long[]{0x0000000000000810L});
    public static final BitSet FOLLOW_stat_in_body130 = new BitSet(new long[]{0x0000000000000810L});
    public static final BitSet FOLLOW_11_in_body133 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_stat157 = new BitSet(new long[]{0x0000000000001000L});
    public static final BitSet FOLLOW_12_in_stat159 = new BitSet(new long[]{0x0000000000000030L});
    public static final BitSet FOLLOW_expr_in_stat161 = new BitSet(new long[]{0x0000000000002000L});
    public static final BitSet FOLLOW_13_in_stat163 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mul_in_expr180 = new BitSet(new long[]{0x0000000000004002L});
    public static final BitSet FOLLOW_14_in_expr183 = new BitSet(new long[]{0x0000000000000030L});
    public static final BitSet FOLLOW_mul_in_expr185 = new BitSet(new long[]{0x0000000000004002L});
    public static final BitSet FOLLOW_atom_in_mul203 = new BitSet(new long[]{0x0000000000008002L});
    public static final BitSet FOLLOW_15_in_mul206 = new BitSet(new long[]{0x0000000000000030L});
    public static final BitSet FOLLOW_atom_in_mul208 = new BitSet(new long[]{0x0000000000008002L});
    public static final BitSet FOLLOW_set_in_atom0 = new BitSet(new long[]{0x0000000000000002L});

}