Func<int, int> TripleExpression = x => x*3;

Func<int, int> TripleStatement = number =>
{
    var result = number * 3;
    return result;
};

Console.WriteLine($"3 x 5 = {TripleStatement(5)}");