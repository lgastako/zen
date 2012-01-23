// $ANTLR 3.4 /Users/administrator/src/zen/src/main/antlr/Zen2.g 2012-01-18 15:30:14

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;
@SuppressWarnings({"all", "warnings", "unchecked"})
public class Zen2Parser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "DIV", "MINUS", "MULT", "NUMBER", "PLUS", "WHITESPACE"
    };

    public static final int EOF=-1;
    public static final int DIV=4;
    public static final int MINUS=5;
    public static final int MULT=6;
    public static final int NUMBER=7;
    public static final int PLUS=8;
    public static final int WHITESPACE=9;

    // delegates
    public Parser[] getDelegates() {
        return new Parser[] {};
    }

    // delegators


public static final String[] ruleNames = new String[] {
    "invalidRule", "term", "expr", "factor"
};

public static final boolean[] decisionCanBacktrack = new boolean[] {
    false, // invalid decision
    false, false
};

 
    public int ruleLevel = 0;
    public int getRuleLevel() { return ruleLevel; }
    public void incRuleLevel() { ruleLevel++; }
    public void decRuleLevel() { ruleLevel--; }
    public Zen2Parser(TokenStream input) {
        this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState());
    }
    public Zen2Parser(TokenStream input, int port, RecognizerSharedState state) {
        super(input, state);
        DebugEventSocketProxy proxy =
            new DebugEventSocketProxy(this, port, null);

        setDebugListener(proxy);
        try {
            proxy.handshake();
        }
        catch (IOException ioe) {
            reportError(ioe);
        }
    }

public Zen2Parser(TokenStream input, DebugEventListener dbg) {
    super(input, dbg, new RecognizerSharedState());
}

protected boolean evalPredicate(boolean result, String predicate) {
    dbg.semanticPredicate(result, predicate);
    return result;
}

    public String[] getTokenNames() { return Zen2Parser.tokenNames; }
    public String getGrammarFileName() { return "/Users/administrator/src/zen/src/main/antlr/Zen2.g"; }



    // $ANTLR start "expr"
    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:4:1: expr : term ( ( PLUS | MINUS ) term )* ;
    public final void expr() throws RecognitionException {
        try { dbg.enterRule(getGrammarFileName(), "expr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(4, 0);

        try {
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:4:9: ( term ( ( PLUS | MINUS ) term )* )
            dbg.enterAlt(1);

            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:4:11: term ( ( PLUS | MINUS ) term )*
            {
            dbg.location(4,11);
            pushFollow(FOLLOW_term_in_expr15);
            term();

            state._fsp--;

            dbg.location(4,16);
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:4:16: ( ( PLUS | MINUS ) term )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1, decisionCanBacktrack[1]);

                int LA1_0 = input.LA(1);

                if ( (LA1_0==MINUS||LA1_0==PLUS) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:4:18: ( PLUS | MINUS ) term
            	    {
            	    dbg.location(4,18);
            	    if ( input.LA(1)==MINUS||input.LA(1)==PLUS ) {
            	        input.consume();
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        dbg.recognitionException(mse);
            	        throw mse;
            	    }

            	    dbg.location(4,36);
            	    pushFollow(FOLLOW_term_in_expr30);
            	    term();

            	    state._fsp--;


            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);
            } finally {dbg.exitSubRule(1);}


            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }

        finally {
        	// do for sure before leaving
        }
        dbg.location(4, 43);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "expr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return ;
    }
    // $ANTLR end "expr"



    // $ANTLR start "term"
    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:5:1: term : factor ( ( MULT | DIV ) factor )* ;
    public final void term() throws RecognitionException {
        try { dbg.enterRule(getGrammarFileName(), "term");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(5, 0);

        try {
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:5:9: ( factor ( ( MULT | DIV ) factor )* )
            dbg.enterAlt(1);

            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:5:11: factor ( ( MULT | DIV ) factor )*
            {
            dbg.location(5,11);
            pushFollow(FOLLOW_factor_in_term44);
            factor();

            state._fsp--;

            dbg.location(5,18);
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:5:18: ( ( MULT | DIV ) factor )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=2;
                try { dbg.enterDecision(2, decisionCanBacktrack[2]);

                int LA2_0 = input.LA(1);

                if ( (LA2_0==DIV||LA2_0==MULT) ) {
                    alt2=1;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:5:20: ( MULT | DIV ) factor
            	    {
            	    dbg.location(5,20);
            	    if ( input.LA(1)==DIV||input.LA(1)==MULT ) {
            	        input.consume();
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        dbg.recognitionException(mse);
            	        throw mse;
            	    }

            	    dbg.location(5,35);
            	    pushFollow(FOLLOW_factor_in_term58);
            	    factor();

            	    state._fsp--;


            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);
            } finally {dbg.exitSubRule(2);}


            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }

        finally {
        	// do for sure before leaving
        }
        dbg.location(5, 44);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "term");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return ;
    }
    // $ANTLR end "term"



    // $ANTLR start "factor"
    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:6:1: factor : NUMBER ;
    public final void factor() throws RecognitionException {
        try { dbg.enterRule(getGrammarFileName(), "factor");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(6, 0);

        try {
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:6:9: ( NUMBER )
            dbg.enterAlt(1);

            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:6:11: NUMBER
            {
            dbg.location(6,11);
            match(input,NUMBER,FOLLOW_NUMBER_in_factor70); 

            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }

        finally {
        	// do for sure before leaving
        }
        dbg.location(6, 17);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "factor");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return ;
    }
    // $ANTLR end "factor"

    // Delegated rules


 

    public static final BitSet FOLLOW_term_in_expr15 = new BitSet(new long[]{0x0000000000000122L});
    public static final BitSet FOLLOW_set_in_expr19 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_term_in_expr30 = new BitSet(new long[]{0x0000000000000122L});
    public static final BitSet FOLLOW_factor_in_term44 = new BitSet(new long[]{0x0000000000000052L});
    public static final BitSet FOLLOW_set_in_term48 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_factor_in_term58 = new BitSet(new long[]{0x0000000000000052L});
    public static final BitSet FOLLOW_NUMBER_in_factor70 = new BitSet(new long[]{0x0000000000000002L});

}