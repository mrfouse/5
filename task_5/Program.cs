﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class program
{
        static void Main(string[] args)
        {
            Console.Write("введите текст: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("ваше самое длинное слово: {0}", str[index]);
            Console.ReadLine();
        }
    }