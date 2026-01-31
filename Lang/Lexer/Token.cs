
//Enum to store Token Types:
enum Tokens
{
    INT,
    STRING,
    LET
}

//Token Struct to store Token Type and Data
//e.g. Token t = new Token{Tokens.LET, varName}
// Token t = new Token{Tokens.INT, varValue}
// Token t = new Token{TokensSTRING, varValue}

struct Token
{
    Tokens type;
    string data;
};