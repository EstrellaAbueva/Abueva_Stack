public class BalancedBrackets
{
    /// <summary>
    /// Check if both characters are a pair.
    /// </summary>
    /// <param name="char1">first charactrer</param>
    /// <param name="char2">second character</param>
    /// <returns>Boolen data type
    ///             true - if they match
    ///             false - if they don't match
    /// </returns>
    public static Boolean isMatchingPair(char char1, char char2)
    {
        if (char1 == '(' && char2 == ')')
            return true;
        else if (char1 == '{' && char2 == '}')
            return true;
        else if (char1 == '[' && char2 == ']')
            return true;
        else
            return false;
    }

    /// <summary>
    /// Pushing the input in the stack if they are opening at the same time popping if the character 
    /// that is in the topn of the stack is the closing of the current character.
    /// </summary>
    /// <param name="input">Character array containing brackets, parenthesis, and square brackets.</param>
    /// <returns>Boolen data type
    ///             true - if the stack is empty
    ///             false - if stack is not empty
    /// </returns>
    public static Boolean BracketsBalanced(char[] input)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '{' || input[i] == '(' || input[i] == '[')
            {
                stack.Push(input[i]);
            }

            if (input[i] == '}' || input[i] == ')' || input[i] == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                else if (!isMatchingPair(stack.Pop(),input[i]))
                {
                    return false;
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Checlks the string if it is a palindrome or not.
    /// </summary>
    /// <param name="input">the string to chec</param>
    /// <returns>Boolen data type
    ///             true - if it is a palindrome
    ///             false - if it is not a palindrome
    /// </returns>
    static Boolean Palindrome(string input)
    {
        Stack<char> stack = new Stack<char>();

        int i, middle = input.Length / 2;

        for(i = 0; i < middle; i++)
        {
            stack.Push(input[i]);
        }

        if (input.Length % 2 != 0)
        {
            i++; //skip if odd
        }

        while (i < input.Length)
        {
            char element = stack.Peek();

            if (element == input[i])
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
            i++;
        }

        return true;
    }

    public static void Main(String[] args)
    {
        int input2 = 1;

        while (input2 == 1)
        {
            Console.Write("Input: ");
            string? input = Console.ReadLine();

            Console.Write("\nChoose if\n\t1 - Balanced Parenthesis\n\t2 - Palindrome\nChoice: ");
            int choose = Convert.ToInt32(Console.ReadLine());
        
            switch (choose)
            {
                case 1:
                    char[] inp = new char[input.Length];

                    for (int i = 0; i < input.Length; i++)
                    {
                        inp[i] = input[i];
                    }

                    Console.Write("Result: ");
                    if (BracketsBalanced(inp))
                        Console.WriteLine("Balanced!Accepted.");
                    else
                        Console.WriteLine("Not Balanced!Not Accepted.");

                    break;
                case 2:
                    Console.Write("Result: ");
                    if (Palindrome(input))
                        Console.WriteLine("Balanced!Accepted.");
                    else
                        Console.WriteLine("Not Balanced!Not Accepted.");
                    break;

            }

            Console.WriteLine("\n\tDo you want to continue: \n\t1 - Yes\n\t2 - No");
            Console.Write("Choice: ");
            input2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}

