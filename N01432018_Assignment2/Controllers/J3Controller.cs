using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        ///<summary>
        ///<logic>
        /// Step:1 : Intialise the array char[], int count = 0 ,timeout=1; 
        /// Step:2 : Ask user for the input string and put constraints that input character should be in 
        ///          lowercase.
        /// Step:3 : If user enter "a"
        /// Step:4 : Intialise loop to iterate the character.
        /// Step:5 : First for(i) loop take the first character and store that character in to array char[].
        /// Step:6 : count variable increse by the positon of the character when the new character comes.
        ///          for example for character a the count variable increse by the position, count=1 because 
        ///          the position of a is 1.
        /// Step:7 : if the consecutive character comes then timeout = count + timeout;
        /// Step:7 : all the characters store in an array and there count will store in count variable one by one.
        /// Step:8 : after storing the characters if the array has "halt" keyword then the program will stop 
        ///          the reading and show output = 0.
        /// Step:9 : In the ouptput, the count variable will be printed which shows the count of the 
        ///          characters in the string.
        /// For example String : abab
        ///                      count for a = count + 1 = 0 + 1 = 1
        ///                      count for b= 1 + 2(position of b=2) =3
        ///                      count for a= 3 + 1(position of a=1) =4
        ///                      count for b= 4 + 2(position of b=2) =6
        ///             The output will be 6 (2 22 2 22 ) = 6
        /// For example String : abba
        ///                      count for a = count + 1 = 0 + 1 = 1
        ///                      count for b= 1 + 2(position of b=2) =3
        ///                      count for b = 3 + 2(position of b=2) = 5 + 1(timeout) =6
        ///                      count for b= 6 + 1(position of a=1) = 7
        ///             The output will be 6 (2 22 2 22 ) = 7
        ///    //////  
        ///    J3 Problem Siolution
    }

    ///</logic>
    ///</summary>
}

