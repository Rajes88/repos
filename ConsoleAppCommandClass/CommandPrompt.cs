using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleAppCommandClass
{
    class CommandPrompt
    {

        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;
        int height;
        int columns;
        string[] screenText;

        //Constructor
        public CommandPrompt(int height, int columns)
        {
            this.columns = columns;
            this.height = height;
            //set the default backgroundcolor
           backgroundColor=ConsoleColor.Black;
            //set the default foregroundcolor
            foregroundColor = ConsoleColor.Green;
            //create screen to hold the rows height

            screenText = new string[height];

            Console.SetWindowSize(columns, height + 7);

            //lets set the screen text to emty
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";

            }
        }

        public void Display()

        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.Clear();
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }

        }   // end of SetForegroundColor

        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }   // end of SetBackgroundColor

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }   // end of SetForegroundColor
        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black; break;
                case "red": color = ConsoleColor.Red; break;
                case "yellow": color=ConsoleColor.Yellow; break;
                case "blue": color = ConsoleColor.Blue; break;
                case "white": color = ConsoleColor.White; break;
                 



                default: color = ConsoleColor.DarkGray; break;
            }
            return color;
        }
        public void SaveScreen(string fileName)
        {
            FileStream stream;
            StreamWriter textOut = null;
            try
            {
                fileName = "C://temp/" + fileName;
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(stream);
                textOut.WriteLine("This is my Text");
                //your code here!!!
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }   // of of SaveScreen method



        public void ClearScreen()
        {
            for (int i = 0; i<screenText.Length;  i++)
            {
                screenText[i] = "";
            }
        }
        public void SetScreenText(int lineNumber, string lineText)
        {
            screenText[lineNumber] = lineText;
        }
    }
}

        // end of ConvertColor method






