using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations arrayOperations =  new ArrayOperations();
            //arrayOperations.AddDataToArray();
            //arrayOperations.SortingDesending();
            //arrayOperations.SortingAssanding();


            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.Disply();
            
            ticTacToeGame.Play();
            //class1 class1 = new class1();
            ////class1.SortingAndSearchingOperationOnArray();
            ////class1.MatrixMultiplication();
            //class1.ArrayOfFibonacciNum();

            Console.ReadLine();
        }
    }
}
