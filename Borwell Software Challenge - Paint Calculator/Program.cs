/// Author: Jake Turrell
/// Date: 14/07/2021
/// Started: 10:28
/// Finished: N/A

using System;
namespace Borwell_Software_Challenge___Paint_Calculator {
    class Program {
        static void Main() {
            // May be attatched to a GUI later.
            // Hungarian Notation

            // Var Asking.
            float fWidth = AskFloat("Width: ");
            float fLength = AskFloat("Length: ");
            float fHeight = AskFloat("Height: ");

            // Calculations
            float fFloorArea = fWidth * fLength;
            float fPaint = 2 * (fWidth + fLength) * fHeight;
            float fVolume = fWidth * fLength * fHeight;

            // Output
            Console.WriteLine("\nFloor Area: {0}", fFloorArea);
            Console.WriteLine("Amount of paint required to paint the walls: {0}", fPaint);
            Console.WriteLine("Volume of the room: {0}", fVolume);
            Console.ReadLine();
        }

        /// <summary>
        /// Prints question to the screen, asks for float
        /// will do checks.
        /// </summary>
        /// <param name="question"></param>
        /// <returns>user given input as a float</returns>
        static float AskFloat(string question) {
            // Var init
            float fResult;
            string sAns;

            do {
                Console.WriteLine(question);
                sAns = Console.ReadLine();

                // Checks valid number, and if result > 0
                // (cant have a room with negative or 0 width on wall)
            } while (float.TryParse(sAns, out fResult) && fResult > 0f); 

            return fResult;
        }
    }
}
