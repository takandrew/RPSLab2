namespace RPSLab2
{
    public class Beaufort: ICipher
    {
        const string engAlphabet = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string rusAlphabet = @"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private bool IsLatin(char letter) //Проверка символа на принадлежность к латинице
        {
            short minusOne = -1;
            if (engAlphabet.IndexOf(char.ToUpper(letter)) == minusOne)
                return false;
            return true;
        }
        public string Encode(string text, string key) //Шифрование
        {
            for (int i = key.Length, j = 0; i < text.Length; i++, j++)
                key += key[((i + j) % key.Length)];
            var keyUP = key.ToCharArray(); 
            for (int i = 0; i < keyUP.Length; i++)
                keyUP[i] = char.ToUpper(keyUP[i]);
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                    if (IsLatin(keyUP[i])) //Если символ ключа латинский
                    {
                        if (IsLatin(letters[i])) //Если символ текста латинский
                            letters[i] = engAlphabet[(engAlphabet.Length + engAlphabet.IndexOf(keyUP[i]) -
                        engAlphabet.IndexOf(letters[i])) % engAlphabet.Length];
                        else //Если символ текста русский
                            letters[i] = rusAlphabet[(rusAlphabet.Length + engAlphabet.IndexOf(keyUP[i]) -
                        rusAlphabet.IndexOf(letters[i])) % rusAlphabet.Length];
                    }
                    else //Если символ ключа русский
                    {
                        if (IsLatin(letters[i])) //Если символ текста латинский
                            letters[i] = engAlphabet[(engAlphabet.Length + rusAlphabet.IndexOf(keyUP[i]) -
                        engAlphabet.IndexOf(letters[i])) % engAlphabet.Length];
                        else //Если символ текста русский
                            letters[i] = rusAlphabet[(rusAlphabet.Length + rusAlphabet.IndexOf(keyUP[i]) -
                        rusAlphabet.IndexOf(letters[i])) % rusAlphabet.Length];
                    }
                    if (isLowerCase)
                        letters[i] = char.ToLower(letters[i]); //Соблюдение изначального регистра
                }

            return string.Join("", letters);
        }
        public string Decode(string text, string key) //Дешифрование
        {
            //В шифре Бофора дешифрование производится теми же действиями с тем же ключом
            text = Encode(text, key); 
            return text;
        }
    }
}
