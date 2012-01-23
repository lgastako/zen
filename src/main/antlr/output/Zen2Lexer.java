// $ANTLR 3.4 /Users/administrator/src/zen/src/main/antlr/Zen2.g 2012-01-18 15:30:14

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked"})
public class Zen2Lexer extends Lexer {
    public static final int EOF=-1;
    public static final int DIV=4;
    public static final int MINUS=5;
    public static final int MULT=6;
    public static final int NUMBER=7;
    public static final int PLUS=8;
    public static final int WHITESPACE=9;

    // delegates
    // delegators
    public Lexer[] getDelegates() {
        return new Lexer[] {};
    }

    public Zen2Lexer() {} 
    public Zen2Lexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public Zen2Lexer(CharStream input, RecognizerSharedState state) {
        super(input,state);
    }
    public String getGrammarFileName() { return "/Users/administrator/src/zen/src/main/antlr/Zen2.g"; }

    // $ANTLR start "WHITESPACE"
    public final void mWHITESPACE() throws RecognitionException {
        try {
            int _type = WHITESPACE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:8:12: ( ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+ )
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:8:15: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
            {
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:8:15: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
            int cnt1=0;
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0 >= '\t' && LA1_0 <= '\n')||(LA1_0 >= '\f' && LA1_0 <= '\r')||LA1_0==' ') ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:
            	    {
            	    if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n')||(input.LA(1) >= '\f' && input.LA(1) <= '\r')||input.LA(1)==' ' ) {
            	        input.consume();
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;
            	    }


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


             _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "NUMBER"
    public final void mNUMBER() throws RecognitionException {
        try {
            int _type = NUMBER;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:10:9: ( ( '0' .. '9' )+ )
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:10:12: ( '0' .. '9' )+
            {
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:10:12: ( '0' .. '9' )+
            int cnt2=0;
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0 >= '0' && LA2_0 <= '9')) ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // /Users/administrator/src/zen/src/main/antlr/Zen2.g:
            	    {
            	    if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) {
            	        input.consume();
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;
            	    }


            	    }
            	    break;

            	default :
            	    if ( cnt2 >= 1 ) break loop2;
                        EarlyExitException eee =
                            new EarlyExitException(2, input);
                        throw eee;
                }
                cnt2++;
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "MULT"
    public final void mMULT() throws RecognitionException {
        try {
            int _type = MULT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:12:7: ( '*' )
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:12:10: '*'
            {
            match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "MULT"

    // $ANTLR start "DIV"
    public final void mDIV() throws RecognitionException {
        try {
            int _type = DIV;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:13:5: ( '/' )
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:13:8: '/'
            {
            match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "MINUS"
    public final void mMINUS() throws RecognitionException {
        try {
            int _type = MINUS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:14:9: ( '-' )
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:14:11: '-'
            {
            match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "PLUS"
    public final void mPLUS() throws RecognitionException {
        try {
            int _type = PLUS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:15:9: ( '+' )
            // /Users/administrator/src/zen/src/main/antlr/Zen2.g:15:12: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "PLUS"

    public void mTokens() throws RecognitionException {
        // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:8: ( WHITESPACE | NUMBER | MULT | DIV | MINUS | PLUS )
        int alt3=6;
        switch ( input.LA(1) ) {
        case '\t':
        case '\n':
        case '\f':
        case '\r':
        case ' ':
            {
            alt3=1;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
            {
            alt3=2;
            }
            break;
        case '*':
            {
            alt3=3;
            }
            break;
        case '/':
            {
            alt3=4;
            }
            break;
        case '-':
            {
            alt3=5;
            }
            break;
        case '+':
            {
            alt3=6;
            }
            break;
        default:
            NoViableAltException nvae =
                new NoViableAltException("", 3, 0, input);

            throw nvae;

        }

        switch (alt3) {
            case 1 :
                // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:10: WHITESPACE
                {
                mWHITESPACE(); 


                }
                break;
            case 2 :
                // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:21: NUMBER
                {
                mNUMBER(); 


                }
                break;
            case 3 :
                // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:28: MULT
                {
                mMULT(); 


                }
                break;
            case 4 :
                // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:33: DIV
                {
                mDIV(); 


                }
                break;
            case 5 :
                // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:37: MINUS
                {
                mMINUS(); 


                }
                break;
            case 6 :
                // /Users/administrator/src/zen/src/main/antlr/Zen2.g:1:43: PLUS
                {
                mPLUS(); 


                }
                break;

        }

    }


 

}