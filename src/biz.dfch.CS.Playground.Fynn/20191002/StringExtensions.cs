﻿/**
 * Copyright 2019 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace biz.dfch.CS.Playground.Fynn._20191002
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string str)
        {
            // VARIANTE 1
            //var result = "";
            //foreach (var character in str.ToCharArray())
            //{
            //    if (' ' != character)
            //    {
            //       result = string.Concat(result, character);
            //    }
            //}

            // VARIANTE 2
            var result = "";

            for (var i = 0; i < str.Length; i++)
                if (' ' == str[i])
                    result += str[i];
                //result = $"{result}{str[i]}";
                //result = result + str[i];

                //str = str.Remove(i,1);
                //i--;

            return result;

            //return str;

            // VARIANTE 3
            //return str.Replace(" ", string.Empty);
        }

        public static int CountLetter(this string str, char c)
        {
            var count = 0;
            for (var i = 0; i < str.Length; i++)
                if (str[i] == c)
                    count++;

            return count;
        }
    }
}