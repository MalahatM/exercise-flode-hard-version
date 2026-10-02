static class InputHelper
{
    // Get the user's menu choice.
    public static int GetChoice()
    {
        Console.Write("Enter your choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Get the user's message.
    public static string GetMessage()
    {
        string message = Console.ReadLine()!;
        return message;
    }
}