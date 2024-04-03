Random rand  = new Random();

int randNum = rand.Next(11);
int numOfGuesses = 0;

Console.WriteLine("Choose a number: ");
int userNum = int.Parse(Console.ReadLine());
numOfGuesses++;

while ( userNum!= randNum){
    if(userNum < randNum){
    Console.WriteLine("Too Low");
    }else{

    Console.WriteLine("Too High");
    }
    Console.WriteLine("Choose a number: ");
    userNum = int.Parse(Console.ReadLine());
    numOfGuesses++;
}

Console.WriteLine("You Did It!");
Console.WriteLine("The number was "+ randNum);
Console.WriteLine("You Did it in "+ numOfGuesses+ " guesses");