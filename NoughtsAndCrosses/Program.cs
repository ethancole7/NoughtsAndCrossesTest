using System;
using System.Diagnostics;

namespace NoughtsAndCrosses
{
    class Program

    {
        //PUSH FROM MACCC
        public static char[,] board = new char[3, 3] { { '_', '_', '_' }, { '_', '_', '_' }, { '_', '_', '_' } };
        public static char computerSymbol;
        public static char playersSymbol;

        static void Main(string[] args)
        {
            
            bool gameOver = false;
            bool inGame = true;
            int playerRow, playerColumn;
            int computerRow, computerColumn;
            int goNumber =0;



            while (!gameOver)
            {
                inGame = true;
                goNumber = 0;
                board = new char[3, 3] { { '_', '_', '_' }, { '_', '_', '_' }, { '_', '_', '_' } };
                while (inGame == true)
                {
                    goNumber += 1;
                    if (goNumber == 1)
                    {
                        playersSymbol = getPlayersSymbol();
                        
                        if (playersSymbol == 'O')
                        {
                            computerSymbol = 'X';
                        }
                        else if (playersSymbol == 'X')
                        {
                            computerSymbol = 'O';
                        }

                    }
                    getValidPlayerCoordinates(out playerRow, out playerColumn);
                    board[playerRow, playerColumn] = playersSymbol;
                    computerGo(out computerRow, out computerColumn);
                    board[computerRow, computerColumn] = computerSymbol;

                    PrintBoard(board);

                    inGame = !checkForGameOver();

                    

                }
                gameOver = menu(gameOver);
                
                
            }

            
            
            

        }

        public static void PrintBoard(char[ , ] board)
        {
            Console.WriteLine();
            Console.WriteLine("\t1 \t2 \t3");
            for (int row = 0; row < board.GetLength(0); row++)
            {
                Console.Write(row + 1);
                for (int collumn = 0; collumn < board.GetLength(1); collumn++)
                {
                    Console.Write("\t" + board[row, collumn]);
                }

                Console.WriteLine();
            }
        }


        public static void getValidPlayerCoordinates(out int playerColumn, out int playerRow)
        {
            bool validColumn = true;
            bool validRow = true;
            bool alreadyPlayed = false;
            string temp;
            do
            {

                Console.WriteLine();
                if (alreadyPlayed == true)
                {
                    Console.WriteLine("Error! You cannot play here, someone has already used this spot.");
                    Console.WriteLine();
                }
                else if (validColumn == false || validRow == false)
                {
                    Console.WriteLine("Error! Enter a valid integer between 1 and 3");
                }
                alreadyPlayed = false;
                validColumn = true;
                Console.WriteLine("Please choose the row (1-3) you wish to play in");
                temp = Console.ReadLine();
                validColumn = int.TryParse(temp, out (playerColumn));
                playerColumn -= 1;

                if (playerColumn > 2 || playerColumn < 0)
                {
                    validColumn = false;
                }

                validRow = true;
                Console.WriteLine("Please choose the column (1-3) you wish to play in");
                temp = Console.ReadLine();
                validRow = int.TryParse(temp, out (playerRow));
                playerRow -= 1;

                if (playerRow > 2 || playerRow < 0)
                {
                    validRow = false;
                }

                if (board[playerColumn, playerRow] != '_')
                {
                    alreadyPlayed = true;
                    Console.WriteLine("Whoops");
                    validColumn = false;
                    validRow = false;
                
                }
                



            } while (validColumn == false || validRow == false);

            Console.Clear();
        }

        public static char getPlayersSymbol()
        {
            bool valid = true, validCharacterConversion = true;

            string temp;
            char playersSymbol = ' ';
            do
            {
                Console.Clear();
                if (valid == false)
                {
                    Console.WriteLine("ERROR! Please either enter an X or an O");
                    Console.WriteLine();
                }
                valid = true;
                Console.WriteLine("What symbol do you want to be (O/X)");//o
                temp = Console.ReadLine();//o
                
                
                temp = temp.ToUpper();
               

                validCharacterConversion = char.TryParse(temp, out playersSymbol);

                if (playersSymbol != 'O' && playersSymbol != 'X')
                {
                    valid = false;
                }
                

            } while (valid == false);
            Console.Clear();
            return playersSymbol;
        }

        public static bool checkForGameOver()
            
        {
            Debug.WriteLine("Check for game over called");
            Console.WriteLine("check for game over called");
            bool gameOver = false;
            //check every row column and diagonal for 3 playerSymbols
            #region
            if (board[0, 0] == playersSymbol && board[0, 1] == playersSymbol && board[0, 2] == playersSymbol)
            {
                //XXX
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[1, 0] == playersSymbol && board[1, 1] == playersSymbol && board[1, 2] == playersSymbol)
            {
                //XXX
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[2, 0] == playersSymbol && board[2, 1] == playersSymbol && board[2, 2] == playersSymbol)
            {
                //XXX
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }

            else if (board[0, 0] == playersSymbol && board[1, 0] == playersSymbol && board[2, 0] == playersSymbol)
            {
                //X
                //X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[0, 1] == playersSymbol && board[1, 1] == playersSymbol && board[2, 1] == playersSymbol)
            {
                //X
                //X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[0, 2] == playersSymbol && board[1, 2] == playersSymbol && board[2, 2] == playersSymbol)
            {
                //X
                //X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }

            else if (board[0, 0] == playersSymbol && board[1, 1] == playersSymbol && board[2, 2] == playersSymbol)
            {
                //    X
                //  X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[2, 0] == playersSymbol && board[1, 1] == playersSymbol && board[0, 2] == playersSymbol)
            {
                //    X
                //  X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("PLAYER WINS!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }


            #endregion

            //if so output x wins and end game
            //check every row column and diagonal for 3 Y
            #region
            else if (board[0, 0] == computerSymbol && board[0, 1] == computerSymbol && board[0, 2] == computerSymbol)
            {
                //XXX
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[1, 0] == computerSymbol && board[1, 1] == computerSymbol && board[1, 2] == computerSymbol)
            {
                //XXX
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[2, 0] == computerSymbol && board[2, 1] == computerSymbol && board[2, 2] == computerSymbol)
            {
                //XXX
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }

            else if (board[0, 0] == computerSymbol && board[1, 0] == computerSymbol && board[2, 0] == computerSymbol)
            {
                //X
                //X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[0, 1] == computerSymbol && board[1, 1] == computerSymbol && board[2, 1] == computerSymbol)
            {
                //X
                //X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[0, 2] == computerSymbol && board[1, 2] == computerSymbol && board[2, 2] == computerSymbol)
            {
                //X
                //X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }

            else if (board[0, 0] == computerSymbol && board[1, 1] == computerSymbol && board[2, 2] == computerSymbol)
            {
                //    X
                //  X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            else if (board[2, 0] == computerSymbol && board[1, 1] == computerSymbol && board[0, 2] == computerSymbol)
            {
                //    X
                //  X
                //X
                //player wins
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine();
                gameOver = true;
                return gameOver;
            }
            #endregion
            //if so output x wins and end game

            //LASTLY check for playable spaces
            //if no playable spaces output draw and end game.
            bool playableSpace = false;
            if (gameOver == false)
            {
                playableSpace = false;
                gameOver = true;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int column = 0; column < board.GetLength(1); column++)
                    {
                        if (board[row, column] == '_')
                        {
                            //there is a playable space
                            playableSpace = true;
                            gameOver = false;
                        }

                    }
                }
                Console.WriteLine(playableSpace);

            }
            
            else if (playableSpace == false)
            {
                Console.WriteLine("YOU DREW!");
                gameOver = true;
                
            }

            return gameOver;
        }

        public static void computerGo(out int computerRow, out int computerColumn)
        {
            computerRow = 0;
            computerColumn = 0;
            //check for places for computer to win
            #region

            if (board[0, 0] == computerSymbol && board[0, 1] == computerSymbol && board[0, 2] == '_')
            {
                computerRow = 0;
                computerColumn = 2;
                return;

            }
            else if (board[1, 0] == computerSymbol && board[1, 1] == computerSymbol && board[1, 2] == '_')
            {
                computerRow = 1;
                computerColumn = 2;
                return;

            }
            else if (board[2, 0] == computerSymbol && board[2, 1] == computerSymbol && board[2, 2] == '_')
            {
                computerRow = 2;
                computerColumn = 2;
                return;

            }
            else if (board[0, 0] == computerSymbol && board[1, 0] == computerSymbol && board[2, 0] == '_')
            {
                computerRow = 2;
                computerColumn = 0;
                return;

            }
            else if (board[0, 1] == computerSymbol && board[1, 1] == computerSymbol && board[2, 1] == '_')
            {
                computerRow = 2;
                computerColumn = 1;
                return;

            }
            else if (board[0, 2] == computerSymbol && board[1, 2] == computerSymbol && board[2, 2] == '_')
            {
                computerRow = 2;
                computerColumn = 2;
                return;

            }

            else if (board[0, 2] == computerSymbol && board[1, 1] == computerSymbol && board[2, 0] == '_')
            {
                computerRow = 2;
                computerColumn = 0;
                return;
            }

            else if (board[0, 0] == computerSymbol && board[1, 1] == computerSymbol && board[2, 2] == '_')
            {
                computerRow = 2;
                computerColumn = 2;
                return;
            }
            #endregion


            //Check for anywhere to go to stop the player getting 3 in a row
            #region

            if (board[0, 0] == playersSymbol && board[0, 1] == playersSymbol && board[0, 2] == '_')
            {
                computerRow = 0;
                computerColumn = 2;
                return;

            }
            else if (board[1, 0] == playersSymbol && board[1, 1] == playersSymbol && board[1, 2] == '_')
            {
                computerRow = 1;
                computerColumn = 2;
                return;

            }
            else if (board[2, 0] == playersSymbol && board[2, 1] == playersSymbol && board[2, 2] == '_')
            {
                computerRow = 2;
                computerColumn = 2;
                return;

            }
            else if (board[0, 0] == playersSymbol && board[1, 0] == playersSymbol && board[2, 0] == '_')
            {
                computerRow = 2;
                computerColumn = 0;
                return;

            }
            else if (board[0, 1] == playersSymbol && board[1, 1] == playersSymbol && board[2, 1] == '_')
            {
                computerRow = 2;
                computerColumn = 1;
                return;

            }
            else if (board[0, 2] == playersSymbol && board[1, 2] == playersSymbol && board[2, 2] == '_')
            {
                computerRow = 2;
                computerColumn = 2;
                return;

            }

            else if (board[0, 2] == playersSymbol && board[1, 1] == playersSymbol && board[2, 0] == '_')
            {
                computerRow = 2;
                computerColumn = 0;
                return;
            }

            else if (board[0, 0] == playersSymbol && board[1, 1] == playersSymbol && board[2, 2] == '_')
            {
                computerRow = 2;
                computerColumn = 2;
                return;
            }
            #endregion

            //random x y position
            #region

            else
            {
                bool validRandomPlacement = false;
                while (validRandomPlacement == false)
                {
                    validRandomPlacement = true;
                    Random rnd = new Random();
                    computerRow = rnd.Next(0, 3);
                    computerColumn = rnd.Next(0, 3);

                    if (board[computerRow, computerColumn] != '_')
                    {
                        validRandomPlacement = false;
                    }

                    if (validRandomPlacement == true)
                    {
                        return;
                    }
                    
                }
                
            }
            #endregion


            
        }

        public static bool menu(bool gameOver)
        {
            Debug.WriteLine("menu system called");

            bool valid = true;
            string choice;
            do
            {
                valid = true;
                Console.WriteLine("Would you like to play again? (Y/N)");
                choice = Console.ReadLine();

                if (choice.ToUpper() == "Y")
                {
                    gameOver = false;
                    break;
                }
                else if (choice.ToUpper() == "N")
                {
                    gameOver = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter either (Y/N)");
                    Console.WriteLine();
                    valid = false;
                }
            } while (valid == false);
            return gameOver;
           
        }
    }

}
