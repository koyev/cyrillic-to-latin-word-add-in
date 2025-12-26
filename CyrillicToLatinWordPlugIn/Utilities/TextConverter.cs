using System.Collections.Generic;
using System.Text;

namespace CyrillicToLatinWordPlugIn.Utilities
{
    public static class TextConverter
    {
        public static Dictionary<char, string> cyrillicToLatin = new Dictionary<char, string>
        {
            {'А', "A"}, {'а', "a"}, {'Б', "B"}, {'б', "b"}, {'В', "V"}, {'в', "v"},
            {'Г', "G"}, {'г', "g"}, {'Д', "D"}, {'д', "d"}, {'Ђ', "Đ"}, {'ђ', "đ"},
            {'Е', "E"}, {'е', "e"}, {'Ж', "Ž"}, {'ж', "ž"}, {'З', "Z"}, {'з', "z"},
            {'И', "I"}, {'и', "i"}, {'Ј', "J"}, {'ј', "j"}, {'К', "K"}, {'к', "k"},
            {'Л', "L"}, {'л', "l"}, {'Љ', "Lj"}, {'љ', "lj"}, {'М', "M"}, {'м', "m"},
            {'Н', "N"}, {'н', "n"}, {'Њ', "Nj"}, {'њ', "nj"}, {'О', "O"}, {'о', "o"},
            {'П', "P"}, {'п', "p"}, {'Р', "R"}, {'р', "r"}, {'С', "S"}, {'с', "s"},
            {'Т', "T"}, {'т', "t"}, {'Ћ', "Ć"}, {'ћ', "ć"}, {'У', "U"}, {'у', "u"},
            {'Ф', "F"}, {'ф', "f"}, {'Х', "H"}, {'х', "h"}, {'Ц', "C"}, {'ц', "c"},
            {'Ч', "Č"}, {'ч', "č"}, {'Џ', "Dž"}, {'џ', "dž"}, {'Ш', "Š"}, {'ш', "š"}
        };

        public static Dictionary<string, char> latinToCyrillic = new Dictionary<string, char>
        {
            {"A", 'А'}, {"a", 'а'}, {"B", 'Б'}, {"b", 'б'}, {"V", 'В'}, {"v", 'в'},
            {"G", 'Г'}, {"g", 'г'}, {"D", 'Д'}, {"d", 'д'}, {"Đ", 'Ђ'}, {"đ", 'ђ'},
            {"E", 'Е'}, {"e", 'е'}, {"Ž", 'Ж'}, {"ž", 'ж'}, {"Z", 'З'}, {"z", 'з'},
            {"I", 'И'}, {"i", 'и'}, {"J", 'Ј'}, {"j", 'ј'}, {"K", 'К'}, {"k", 'к'},
            {"L", 'Л'}, {"l", 'л'}, {"Lj", 'Љ'}, {"lj", 'љ'}, {"M", 'М'}, {"m", 'м'},
            {"N", 'Н'}, {"n", 'н'}, {"Nj", 'Њ'}, {"nj", 'њ'}, {"O", 'О'}, {"o", 'о'},
            {"P", 'П'}, {"p", 'п'}, {"R", 'Р'}, {"r", 'р'}, {"S", 'С'}, {"s", 'с'},
            {"T", 'Т'}, {"t", 'т'}, {"Ć", 'Ћ'}, {"ć", 'ћ'}, {"U", 'У'}, {"u", 'у'},
            {"F", 'Ф'}, {"f", 'ф'}, {"H", 'Х'}, {"h", 'х'}, {"C", 'Ц'}, {"c", 'ц'},
            {"Č", 'Ч'}, {"č", 'ч'}, {"Dž", 'Џ'}, {"dž", 'џ'}, {"Š", 'Ш'}, {"š", 'ш'}
        };

        public static string CyrillicToLatin(string text)
        {
            var result = new StringBuilder();
            foreach (var c in text)
            {
                if (cyrillicToLatin.ContainsKey(c))
                {
                    result.Append(cyrillicToLatin[c]);
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        public static string LatinToCyrillic(string text)
        {
            var result = new StringBuilder();
            int i = 0;
            while (i < text.Length)
            {
                string charToCheck;
                if (i + 1 < text.Length)
                {
                    charToCheck = text.Substring(i, 2);
                    if (latinToCyrillic.ContainsKey(charToCheck))
                    {
                        result.Append(latinToCyrillic[charToCheck]);
                        i += 2;
                        continue;
                    }
                }

                charToCheck = text[i].ToString();
                if (latinToCyrillic.ContainsKey(charToCheck))
                {
                    result.Append(latinToCyrillic[charToCheck]);
                }
                else
                {
                    result.Append(text[i]);
                }
                i++;
            }
            return result.ToString();
        }

        public static string DetectAndConvert(string text)
        {
            int cyrillicCount = 0;
            int latinCount = 0;

            foreach (char c in text)
            {
                if (cyrillicToLatin.ContainsKey(c))
                {
                    cyrillicCount++;
                }
                else if (latinToCyrillic.ContainsKey(c.ToString()) ||
                         (c.ToString().Length == 2 && latinToCyrillic.ContainsKey(c.ToString())))
                {
                    latinCount++;
                }
            }

            if (cyrillicCount > latinCount)
            {
                return CyrillicToLatin(text);
            }
            else
            {
                return LatinToCyrillic(text);
            }
        }
    }
}