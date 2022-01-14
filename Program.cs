using System;
    namespace tictactoe
    {
        class Program
        {
            static void Main(string[] args)
            {
                string p = next("");
                string[] game = MakeGame();
                while (!Finish(game) && !Winner(game))
                {
                    ViewGame(game);
                    move(p, game);
                    p = next(p);
                }

                ViewGame(game);
                Console.WriteLine("\nThank you for playing my interactive tictactoe game.\n");
            }
            static string[] MakeGame()
            {
                string[] game = new string[16];
                for (int i = 0; i < 16; i++)
                {
                    game[i] = (i + 1).ToString();
                }
                return game;
                

                
            }
            static bool Winner(string[] game)
            {

                    return ((game[0] == "x" && game[1] == "x" && game[2] == "x" && game[3] == "x") 
                            || (game[4] == "x" && game[5] == "x" && game[6] == "x" && game[7] == "x") 
                            || (game[8] == "x" && game[9] == "x" && game[10] == " x" && game[11] == " x")
                            || (game[12] == "x" && game[13] == "x" && game[14] == "x" && game[15] == "x")  
                            || (game[0] == "x" && game[4] == "x" && game[8] == "x" && game[12] == "x") 
                            || (game[1] == "x" && game[5] == "x" && game[9] == "x" && game[13] == "x") 
                            || (game[2] == "x" && game[6] == "x" && game[10] == "x" && game[14] == "x")
                            || (game[3] == "x" && game[7] == "x" && game[11] == "x" && game[15] == "x")  
                            || (game[0] == "x" && game[5] == "x" && game[10] == "x" && game[15] == "x")
                            || (game[3] == "x" && game[6] == "x" && game[9] == "x" && game[12] == "x"))||
                            ((game[0] == "o" && game[1] == "o" && game[2] == "o" && game[3] == "o") 
                            || (game[4] == "o" && game[5] == "o" && game[6] == "o" && game[7] == "o") 
                            || (game[8] == "o" && game[9] == "o" && game[10] == "o" && game[11] == "o")
                            || (game[12] == "o" && game[13] == "o" && game[14] == "o" && game[15] == "o")  
                            || (game[0] == "o" && game[4] == "o" && game[8] == "o" && game[12] == "o") 
                            || (game[1] == "o" && game[5] == "o" && game[9] == "o" && game[13] == "o") 
                            || (game[2] == "o" && game[6] == "o" && game[10] == "o" && game[14] == "o")
                            || (game[3] == "o" && game[7] == "o" && game[11] == "o" && game[15] == "o")  
                            || (game[0] == "o" && game[5] == "o" && game[10] == "o" && game[15] == "o")
                            || (game[3] == "o" && game[6] == "o" && game[9] == "o" && game[12] == "o"));
              
            }
            static bool Finish(string[] game)
            {
                
                bool ans = true;
                for (int i = 0; i < 9; i++)
                {
                    if (game[i] != "x" && game[i] != "o")
                    {
                        ans = false;
                        break;
                    }
                }
                return ans;

            }


            static void ViewGame(string[] game)
            {

                    Console.WriteLine();
                    Console.WriteLine($" {game[0]}| {game[1]}| {game[2]}| {game[3]}");
                    Console.WriteLine("--+--+--+--");
                    Console.WriteLine($" {game[4]}| {game[5]}| {game[6]}| {game[7]}");
                    Console.WriteLine("--+--+--+--");
                    Console.WriteLine($" {game[8]}|{game[9]}|{game[10]}|{game[11]}");
                    Console.WriteLine("--+--+--+--");
                    Console.WriteLine($"{game[12]}|{game[13]}|{game[14]}|{game[15]}");
    

            }
            
            static void move(string p , string[] game)
            {
                Console.Write($"\n{p}'s turn to choose a square (1-9): ");
                int square = Convert.ToInt32(Console.ReadLine());
                game[square - 1] = p;
            }
            static string next(string curr)
            {
                string p = "o";
                if (curr == "" || curr == "o")
                {
                    p = "x";
                }
            return p;
            }
        }
    }