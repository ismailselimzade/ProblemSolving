Solution solution = new();

// =========================================================================
// TESTS
// =========================================================================

TestArrayResult<Array>
(
    problemName: nameof(solution), // add solution.MethodName
    result: null!
);

TestValueResult<object>
(
    problemName: nameof(solution), // add solution.MethodName
    result: null!
);

// =========================================================================
// HELPER METHODS
// =========================================================================

static void TestArrayResult<T>(string problemName, IEnumerable<T> result)
{
    if (result == null)
    {
        Console.WriteLine($"[{problemName}] -> Result: [Null]");
    }
    else if (!result.Any())
    {
        Console.WriteLine($"[{problemName}] -> Result: [Boş / Tapılmadı]");
    }
    else
    {
        string output = string.Join(", ", result);
        Console.WriteLine($"[{problemName}] -> Result: [{output}]");
    }
}

static void TestValueResult<T>(string problemName, T result)
{
    if (result == null)
    {
        Console.WriteLine($"[{problemName}] -> Result: [Null]");
    }
    else
    {
        Console.WriteLine($"[{problemName}] -> Result: [{result}]");
    }
}