using System;

namespace Lernatelier_Spiel_Zahlen_raten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string titel = @"

▄▄▄█████▓ ██░ ██ ▓█████      ▄████  █    ██ ▓█████   ██████   ██████      ██████  ██▓ ███▄ ▄███▓ █    ██  ██▓    ▄▄▄     ▄▄▄█████▓ ▒█████   ██▀███  
▓  ██▒ ▓▒▓██░ ██▒▓█   ▀     ██▒ ▀█▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▒██    ▒    ▒██    ▒ ▓██▒▓██▒▀█▀ ██▒ ██  ▓██▒▓██▒   ▒████▄   ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒
▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██░▄▄▄░▓██  ▒██░▒███   ░ ▓██▄   ░ ▓██▄      ░ ▓██▄   ▒██▒▓██    ▓██░▓██  ▒██░▒██░   ▒██  ▀█▄ ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒
░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░▓█  ██▓▓▓█  ░██░▒▓█  ▄   ▒   ██▒  ▒   ██▒     ▒   ██▒░██░▒██    ▒██ ▓▓█  ░██░▒██░   ░██▄▄▄▄██░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄  
  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▒▓███▀▒▒▒█████▓ ░▒████▒▒██████▒▒▒██████▒▒   ▒██████▒▒░██░▒██▒   ░██▒▒▒█████▓ ░██████▒▓█   ▓██▒ ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒
  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ░▒   ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░   ▒ ▒▓▒ ▒ ░░▓  ░ ▒░   ░  ░░▒▓▒ ▒ ▒ ░ ▒░▓  ░▒▒   ▓▒█░ ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░
    ░     ▒ ░▒░ ░ ░ ░  ░     ░   ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░   ░ ░▒  ░ ░ ▒ ░░  ░      ░░░▒░ ░ ░ ░ ░ ▒  ░ ▒   ▒▒ ░   ░      ░ ▒ ▒░   ░▒ ░ ▒░
  ░       ░  ░░ ░   ░      ░ ░   ░  ░░░ ░ ░    ░   ░  ░  ░  ░  ░  ░     ░  ░  ░   ▒ ░░      ░    ░░░ ░ ░   ░ ░    ░   ▒    ░      ░ ░ ░ ▒    ░░   ░ 
          ░  ░  ░   ░  ░         ░    ░        ░  ░      ░        ░           ░   ░         ░      ░         ░  ░     ░  ░            ░ ░     ░     
                                                                                                                                                    
";
            Console.WriteLine(titel);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;


            try
            {
                int choose;

                Console.WriteLine("What game do you want to play?");
                Console.WriteLine("Please write [10] for the game with 1 - 10, [50] for a game with 1-50 and [100] for the game with 1 - 100.");
                choose = Convert.ToInt32(Console.ReadLine());


                if (choose == 10)
                {
                    Random randomNumber = new Random();
                    int random = randomNumber.Next(1, 11); //immer +1 für definierten Bereich

                    int attemps = -1;
                    int UserGuess = 0;


                    Console.WriteLine("I think a number between 1 and 10. " +
                        "Guess the number by typing your number." +
                        "See if you can guess it in 10 turns or fewer. We'll tell you if your guess was too high or too low. " +
                        "At the end you'll get a little suprise...;)");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Are you ready?");
                    Console.Read();

                    Console.WriteLine(random);
                    Console.ReadKey();

                    Console.Clear();



                    // ++++++++++++++++++++++++++++++++++++++++++++
                    // Hauptlogik/Hauptlauf
                    // ++++++++++++++++++++++++++++++++++++++++++++


                    while (!(random == UserGuess))
                    {
                        try
                        {
                            ++attemps;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Eingabe: ");
                            UserGuess = int.Parse(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.White;

                            if (UserGuess == 666)
                            {
                                Console.WriteLine("Hey, you won't call the satan, right? So, now guess again, else you'll get eaten by the titans!");
                            }
                            else if (UserGuess == 69)
                            {
                                Console.WriteLine("Hey, you looser, stop that! It's not funny! Guess again!");
                            }
                            else if (UserGuess == 143)
                            {
                                Console.WriteLine("Naww, I love you too. But now we don't have time for that, sorry honey :c. Please guess the number, so we can continue.");
                            }
                            else if (!(UserGuess > 0 && UserGuess < 11))
                            {
                                throw new Exception();
                            }
                            else if (UserGuess > random)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You're thinking too big. Please try again.");
                            }
                            else if (UserGuess < random)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You're thinking too small. Please try again.");
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Please write a number between 1 and 10. Else I will kick you out of this game and you'll be killed by the titaaaaaaaaaaaaans!");
                        }
                    }


                    //+++++++++++++++++++++++++++++++++++++++++++
                    // Nachlauf
                    //+++++++++++++++++++++++++++++++++++++++++++
                    //
                    // z.B. Habe ich alle Dateien Closed, usw. usw.


                    Console.ForegroundColor = ConsoleColor.White;

                    if (attemps < 2)
                    {
                        Console.WriteLine("Wow, your're a cheater. You just got " + attemps + " attemps. Did you really just guessed the number or are you just a genius?!");
                    }
                    else if (attemps < 3)
                    {
                        Console.WriteLine("Wow, that was a good one. You got " + attemps + " attemps to guess the number. Wow, you're really a talent!");
                    }
                    else if (attemps < 4)
                    {
                        Console.WriteLine("Dude, you're really good. You just got " + attemps + " attemps. Just a little practice then you'll manage to get just one attemp. Sheeesh, I think that was just luck.");
                    }
                    else if (attemps < 5)
                    {
                        Console.WriteLine("Wow, that was nice. You got " + attemps + " attemps to guess the number. You just need a little practice, then you'll be a genius.");
                    }
                    else if (attemps < 6)
                    {
                        Console.WriteLine("Mh, well. You got " + attemps + " attemps to guess the secret number. Well with a little more practice you'll get better.");
                    }
                    else if (attemps < 7)
                    {
                        Console.WriteLine("Mh, that could be better. Well, you got " + attemps + " attemps to guess the number.");
                    }
                    else if (attemps < 8)
                    {
                        Console.WriteLine("Well, it could be better. You got " + attemps + " attemps too guess the number. Just a little more luck then you'll be better in this game.");
                    }
                    else if (attemps < 9)
                    {
                        Console.WriteLine("Hey, this game isn't so difficult. But well, you got " + attemps + " attemps. But it's okay, you can practice and get better! (≧∇≦)ﾉ");
                    }
                    else if (attemps < 10)
                    {
                        Console.WriteLine("Okay. That wasn't so hard, wasn't it? For that you needet " + attemps + " attemps to guess it. Well, now you can try it again, not?");
                    }
                    else if (attemps < 11)
                    {
                        Console.WriteLine("Finally, you got it! You had " + attemps + " attemps to guess the number! Phu, that was a close one...");
                    }
                    else if (attemps > 10)
                    {
                        Console.WriteLine("Nooo, you've lost. You had " + attemps + " attemps to guess the number, but you didn't manage to guess it in 10 attemps. I'm sorry, but you need to try again. With a little more luck you'll get it. ´U´");
                    }

                    Console.ReadKey();
                }



                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



                if (choose == 50)
                {
                    Random randomNumber = new Random();
                    int ran = randomNumber.Next(1, 51); //immer +1 für definierten Bereich
                    int attemps = -1;
                    int UG = 0;

                    Console.WriteLine("I think a number between 1 and 50. " +
                        "Guess the number by typing your number." +
                        "See if you can guess it in 10 turns or fewer. We'll tell you if your guess was too high or too low. " +
                        "At the end you'll get a little suprise...;)");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Are you ready?");
                    Console.Read();

                    Console.WriteLine(ran);
                    Console.ReadKey();

                    Console.Clear();


                    //++++++++++++++++++++++++++++++++++++++++++++
                    //Hauptlogik/Hauptlauf
                    //++++++++++++++++++++++++++++++++++++++++++++



                    while (!(ran == UG))
                    {
                        try
                        {
                            ++attemps;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Eingabe: ");
                            UG = int.Parse(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.White;

                            if (UG == 666)
                            {
                                Console.WriteLine("Hey, you won't call the satan, right? So, now guess again, else you get killed by the LoV!");
                            }
                            else if (UG == 69)
                            {
                                Console.WriteLine("Hey, you looser, stop that! It's not funny! Guess again!");
                            }
                            else if (UG == 143)
                            {
                                Console.WriteLine("Naww, I love you too. But now we don't have time for that, sorry honey :c. Please guess the number, so we can continue.");
                            }
                            else if (!(UG > 0 && UG <= 50))
                            {
                                throw new Exception();
                            }
                            else if (UG > ran)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You're thinking too big. Please try again.");
                            }
                            else if (UG < ran)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You're thinking too small. Please try again.");
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Please write a number between 1 and 50. Else I will kick you out of this game and you'll be killed by Himiko Toga.");
                        }
                    }


                    //+++++++++++++++++++++++++++++++++++++++++++
                    //Nachlauf
                    //+++++++++++++++++++++++++++++++++++++++++++
                    //
                    //z.B. Habe ich alle Dateien Closed, usw. usw.


                    Console.ForegroundColor = ConsoleColor.White;

                    if (attemps < 2)
                    {
                        Console.WriteLine("Wow, your're a cheater. You just got " + attemps + " attemps. Did you really just guessed the number or are you just a genius?!");
                    }
                    else if (attemps < 3)
                    {
                        Console.WriteLine("Wow, that was a good one. You got " + attemps + " attemps to guess the number. Wow, you're really a talent!");
                    }
                    else if (attemps < 4)
                    {
                        Console.WriteLine("Dude, you're really good. You just got " + attemps + " attemps. Just a little practice then you'll manage to get just one attemp. Sheeesh, I think that was just luck.");
                    }
                    else if (attemps < 5)
                    {
                        Console.WriteLine("Wow, that was nice. You got " + attemps + " attemps to guess the number. You just need a little practice, then you'll be a genius.");
                    }
                    else if (attemps < 6)
                    {
                        Console.WriteLine("Mh, well. You got " + attemps + " attemps to guess the secret number. Well with a little more practice you'll get better.");
                    }
                    else if (attemps < 7)
                    {
                        Console.WriteLine("Mh, that could be better. Well, you got " + attemps + " attemps to guess the number.");
                    }
                    else if (attemps < 8)
                    {
                        Console.WriteLine("Well, it could be better. You got " + attemps + " attemps too guess the number. Just a little more luck then you'll be better in this game.");
                    }
                    else if (attemps < 9)
                    {
                        Console.WriteLine("Hey, this game isn't so difficult. But well, you got " + attemps + " attemps. But it's okay, you can practice and get better! (≧∇≦)ﾉ");
                    }
                    else if (attemps < 10)
                    {
                        Console.WriteLine("Okay. That wasn't so hard, wasn't it? For that you needet " + attemps + " attemps to guess it. Well, now you can try it again, not?");
                    }
                    else if (attemps < 11)
                    {
                        Console.WriteLine("Finally, you got it! You had " + attemps + " attemps to guess the number! Phu, that was a close one...");
                    }
                    else if (attemps > 10)
                    {
                        Console.WriteLine("Nooo, you've lost. You had " + attemps + " attemps to guess the number, but you didn't manage to guess it in 10 attemps. I'm sorry, but you need to try again. With a little more luck you'll get it. ´U´");
                    }

                    Console.ReadKey();
                }



                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


                else if (choose == 100)
                {
                    Random randomNumber = new Random();
                    int rnd = randomNumber.Next(1, 101); //immer +1 für definierten Bereich

                    int attemps = -1;
                    int guess = 0;

                    Console.WriteLine("I think a number between 1 and 100. " +
                        "Guess the number by typing your number." +
                        "See if you can guess it in 10 turns or fewer. We'll tell you if your guess was too high or too low. " +
                        "At the end you'll get a little suprise...;)");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Are you ready?");
                    Console.Read();

                    Console.WriteLine(rnd);
                    Console.ReadKey();

                    Console.Clear();




                    //++++++++++++++++++++++++++++++++++++++++++++
                    //Hauptlogik/Hauptlauf
                    //++++++++++++++++++++++++++++++++++++++++++++


                    while (rnd != guess)
                    {
                        try
                        {
                            ++attemps;
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.Write("Eingabe: ");
                            guess = int.Parse(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.White;

                            if (guess == 666)
                            {
                                Console.WriteLine("Hey, you won't call the satan, right? So, now guess again, else you'll get killed by the chitauris!");
                            }
                            else if (guess == 69)
                            {
                                Console.WriteLine("Hey, you looser, stop that! It's not funny! Guess again!");
                            }
                            else if (guess == 143)
                            {
                                Console.WriteLine("Naww, I love you too. But now we don't have time for that, sorry honey :c. Please guess the number, so we can continue.");
                            }

                            else if (guess > rnd)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You're thinking too big. Please try again.");
                            }
                            else if (guess < rnd)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You're thinking too small. Please try again.");
                            }
                            else if (!(guess > 0 && guess <= 100))
                            {
                                throw new Exception();
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Please write a number between 1 and 100. Else I will kick you out of this game and you'll be killed by Natasha Romanoff... or Wanda Maximoff.");
                        }
                    }

                    //+++++++++++++++++++++++++++++++++++++++++++
                    //Nachlauf
                    //+++++++++++++++++++++++++++++++++++++++++++
                    //
                    //z.B. Habe ich alle Dateien Closed, usw. usw.


                    Console.ForegroundColor = ConsoleColor.White;

                    if (attemps < 2)
                    {
                        Console.WriteLine("Wow, your're a cheater. You just got " + attemps + " attemps. Did you really just guessed the number or are you just a genius?!");
                    }
                    else if (attemps < 3)
                    {
                        Console.WriteLine("Wow, that was a good one. You got " + attemps + " attemps to guess the number. Wow, you're really a talent!");
                    }
                    else if (attemps < 4)
                    {
                        Console.WriteLine("Dude, you're really good. You just got " + attemps + " attemps. Just a little practice then you'll manage to get just one attemp. Sheeesh, I think that was just luck.");
                    }
                    else if (attemps < 5)
                    {
                        Console.WriteLine("Wow, that was nice. You got " + attemps + " attemps to guess the number. You just need a little practice, then you'll be a genius.");
                    }
                    else if (attemps < 6)
                    {
                        Console.WriteLine("Mh, well. You got " + attemps + " attemps to guess the secret number. Well with a little more practice you'll get better.");
                    }
                    else if (attemps < 7)
                    {
                        Console.WriteLine("Mh, that could be better. Well, you got " + attemps + " attemps to guess the number.");
                    }
                    else if (attemps < 8)
                    {
                        Console.WriteLine("Well, it could be better. You got " + attemps + " attemps too guess the number. Just a little more luck then you'll be better in this game.");
                    }
                    else if (attemps < 9)
                    {
                        Console.WriteLine("Hey, this game isn't so difficult. But well, you got " + attemps + " attemps. But it's okay, you can practice and get better! (≧∇≦)ﾉ");
                    }
                    else if (attemps < 10)
                    {
                        Console.WriteLine("Okay. That wasn't so hard, wasn't it? For that you needet " + attemps + " attemps to guess it. Well, now you can try it again, not?");
                    }
                    else if (attemps < 11)
                    {
                        Console.WriteLine("Finally, you got it! You had " + attemps + " attemps to guess the number! Phu, that was a close one...");
                    }
                    else if (attemps > 10)
                    {
                        Console.WriteLine("Nooo, you've lost. You had " + attemps + " attemps to guess the number, but you didn't manage to guess it in 10 attemps. I'm sorry, but you need to try again. With a little more luck you'll get it. ´U´");
                    }

                    Console.ReadKey();
                }
            }
            catch
            {

            }

        }
        
    }
}

