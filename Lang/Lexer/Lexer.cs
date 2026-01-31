using System.Linq;

class Lexer
{
    public string data;
    public List<string> split_data;
    public List<Token> tokenised_data = new List<Token>();
    public Tokens token_list;

    public Lexer(string Data)
    {
        this.data = Data.ToUpper();
    }

    public void Run()
    {
        Tokens result;
        Token token;

        //Firstly we need to separate the data by spaces, we do this using String.Split(' ')
        split_data = data.Split(" ").ToList();
        //We also need to remove the extra whitespace from the names:
        for(int i = 0; i < split_data.Count; i++)
        {
            split_data[i] = String.Concat(split_data[i].Where(c => !Char.IsWhiteSpace(c)));
        }
        split_data.RemoveAll(string.IsNullOrWhiteSpace);

        //Next we need to search that string for keywords like Let and Int. I am choosing to do this by using a foreach loop
        foreach (string term in split_data)
        {
            //Check if the term is inside of the Tokens enum
            if (Enum.IsDefined(typeof(Tokens), term))
            {
                //If the term is inside of our Tokens enum the write it out:
                var checker = Enum.TryParse<Tokens>(term, out result);
                token = new Token
                {
                    type = result,
                    data = term
                };
                tokenised_data.Add(token);
                Console.WriteLine($"Type: {token.type} Data: {token.data}");
                token = new Token { };
            }
            else
            {
                token = new Token
                {
                    type = Tokens.UNKNOWN,
                    data = term
                };
                tokenised_data.Add(token);
                Console.WriteLine($"Type: {token.type} Data: {token.data}");
                token = new Token { };
            }
        }
    }
}