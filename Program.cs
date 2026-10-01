// This is a simple console application that allows the user
// to encode and decode messages.

int choice = 0;

// Keep showing the menu until the user chooses Exit.
while (choice != 3)
{
    Console.WriteLine("1. Encode a message");
    Console.WriteLine("2. Decode a message");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    choice = Convert.ToInt32(Console.ReadLine());

    // Handle the user's choice.
    switch (choice)
    {
        case 1:
            Console.Write("Enter the message to encode: ");
            string messageToEncode = Console.ReadLine()!;

            // Create an object from MessageEncoder.
            MessageEncoder encoder = new MessageEncoder();

            // Send the message to the Encode method.
            string encodedMessage = encoder.Encode(messageToEncode);

            // Show the encoded result.
            Console.WriteLine($"Encoded message: {encodedMessage}");
            break;

        case 2:
            Console.Write("Enter the message to decode: ");
            string messageToDecode = Console.ReadLine()!;
            break;

        case 3:
            Console.WriteLine("Exiting the program.");
            break;
    }
}