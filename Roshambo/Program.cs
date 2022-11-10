using Roshambo;


HumanPlayer player = new HumanPlayer();
RandomPlayer randomPlayer = new RandomPlayer();
RockPlayer rockPlayer = new RockPlayer();

rockPlayer.Name = "The Rock";
randomPlayer.Name = "Steve";


Console.WriteLine("Let play some Roshambo");

try
{
    Console.WriteLine("What is your name?");
    player.Name = Convert.ToString(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Invalid Input");
}


while (true)
{
    Console.WriteLine($"{player.Name}, who would you like to play? {rockPlayer.Name} or {randomPlayer.Name}");
    string opponent = Convert.ToString(Console.ReadLine()).ToLower();

    Console.WriteLine("What are your going throw? Rock, Paper, Scissors");
    string playersChoice = Convert.ToString(Console.ReadLine()).ToLower();

    if (opponent.ToLower() == "the rock")
    {
        
        var alwaysRock = rockPlayer.GenerateRoshambo();


        if (playersChoice.ToLower() == "rock" && alwaysRock == Player.Roshambo.Rock)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{rockPlayer.Name} throws: {alwaysRock}");
            Console.WriteLine("You tie!");
        }
        else if (playersChoice.ToLower() == "paper" && alwaysRock == Player.Roshambo.Rock)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{rockPlayer.Name} throws: {alwaysRock}");
            Console.WriteLine($"{player.Name} wins!!");
        }
        else if (playersChoice.ToLower() == "scissors" && alwaysRock == Player.Roshambo.Rock)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{rockPlayer.Name} throws: {alwaysRock}");
            Console.WriteLine($"{rockPlayer.Name} wins");
        }
    }
    else if (opponent.ToLower() == "steve")
    {
        
        var thrown = randomPlayer.GenerateRoshambo();

        if (playersChoice.ToLower() == "rock" && thrown == Player.Roshambo.Rock)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine("You tie!");
        }
        else if (playersChoice.ToLower() == "paper" && thrown == Player.Roshambo.Rock)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"{player.Name} wins!!");
        }
        else if (playersChoice.ToLower() == "scissors" && thrown == Player.Roshambo.Rock)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"{randomPlayer.Name} wins");
        }
        if (playersChoice.ToLower() == "rock" && thrown == Player.Roshambo.Paper)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"{randomPlayer.Name} Wins!");
        }
        else if (playersChoice.ToLower() == "paper" && thrown == Player.Roshambo.Paper)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"You Tie!");
        }
        else if (playersChoice.ToLower() == "scissors" && thrown == Player.Roshambo.Paper)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"{player.Name} wins");
        }
        if (playersChoice.ToLower() == "rock" && thrown == Player.Roshambo.Scissors)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"{player.Name} wins!");
        }
        else if (playersChoice.ToLower() == "paper" && thrown == Player.Roshambo.Scissors)
        {
            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine($"{randomPlayer.Name} wins!!");
        }
        else if (playersChoice.ToLower() == "scissors" && thrown == Player.Roshambo.Scissors)
        {

            Console.WriteLine($"{player.Name} throws: {playersChoice}");
            Console.WriteLine($"{randomPlayer.Name} throws: {thrown}");
            Console.WriteLine("You tie!");
        }

       
    }
        Console.WriteLine("Do you want to play again? y/n");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "y")
        {
            continue;
        }
        else
        {
            break;
        }

}