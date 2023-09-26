

using System.Collections;

var numbers = GetNumbers();
IEnumerator<int> enumerator = numbers.GetEnumerator();

while (enumerator.MoveNext())
{
    int item = enumerator.Current;
    Console.WriteLine(item);
}

foreach (var number in GetNumbersOrdinary().Take(10))
{
    Console.WriteLine(number);
}

foreach (var number in GetNumbersYield().Take(10))
{
    Console.WriteLine(number);
}

IEnumerable<int> GetNumbersYield()
{
    int i = 0;

    while (true)
    {
        yield return ++i;
    }
}

IEnumerable<int> GetNumbersOrdinary()
{
    int i = 0;
    var res = new List<int>();

    while (i < 10000000)
    {
        res.Add(++i);
    }

    return res;
}

IEnumerable<int> GetNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
}