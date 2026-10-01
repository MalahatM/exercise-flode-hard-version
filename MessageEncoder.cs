class MessageEncoder
{
    public string Encode(string message)
    {
        string encodedMessage = "";

        // Go through the message one character at a time.
        foreach (char letter in message)
        {
            switch (letter)
            {
                case 'A':
                    encodedMessage += '@';
                    break;

                case 'E':
                    encodedMessage += '3';
                    break;

                case 'I':
                    encodedMessage += '!';
                    break;

                case 'O':
                    encodedMessage += '0';
                    break;

                case 'S':
                    encodedMessage += '$';
                    break;

                default:
                    // Keep all other characters unchanged.
                    encodedMessage += letter;
                    break;
            }
        }

        return encodedMessage;
    }
}