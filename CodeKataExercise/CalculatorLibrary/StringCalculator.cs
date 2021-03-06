﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StringCalculator
    {
        
        public int Add(string numbers)
        {
            int sumToReturn = 0;
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.StartsWith("//"))
            {
                if (numbers.Length < 4)
                    return 0;

                char delimiter = numbers[2];
                if (numbers[3] != '\n')
                    return 0;
                string[] nums = numbers.Substring(4).Split(delimiter);
                sumToReturn = AddCollection(nums);
            }
            else
            {
                string[] nums = numbers.Split(new[] {"\n", ","}, StringSplitOptions.None);
                sumToReturn = AddCollection(nums);
            }
                
            return sumToReturn;
        }

        private int AddCollection(string[] numbers)
        {
            int sum = 0;
            foreach (string value in numbers)
            {
                int intValue = Convert.ToInt32(value);
                if (intValue < 0)
                {
                    throw new Exception(string.Format("Negatives not allowed"));
                }
                sum += intValue;
            }
            return sum;
        }
    }
}
