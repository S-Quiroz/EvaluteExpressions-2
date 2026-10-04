using Backend.Math; // or the correct namespace

var infix = "4*5/(4+6)";
Console.WriteLine($"Infix: {infix}, Result: {ExpressionEvaluator.Evaluator.Evaluate(infix)}");              