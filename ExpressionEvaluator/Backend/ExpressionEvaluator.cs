using System.Globalization;

namespace Backend;

public class ExpressionEvaluator
{
    public static double Evalute(StringInfo infix)
    {
        var postfix = ToPostfix(infix);
        return EvalutePostfix(postfix);
    }

    private static double EvalutePostfix(string postfix)
    {
        throw new NotImplementedException();
    }

    private static string ToPostfix(StringInfo infix)
    {
        throw new NotImplementedException();
    }
}
