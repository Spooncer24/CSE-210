using System;
using System.Collections.Generic;
using System.Linq;

class Word
{
    public List<bool> HidenWordsBools(List<bool> hiddenBool)
    {
        Random random = new Random();
        int index;

        //counts how many false bools are in list
        int countBool = hiddenBool.Count(x => !x);

        // if there is there is three or less false bools in list it will change them to true
        if (countBool <= 3)
        {
            for (int i = 0; i < hiddenBool.Count; i++)
            {
                hiddenBool[i] = true;
            }
        }
        else
        {   
            int _loop = 3;

            // while loop to change 3 bools at random
            while (_loop > 0)
            {
                // do while loop will reroll if bool is already true
                do
                {
                    index = random.Next(hiddenBool.Count);
                }
                while (hiddenBool[index]);
                _loop --;
                hiddenBool[index] = true;
            }
        }

        return hiddenBool;
    }

    public bool CheckDone(List<bool> hiddenBool)
    {
        bool done;

        //counts the amount of false bools in list
        int countBool = hiddenBool.Count(x => !x);

        //IF no more false statements return done true
        if (countBool == 0)
        {
            return done = true;
        }

        return done = false;
    }

}