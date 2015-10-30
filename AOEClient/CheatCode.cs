namespace AOEClient
{
    public class CheatCode
    {
        public CheatCode(string name, string phrase, short amount = 1)
        {
            Name = name;
            Amount = amount;
            CheatPhrase = phrase;
        }

        public string Name { get; set; }

        public short Amount { get; set; }

        public string CheatPhrase { get; set; }
    }
}
