using System;

namespace LausProject
{
	class MainClass
	{
		private static double  AdultTicket=5.00;
		private static double ChildTicket=2.50;
		private static double FamilyTicket=15.00;
		private static double Adultreturn=7.50;
		private static double Childreturn=5.00;
		private static int numAdult=0;
		private static int numChild=0;
		private static int numFamily=0;
		private static int numAdultreturn=0;
		private static int numChildreturn=0;
		private static int numTransactions=0;
		private static double extraZone = .40;
		private static int numZones=0;
		private static double transactionCost = 0;
		private static double TotalTakings=0;
		private static string RedZone;

		public static void Main (string[] args)
		{
			menu();
		}
		public static void admin ()
		{
			Console.WriteLine ("Number of Adult tickets " + numAdult);
			Console.WriteLine("Number of Child tickets " + numChild);
			Console.WriteLine("Number of Family tickets " + numFamily);
			Console.WriteLine("Number of Adult return tickets" + numAdultreturn);
			Console.WriteLine("Number of Child return tickets" + numChildreturn);
			Console.WriteLine ("Total Tickets Sold" + TotalTakings);
		}


		public static void addticket()
		{
			Console.WriteLine ("Do you want to add more tickets? If yes press M if no press P");
			string choice = Console.ReadLine ();

			switch (choice) 
			{
			case"M":
				{

					ticketMenu(1,"zone1");
					break;
				}
			case"P":
				{
					break;
				}
			}


		}
		public static void payment (double moneyEntered, string ticket)
		{
			Console.WriteLine ("Final Price is " + transactionCost);
			double Payed = Convert.ToDouble(Console.ReadLine());

			while (moneyEntered < transactionCost) 
			{
				Console.WriteLine ("Please enter remaining balance of " + (transactionCost - moneyEntered));
				moneyEntered = moneyEntered + Convert.ToDouble(Console.ReadLine());
			}

			if (moneyEntered > transactionCost) 
			{
				Console.WriteLine ("Change is " + (moneyEntered - transactionCost));
			}
			Console.WriteLine ("Transactions Complete. Please take your ticket");
			numTransactions++;

			if (ticket == "Adult")
			{
				numAdult++;
			}
			if (ticket == "Child")
			{
				numChild++;
			}
			if (ticket == "Family") 
			{
				numFamily++;
			}
		}

		public static void ticketMenu(int numZones, string zone)
		{
			Console.WriteLine ("Press 1 for an Adult ticket");
			Console.WriteLine ("Press 2 for an Child ticket");
			Console.WriteLine ("Press 3 for an Family ticket");
			Console.WriteLine ("Press 4 for an Child return ticket");
			Console.WriteLine ("Press 5 for an Adult return ticket");
			string choice = Console.ReadLine ();

			switch (choice)
			{
			case "1":
				{
					string ticket = "Adult";
					transactionCost += AdultTicket + (extraZone * numZones);
					payment (AdultTicket,ticket);
					break;
				}
			case "2":
				{
					string ticket = "Child";
					transactionCost += ChildTicket + (extraZone * numZones);
					payment (ChildTicket,ticket);
					break;
				}
			case "3":
				{
					string ticket = "Family";
					transactionCost += FamilyTicket + (extraZone * numZones);
					payment (FamilyTicket,ticket);
					break;
				}
			case "4":
				{
					string ticket = "Child Return";
					transactionCost += Childreturn + (extraZone * numZones);
					payment (Childreturn,ticket);
					break;
				}
			case "5":
				{
					string ticket = "Adult Return";
					transactionCost += Adultreturn + (extraZone * numZones);
					payment (Adultreturn,ticket);
					break;
				}
			}
		}


		public static void menu()
		{
			Console.WriteLine ("===========================");
			Console.WriteLine ("Welcome to the luas ticket machine. We hope you will enjoy you're ride with us ");
			Console.WriteLine ("===========================");
			Console.WriteLine ("Press 1 For Zone 1");
			Console.WriteLine("Press 2 for Zone 2");
			Console.WriteLine("Press 3 for Zone 3");
			Console.WriteLine("Press 4 for Zone 4");
			string choice = Console.ReadLine ();

			switch (choice) 
			{
			case "1":
				{
					ticketMenu(1,"zone1");
					break;
				}
			case "2":
				{
					ticketMenu(2,"zone2");
					break;
				}
			case "3":
				{
					ticketMenu(3,"zone3");
					break;
				}
			case "4":
				{
					ticketMenu(4,"zone4");
					break;
				}

			case "A":
				{
					admin ();
					break;
				}
			case "X":
				{
					Environment.Exit(0);
					break;
				}
			default:
				{
					Console.WriteLine("Invlid choice please choose 1, 2, 3 or 4 ");
					break;
				}

			}

			menu();
		}
	}
}


