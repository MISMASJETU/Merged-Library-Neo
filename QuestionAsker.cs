using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created for mergedLibraryNeo by MMG 2022
namespace MergedLibraryNeo
{
    internal class QuestionAsker //My magnum opus from java is finaly on csharp
    {
        public void NewFrame()
        {
            for (int i = 0; i < 50; i++)
            { //makes white space to render next frame
                Console.Clear();
            }
        }
        public int Question(String question, int lowestAnswer, int highestAnswer)
        { //asks player question and makes it so player can never enter bad input and crash the game
            bool tmpChosen = false; //checks if player has chosen an option
            int optionChosen = -431743157; //just to make sure in case of inputMismatch
            bool alreadyTryed = false;
            string tmpConversion;
            while (!tmpChosen)
            {
                NewFrame();
                Console.WriteLine(question); //asks question
                if (alreadyTryed)
                { //if player tried input something once, but it did not fit, run this
                    Console.WriteLine("Try again");
                }
                
                tmpConversion = Console.ReadLine();
                //handles potential mismatch from user
                if (int.TryParse(tmpConversion, out optionChosen))
                {

                } 
                else
                {
                    alreadyTryed = true; //if input was wrong, it will show player to try again
                }
                
                

                if (lowestAnswer <= optionChosen && optionChosen <= highestAnswer)
                { //checks if selected option fits
                    tmpChosen = true;
                }
                else
                {
                    alreadyTryed = true; //if input was wrong, it will show player to try again
                }

            }
            return optionChosen;
        }
    }
}
