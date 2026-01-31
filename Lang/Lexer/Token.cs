
//Enum to store Token Types:
public enum Tokens
{
    INT,
    STRING,
    LET,
    UNKNOWN
}

//Token Struct to store Token Type and Data
//e.g. Token t = new Token{Tokens.LET, varName}
// Token t = new Token{Tokens.INT, varValue}
// Token t = new Token{TokensSTRING, varValue}

public struct Token
{
    public Tokens type;
    public string data;
};