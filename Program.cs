int choice = 0;
while (choice != 3)
{
	Console.WriteLine("1. Encode a message");
Console.WriteLine("2. Decode a message");
Console.WriteLine("3. Exit");
Console.Write("Enter your choice: ");
choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
	{
		
		case 1:
			Console.Write("Enter the message to encode: ");
			string messageToEncode = Console.ReadLine();
			break;
			
	
		case 2:
			Console.Write("Enter the message to decode: ");
			string messageToDecode = Console.ReadLine();
			break;
			
	
		case 3:
			Console.WriteLine("Exiting the program.");
			break;
			
	}
}