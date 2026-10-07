Solution solution = new();

// =========================================================================
// TESTS
// =========================================================================

TestArrayResult(
    problemName: nameof(solution),
    result: null
);

// =========================================================================
// HELPER METHODS
// =========================================================================

static void TestArrayResult<T>(string problemName, IEnumerable<T> result)
{
    string output = result != null && result.Any() ? string.Join(", ", result) : "Boş / Null / Tapılmadı";
    Console.WriteLine($"[{problemName}] -> Result: [{output}]");
}