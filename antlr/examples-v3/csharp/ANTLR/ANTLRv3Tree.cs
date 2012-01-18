// $ANTLR 3.1b2 ANTLRv3Tree.g 2008-08-11 12:00:50

using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


/** ANTLR v3 tree grammar to walk trees created by ANTLRv3.g */
public partial class ANTLRv3Tree : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"DOC_COMMENT", 
		"PARSER", 
		"LEXER", 
		"RULE", 
		"BLOCK", 
		"OPTIONAL", 
		"CLOSURE", 
		"POSITIVE_CLOSURE", 
		"SYNPRED", 
		"RANGE", 
		"CHAR_RANGE", 
		"EPSILON", 
		"ALT", 
		"EOR", 
		"EOB", 
		"EOA", 
		"ID", 
		"ARG", 
		"ARGLIST", 
		"RET", 
		"LEXER_GRAMMAR", 
		"PARSER_GRAMMAR", 
		"TREE_GRAMMAR", 
		"COMBINED_GRAMMAR", 
		"INITACTION", 
		"LABEL", 
		"TEMPLATE", 
		"SCOPE", 
		"SEMPRED", 
		"GATED_SEMPRED", 
		"SYN_SEMPRED", 
		"BACKTRACK_SEMPRED", 
		"FRAGMENT", 
		"TREE_BEGIN", 
		"ROOT", 
		"BANG", 
		"REWRITE", 
		"TOKENS", 
		"TOKEN_REF", 
		"STRING_LITERAL", 
		"CHAR_LITERAL", 
		"ACTION", 
		"OPTIONS", 
		"INT", 
		"ARG_ACTION", 
		"RULE_REF", 
		"DOUBLE_QUOTE_STRING_LITERAL", 
		"DOUBLE_ANGLE_STRING_LITERAL", 
		"SRC", 
		"SL_COMMENT", 
		"ML_COMMENT", 
		"LITERAL_CHAR", 
		"ESC", 
		"XDIGIT", 
		"NESTED_ARG_ACTION", 
		"ACTION_STRING_LITERAL", 
		"ACTION_CHAR_LITERAL", 
		"NESTED_ACTION", 
		"ACTION_ESC", 
		"WS_LOOP", 
		"WS", 
		"'lexer'", 
		"'parser'", 
		"'tree'", 
		"'grammar'", 
		"';'", 
		"'}'", 
		"'='", 
		"'@'", 
		"'::'", 
		"'*'", 
		"'protected'", 
		"'public'", 
		"'private'", 
		"'returns'", 
		"':'", 
		"'throws'", 
		"','", 
		"'('", 
		"'|'", 
		"')'", 
		"'catch'", 
		"'finally'", 
		"'+='", 
		"'=>'", 
		"'~'", 
		"'?'", 
		"'+'", 
		"'.'", 
		"'$'"
    };

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



        public ANTLRv3Tree(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public ANTLRv3Tree(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
             
        }
        

    override public string[] TokenNames {
		get { return ANTLRv3Tree.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "ANTLRv3Tree.g"; }
    }



    // $ANTLR start "grammarDef"
    // ANTLRv3Tree.g:39:1: grammarDef : ^( grammarType ID ( DOC_COMMENT )? ( optionsSpec )? ( tokensSpec )? ( attrScope )* ( action )* ( rule )+ ) ;
    public void grammarDef() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:40:5: ( ^( grammarType ID ( DOC_COMMENT )? ( optionsSpec )? ( tokensSpec )? ( attrScope )* ( action )* ( rule )+ ) )
            // ANTLRv3Tree.g:40:9: ^( grammarType ID ( DOC_COMMENT )? ( optionsSpec )? ( tokensSpec )? ( attrScope )* ( action )* ( rule )+ )
            {
            	PushFollow(FOLLOW_grammarType_in_grammarDef52);
            	grammarType();
            	state.followingStackPointer--;


            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_grammarDef54); 
            	// ANTLRv3Tree.g:40:27: ( DOC_COMMENT )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == DOC_COMMENT) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:40:27: DOC_COMMENT
            	        {
            	        	Match(input,DOC_COMMENT,FOLLOW_DOC_COMMENT_in_grammarDef56); 

            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:40:40: ( optionsSpec )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == OPTIONS) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:40:40: optionsSpec
            	        {
            	        	PushFollow(FOLLOW_optionsSpec_in_grammarDef59);
            	        	optionsSpec();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:40:53: ( tokensSpec )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == TOKENS) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:40:53: tokensSpec
            	        {
            	        	PushFollow(FOLLOW_tokensSpec_in_grammarDef62);
            	        	tokensSpec();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:40:65: ( attrScope )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == SCOPE) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:40:65: attrScope
            			    {
            			    	PushFollow(FOLLOW_attrScope_in_grammarDef65);
            			    	attrScope();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	// ANTLRv3Tree.g:40:76: ( action )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == 72) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:40:76: action
            			    {
            			    	PushFollow(FOLLOW_action_in_grammarDef68);
            			    	action();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	// ANTLRv3Tree.g:40:84: ( rule )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == RULE) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:40:84: rule
            			    {
            			    	PushFollow(FOLLOW_rule_in_grammarDef71);
            			    	rule();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee =
            		                new EarlyExitException(6, input);
            		            throw eee;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "grammarDef"


    // $ANTLR start "grammarType"
    // ANTLRv3Tree.g:43:1: grammarType : ( LEXER_GRAMMAR | PARSER_GRAMMAR | TREE_GRAMMAR | COMBINED_GRAMMAR );
    public void grammarType() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:44:2: ( LEXER_GRAMMAR | PARSER_GRAMMAR | TREE_GRAMMAR | COMBINED_GRAMMAR )
            // ANTLRv3Tree.g:
            {
            	if ( (input.LA(1) >= LEXER_GRAMMAR && input.LA(1) <= COMBINED_GRAMMAR) ) 
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
    // $ANTLR end "grammarType"


    // $ANTLR start "tokensSpec"
    // ANTLRv3Tree.g:50:1: tokensSpec : ^( TOKENS ( tokenSpec )+ ) ;
    public void tokensSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:51:2: ( ^( TOKENS ( tokenSpec )+ ) )
            // ANTLRv3Tree.g:51:4: ^( TOKENS ( tokenSpec )+ )
            {
            	Match(input,TOKENS,FOLLOW_TOKENS_in_tokensSpec127); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:51:13: ( tokenSpec )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == TOKEN_REF || LA7_0 == 71) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:51:13: tokenSpec
            			    {
            			    	PushFollow(FOLLOW_tokenSpec_in_tokensSpec129);
            			    	tokenSpec();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee =
            		                new EarlyExitException(7, input);
            		            throw eee;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "tokensSpec"


    // $ANTLR start "tokenSpec"
    // ANTLRv3Tree.g:54:1: tokenSpec : ( ^( '=' TOKEN_REF STRING_LITERAL ) | ^( '=' TOKEN_REF CHAR_LITERAL ) | TOKEN_REF );
    public void tokenSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:55:2: ( ^( '=' TOKEN_REF STRING_LITERAL ) | ^( '=' TOKEN_REF CHAR_LITERAL ) | TOKEN_REF )
            int alt8 = 3;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 71) )
            {
                int LA8_1 = input.LA(2);

                if ( (LA8_1 == DOWN) )
                {
                    int LA8_3 = input.LA(3);

                    if ( (LA8_3 == TOKEN_REF) )
                    {
                        int LA8_4 = input.LA(4);

                        if ( (LA8_4 == STRING_LITERAL) )
                        {
                            alt8 = 1;
                        }
                        else if ( (LA8_4 == CHAR_LITERAL) )
                        {
                            alt8 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d8s4 =
                                new NoViableAltException("", 8, 4, input);

                            throw nvae_d8s4;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d8s3 =
                            new NoViableAltException("", 8, 3, input);

                        throw nvae_d8s3;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d8s1 =
                        new NoViableAltException("", 8, 1, input);

                    throw nvae_d8s1;
                }
            }
            else if ( (LA8_0 == TOKEN_REF) )
            {
                alt8 = 3;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // ANTLRv3Tree.g:55:4: ^( '=' TOKEN_REF STRING_LITERAL )
                    {
                    	Match(input,71,FOLLOW_71_in_tokenSpec143); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_tokenSpec145); 
                    	Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_tokenSpec147); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:56:4: ^( '=' TOKEN_REF CHAR_LITERAL )
                    {
                    	Match(input,71,FOLLOW_71_in_tokenSpec154); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_tokenSpec156); 
                    	Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_tokenSpec158); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:57:4: TOKEN_REF
                    {
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_tokenSpec164); 

                    }
                    break;

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
    // $ANTLR end "tokenSpec"


    // $ANTLR start "attrScope"
    // ANTLRv3Tree.g:60:1: attrScope : ^( 'scope' ID ACTION ) ;
    public void attrScope() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:61:2: ( ^( 'scope' ID ACTION ) )
            // ANTLRv3Tree.g:61:4: ^( 'scope' ID ACTION )
            {
            	Match(input,SCOPE,FOLLOW_SCOPE_in_attrScope176); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_attrScope178); 
            	Match(input,ACTION,FOLLOW_ACTION_in_attrScope180); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "attrScope"


    // $ANTLR start "action"
    // ANTLRv3Tree.g:64:1: action : ( ^( '@' ID ID ACTION ) | ^( '@' ID ACTION ) );
    public void action() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:65:2: ( ^( '@' ID ID ACTION ) | ^( '@' ID ACTION ) )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == 72) )
            {
                int LA9_1 = input.LA(2);

                if ( (LA9_1 == DOWN) )
                {
                    int LA9_2 = input.LA(3);

                    if ( (LA9_2 == ID) )
                    {
                        int LA9_3 = input.LA(4);

                        if ( (LA9_3 == ID) )
                        {
                            alt9 = 1;
                        }
                        else if ( (LA9_3 == ACTION) )
                        {
                            alt9 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d9s3 =
                                new NoViableAltException("", 9, 3, input);

                            throw nvae_d9s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d9s2 =
                            new NoViableAltException("", 9, 2, input);

                        throw nvae_d9s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d9s1 =
                        new NoViableAltException("", 9, 1, input);

                    throw nvae_d9s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // ANTLRv3Tree.g:65:4: ^( '@' ID ID ACTION )
                    {
                    	Match(input,72,FOLLOW_72_in_action193); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_action195); 
                    	Match(input,ID,FOLLOW_ID_in_action197); 
                    	Match(input,ACTION,FOLLOW_ACTION_in_action199); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:66:4: ^( '@' ID ACTION )
                    {
                    	Match(input,72,FOLLOW_72_in_action206); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_action208); 
                    	Match(input,ACTION,FOLLOW_ACTION_in_action210); 

                    	Match(input, Token.UP, null); 

                    }
                    break;

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
    // $ANTLR end "action"


    // $ANTLR start "optionsSpec"
    // ANTLRv3Tree.g:69:1: optionsSpec : ^( OPTIONS ( option )+ ) ;
    public void optionsSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:70:2: ( ^( OPTIONS ( option )+ ) )
            // ANTLRv3Tree.g:70:4: ^( OPTIONS ( option )+ )
            {
            	Match(input,OPTIONS,FOLLOW_OPTIONS_in_optionsSpec223); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:70:14: ( option )+
            	int cnt10 = 0;
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == 71) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:70:14: option
            			    {
            			    	PushFollow(FOLLOW_option_in_optionsSpec225);
            			    	option();
            			    	state.followingStackPointer--;


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


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "optionsSpec"


    // $ANTLR start "option"
    // ANTLRv3Tree.g:73:1: option : ^( '=' ID optionValue ) ;
    public void option() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:74:5: ( ^( '=' ID optionValue ) )
            // ANTLRv3Tree.g:74:9: ^( '=' ID optionValue )
            {
            	Match(input,71,FOLLOW_71_in_option244); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_option246); 
            	PushFollow(FOLLOW_optionValue_in_option248);
            	optionValue();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "option"


    // $ANTLR start "optionValue"
    // ANTLRv3Tree.g:77:1: optionValue : ( ID | STRING_LITERAL | CHAR_LITERAL | INT );
    public void optionValue() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:78:5: ( ID | STRING_LITERAL | CHAR_LITERAL | INT )
            // ANTLRv3Tree.g:
            {
            	if ( input.LA(1) == ID || (input.LA(1) >= STRING_LITERAL && input.LA(1) <= CHAR_LITERAL) || input.LA(1) == INT ) 
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
    // $ANTLR end "optionValue"


    // $ANTLR start "rule"
    // ANTLRv3Tree.g:84:1: rule : ^( RULE ID ( modifier )? ( ^( ARG ARG_ACTION ) )? ( ^( RET ARG_ACTION ) )? ( throwsSpec )? ( optionsSpec )? ( ruleScopeSpec )? ( ruleAction )* altList ( exceptionGroup )? EOR ) ;
    public void rule() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:85:2: ( ^( RULE ID ( modifier )? ( ^( ARG ARG_ACTION ) )? ( ^( RET ARG_ACTION ) )? ( throwsSpec )? ( optionsSpec )? ( ruleScopeSpec )? ( ruleAction )* altList ( exceptionGroup )? EOR ) )
            // ANTLRv3Tree.g:85:4: ^( RULE ID ( modifier )? ( ^( ARG ARG_ACTION ) )? ( ^( RET ARG_ACTION ) )? ( throwsSpec )? ( optionsSpec )? ( ruleScopeSpec )? ( ruleAction )* altList ( exceptionGroup )? EOR )
            {
            	Match(input,RULE,FOLLOW_RULE_in_rule314); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_rule316); 
            	// ANTLRv3Tree.g:85:15: ( modifier )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == FRAGMENT || (LA11_0 >= 75 && LA11_0 <= 77)) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:85:15: modifier
            	        {
            	        	PushFollow(FOLLOW_modifier_in_rule318);
            	        	modifier();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:85:25: ( ^( ARG ARG_ACTION ) )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == ARG) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:85:26: ^( ARG ARG_ACTION )
            	        {
            	        	Match(input,ARG,FOLLOW_ARG_in_rule323); 

            	        	Match(input, Token.DOWN, null); 
            	        	Match(input,ARG_ACTION,FOLLOW_ARG_ACTION_in_rule325); 

            	        	Match(input, Token.UP, null); 

            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:85:46: ( ^( RET ARG_ACTION ) )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == RET) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:85:47: ^( RET ARG_ACTION )
            	        {
            	        	Match(input,RET,FOLLOW_RET_in_rule332); 

            	        	Match(input, Token.DOWN, null); 
            	        	Match(input,ARG_ACTION,FOLLOW_ARG_ACTION_in_rule334); 

            	        	Match(input, Token.UP, null); 

            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:86:9: ( throwsSpec )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 80) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:86:9: throwsSpec
            	        {
            	        	PushFollow(FOLLOW_throwsSpec_in_rule347);
            	        	throwsSpec();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:86:21: ( optionsSpec )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == OPTIONS) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:86:21: optionsSpec
            	        {
            	        	PushFollow(FOLLOW_optionsSpec_in_rule350);
            	        	optionsSpec();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:86:34: ( ruleScopeSpec )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == SCOPE) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:86:34: ruleScopeSpec
            	        {
            	        	PushFollow(FOLLOW_ruleScopeSpec_in_rule353);
            	        	ruleScopeSpec();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:86:49: ( ruleAction )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 72) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:86:49: ruleAction
            			    {
            			    	PushFollow(FOLLOW_ruleAction_in_rule356);
            			    	ruleAction();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	PushFollow(FOLLOW_altList_in_rule367);
            	altList();
            	state.followingStackPointer--;

            	// ANTLRv3Tree.g:88:9: ( exceptionGroup )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( ((LA18_0 >= 85 && LA18_0 <= 86)) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:88:9: exceptionGroup
            	        {
            	        	PushFollow(FOLLOW_exceptionGroup_in_rule377);
            	        	exceptionGroup();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,EOR,FOLLOW_EOR_in_rule380); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rule"


    // $ANTLR start "modifier"
    // ANTLRv3Tree.g:92:1: modifier : ( 'protected' | 'public' | 'private' | 'fragment' );
    public void modifier() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:93:2: ( 'protected' | 'public' | 'private' | 'fragment' )
            // ANTLRv3Tree.g:
            {
            	if ( input.LA(1) == FRAGMENT || (input.LA(1) >= 75 && input.LA(1) <= 77) ) 
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
    // $ANTLR end "modifier"


    // $ANTLR start "ruleAction"
    // ANTLRv3Tree.g:96:1: ruleAction : ^( '@' ID ACTION ) ;
    public void ruleAction() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:98:2: ( ^( '@' ID ACTION ) )
            // ANTLRv3Tree.g:98:4: ^( '@' ID ACTION )
            {
            	Match(input,72,FOLLOW_72_in_ruleAction419); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_ruleAction421); 
            	Match(input,ACTION,FOLLOW_ACTION_in_ruleAction423); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "ruleAction"


    // $ANTLR start "throwsSpec"
    // ANTLRv3Tree.g:101:1: throwsSpec : ^( 'throws' ( ID )+ ) ;
    public void throwsSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:102:2: ( ^( 'throws' ( ID )+ ) )
            // ANTLRv3Tree.g:102:4: ^( 'throws' ( ID )+ )
            {
            	Match(input,80,FOLLOW_80_in_throwsSpec436); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:102:15: ( ID )+
            	int cnt19 = 0;
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == ID) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:102:15: ID
            			    {
            			    	Match(input,ID,FOLLOW_ID_in_throwsSpec438); 

            			    }
            			    break;

            			default:
            			    if ( cnt19 >= 1 ) goto loop19;
            		            EarlyExitException eee =
            		                new EarlyExitException(19, input);
            		            throw eee;
            	    }
            	    cnt19++;
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whinging that label 'loop19' has no statements


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "throwsSpec"


    // $ANTLR start "ruleScopeSpec"
    // ANTLRv3Tree.g:105:1: ruleScopeSpec : ( ^( 'scope' ACTION ) | ^( 'scope' ACTION ( ID )+ ) | ^( 'scope' ( ID )+ ) );
    public void ruleScopeSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:106:2: ( ^( 'scope' ACTION ) | ^( 'scope' ACTION ( ID )+ ) | ^( 'scope' ( ID )+ ) )
            int alt22 = 3;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == SCOPE) )
            {
                int LA22_1 = input.LA(2);

                if ( (LA22_1 == DOWN) )
                {
                    int LA22_2 = input.LA(3);

                    if ( (LA22_2 == ACTION) )
                    {
                        int LA22_3 = input.LA(4);

                        if ( (LA22_3 == UP) )
                        {
                            alt22 = 1;
                        }
                        else if ( (LA22_3 == ID) )
                        {
                            alt22 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d22s3 =
                                new NoViableAltException("", 22, 3, input);

                            throw nvae_d22s3;
                        }
                    }
                    else if ( (LA22_2 == ID) )
                    {
                        alt22 = 3;
                    }
                    else 
                    {
                        NoViableAltException nvae_d22s2 =
                            new NoViableAltException("", 22, 2, input);

                        throw nvae_d22s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d22s1 =
                        new NoViableAltException("", 22, 1, input);

                    throw nvae_d22s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // ANTLRv3Tree.g:106:4: ^( 'scope' ACTION )
                    {
                    	Match(input,SCOPE,FOLLOW_SCOPE_in_ruleScopeSpec452); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ACTION,FOLLOW_ACTION_in_ruleScopeSpec454); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:107:4: ^( 'scope' ACTION ( ID )+ )
                    {
                    	Match(input,SCOPE,FOLLOW_SCOPE_in_ruleScopeSpec461); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ACTION,FOLLOW_ACTION_in_ruleScopeSpec463); 
                    	// ANTLRv3Tree.g:107:21: ( ID )+
                    	int cnt20 = 0;
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);

                    	    if ( (LA20_0 == ID) )
                    	    {
                    	        alt20 = 1;
                    	    }


                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // ANTLRv3Tree.g:107:21: ID
                    			    {
                    			    	Match(input,ID,FOLLOW_ID_in_ruleScopeSpec465); 

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


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:108:4: ^( 'scope' ( ID )+ )
                    {
                    	Match(input,SCOPE,FOLLOW_SCOPE_in_ruleScopeSpec473); 

                    	Match(input, Token.DOWN, null); 
                    	// ANTLRv3Tree.g:108:14: ( ID )+
                    	int cnt21 = 0;
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == ID) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // ANTLRv3Tree.g:108:14: ID
                    			    {
                    			    	Match(input,ID,FOLLOW_ID_in_ruleScopeSpec475); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt21 >= 1 ) goto loop21;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(21, input);
                    		            throw eee;
                    	    }
                    	    cnt21++;
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whinging that label 'loop21' has no statements


                    	Match(input, Token.UP, null); 

                    }
                    break;

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
    // $ANTLR end "ruleScopeSpec"


    // $ANTLR start "block"
    // ANTLRv3Tree.g:111:1: block : ^( BLOCK ( optionsSpec )? ( alternative rewrite )+ EOB ) ;
    public void block() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:112:5: ( ^( BLOCK ( optionsSpec )? ( alternative rewrite )+ EOB ) )
            // ANTLRv3Tree.g:112:9: ^( BLOCK ( optionsSpec )? ( alternative rewrite )+ EOB )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block495); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:112:18: ( optionsSpec )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == OPTIONS) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // ANTLRv3Tree.g:112:18: optionsSpec
            	        {
            	        	PushFollow(FOLLOW_optionsSpec_in_block497);
            	        	optionsSpec();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	// ANTLRv3Tree.g:112:31: ( alternative rewrite )+
            	int cnt24 = 0;
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == ALT) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:112:32: alternative rewrite
            			    {
            			    	PushFollow(FOLLOW_alternative_in_block501);
            			    	alternative();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_rewrite_in_block503);
            			    	rewrite();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt24 >= 1 ) goto loop24;
            		            EarlyExitException eee =
            		                new EarlyExitException(24, input);
            		            throw eee;
            	    }
            	    cnt24++;
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whinging that label 'loop24' has no statements

            	Match(input,EOB,FOLLOW_EOB_in_block507); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "block"


    // $ANTLR start "altList"
    // ANTLRv3Tree.g:115:1: altList : ^( BLOCK ( alternative rewrite )+ EOB ) ;
    public void altList() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:116:5: ( ^( BLOCK ( alternative rewrite )+ EOB ) )
            // ANTLRv3Tree.g:116:9: ^( BLOCK ( alternative rewrite )+ EOB )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_altList530); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:116:18: ( alternative rewrite )+
            	int cnt25 = 0;
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == ALT) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:116:19: alternative rewrite
            			    {
            			    	PushFollow(FOLLOW_alternative_in_altList533);
            			    	alternative();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_rewrite_in_altList535);
            			    	rewrite();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt25 >= 1 ) goto loop25;
            		            EarlyExitException eee =
            		                new EarlyExitException(25, input);
            		            throw eee;
            	    }
            	    cnt25++;
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whinging that label 'loop25' has no statements

            	Match(input,EOB,FOLLOW_EOB_in_altList539); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "altList"


    // $ANTLR start "alternative"
    // ANTLRv3Tree.g:119:1: alternative : ( ^( ALT ( element )+ EOA ) | ^( ALT EPSILON EOA ) );
    public void alternative() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:120:5: ( ^( ALT ( element )+ EOA ) | ^( ALT EPSILON EOA ) )
            int alt27 = 2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0 == ALT) )
            {
                int LA27_1 = input.LA(2);

                if ( (LA27_1 == DOWN) )
                {
                    int LA27_2 = input.LA(3);

                    if ( (LA27_2 == EPSILON) )
                    {
                        alt27 = 2;
                    }
                    else if ( ((LA27_2 >= BLOCK && LA27_2 <= SYNPRED) || LA27_2 == CHAR_RANGE || (LA27_2 >= SEMPRED && LA27_2 <= SYN_SEMPRED) || (LA27_2 >= TREE_BEGIN && LA27_2 <= BANG) || (LA27_2 >= TOKEN_REF && LA27_2 <= ACTION) || LA27_2 == RULE_REF || LA27_2 == 71 || LA27_2 == 87 || LA27_2 == 89 || LA27_2 == 92) )
                    {
                        alt27 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d27s2 =
                            new NoViableAltException("", 27, 2, input);

                        throw nvae_d27s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d27s1 =
                        new NoViableAltException("", 27, 1, input);

                    throw nvae_d27s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // ANTLRv3Tree.g:120:9: ^( ALT ( element )+ EOA )
                    {
                    	Match(input,ALT,FOLLOW_ALT_in_alternative561); 

                    	Match(input, Token.DOWN, null); 
                    	// ANTLRv3Tree.g:120:15: ( element )+
                    	int cnt26 = 0;
                    	do 
                    	{
                    	    int alt26 = 2;
                    	    int LA26_0 = input.LA(1);

                    	    if ( ((LA26_0 >= BLOCK && LA26_0 <= SYNPRED) || LA26_0 == CHAR_RANGE || (LA26_0 >= SEMPRED && LA26_0 <= SYN_SEMPRED) || (LA26_0 >= TREE_BEGIN && LA26_0 <= BANG) || (LA26_0 >= TOKEN_REF && LA26_0 <= ACTION) || LA26_0 == RULE_REF || LA26_0 == 71 || LA26_0 == 87 || LA26_0 == 89 || LA26_0 == 92) )
                    	    {
                    	        alt26 = 1;
                    	    }


                    	    switch (alt26) 
                    		{
                    			case 1 :
                    			    // ANTLRv3Tree.g:120:15: element
                    			    {
                    			    	PushFollow(FOLLOW_element_in_alternative563);
                    			    	element();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt26 >= 1 ) goto loop26;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(26, input);
                    		            throw eee;
                    	    }
                    	    cnt26++;
                    	} while (true);

                    	loop26:
                    		;	// Stops C# compiler whinging that label 'loop26' has no statements

                    	Match(input,EOA,FOLLOW_EOA_in_alternative566); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:121:9: ^( ALT EPSILON EOA )
                    {
                    	Match(input,ALT,FOLLOW_ALT_in_alternative578); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,EPSILON,FOLLOW_EPSILON_in_alternative580); 
                    	Match(input,EOA,FOLLOW_EOA_in_alternative582); 

                    	Match(input, Token.UP, null); 

                    }
                    break;

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
    // $ANTLR end "alternative"


    // $ANTLR start "exceptionGroup"
    // ANTLRv3Tree.g:124:1: exceptionGroup : ( ( exceptionHandler )+ ( finallyClause )? | finallyClause );
    public void exceptionGroup() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:125:2: ( ( exceptionHandler )+ ( finallyClause )? | finallyClause )
            int alt30 = 2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0 == 85) )
            {
                alt30 = 1;
            }
            else if ( (LA30_0 == 86) )
            {
                alt30 = 2;
            }
            else 
            {
                NoViableAltException nvae_d30s0 =
                    new NoViableAltException("", 30, 0, input);

                throw nvae_d30s0;
            }
            switch (alt30) 
            {
                case 1 :
                    // ANTLRv3Tree.g:125:4: ( exceptionHandler )+ ( finallyClause )?
                    {
                    	// ANTLRv3Tree.g:125:4: ( exceptionHandler )+
                    	int cnt28 = 0;
                    	do 
                    	{
                    	    int alt28 = 2;
                    	    int LA28_0 = input.LA(1);

                    	    if ( (LA28_0 == 85) )
                    	    {
                    	        alt28 = 1;
                    	    }


                    	    switch (alt28) 
                    		{
                    			case 1 :
                    			    // ANTLRv3Tree.g:125:4: exceptionHandler
                    			    {
                    			    	PushFollow(FOLLOW_exceptionHandler_in_exceptionGroup597);
                    			    	exceptionHandler();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt28 >= 1 ) goto loop28;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(28, input);
                    		            throw eee;
                    	    }
                    	    cnt28++;
                    	} while (true);

                    	loop28:
                    		;	// Stops C# compiler whinging that label 'loop28' has no statements

                    	// ANTLRv3Tree.g:125:22: ( finallyClause )?
                    	int alt29 = 2;
                    	int LA29_0 = input.LA(1);

                    	if ( (LA29_0 == 86) )
                    	{
                    	    alt29 = 1;
                    	}
                    	switch (alt29) 
                    	{
                    	    case 1 :
                    	        // ANTLRv3Tree.g:125:22: finallyClause
                    	        {
                    	        	PushFollow(FOLLOW_finallyClause_in_exceptionGroup600);
                    	        	finallyClause();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:126:4: finallyClause
                    {
                    	PushFollow(FOLLOW_finallyClause_in_exceptionGroup606);
                    	finallyClause();
                    	state.followingStackPointer--;


                    }
                    break;

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
    // $ANTLR end "exceptionGroup"


    // $ANTLR start "exceptionHandler"
    // ANTLRv3Tree.g:129:1: exceptionHandler : ^( 'catch' ARG_ACTION ACTION ) ;
    public void exceptionHandler() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:130:5: ( ^( 'catch' ARG_ACTION ACTION ) )
            // ANTLRv3Tree.g:130:10: ^( 'catch' ARG_ACTION ACTION )
            {
            	Match(input,85,FOLLOW_85_in_exceptionHandler627); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ARG_ACTION,FOLLOW_ARG_ACTION_in_exceptionHandler629); 
            	Match(input,ACTION,FOLLOW_ACTION_in_exceptionHandler631); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "exceptionHandler"


    // $ANTLR start "finallyClause"
    // ANTLRv3Tree.g:133:1: finallyClause : ^( 'finally' ACTION ) ;
    public void finallyClause() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:134:5: ( ^( 'finally' ACTION ) )
            // ANTLRv3Tree.g:134:10: ^( 'finally' ACTION )
            {
            	Match(input,86,FOLLOW_86_in_finallyClause653); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ACTION,FOLLOW_ACTION_in_finallyClause655); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "finallyClause"


    // $ANTLR start "element"
    // ANTLRv3Tree.g:137:1: element : elementNoOptionSpec ;
    public void element() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:138:2: ( elementNoOptionSpec )
            // ANTLRv3Tree.g:138:4: elementNoOptionSpec
            {
            	PushFollow(FOLLOW_elementNoOptionSpec_in_element670);
            	elementNoOptionSpec();
            	state.followingStackPointer--;


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
    // $ANTLR end "element"


    // $ANTLR start "elementNoOptionSpec"
    // ANTLRv3Tree.g:141:1: elementNoOptionSpec : ( ^( ( '=' | '+=' ) ID block ) | ^( ( '=' | '+=' ) ID atom ) | atom | ebnf | ACTION | SEMPRED | GATED_SEMPRED | treeSpec );
    public void elementNoOptionSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:142:2: ( ^( ( '=' | '+=' ) ID block ) | ^( ( '=' | '+=' ) ID atom ) | atom | ebnf | ACTION | SEMPRED | GATED_SEMPRED | treeSpec )
            int alt31 = 8;
            alt31 = dfa31.Predict(input);
            switch (alt31) 
            {
                case 1 :
                    // ANTLRv3Tree.g:142:4: ^( ( '=' | '+=' ) ID block )
                    {
                    	if ( input.LA(1) == 71 || input.LA(1) == 87 ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}


                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_elementNoOptionSpec688); 
                    	PushFollow(FOLLOW_block_in_elementNoOptionSpec690);
                    	block();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:143:4: ^( ( '=' | '+=' ) ID atom )
                    {
                    	if ( input.LA(1) == 71 || input.LA(1) == 87 ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}


                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_elementNoOptionSpec703); 
                    	PushFollow(FOLLOW_atom_in_elementNoOptionSpec705);
                    	atom();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:144:4: atom
                    {
                    	PushFollow(FOLLOW_atom_in_elementNoOptionSpec711);
                    	atom();
                    	state.followingStackPointer--;


                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:145:4: ebnf
                    {
                    	PushFollow(FOLLOW_ebnf_in_elementNoOptionSpec716);
                    	ebnf();
                    	state.followingStackPointer--;


                    }
                    break;
                case 5 :
                    // ANTLRv3Tree.g:146:6: ACTION
                    {
                    	Match(input,ACTION,FOLLOW_ACTION_in_elementNoOptionSpec723); 

                    }
                    break;
                case 6 :
                    // ANTLRv3Tree.g:147:6: SEMPRED
                    {
                    	Match(input,SEMPRED,FOLLOW_SEMPRED_in_elementNoOptionSpec730); 

                    }
                    break;
                case 7 :
                    // ANTLRv3Tree.g:148:4: GATED_SEMPRED
                    {
                    	Match(input,GATED_SEMPRED,FOLLOW_GATED_SEMPRED_in_elementNoOptionSpec735); 

                    }
                    break;
                case 8 :
                    // ANTLRv3Tree.g:149:6: treeSpec
                    {
                    	PushFollow(FOLLOW_treeSpec_in_elementNoOptionSpec742);
                    	treeSpec();
                    	state.followingStackPointer--;


                    }
                    break;

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
    // $ANTLR end "elementNoOptionSpec"


    // $ANTLR start "atom"
    // ANTLRv3Tree.g:152:1: atom : ( ^( ( '^' | '!' ) atom ) | range | notSet | ^( RULE_REF ARG_ACTION ) | RULE_REF | terminal );
    public void atom() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:152:5: ( ^( ( '^' | '!' ) atom ) | range | notSet | ^( RULE_REF ARG_ACTION ) | RULE_REF | terminal )
            int alt32 = 6;
            switch ( input.LA(1) ) 
            {
            case ROOT:
            case BANG:
            	{
                alt32 = 1;
                }
                break;
            case CHAR_RANGE:
            	{
                alt32 = 2;
                }
                break;
            case 89:
            	{
                alt32 = 3;
                }
                break;
            case RULE_REF:
            	{
                int LA32_4 = input.LA(2);

                if ( (LA32_4 == DOWN) )
                {
                    alt32 = 4;
                }
                else if ( (LA32_4 == UP || (LA32_4 >= BLOCK && LA32_4 <= SYNPRED) || LA32_4 == CHAR_RANGE || LA32_4 == EOA || (LA32_4 >= SEMPRED && LA32_4 <= SYN_SEMPRED) || (LA32_4 >= TREE_BEGIN && LA32_4 <= BANG) || (LA32_4 >= TOKEN_REF && LA32_4 <= ACTION) || LA32_4 == RULE_REF || LA32_4 == 71 || LA32_4 == 87 || LA32_4 == 89 || LA32_4 == 92) )
                {
                    alt32 = 5;
                }
                else 
                {
                    NoViableAltException nvae_d32s4 =
                        new NoViableAltException("", 32, 4, input);

                    throw nvae_d32s4;
                }
                }
                break;
            case TOKEN_REF:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case 92:
            	{
                alt32 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // ANTLRv3Tree.g:152:9: ^( ( '^' | '!' ) atom )
                    {
                    	if ( (input.LA(1) >= ROOT && input.LA(1) <= BANG) ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}


                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_atom_in_atom760);
                    	atom();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:153:4: range
                    {
                    	PushFollow(FOLLOW_range_in_atom766);
                    	range();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:154:4: notSet
                    {
                    	PushFollow(FOLLOW_notSet_in_atom771);
                    	notSet();
                    	state.followingStackPointer--;


                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:155:7: ^( RULE_REF ARG_ACTION )
                    {
                    	Match(input,RULE_REF,FOLLOW_RULE_REF_in_atom780); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ARG_ACTION,FOLLOW_ARG_ACTION_in_atom782); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 5 :
                    // ANTLRv3Tree.g:156:7: RULE_REF
                    {
                    	Match(input,RULE_REF,FOLLOW_RULE_REF_in_atom791); 

                    }
                    break;
                case 6 :
                    // ANTLRv3Tree.g:157:9: terminal
                    {
                    	PushFollow(FOLLOW_terminal_in_atom801);
                    	terminal();
                    	state.followingStackPointer--;


                    }
                    break;

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
    // $ANTLR end "atom"


    // $ANTLR start "notSet"
    // ANTLRv3Tree.g:160:1: notSet : ( ^( '~' notTerminal ) | ^( '~' block ) );
    public void notSet() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:161:2: ( ^( '~' notTerminal ) | ^( '~' block ) )
            int alt33 = 2;
            int LA33_0 = input.LA(1);

            if ( (LA33_0 == 89) )
            {
                int LA33_1 = input.LA(2);

                if ( (LA33_1 == DOWN) )
                {
                    int LA33_2 = input.LA(3);

                    if ( (LA33_2 == BLOCK) )
                    {
                        alt33 = 2;
                    }
                    else if ( ((LA33_2 >= TOKEN_REF && LA33_2 <= CHAR_LITERAL)) )
                    {
                        alt33 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d33s2 =
                            new NoViableAltException("", 33, 2, input);

                        throw nvae_d33s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d33s1 =
                        new NoViableAltException("", 33, 1, input);

                    throw nvae_d33s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d33s0 =
                    new NoViableAltException("", 33, 0, input);

                throw nvae_d33s0;
            }
            switch (alt33) 
            {
                case 1 :
                    // ANTLRv3Tree.g:161:4: ^( '~' notTerminal )
                    {
                    	Match(input,89,FOLLOW_89_in_notSet816); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_notTerminal_in_notSet818);
                    	notTerminal();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:162:4: ^( '~' block )
                    {
                    	Match(input,89,FOLLOW_89_in_notSet825); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_block_in_notSet827);
                    	block();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;

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
    // $ANTLR end "notSet"


    // $ANTLR start "treeSpec"
    // ANTLRv3Tree.g:165:1: treeSpec : ^( TREE_BEGIN ( element )+ ) ;
    public void treeSpec() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:166:2: ( ^( TREE_BEGIN ( element )+ ) )
            // ANTLRv3Tree.g:166:4: ^( TREE_BEGIN ( element )+ )
            {
            	Match(input,TREE_BEGIN,FOLLOW_TREE_BEGIN_in_treeSpec840); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:166:17: ( element )+
            	int cnt34 = 0;
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( ((LA34_0 >= BLOCK && LA34_0 <= SYNPRED) || LA34_0 == CHAR_RANGE || (LA34_0 >= SEMPRED && LA34_0 <= SYN_SEMPRED) || (LA34_0 >= TREE_BEGIN && LA34_0 <= BANG) || (LA34_0 >= TOKEN_REF && LA34_0 <= ACTION) || LA34_0 == RULE_REF || LA34_0 == 71 || LA34_0 == 87 || LA34_0 == 89 || LA34_0 == 92) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:166:17: element
            			    {
            			    	PushFollow(FOLLOW_element_in_treeSpec842);
            			    	element();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt34 >= 1 ) goto loop34;
            		            EarlyExitException eee =
            		                new EarlyExitException(34, input);
            		            throw eee;
            	    }
            	    cnt34++;
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whinging that label 'loop34' has no statements


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "treeSpec"


    // $ANTLR start "ebnf"
    // ANTLRv3Tree.g:169:1: ebnf : ( ^( SYNPRED block ) | SYN_SEMPRED | ^( ebnfSuffix block ) | block );
    public void ebnf() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:171:2: ( ^( SYNPRED block ) | SYN_SEMPRED | ^( ebnfSuffix block ) | block )
            int alt35 = 4;
            switch ( input.LA(1) ) 
            {
            case SYNPRED:
            	{
                alt35 = 1;
                }
                break;
            case SYN_SEMPRED:
            	{
                alt35 = 2;
                }
                break;
            case OPTIONAL:
            case CLOSURE:
            case POSITIVE_CLOSURE:
            	{
                alt35 = 3;
                }
                break;
            case BLOCK:
            	{
                alt35 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d35s0 =
            	        new NoViableAltException("", 35, 0, input);

            	    throw nvae_d35s0;
            }

            switch (alt35) 
            {
                case 1 :
                    // ANTLRv3Tree.g:171:4: ^( SYNPRED block )
                    {
                    	Match(input,SYNPRED,FOLLOW_SYNPRED_in_ebnf858); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_block_in_ebnf860);
                    	block();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:172:4: SYN_SEMPRED
                    {
                    	Match(input,SYN_SEMPRED,FOLLOW_SYN_SEMPRED_in_ebnf866); 

                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:173:4: ^( ebnfSuffix block )
                    {
                    	PushFollow(FOLLOW_ebnfSuffix_in_ebnf872);
                    	ebnfSuffix();
                    	state.followingStackPointer--;


                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_block_in_ebnf874);
                    	block();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:174:4: block
                    {
                    	PushFollow(FOLLOW_block_in_ebnf880);
                    	block();
                    	state.followingStackPointer--;


                    }
                    break;

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
    // $ANTLR end "ebnf"


    // $ANTLR start "range"
    // ANTLRv3Tree.g:177:1: range : ^( CHAR_RANGE CHAR_LITERAL CHAR_LITERAL ) ;
    public void range() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:178:2: ( ^( CHAR_RANGE CHAR_LITERAL CHAR_LITERAL ) )
            // ANTLRv3Tree.g:178:4: ^( CHAR_RANGE CHAR_LITERAL CHAR_LITERAL )
            {
            	Match(input,CHAR_RANGE,FOLLOW_CHAR_RANGE_in_range892); 

            	Match(input, Token.DOWN, null); 
            	Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_range894); 
            	Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_range896); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "range"


    // $ANTLR start "terminal"
    // ANTLRv3Tree.g:181:1: terminal : ( CHAR_LITERAL | TOKEN_REF | STRING_LITERAL | ^( TOKEN_REF ARG_ACTION ) | '.' );
    public void terminal() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:182:5: ( CHAR_LITERAL | TOKEN_REF | STRING_LITERAL | ^( TOKEN_REF ARG_ACTION ) | '.' )
            int alt36 = 5;
            switch ( input.LA(1) ) 
            {
            case CHAR_LITERAL:
            	{
                alt36 = 1;
                }
                break;
            case TOKEN_REF:
            	{
                int LA36_2 = input.LA(2);

                if ( (LA36_2 == DOWN) )
                {
                    alt36 = 4;
                }
                else if ( (LA36_2 == UP || (LA36_2 >= BLOCK && LA36_2 <= SYNPRED) || LA36_2 == CHAR_RANGE || LA36_2 == EOA || (LA36_2 >= SEMPRED && LA36_2 <= SYN_SEMPRED) || (LA36_2 >= TREE_BEGIN && LA36_2 <= BANG) || (LA36_2 >= TOKEN_REF && LA36_2 <= ACTION) || LA36_2 == RULE_REF || LA36_2 == 71 || LA36_2 == 87 || LA36_2 == 89 || LA36_2 == 92) )
                {
                    alt36 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d36s2 =
                        new NoViableAltException("", 36, 2, input);

                    throw nvae_d36s2;
                }
                }
                break;
            case STRING_LITERAL:
            	{
                alt36 = 3;
                }
                break;
            case 92:
            	{
                alt36 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("", 36, 0, input);

            	    throw nvae_d36s0;
            }

            switch (alt36) 
            {
                case 1 :
                    // ANTLRv3Tree.g:182:9: CHAR_LITERAL
                    {
                    	Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_terminal913); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:183:7: TOKEN_REF
                    {
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_terminal921); 

                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:184:7: STRING_LITERAL
                    {
                    	Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_terminal929); 

                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:185:7: ^( TOKEN_REF ARG_ACTION )
                    {
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_terminal938); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ARG_ACTION,FOLLOW_ARG_ACTION_in_terminal940); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 5 :
                    // ANTLRv3Tree.g:186:7: '.'
                    {
                    	Match(input,92,FOLLOW_92_in_terminal949); 

                    }
                    break;

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
    // $ANTLR end "terminal"


    // $ANTLR start "notTerminal"
    // ANTLRv3Tree.g:189:1: notTerminal : ( CHAR_LITERAL | TOKEN_REF | STRING_LITERAL );
    public void notTerminal() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:190:2: ( CHAR_LITERAL | TOKEN_REF | STRING_LITERAL )
            // ANTLRv3Tree.g:
            {
            	if ( (input.LA(1) >= TOKEN_REF && input.LA(1) <= CHAR_LITERAL) ) 
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
    // $ANTLR end "notTerminal"


    // $ANTLR start "ebnfSuffix"
    // ANTLRv3Tree.g:195:1: ebnfSuffix : ( OPTIONAL | CLOSURE | POSITIVE_CLOSURE );
    public void ebnfSuffix() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:196:2: ( OPTIONAL | CLOSURE | POSITIVE_CLOSURE )
            // ANTLRv3Tree.g:
            {
            	if ( (input.LA(1) >= OPTIONAL && input.LA(1) <= POSITIVE_CLOSURE) ) 
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
    // $ANTLR end "ebnfSuffix"


    // $ANTLR start "rewrite"
    // ANTLRv3Tree.g:203:1: rewrite : ( ( ^( '->' SEMPRED rewrite_alternative ) )* ^( '->' rewrite_alternative ) | );
    public void rewrite() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:204:2: ( ( ^( '->' SEMPRED rewrite_alternative ) )* ^( '->' rewrite_alternative ) | )
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == REWRITE) )
            {
                alt38 = 1;
            }
            else if ( (LA38_0 == ALT || LA38_0 == EOB) )
            {
                alt38 = 2;
            }
            else 
            {
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // ANTLRv3Tree.g:204:4: ( ^( '->' SEMPRED rewrite_alternative ) )* ^( '->' rewrite_alternative )
                    {
                    	// ANTLRv3Tree.g:204:4: ( ^( '->' SEMPRED rewrite_alternative ) )*
                    	do 
                    	{
                    	    int alt37 = 2;
                    	    int LA37_0 = input.LA(1);

                    	    if ( (LA37_0 == REWRITE) )
                    	    {
                    	        int LA37_1 = input.LA(2);

                    	        if ( (LA37_1 == DOWN) )
                    	        {
                    	            int LA37_2 = input.LA(3);

                    	            if ( (LA37_2 == SEMPRED) )
                    	            {
                    	                alt37 = 1;
                    	            }


                    	        }


                    	    }


                    	    switch (alt37) 
                    		{
                    			case 1 :
                    			    // ANTLRv3Tree.g:204:5: ^( '->' SEMPRED rewrite_alternative )
                    			    {
                    			    	Match(input,REWRITE,FOLLOW_REWRITE_in_rewrite1015); 

                    			    	Match(input, Token.DOWN, null); 
                    			    	Match(input,SEMPRED,FOLLOW_SEMPRED_in_rewrite1017); 
                    			    	PushFollow(FOLLOW_rewrite_alternative_in_rewrite1019);
                    			    	rewrite_alternative();
                    			    	state.followingStackPointer--;


                    			    	Match(input, Token.UP, null); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop37;
                    	    }
                    	} while (true);

                    	loop37:
                    		;	// Stops C# compiler whining that label 'loop37' has no statements

                    	Match(input,REWRITE,FOLLOW_REWRITE_in_rewrite1025); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_rewrite_alternative_in_rewrite1027);
                    	rewrite_alternative();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:206:2: 
                    {
                    }
                    break;

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
    // $ANTLR end "rewrite"


    // $ANTLR start "rewrite_alternative"
    // ANTLRv3Tree.g:208:1: rewrite_alternative : ( rewrite_template | rewrite_tree_alternative | ^( ALT EPSILON EOA ) );
    public void rewrite_alternative() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:209:2: ( rewrite_template | rewrite_tree_alternative | ^( ALT EPSILON EOA ) )
            int alt39 = 3;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == TEMPLATE || LA39_0 == ACTION) )
            {
                alt39 = 1;
            }
            else if ( (LA39_0 == ALT) )
            {
                int LA39_2 = input.LA(2);

                if ( (LA39_2 == DOWN) )
                {
                    int LA39_3 = input.LA(3);

                    if ( (LA39_3 == EPSILON) )
                    {
                        alt39 = 3;
                    }
                    else if ( ((LA39_3 >= BLOCK && LA39_3 <= POSITIVE_CLOSURE) || LA39_3 == LABEL || LA39_3 == TREE_BEGIN || (LA39_3 >= TOKEN_REF && LA39_3 <= ACTION) || LA39_3 == RULE_REF) )
                    {
                        alt39 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d39s3 =
                            new NoViableAltException("", 39, 3, input);

                        throw nvae_d39s3;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d39s2 =
                        new NoViableAltException("", 39, 2, input);

                    throw nvae_d39s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d39s0 =
                    new NoViableAltException("", 39, 0, input);

                throw nvae_d39s0;
            }
            switch (alt39) 
            {
                case 1 :
                    // ANTLRv3Tree.g:209:4: rewrite_template
                    {
                    	PushFollow(FOLLOW_rewrite_template_in_rewrite_alternative1042);
                    	rewrite_template();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:210:4: rewrite_tree_alternative
                    {
                    	PushFollow(FOLLOW_rewrite_tree_alternative_in_rewrite_alternative1047);
                    	rewrite_tree_alternative();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:211:9: ^( ALT EPSILON EOA )
                    {
                    	Match(input,ALT,FOLLOW_ALT_in_rewrite_alternative1058); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,EPSILON,FOLLOW_EPSILON_in_rewrite_alternative1060); 
                    	Match(input,EOA,FOLLOW_EOA_in_rewrite_alternative1062); 

                    	Match(input, Token.UP, null); 

                    }
                    break;

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
    // $ANTLR end "rewrite_alternative"


    // $ANTLR start "rewrite_tree_block"
    // ANTLRv3Tree.g:214:1: rewrite_tree_block : ^( BLOCK rewrite_tree_alternative EOB ) ;
    public void rewrite_tree_block() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:215:5: ( ^( BLOCK rewrite_tree_alternative EOB ) )
            // ANTLRv3Tree.g:215:9: ^( BLOCK rewrite_tree_alternative EOB )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_rewrite_tree_block1080); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_rewrite_tree_alternative_in_rewrite_tree_block1082);
            	rewrite_tree_alternative();
            	state.followingStackPointer--;

            	Match(input,EOB,FOLLOW_EOB_in_rewrite_tree_block1084); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_tree_block"


    // $ANTLR start "rewrite_tree_alternative"
    // ANTLRv3Tree.g:218:1: rewrite_tree_alternative : ^( ALT ( rewrite_tree_element )+ EOA ) ;
    public void rewrite_tree_alternative() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:219:5: ( ^( ALT ( rewrite_tree_element )+ EOA ) )
            // ANTLRv3Tree.g:219:7: ^( ALT ( rewrite_tree_element )+ EOA )
            {
            	Match(input,ALT,FOLLOW_ALT_in_rewrite_tree_alternative1103); 

            	Match(input, Token.DOWN, null); 
            	// ANTLRv3Tree.g:219:13: ( rewrite_tree_element )+
            	int cnt40 = 0;
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( ((LA40_0 >= BLOCK && LA40_0 <= POSITIVE_CLOSURE) || LA40_0 == LABEL || LA40_0 == TREE_BEGIN || (LA40_0 >= TOKEN_REF && LA40_0 <= ACTION) || LA40_0 == RULE_REF) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:219:13: rewrite_tree_element
            			    {
            			    	PushFollow(FOLLOW_rewrite_tree_element_in_rewrite_tree_alternative1105);
            			    	rewrite_tree_element();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt40 >= 1 ) goto loop40;
            		            EarlyExitException eee =
            		                new EarlyExitException(40, input);
            		            throw eee;
            	    }
            	    cnt40++;
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whinging that label 'loop40' has no statements

            	Match(input,EOA,FOLLOW_EOA_in_rewrite_tree_alternative1108); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_tree_alternative"


    // $ANTLR start "rewrite_tree_element"
    // ANTLRv3Tree.g:222:1: rewrite_tree_element : ( rewrite_tree_atom | rewrite_tree | rewrite_tree_block | rewrite_tree_ebnf );
    public void rewrite_tree_element() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:223:2: ( rewrite_tree_atom | rewrite_tree | rewrite_tree_block | rewrite_tree_ebnf )
            int alt41 = 4;
            switch ( input.LA(1) ) 
            {
            case LABEL:
            case TOKEN_REF:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case ACTION:
            case RULE_REF:
            	{
                alt41 = 1;
                }
                break;
            case TREE_BEGIN:
            	{
                alt41 = 2;
                }
                break;
            case BLOCK:
            	{
                alt41 = 3;
                }
                break;
            case OPTIONAL:
            case CLOSURE:
            case POSITIVE_CLOSURE:
            	{
                alt41 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d41s0 =
            	        new NoViableAltException("", 41, 0, input);

            	    throw nvae_d41s0;
            }

            switch (alt41) 
            {
                case 1 :
                    // ANTLRv3Tree.g:223:4: rewrite_tree_atom
                    {
                    	PushFollow(FOLLOW_rewrite_tree_atom_in_rewrite_tree_element1123);
                    	rewrite_tree_atom();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:224:4: rewrite_tree
                    {
                    	PushFollow(FOLLOW_rewrite_tree_in_rewrite_tree_element1128);
                    	rewrite_tree();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:225:6: rewrite_tree_block
                    {
                    	PushFollow(FOLLOW_rewrite_tree_block_in_rewrite_tree_element1135);
                    	rewrite_tree_block();
                    	state.followingStackPointer--;


                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:226:6: rewrite_tree_ebnf
                    {
                    	PushFollow(FOLLOW_rewrite_tree_ebnf_in_rewrite_tree_element1142);
                    	rewrite_tree_ebnf();
                    	state.followingStackPointer--;


                    }
                    break;

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
    // $ANTLR end "rewrite_tree_element"


    // $ANTLR start "rewrite_tree_atom"
    // ANTLRv3Tree.g:229:1: rewrite_tree_atom : ( CHAR_LITERAL | TOKEN_REF | ^( TOKEN_REF ARG_ACTION ) | RULE_REF | STRING_LITERAL | LABEL | ACTION );
    public void rewrite_tree_atom() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:230:5: ( CHAR_LITERAL | TOKEN_REF | ^( TOKEN_REF ARG_ACTION ) | RULE_REF | STRING_LITERAL | LABEL | ACTION )
            int alt42 = 7;
            switch ( input.LA(1) ) 
            {
            case CHAR_LITERAL:
            	{
                alt42 = 1;
                }
                break;
            case TOKEN_REF:
            	{
                int LA42_2 = input.LA(2);

                if ( (LA42_2 == DOWN) )
                {
                    alt42 = 3;
                }
                else if ( (LA42_2 == UP || (LA42_2 >= BLOCK && LA42_2 <= POSITIVE_CLOSURE) || LA42_2 == EOA || LA42_2 == LABEL || LA42_2 == TREE_BEGIN || (LA42_2 >= TOKEN_REF && LA42_2 <= ACTION) || LA42_2 == RULE_REF) )
                {
                    alt42 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d42s2 =
                        new NoViableAltException("", 42, 2, input);

                    throw nvae_d42s2;
                }
                }
                break;
            case RULE_REF:
            	{
                alt42 = 4;
                }
                break;
            case STRING_LITERAL:
            	{
                alt42 = 5;
                }
                break;
            case LABEL:
            	{
                alt42 = 6;
                }
                break;
            case ACTION:
            	{
                alt42 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d42s0 =
            	        new NoViableAltException("", 42, 0, input);

            	    throw nvae_d42s0;
            }

            switch (alt42) 
            {
                case 1 :
                    // ANTLRv3Tree.g:230:9: CHAR_LITERAL
                    {
                    	Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_rewrite_tree_atom1158); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:231:6: TOKEN_REF
                    {
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_rewrite_tree_atom1165); 

                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:232:6: ^( TOKEN_REF ARG_ACTION )
                    {
                    	Match(input,TOKEN_REF,FOLLOW_TOKEN_REF_in_rewrite_tree_atom1173); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ARG_ACTION,FOLLOW_ARG_ACTION_in_rewrite_tree_atom1175); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:233:9: RULE_REF
                    {
                    	Match(input,RULE_REF,FOLLOW_RULE_REF_in_rewrite_tree_atom1187); 

                    }
                    break;
                case 5 :
                    // ANTLRv3Tree.g:234:6: STRING_LITERAL
                    {
                    	Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_rewrite_tree_atom1194); 

                    }
                    break;
                case 6 :
                    // ANTLRv3Tree.g:235:6: LABEL
                    {
                    	Match(input,LABEL,FOLLOW_LABEL_in_rewrite_tree_atom1201); 

                    }
                    break;
                case 7 :
                    // ANTLRv3Tree.g:236:4: ACTION
                    {
                    	Match(input,ACTION,FOLLOW_ACTION_in_rewrite_tree_atom1206); 

                    }
                    break;

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
    // $ANTLR end "rewrite_tree_atom"


    // $ANTLR start "rewrite_tree_ebnf"
    // ANTLRv3Tree.g:239:1: rewrite_tree_ebnf : ^( ebnfSuffix rewrite_tree_block ) ;
    public void rewrite_tree_ebnf() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:240:2: ( ^( ebnfSuffix rewrite_tree_block ) )
            // ANTLRv3Tree.g:240:4: ^( ebnfSuffix rewrite_tree_block )
            {
            	PushFollow(FOLLOW_ebnfSuffix_in_rewrite_tree_ebnf1218);
            	ebnfSuffix();
            	state.followingStackPointer--;


            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_rewrite_tree_block_in_rewrite_tree_ebnf1220);
            	rewrite_tree_block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_tree_ebnf"


    // $ANTLR start "rewrite_tree"
    // ANTLRv3Tree.g:243:1: rewrite_tree : ^( TREE_BEGIN rewrite_tree_atom ( rewrite_tree_element )* ) ;
    public void rewrite_tree() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:244:2: ( ^( TREE_BEGIN rewrite_tree_atom ( rewrite_tree_element )* ) )
            // ANTLRv3Tree.g:244:4: ^( TREE_BEGIN rewrite_tree_atom ( rewrite_tree_element )* )
            {
            	Match(input,TREE_BEGIN,FOLLOW_TREE_BEGIN_in_rewrite_tree1234); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_rewrite_tree_atom_in_rewrite_tree1236);
            	rewrite_tree_atom();
            	state.followingStackPointer--;

            	// ANTLRv3Tree.g:244:35: ( rewrite_tree_element )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( ((LA43_0 >= BLOCK && LA43_0 <= POSITIVE_CLOSURE) || LA43_0 == LABEL || LA43_0 == TREE_BEGIN || (LA43_0 >= TOKEN_REF && LA43_0 <= ACTION) || LA43_0 == RULE_REF) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // ANTLRv3Tree.g:244:35: rewrite_tree_element
            			    {
            			    	PushFollow(FOLLOW_rewrite_tree_element_in_rewrite_tree1238);
            			    	rewrite_tree_element();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_tree"


    // $ANTLR start "rewrite_template"
    // ANTLRv3Tree.g:247:1: rewrite_template : ( ^( TEMPLATE ID rewrite_template_args ( DOUBLE_QUOTE_STRING_LITERAL | DOUBLE_ANGLE_STRING_LITERAL ) ) | rewrite_template_ref | rewrite_indirect_template_head | ACTION );
    public void rewrite_template() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:248:2: ( ^( TEMPLATE ID rewrite_template_args ( DOUBLE_QUOTE_STRING_LITERAL | DOUBLE_ANGLE_STRING_LITERAL ) ) | rewrite_template_ref | rewrite_indirect_template_head | ACTION )
            int alt44 = 4;
            alt44 = dfa44.Predict(input);
            switch (alt44) 
            {
                case 1 :
                    // ANTLRv3Tree.g:248:6: ^( TEMPLATE ID rewrite_template_args ( DOUBLE_QUOTE_STRING_LITERAL | DOUBLE_ANGLE_STRING_LITERAL ) )
                    {
                    	Match(input,TEMPLATE,FOLLOW_TEMPLATE_in_rewrite_template1256); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_rewrite_template1258); 
                    	PushFollow(FOLLOW_rewrite_template_args_in_rewrite_template1260);
                    	rewrite_template_args();
                    	state.followingStackPointer--;

                    	if ( (input.LA(1) >= DOUBLE_QUOTE_STRING_LITERAL && input.LA(1) <= DOUBLE_ANGLE_STRING_LITERAL) ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:251:4: rewrite_template_ref
                    {
                    	PushFollow(FOLLOW_rewrite_template_ref_in_rewrite_template1283);
                    	rewrite_template_ref();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // ANTLRv3Tree.g:252:4: rewrite_indirect_template_head
                    {
                    	PushFollow(FOLLOW_rewrite_indirect_template_head_in_rewrite_template1288);
                    	rewrite_indirect_template_head();
                    	state.followingStackPointer--;


                    }
                    break;
                case 4 :
                    // ANTLRv3Tree.g:253:4: ACTION
                    {
                    	Match(input,ACTION,FOLLOW_ACTION_in_rewrite_template1293); 

                    }
                    break;

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
    // $ANTLR end "rewrite_template"


    // $ANTLR start "rewrite_template_ref"
    // ANTLRv3Tree.g:256:1: rewrite_template_ref : ^( TEMPLATE ID rewrite_template_args ) ;
    public void rewrite_template_ref() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:258:2: ( ^( TEMPLATE ID rewrite_template_args ) )
            // ANTLRv3Tree.g:258:4: ^( TEMPLATE ID rewrite_template_args )
            {
            	Match(input,TEMPLATE,FOLLOW_TEMPLATE_in_rewrite_template_ref1307); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_rewrite_template_ref1309); 
            	PushFollow(FOLLOW_rewrite_template_args_in_rewrite_template_ref1311);
            	rewrite_template_args();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_template_ref"


    // $ANTLR start "rewrite_indirect_template_head"
    // ANTLRv3Tree.g:261:1: rewrite_indirect_template_head : ^( TEMPLATE ACTION rewrite_template_args ) ;
    public void rewrite_indirect_template_head() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:263:2: ( ^( TEMPLATE ACTION rewrite_template_args ) )
            // ANTLRv3Tree.g:263:4: ^( TEMPLATE ACTION rewrite_template_args )
            {
            	Match(input,TEMPLATE,FOLLOW_TEMPLATE_in_rewrite_indirect_template_head1326); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ACTION,FOLLOW_ACTION_in_rewrite_indirect_template_head1328); 
            	PushFollow(FOLLOW_rewrite_template_args_in_rewrite_indirect_template_head1330);
            	rewrite_template_args();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_indirect_template_head"


    // $ANTLR start "rewrite_template_args"
    // ANTLRv3Tree.g:266:1: rewrite_template_args : ( ^( ARGLIST ( rewrite_template_arg )+ ) | ARGLIST );
    public void rewrite_template_args() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:267:2: ( ^( ARGLIST ( rewrite_template_arg )+ ) | ARGLIST )
            int alt46 = 2;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == ARGLIST) )
            {
                int LA46_1 = input.LA(2);

                if ( (LA46_1 == DOWN) )
                {
                    alt46 = 1;
                }
                else if ( (LA46_1 == UP || (LA46_1 >= DOUBLE_QUOTE_STRING_LITERAL && LA46_1 <= DOUBLE_ANGLE_STRING_LITERAL)) )
                {
                    alt46 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d46s1 =
                        new NoViableAltException("", 46, 1, input);

                    throw nvae_d46s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // ANTLRv3Tree.g:267:4: ^( ARGLIST ( rewrite_template_arg )+ )
                    {
                    	Match(input,ARGLIST,FOLLOW_ARGLIST_in_rewrite_template_args1343); 

                    	Match(input, Token.DOWN, null); 
                    	// ANTLRv3Tree.g:267:14: ( rewrite_template_arg )+
                    	int cnt45 = 0;
                    	do 
                    	{
                    	    int alt45 = 2;
                    	    int LA45_0 = input.LA(1);

                    	    if ( (LA45_0 == ARG) )
                    	    {
                    	        alt45 = 1;
                    	    }


                    	    switch (alt45) 
                    		{
                    			case 1 :
                    			    // ANTLRv3Tree.g:267:14: rewrite_template_arg
                    			    {
                    			    	PushFollow(FOLLOW_rewrite_template_arg_in_rewrite_template_args1345);
                    			    	rewrite_template_arg();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt45 >= 1 ) goto loop45;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(45, input);
                    		            throw eee;
                    	    }
                    	    cnt45++;
                    	} while (true);

                    	loop45:
                    		;	// Stops C# compiler whinging that label 'loop45' has no statements


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // ANTLRv3Tree.g:268:4: ARGLIST
                    {
                    	Match(input,ARGLIST,FOLLOW_ARGLIST_in_rewrite_template_args1352); 

                    }
                    break;

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
    // $ANTLR end "rewrite_template_args"


    // $ANTLR start "rewrite_template_arg"
    // ANTLRv3Tree.g:271:1: rewrite_template_arg : ^( ARG ID ACTION ) ;
    public void rewrite_template_arg() // throws RecognitionException [1]
    {   
        try 
    	{
            // ANTLRv3Tree.g:272:2: ( ^( ARG ID ACTION ) )
            // ANTLRv3Tree.g:272:6: ^( ARG ID ACTION )
            {
            	Match(input,ARG,FOLLOW_ARG_in_rewrite_template_arg1366); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_rewrite_template_arg1368); 
            	Match(input,ACTION,FOLLOW_ACTION_in_rewrite_template_arg1370); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "rewrite_template_arg"

    // Delegated rules


   	protected DFA31 dfa31;
   	protected DFA44 dfa44;
	private void InitializeCyclicDFAs()
	{
    	this.dfa31 = new DFA31(this);
    	this.dfa44 = new DFA44(this);


	}

    const string DFA31_eotS =
        "\x0c\uffff";
    const string DFA31_eofS =
        "\x0c\uffff";
    const string DFA31_minS =
        "\x01\x08\x01\x02\x06\uffff\x01\x14\x01\x08\x02\uffff";
    const string DFA31_maxS =
        "\x01\x5c\x01\x02\x06\uffff\x01\x14\x01\x5c\x02\uffff";
    const string DFA31_acceptS =
        "\x02\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x02\uffff"+
        "\x01\x01\x01\x02";
    const string DFA31_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA31_transitionS = {
            "\x05\x03\x01\uffff\x01\x02\x11\uffff\x01\x05\x01\x06\x01\x03"+
            "\x02\uffff\x01\x07\x02\x02\x02\uffff\x03\x02\x01\x04\x03\uffff"+
            "\x01\x02\x15\uffff\x01\x01\x0f\uffff\x01\x01\x01\uffff\x01\x02"+
            "\x02\uffff\x01\x02",
            "\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x09",
            "\x01\x0a\x05\uffff\x01\x0b\x17\uffff\x02\x0b\x02\uffff\x03"+
            "\x0b\x04\uffff\x01\x0b\x27\uffff\x01\x0b\x02\uffff\x01\x0b",
            "",
            ""
    };

    static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
    static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
    static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
    static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
    static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
    static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
    static readonly short[][] DFA31_transition = DFA.UnpackEncodedStringArray(DFA31_transitionS);

    protected class DFA31 : DFA
    {
        public DFA31(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 31;
            this.eot = DFA31_eot;
            this.eof = DFA31_eof;
            this.min = DFA31_min;
            this.max = DFA31_max;
            this.accept = DFA31_accept;
            this.special = DFA31_special;
            this.transition = DFA31_transition;

        }

        override public string Description
        {
            get { return "141:1: elementNoOptionSpec : ( ^( ( '=' | '+=' ) ID block ) | ^( ( '=' | '+=' ) ID atom ) | atom | ebnf | ACTION | SEMPRED | GATED_SEMPRED | treeSpec );"; }
        }

    }

    const string DFA44_eotS =
        "\x10\uffff";
    const string DFA44_eofS =
        "\x10\uffff";
    const string DFA44_minS =
        "\x01\x1e\x01\x02\x01\uffff\x01\x14\x01\x16\x01\uffff\x01\x02\x01"+
        "\x15\x02\uffff\x01\x02\x01\x14\x01\x2d\x03\x03";
    const string DFA44_maxS =
        "\x01\x2d\x01\x02\x01\uffff\x01\x2d\x01\x16\x01\uffff\x01\x33\x01"+
        "\x15\x02\uffff\x01\x02\x01\x14\x01\x2d\x01\x03\x01\x15\x01\x33";
    const string DFA44_acceptS =
        "\x02\uffff\x01\x04\x02\uffff\x01\x03\x02\uffff\x01\x02\x01\x01\x06"+
        "\uffff";
    const string DFA44_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA44_transitionS = {
            "\x01\x01\x0e\uffff\x01\x02",
            "\x01\x03",
            "",
            "\x01\x04\x18\uffff\x01\x05",
            "\x01\x06",
            "",
            "\x01\x07\x01\x08\x2e\uffff\x02\x09",
            "\x01\x0a",
            "",
            "",
            "\x01\x0b",
            "\x01\x0c",
            "\x01\x0d",
            "\x01\x0e",
            "\x01\x0f\x11\uffff\x01\x0a",
            "\x01\x08\x2e\uffff\x02\x09"
    };

    static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
    static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
    static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
    static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
    static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
    static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
    static readonly short[][] DFA44_transition = DFA.UnpackEncodedStringArray(DFA44_transitionS);

    protected class DFA44 : DFA
    {
        public DFA44(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 44;
            this.eot = DFA44_eot;
            this.eof = DFA44_eof;
            this.min = DFA44_min;
            this.max = DFA44_max;
            this.accept = DFA44_accept;
            this.special = DFA44_special;
            this.transition = DFA44_transition;

        }

        override public string Description
        {
            get { return "247:1: rewrite_template : ( ^( TEMPLATE ID rewrite_template_args ( DOUBLE_QUOTE_STRING_LITERAL | DOUBLE_ANGLE_STRING_LITERAL ) ) | rewrite_template_ref | rewrite_indirect_template_head | ACTION );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_grammarType_in_grammarDef52 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_grammarDef54 = new BitSet(new ulong[]{0x0000420080000090UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_DOC_COMMENT_in_grammarDef56 = new BitSet(new ulong[]{0x0000420080000090UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_optionsSpec_in_grammarDef59 = new BitSet(new ulong[]{0x0000420080000090UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_tokensSpec_in_grammarDef62 = new BitSet(new ulong[]{0x0000420080000090UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_attrScope_in_grammarDef65 = new BitSet(new ulong[]{0x0000420080000090UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_action_in_grammarDef68 = new BitSet(new ulong[]{0x0000420080000090UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_rule_in_grammarDef71 = new BitSet(new ulong[]{0x0000420080000098UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_set_in_grammarType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOKENS_in_tokensSpec127 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tokenSpec_in_tokensSpec129 = new BitSet(new ulong[]{0x0000040000000008UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_tokenSpec143 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_tokenSpec145 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_tokenSpec147 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_71_in_tokenSpec154 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_tokenSpec156 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_tokenSpec158 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_tokenSpec164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SCOPE_in_attrScope176 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_attrScope178 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ACTION_in_attrScope180 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_action193 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_action195 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ID_in_action197 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ACTION_in_action199 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_action206 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_action208 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ACTION_in_action210 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_optionsSpec223 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_option_in_optionsSpec225 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_option244 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_option246 = new BitSet(new ulong[]{0x0000980000100000UL});
    public static readonly BitSet FOLLOW_optionValue_in_option248 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_set_in_optionValue0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RULE_in_rule314 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_rule316 = new BitSet(new ulong[]{0x0000401080A00100UL,0x0000000000013900UL});
    public static readonly BitSet FOLLOW_modifier_in_rule318 = new BitSet(new ulong[]{0x0000401080A00100UL,0x0000000000013900UL});
    public static readonly BitSet FOLLOW_ARG_in_rule323 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ARG_ACTION_in_rule325 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RET_in_rule332 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ARG_ACTION_in_rule334 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_throwsSpec_in_rule347 = new BitSet(new ulong[]{0x0000401080A00100UL,0x0000000000013900UL});
    public static readonly BitSet FOLLOW_optionsSpec_in_rule350 = new BitSet(new ulong[]{0x0000401080A00100UL,0x0000000000013900UL});
    public static readonly BitSet FOLLOW_ruleScopeSpec_in_rule353 = new BitSet(new ulong[]{0x0000401080A00100UL,0x0000000000013900UL});
    public static readonly BitSet FOLLOW_ruleAction_in_rule356 = new BitSet(new ulong[]{0x0000401080A00100UL,0x0000000000013900UL});
    public static readonly BitSet FOLLOW_altList_in_rule367 = new BitSet(new ulong[]{0x0000000000020000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_exceptionGroup_in_rule377 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_EOR_in_rule380 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_set_in_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_ruleAction419 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_ruleAction421 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ACTION_in_ruleAction423 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_80_in_throwsSpec436 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_throwsSpec438 = new BitSet(new ulong[]{0x0000000000100008UL});
    public static readonly BitSet FOLLOW_SCOPE_in_ruleScopeSpec452 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ACTION_in_ruleScopeSpec454 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SCOPE_in_ruleScopeSpec461 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ACTION_in_ruleScopeSpec463 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ID_in_ruleScopeSpec465 = new BitSet(new ulong[]{0x0000000000100008UL});
    public static readonly BitSet FOLLOW_SCOPE_in_ruleScopeSpec473 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_ruleScopeSpec475 = new BitSet(new ulong[]{0x0000000000100008UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block495 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_optionsSpec_in_block497 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_alternative_in_block501 = new BitSet(new ulong[]{0x0000010000050000UL});
    public static readonly BitSet FOLLOW_rewrite_in_block503 = new BitSet(new ulong[]{0x0000010000050000UL});
    public static readonly BitSet FOLLOW_EOB_in_block507 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BLOCK_in_altList530 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alternative_in_altList533 = new BitSet(new ulong[]{0x0000010000050000UL});
    public static readonly BitSet FOLLOW_rewrite_in_altList535 = new BitSet(new ulong[]{0x0000010000050000UL});
    public static readonly BitSet FOLLOW_EOB_in_altList539 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ALT_in_alternative561 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_element_in_alternative563 = new BitSet(new ulong[]{0x00023CE700085F00UL,0x0000000012800080UL});
    public static readonly BitSet FOLLOW_EOA_in_alternative566 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ALT_in_alternative578 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EPSILON_in_alternative580 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EOA_in_alternative582 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_exceptionHandler_in_exceptionGroup597 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_finallyClause_in_exceptionGroup600 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_finallyClause_in_exceptionGroup606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_exceptionHandler627 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ARG_ACTION_in_exceptionHandler629 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ACTION_in_exceptionHandler631 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_86_in_finallyClause653 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ACTION_in_finallyClause655 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_elementNoOptionSpec_in_element670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementNoOptionSpec682 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_elementNoOptionSpec688 = new BitSet(new ulong[]{0x0000000400001F00UL});
    public static readonly BitSet FOLLOW_block_in_elementNoOptionSpec690 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_set_in_elementNoOptionSpec697 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_elementNoOptionSpec703 = new BitSet(new ulong[]{0x00021CC000004000UL,0x0000000012000000UL});
    public static readonly BitSet FOLLOW_atom_in_elementNoOptionSpec705 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_atom_in_elementNoOptionSpec711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ebnf_in_elementNoOptionSpec716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ACTION_in_elementNoOptionSpec723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMPRED_in_elementNoOptionSpec730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GATED_SEMPRED_in_elementNoOptionSpec735 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_treeSpec_in_elementNoOptionSpec742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_atom754 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_atom_in_atom760 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_range_in_atom766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notSet_in_atom771 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RULE_REF_in_atom780 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ARG_ACTION_in_atom782 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RULE_REF_in_atom791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_terminal_in_atom801 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_89_in_notSet816 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_notTerminal_in_notSet818 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_89_in_notSet825 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_notSet827 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_TREE_BEGIN_in_treeSpec840 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_element_in_treeSpec842 = new BitSet(new ulong[]{0x00023CE700085F08UL,0x0000000012800080UL});
    public static readonly BitSet FOLLOW_SYNPRED_in_ebnf858 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ebnf860 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SYN_SEMPRED_in_ebnf866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ebnfSuffix_in_ebnf872 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ebnf874 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_in_ebnf880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_RANGE_in_range892 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_range894 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_range896 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_terminal913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_terminal921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_terminal929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_terminal938 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ARG_ACTION_in_terminal940 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_92_in_terminal949 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_notTerminal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_ebnfSuffix0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REWRITE_in_rewrite1015 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_SEMPRED_in_rewrite1017 = new BitSet(new ulong[]{0x0000200040010000UL});
    public static readonly BitSet FOLLOW_rewrite_alternative_in_rewrite1019 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REWRITE_in_rewrite1025 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_rewrite_alternative_in_rewrite1027 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_rewrite_template_in_rewrite_alternative1042 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rewrite_tree_alternative_in_rewrite_alternative1047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALT_in_rewrite_alternative1058 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EPSILON_in_rewrite_alternative1060 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_EOA_in_rewrite_alternative1062 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BLOCK_in_rewrite_tree_block1080 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_rewrite_tree_alternative_in_rewrite_tree_block1082 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_EOB_in_rewrite_tree_block1084 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ALT_in_rewrite_tree_alternative1103 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_rewrite_tree_element_in_rewrite_tree_alternative1105 = new BitSet(new ulong[]{0x00023C2020080F00UL});
    public static readonly BitSet FOLLOW_EOA_in_rewrite_tree_alternative1108 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_rewrite_tree_atom_in_rewrite_tree_element1123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rewrite_tree_in_rewrite_tree_element1128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rewrite_tree_block_in_rewrite_tree_element1135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rewrite_tree_ebnf_in_rewrite_tree_element1142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_rewrite_tree_atom1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_rewrite_tree_atom1165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOKEN_REF_in_rewrite_tree_atom1173 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ARG_ACTION_in_rewrite_tree_atom1175 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RULE_REF_in_rewrite_tree_atom1187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_rewrite_tree_atom1194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LABEL_in_rewrite_tree_atom1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ACTION_in_rewrite_tree_atom1206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ebnfSuffix_in_rewrite_tree_ebnf1218 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_rewrite_tree_block_in_rewrite_tree_ebnf1220 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_TREE_BEGIN_in_rewrite_tree1234 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_rewrite_tree_atom_in_rewrite_tree1236 = new BitSet(new ulong[]{0x00023C2020080F08UL});
    public static readonly BitSet FOLLOW_rewrite_tree_element_in_rewrite_tree1238 = new BitSet(new ulong[]{0x00023C2020080F08UL});
    public static readonly BitSet FOLLOW_TEMPLATE_in_rewrite_template1256 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_rewrite_template1258 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_rewrite_template_args_in_rewrite_template1260 = new BitSet(new ulong[]{0x000C000000000000UL});
    public static readonly BitSet FOLLOW_set_in_rewrite_template1267 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_rewrite_template_ref_in_rewrite_template1283 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rewrite_indirect_template_head_in_rewrite_template1288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ACTION_in_rewrite_template1293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TEMPLATE_in_rewrite_template_ref1307 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_rewrite_template_ref1309 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_rewrite_template_args_in_rewrite_template_ref1311 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_TEMPLATE_in_rewrite_indirect_template_head1326 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ACTION_in_rewrite_indirect_template_head1328 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_rewrite_template_args_in_rewrite_indirect_template_head1330 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ARGLIST_in_rewrite_template_args1343 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_rewrite_template_arg_in_rewrite_template_args1345 = new BitSet(new ulong[]{0x0000000000200008UL});
    public static readonly BitSet FOLLOW_ARGLIST_in_rewrite_template_args1352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARG_in_rewrite_template_arg1366 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_rewrite_template_arg1368 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ACTION_in_rewrite_template_arg1370 = new BitSet(new ulong[]{0x0000000000000008UL});

}
