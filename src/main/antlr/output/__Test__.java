import java.io.*;
import org.antlr.runtime.*;
import org.antlr.runtime.debug.DebugEventSocketProxy;


public class __Test__ {

    public static void main(String args[]) throws Exception {
        Zen2Lexer lex = new Zen2Lexer(new ANTLRFileStream("/Users/administrator/src/zen/src/main/antlr/output/__Test___input.txt", "UTF8"));
        CommonTokenStream tokens = new CommonTokenStream(lex);

        Zen2Parser g = new Zen2Parser(tokens, 49100, null);
        try {
            g.expr();
        } catch (RecognitionException e) {
            e.printStackTrace();
        }
    }
}