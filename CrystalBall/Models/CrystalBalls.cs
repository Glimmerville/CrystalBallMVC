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
            string[] responses = {"Serve others before you serve yourself.", "Small changes now are easier than huge changes later.", "Time is both friend and enemy.", "That wasn't chicken.", "That red light you ran had a police camera.", "You will spill something on your shirt.", "That lump is cancer.", "Don't play the lottery today.", "You forgot to let the dog out.", "Today will be partly cloudy with a high of 70 degrees." };
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length);
            return responses[num];
        }
    }
}