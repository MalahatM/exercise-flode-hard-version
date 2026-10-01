class MessageDecoder
{
    public string Decode(string message)
    {
        string decodedMessage = "";

        // Go through the message one character at a time.
        foreach (char letter in message)
        {
            switch (letter)
            {
                case '@':
                    decodedMessage += 'A';
                    break;

                case '3':
                    decodedMessage += 'E';
                    break;

                case '!':
                    decodedMessage += 'I';
                    break;

                case '0':
                    decodedMessage += 'O';
                    break;

                case '$':
                    decodedMessage += 'S';
                    break;

                default:
                    // Keep all other characters unchanged.
                    decodedMessage += letter;
                    break;
            }
        }

        return decodedMessage;
    }
}