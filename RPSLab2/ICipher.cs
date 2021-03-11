namespace RPSLab2
{
    interface ICipher
    {
        string Encode(string text, string key);
        string Decode(string text, string key);
    }
}
