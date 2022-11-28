public class BalancedBrackets
{
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
            stack.Pop();

            if (element != input[i])
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

