using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        ///<summary>
        /// Compute how many ways one can roll the value of 10.
        ///</summary>
        ///<param name="d1">Represent the dice 1 value</param>
        ///<param name="d2">Representtt the dice 2 value</param>
        ///<returns>
        /// The number of ways to get the sum 10 of two dices.
        ///</returns>
        ///<example>
        ///  if d1 = 6   
        ///     d2 = 8
        ///  then
        ///    Ans = There are 5 ways to get sum 10.
        ///</example>
        ///<logic>
        /// The if else condition checks the value of dice and returns the ways after arithmatic calculation.
        /// 1) If d1 and d2 is less than then there is no chance of getting the sum 10.
        ///    So there are 0 ways to get the sum 10
        /// 2) If d1 = d2 =5 then there would be only one ways to get the sum 10.Because 5 + 5 = 10 is the 
        ///    only way we can get sum 10.
        /// 3) If d1 = 6 and d2 < 10 then it checks condition in if else stament for all the value of d2
        ///    if d2 <=3 then there is no way to get sum 10
        ///    if d2 = 4,5,6,7,8,9 then the formula (d2/2)-1 will provide the ways to get the sum 10
        ///    If d2 >= 10 or m then there would be only 6 ways to get the sum 10.
        ///    for example d1=6,d2=4 then (4/2)-1 = 1 which means only one ways to get the sum 10.
        ///  4) like wise in all the value of d1 and d2 below the expression is caluculated to get the sum 10.
        ///  ffff
        ///</logic>
        ///  


        [Route("api/J2/DiceGame/{d1}/{d2}")]
        [HttpGet]


        public string DiceGame(int d1, int d2)
        {
            int ans;

            if (d1 <= 4 && d2 <= 4)
            {
                return "There are 0 ways to get theee sum 10";
            }
            else if (d1 == 5 && d2 == 5)
            {
                ans = d1 / d2;
                return "There is only " + ans + " way to get the sum 10";
            }

            else if (d1 == 6 && d2 <= 10)
            {
                if (d2 <= 3)
                {
                    return "There are 0 ways to get the sum 10";
                }
                else if (d2 == 4)
                {
                    ans = (d2 / 2) - 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 5)
                {
                    ans = (d2 / 2) - 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 6)
                {
                    ans = (d2 / 2);
                    return "There are " + ans + " ways to get the sum 10";
                }

                else if (d2 == 7)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 8)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + "ways to get the sum 10";
                }
                else if (d2 == 9)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else
                {
                    return "There are 6 ways to get the sum 10";
                }

            }
            else if (d1 == 7 && d2 <= 10)
            {
                if (d2 <= 3)
                {
                    return "There are 0 ways to get the sum 10";
                }
                else if (d2 == 4)
                {
                    ans = (d2 / 2);
                    return "There are " + ans + " ways to get the sum 10";
                }
                if (d2 == 5)
                {
                    ans = (d2 / 2);
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 6)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 7)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }

                else if (d2 == 8)
                {
                    ans = (d2 / 2) + 2;
                    return "There are " + ans + " ways to get the sum 10";
                }

                else if (d2 == 9)
                {
                    ans = (d2 / 2) + 2;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else
                {
                    return "There are 7 ways to get the sum 10";
                }
            }
            else if (d1 == 8 && d2 >= 8)
            {
                if (d2 <= 3)
                {
                    return "There are 0 ways to get the sum 10";
                }
                else if (d2 == 4)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                if (d2 == 5)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 6)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 7)
                {
                    ans = (d2 / 2) + 2;
                    return "There are " + ans + " ways to get the sum 10";
                }

                else if (d2 == 8)
                {
                    ans = (d2 / 2) + 3;
                    return "There are " + ans + " ways to get the sum 10";
                }


                else if (d2 == 9)
                {
                    ans = (d2 / 2) + 3;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else
                {

                    return "There are 8 ways to get the sum 10";
                }
            }
            else if (d1 == 9 && d2 >= 9)
            {
                if (d2 <= 3)
                {
                    return "There are 0 ways for to get the sum 10";
                }
                else if (d2 == 4)
                {
                    ans = (d2 / 2) - 2;
                    return "There are " + ans + " ways to get the sum 10";
                }
                if (d2 == 5)
                {
                    ans = (d2 / 2) - 2;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 6)
                {
                    ans = (d2 / 2) + 1;
                    return "There are " + ans + " ways to get the sum 10";
                }
                if (d2 == 7)
                {
                    ans = (d2 / 2) + 2;
                    return "There are " + ans + " ways to get the sum 10";
                }

                else if (d2 == 8)
                {
                    ans = (d2 / 2) + 2;
                    return "There are " + ans + " ways to get the sum 10";
                }
                else if (d2 == 9)
                {
                    ans = (d2 / 2) + 4;
                    return "There are " + ans + " ways to get the sum 10";
                }

                else
                {
                    ans = (d2 / 2) + 4;
                    return "There are " + ans + " ways to get the sum 10";
                }
            }

            else
            {
                return "There are 9 ways to get the sum 10";
            }

        }




    }
}

//////End
