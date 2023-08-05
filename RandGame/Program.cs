int number , num;
Random rand = new Random();
int guessed = rand.Next(1, 100);
bool cont = true;

do
{
    
   Console.WriteLine("Welcome To Random game, please write a number between 1 to 100");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == guessed)
        Console.WriteLine("Exellent ! ");
    else if (number > guessed)
        Console.WriteLine("Too High, choose another value ");
    else
        Console.WriteLine("Too low, choose another value");

    Console.WriteLine("Do you want to change the number ?\n 1-Yes\n2-No");
     num = Convert.ToInt32(Console.ReadLine());
    if(num == 1)
        guessed = rand.Next(1, 100);

    Console.WriteLine("Do you want to Quit ?\n 1-Yes\n2-No");
     num = Convert.ToInt32(Console.ReadLine());
    if(num == 1)
        cont = false;

} while (cont);