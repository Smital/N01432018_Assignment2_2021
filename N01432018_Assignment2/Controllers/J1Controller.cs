using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01432018_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Compute the total calories of meal
        /// </summary>
        /// <param name="burger">Represent the index of burger choice</param>
        /// <param name="side">Represent the index of drink choice</param>
        /// <param name="drink">Represent the index of side choice</param>
        /// <param name="dessert">Represent the index of dessert choice</param>
        /// <returns>
        /// Output shows total number of calories count after adding calorie value of 4 choices.
        /// Total Calories = Sum of each choice of calories.
        /// </returns>
        /// <example>
        ///  if Cheeseburger = 461 calories  choice = 1
        ///     Chef Salad = 70 Calories     choice = 3
        ///     Orange Juice = 160 calories  choice = 2
        ///     No Dessert = 0               choice = 4
        ///  then
        ///    api/J1/Menu/1 for burger choice/3 for side choice/2 for drink choice/4 for for dessert choice
        ///    api/J1/Menu/1/3/2/4 = Total calories of each choice ( 461 + 70 + 160 + 0 ) = 691
        ///  </example>
        ///  <logic>
        ///  Define burger calories ( 4 choice in 4 if-else statments ).After selection of one burger choice,
        ///  it will add calories to 3 food items such as
        ///  side order,drink and dessert in if statments.
        ///  </logic>

        [Route("api/J1/Menu/{burger}/{side}/{drink}/{dessert}")]
        [HttpGet]


        public int Menu(int burger, int side, int drink, int dessert)
        {
            int calories;

            if (burger == 1)
            {
                calories = 461;
            }
            else if (burger == 2)
            {
                calories = 431;
            }
            else if (burger == 3)
            {
                calories = 420;
            }
            else
            {
                calories = 0;
            }


            if (side == 1)
            {
                calories = calories + 100;
            }
            else if (side == 2)
            {
                calories = calories + 57;
            }
            else if (side == 3)
            {
                calories = calories + 70;
            }
            else
            {
                calories = calories + 0;
            }



            if (drink == 1)
            {
                calories = calories + 130;
            }
            else if (drink == 2)
            {
                calories = calories + 160;
            }
            else if (side == 3)
            {
                calories = calories + 118;
            }
            else
            {
                calories = calories + 0;
            }


            if (dessert == 1)
            {
                calories = calories + 167;
            }
            else if (dessert == 2)
            {
                calories = calories + 266;
            }
            else if (dessert == 3)
            {
                calories = calories + 75;
            }
            else
            {
                calories = calories + 0;
            }
            return calories;

        }


    }

}

    