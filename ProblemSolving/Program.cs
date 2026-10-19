Solution solution = new();

// =========================================================================
// TESTS
// =========================================================================

// Kolleksiya (Massiv/List) şəklində cavab qaytaran problemlər üçün
TestArrayResult<Array>
(
    problemName: nameof(solution), // Metodun və ya problemin adını dəqiq görmək üçün
    result: null! // Yoxlamaq istədiyimiz metodu və dəyərləri göndəririk (solution.?)
);

// Tək dəyər tipli cavab qaytaran problemlər üçün
TestValueResult<object>
(
    problemName: nameof(solution.hourglassSum), // Metodun və ya problemin adını dəqiq görmək üçün
    result: solution.hourglassSum(new List<List<int>>
{
    new List<int> { -1, -1, 0, -9, -2, -2 },
    new List<int> { -2, -1, -6, -8, -2, -5 },
    new List<int> { -1, -1, -1, -2, -3, -4 },
    new List<int> { -1, -9, -2, -4, -4, -5 },
    new List<int> { -7 ,-3, -3, -2, -9, -9 },
    new List<int> { -1, -3, -1, -2, -4 ,-5 }
    }) // Yoxlamaq istədiyimiz metodu və dəyərləri göndəririk (solution.?)
);

// =========================================================================
// HELPER METHODS
// =========================================================================

// Kolleksiya (Massiv/List) şəklində cavab qaytaran problemlər üçün
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

// Tək dəyər tipli cavab qaytaran problemlər üçün
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