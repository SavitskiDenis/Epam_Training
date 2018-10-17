using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class WordsRedaction
    {
        private  char[] _vowelArray = { 'а', 'у', 'е', 'ё', 'ы', 'о', 'я', 'и', 'э', 'ю' };
        private char[] _badLeters = { 'р', 'л', 'м', 'н','й'};
        private string [] _myStringArray;

        public WordsRedaction(string _myString)
        {
            _myStringArray = _myString.Split(new char[] {' ','.',',','?'});
            StartSplit();
            
        }

        private void StartSplit()
        {
            for (int i = 0; i < _myStringArray.Length; i++)
            {
                _myStringArray[i] = SplitWord(_myStringArray[i]);
               
            }
          
        }

        private  string SplitWord(string _myStringVar)
       {
           StringBuilder _myBuilder = new StringBuilder(_myStringVar);
           bool _check=false;
               
           for (int i = 0; i < _myBuilder.Length; i++)
           {
               if(IsVowel(_myBuilder[i]) && i!=_myBuilder.Length-1)
               {
                   if (i + 1 == _myBuilder.Length - 1 && !IsVowel(_myBuilder[i + 1]))
                   {
                       continue;
                   }
                   else
                   {
                       if(i+2!=_myBuilder.Length-1 && !IsVowel(_myBuilder[i+1]))
                       {
                           for (int j = 0; j < _badLeters.Length; j++)
                           {
                               if(_myBuilder[i+1]==_badLeters[j] && !IsVowel(_myBuilder[i+2]))
                               {
                                   _check = true;
                                   _myBuilder.Insert(i + 2, "-");
                                   break;
                               }
                           }
                           if(!_check)
                           {
                               _myBuilder.Insert(i + 1, "-");
                           }
                       }
                       else
                       {
                           if(!IsVowel(_myBuilder[i+1]) && !IsVowel(_myBuilder[i+2]))
                           {
                               continue;
                           }
                           _myBuilder.Insert(i + 1, "-");
                       }
                       
                   }
                   
               }
               
           }

           return _myBuilder.ToString();
       }

        private bool IsVowel(char _myChar)
        {
            for (int i = 0; i < _vowelArray.Length; i++)
            {
                if(Char.ToUpper(_myChar)==Char.ToUpper(_vowelArray[i]))
                {
                    return true;
                }
            }
            return false;

        }

        public string[] stringArray
        {
            get
            {
                if(_myStringArray!=null)
                {
                    return _myStringArray;
                }
                return null;
            }
        }
    }
}
