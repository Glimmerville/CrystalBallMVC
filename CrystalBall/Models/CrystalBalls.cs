using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBall.Models
{
    public class CrystalBalls
    {
        //create an array of strings
        //get random number
        //print random string from array

        public string getResponse()
        {
            string[] responses = {"You are loved", "Serve others before you serve yourself.", "Small changes now are easier than huge changes later.", "Time is both friend and enemy." };
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length);
            return responses[num];
        }
    }
}