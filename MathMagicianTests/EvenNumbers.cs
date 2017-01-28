using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.EvenNumbers
{
    public class EvenNumber : Integer 
    {
        private int First { get; set; }
        //private list<int> sequence {get, set}
        public EvenNumber();
        {
            First = 2;
        }
        public int GetFirst()
    { 
         return First;
}
        public int GetNext(intCurrent);
        int addone = current +2;        
        return current +2;
        }





    //Jurnell's example starts below:
     public int[] GetSequence(int howMany)
{
    int[] numbers = new[how_many];
    numbers[0] = GetFirst();//i = 1
                            //for(int i = 0; i < length; i++)
    for (int i = 1; i < numbers.Length; i++)
    {
        numbers[i] = GetNext(numbers[i - 1]);
    }
    return numbers;

}

public string PrintNumbers(int[] number_array)
{
    return string.Join("", number_array);
}

int Integer.GetSequence(int how_many)
{
    throw new NotImplementedException();
}

public string printNumbers(int[] how_many)
{
    throw new NotImplementedException();
}

public int GetFirst()
{
    return First;
}
public int GetNext(int current)
{
    //"current' argument is read-only

    //return current++1
    //return ++current

    return current + 1;
}

    }
}
    }    
}
    
