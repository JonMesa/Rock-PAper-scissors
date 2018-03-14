/*
 * Created by SharpDevelop.
 * User: 0260704
 * Date: 3/14/2018
 * Time: 10:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace porn_hubfaggoty
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Rock Paper Scissors!");
			Console.ReadLine();
			Console.WriteLine("Make your choice!");
			gameFunc();
			
			Console.Write("Press any key to continue . . .");
			Console.ReadKey(true);
			
			
			
			
		
		}
		public static void gameFunc()
		{
			Random rand = new Random
				
			string rock = "ROCK";
			string paper = "PAPER";
			string scissors = "SCISSORS";
			string choice = Console.ReadLine();
			
			int random = rand.Next(1, 4);
			choice = choice.ToUpper();
			
			switch (random) 
			{
				case 1:
					if(choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us->" + rock +"./n");
						Console.WriteLine("Issa tie");
						
					} 
					else if (choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us->" + rock +"./n");
						Console.WriteLine("You win!");
					} 
					else if(choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us->" + rock +"./n");
						Console.WriteLine("You lose!");
					}
					else
					{
						Console.WriteLine(choice + " IS NOT A CHOICE");
					}
					break;
					
				case 2: 
						if(choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us->" + scissors +"./n");
						Console.WriteLine("You Win!");
						
					} 
					else if (choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us->" + scissors +"./n");
						Console.WriteLine("You Lose");
					} 
					else if(choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us->" + scissors +"./n");
						Console.WriteLine("Issa tie");
					}
					else
					{
						Console.WriteLine(choice + " IS NOT A CHOICE");
					}
					break;
					
				default:
						if(choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us->" + rock +"./n");
						Console.WriteLine("Issa tie");
						
					} 
					else if (choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us->" + rock +"./n");
						Console.WriteLine("You win!");
					} 
					else if(choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us->" + rock +"./n");
						Console.WriteLine("You lose!");
					}
					else
					{
						Console.WriteLine(choice + " IS NOT A CHOICE");
					}
					break;
			}
			
			Console.ReadLine();
		
		}
	}
}