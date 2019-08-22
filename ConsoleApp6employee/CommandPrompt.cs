using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommandPrompt

{
    class CommandPrompt
    {
        int height;
        int colums;
        string[] screenText;

        // Constructor
        public CommandPrompt(int height, int columns)


        {
            //set the default backgroundcolor
            //set the default foregroundcolor
            //create screen to hold the rows height

            screenText = new string[height];


            Console.SetWindowSize(columns, height + 7);

            // lets set the screen text to empty
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";

            }

        }

    }

}

