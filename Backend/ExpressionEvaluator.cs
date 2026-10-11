using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evaluate(string infix) => EvalutePostfix(ToPostfix(infix));

    private static string ToPostfix(string infix)
    {
        var posfix = string.Empty;
        var stack = new Stack<char>();
        /*foreach (var item in infix)
        {
            if (IsOperator(item))
            {
                if (item == ')')
                {
                    var ope = stack.Pop();
                    while(ope != '(')
                    {
                        posfix += ope;
                        ope = stack.Pop();
                    }
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            posfix += stack.Pop();
                            stack.Push(item);
                        }
                    }
                }
            }
            else
            {
                posfix += item;
            }
        }*/
        for (int i = 0; i < infix.Length;)
        {
            char item = infix[i];

            if (IsOperator(item))
            {
                if (item == ')')
                {
                    var ope = stack.Pop();
                    while (ope != '(')
                    {
                        posfix += ope;
                        ope = stack.Pop();
                    }
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            posfix += stack.Pop();
                            stack.Push(item);
                        }
                    }
                }
                i++;
            }
            else
            {
                string num = "";

                while (i < infix.Length && !IsOperator(infix[i]))
                {
                    num += infix[i];
                    i++;
                }
                posfix += num + " ";
            }
        }   
        do
        {
            posfix += stack.Pop();
        } while (stack.Count != 0);
        return posfix;
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();
        int i = 0;

        while (i < postfix.Length)
        {
            if (postfix[i] == ' ')
            {
                i++;
            }
            else if (!IsOperator(postfix[i]))
            {
                string num = "";

                while (i < postfix.Length &&
                       postfix[i] != ' ' &&
                       !IsOperator(postfix[i]))
                {
                    num += postfix[i];
                    i++;
                }

                stack.Push(double.Parse(num, System.Globalization.CultureInfo.InvariantCulture));
            }
            else
            {
                char item = postfix[i];

                var ope2 = stack.Pop();
                var ope1 = stack.Pop();

                stack.Push(Calculate(ope1, ope2, item));
                i++;
            }
        }

        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}
