﻿using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string duplicate = "";

            for (int i = 0; i < original.Length; i++)
            {
                duplicate += original[i].ToString() + original[i];

            }
            return duplicate;
        }
    }
}
