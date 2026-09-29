Main();

static void Main()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("Select an option: \n1 - encrypt text \n2 - decrypt text \n0 - End");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Enter a string: ");
            string String = Console.ReadLine();
            Console.WriteLine("Enter number of rotations");
            int k = Convert.ToInt32(Console.ReadLine());

             string encrypted = Encrypt(String, k);
            break;
        case 2:
            Console.WriteLine("Enter a string: ");
            string String1 = Console.ReadLine();
            Console.WriteLine("Enter number of rotations");
            int k1 = Convert.ToInt32(Console.ReadLine());

            string decrypted = Decrypt(String1, k1);
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Please enter a valid option");
            break;
    }
}

static string Encrypt(string words, int k)
{
    string original = words;
    string encrypted = "";

    try
    {
        if(k <= 0 || k >= 100)
        {
            throw new Exception("Rotation should be between 1 and 100");
        }

        for (int i = 0; i < words.Length; i++)
        {
            char c = words[i];

            if (char.IsLetter(c))
            {
                char before = char.IsUpper(c) ? 'A' : 'a';
                char encryptedChar = (char)((c - before + k) % 26 + before);
                encrypted = encrypted + encryptedChar;
            }
            else
            {
                encrypted += c;
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine($"The sentence you inputted is: {original}");
    Console.WriteLine($"The encrypted sentence is now:  {encrypted}");

    return encrypted;
}

static string Decrypt(string words, int k)
{
    string decrypt = words;
    string original = "";

    try
    {
        if (k <= 0 || k >= 100)
        {
            throw new Exception("Rotation should be between 1 and 100");
        }

        for (int i = 0; i < words.Length; i++)
        {
            char c = words[i];

            if (char.IsLetter(c))
            {
                char before = char.IsUpper(c) ? 'A' : 'a';
                char decryptedChar = (char)((c - before - k) % 26 + before);
                original = original + decryptedChar;
            }
            else
            {
                original += c;
            }

        } 
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine($"The sentence you inputted is: {decrypt}");
    Console.WriteLine($"The encrypted sentence is now:  {original}");
            

    return original;
}





//COUNTWORDS TASK
    //int count = 0;

    //for(int i = 0; i < String.Length; i++)
    //{
    //    if (char.IsUpper(String[i]))
    //    {
    //        count++;
    //    }
    //}