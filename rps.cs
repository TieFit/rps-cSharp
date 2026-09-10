using System;
					
public class Program
{
	public static void Main()
	{
		int roundsPlayed = 0;
		int userWins = 0;
		int computerWins = 0;
		int ties = 0;
		string result = "";
		
		while (roundsPlayed < 3) {
			char userChoice = GetUserChoice();
			char computerChoice = GetComputerChoice();
			
			switch (userChoice, computerChoice) {
				case ('r', 's'):
					Console.WriteLine("You win!");
					userWins++;
					break;
					
				case ('r', 'p'):
					Console.WriteLine("You lose!");
					computerWins++;
					break;
					
				case ('r', 'r'):
					Console.WriteLine("Tie!");
					ties++;
					break;
				
				case ('p', 'r'):
					Console.WriteLine("You win!");
					userWins++;
					break;
				
				case ('p', 's'):
					Console.WriteLine("You lose!");
					computerWins++;
					break;
				
				case ('p', 'p'):
					Console.WriteLine("Tie!");
					ties++;
					break;
				
				case('s', 'p'):
					Console.WriteLine("You win!");
					userWins++;
					break;
				
				case('s', 'r'):
					Console.WriteLine("You lose!");
					computerWins++;
					break;
				
				case('s', 's'):
					Console.WriteLine("Tie!");
					ties++;
					break;
			}
			roundsPlayed++;
		}
		
		if (userWins > computerWins) {
			result = "You won the game!";
		}
		else if (userWins < computerWins) {
			result = "You lost the game!";
		}
		else {
			result = "You tied!";
		}
		
		Console.WriteLine($"User Wins: {userWins}\nComputer Wins: {computerWins}\nTies: {ties}\n\nResult: {result}");
	}
	
	public static char GetUserChoice() {
		Console.Write("Enter your move: 'r', 'p', or 's': ");
		char playerChoice = char.Parse(Console.ReadLine());
		
		while (playerChoice != 'r' && playerChoice != 'p' && playerChoice != 's') {
			Console.Write("Invalid move, enter your move: 'r', 'p', or 's'");
			playerChoice = char.Parse(Console.ReadLine());
		}
		return playerChoice;
	}
	
	public static char GetComputerChoice() {
		string moves = "rps";
		char computerChoice = moves[Random.Shared.Next(moves.Length)];
									
		return computerChoice;
	}
}