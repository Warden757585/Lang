class Lexer
{
    public string data;
    public string[] split_data;
    public Token[] tokenised_data;
    public Tokens token_list;

    public Lexer(string Data)
    {
        this.data = Data.ToUpper();
    }

    public void Run()
    {
        object result;

        //Firstly we need to separate the data by spaces, we do this using String.Split(' ')
        split_data = data.Split(' ');
        //Next we need to search that string for keywords like Let and Int. I am choosing to do this by using a foreach loop
        foreach(string term in split_data)
        {
            //Check if the term is inside of the Tokens enum
            if (Enum.IsDefined(typeof(Tokens), term))
            {
                //If the term is inside of our Tokens enum the write it out:
                var checker = Enum.TryParse(typeof(Tokens), term, out result);
                Console.Write($" {result}");
            }
            else
            {
                Console.Write(" Unknown");
            }
        }
    }
}