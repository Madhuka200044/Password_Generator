
using System;
using System.Collections.Generic;
using System.Linq;

namespace Password_Generator
{   public enum CharType
    {
        lowecase,
        uppercase,
        digits,
        symbols

    }
    internal class PasswordGenHelper
    {
        public static string PasswordGenerater(GenerateConfigs generateConfigs)
        {
            string generatepassword = string.Empty;
            List<char> Charactor = new List<char>();
            if (generateConfigs.isLowercase)
                Charactor.AddRange(GetCharacters(CharType.lowecase));
            if (generateConfigs.isUppercase)
                Charactor.AddRange(GetCharacters(CharType.uppercase));
            if (generateConfigs.isDigits)
                Charactor.AddRange(GetCharacters(CharType.digits));
            if (generateConfigs.isSymbols)
                Charactor.AddRange(GetCharacters(CharType.symbols));

            Random random = new Random();
            List<char> selectedchars = Enumerable.Range(0, generateConfigs.length).Select(c => Charactor[random.Next(Charactor.Count)]).ToList();
            generatepassword = string.Join(" ", selectedchars); 
            return generatepassword;
        }

        public static List<char> GetCharacters(CharType chartype)
        {
            if(chartype == CharType.lowecase)
            {
                return Enumerable.Range('a','z' - 'a'+1).Select(i => (char)i).ToList();
            }

             
            if(chartype == CharType.uppercase)
            {
                return Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (char)i).ToList();
            }

            if (chartype == CharType.digits)
            {
                return Enumerable.Range('0', '9' - '0' + 1).Select(i => (char)i).ToList();
            }

            return "!@#$%^&*()_+-/*|\\{}[]:;.,?><:".Where(c => char.IsSymbol(c)).ToList();
        }
    }
}
 