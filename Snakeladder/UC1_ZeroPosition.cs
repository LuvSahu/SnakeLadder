using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class UC1_ZeroPosition
    {
       
            public int Player1 = 0;
            public int Player2 = 0;

        //Snake:47 to 9, 62 to 40, 96 to 75
        //Ladder: 6 to 46, 19 to 43,52 to 71, 57 to 98
        public void SnakeLadder()
            {

                while (Player1 <= 100 && Player2 <= 100)
                {
                    Random random = new Random();
                    int Dice = random.Next(1, 7);

                    int Option = random.Next(0, 3);

                    if (Option == 1)
                    {
                        Player1 += Dice;


                        if (Player1 == 6)
                        {
                            Console.WriteLine("Player 1 Ladder 6");
                            Player1 += 40;
                            Option = 1;
                        }
                        else if (Player1 == 19)
                        {
                            Console.WriteLine("Player 1 Ladder 19");
                            Player1 += 24;
                            Option = 1;
                        }
                        else if (Player1 == 52)
                        {
                            Console.WriteLine("Player 1 Ladder 52");
                            Player1 += 19;
                            Option = 1;
                        }
                        else if (Player1 == 57)
                        {
                            Console.WriteLine("Player 1 Ladder 57");
                            Player1 += 41;
                            Option = 1;
                        }
                        //Snake 47 to 9, 62 to 40, 96 to 75
                        else if (Player1 == 47)
                        {
                            Console.WriteLine("Player 1 Snake 47");
                            Player1 += -38;
                        }
                        else if (Player1 == 62)
                        {
                            Console.WriteLine("Player 1 Snake 62");
                            Player1 += -22;
                        }
                        else if (Player1 == 96)
                        {
                            Console.WriteLine("Player 1 Snake 96");
                            Player1 += -21;
                        }
                        Console.WriteLine("Player1 " + Player1);
                    }
                    if (Option == 2)
                    {
                        Player2 += Dice;


                        if (Player2 == 6)
                        {
                            Console.WriteLine("Player 2 Ladder 6");
                            Player2 += 40;
                            Option = 2;
                        }
                        else if (Player2 == 19)
                        {
                            Console.WriteLine("Player 2 Ladder 19");
                            Player2 += 24;
                            Option = 2;
                        }
                        else if (Player2 == 52)
                        {
                            Console.WriteLine("Player 2 Ladder 52");
                            Player2 += 19;
                            Option = 2;
                        }
                        else if (Player2 == 57)
                        {
                            Console.WriteLine("Player 2 Ladder 57");
                            Player2 += 41;
                            Option = 2;
                        }
                        //Snake 47 to 9, 62 to 40, 96 to 75
                        else if (Player2 == 47)
                        {
                            Console.WriteLine("Player 2 Snake 47");
                            Player1 += -38;
                        }
                        else if (Player2 == 62)
                        {
                            Console.WriteLine("Player 2 Snake 62");
                            Player1 += -22;
                        }
                        else if (Player2 == 96)
                        {
                            Console.WriteLine("Player 2 Snake 96");
                            Player2 += -21;
                        }
                        Console.WriteLine("Player2 " + Player2);
                    }
                    else
                    {
                        Console.WriteLine("Player stays in the same Position");
                    }

                    if (Player1 >= 100)
                    {
                        Console.WriteLine("Player1 is Won");
                        break;
                    }
                    else if (Player2 >= 100)
                    {
                        Console.WriteLine("Player2 is Won");
                        break;
                    }

                }

            }
        }

    }


