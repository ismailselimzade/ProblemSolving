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
    problemName: nameof(solution.RomanToInt_Optimal), // Metodun və ya problemin adını dəqiq görmək üçün
    result: solution.RomanToInt_Optimal("MCMXCIV") // Yoxlamaq istədiyimiz metodu və dəyərləri göndəririk (solution.?)
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