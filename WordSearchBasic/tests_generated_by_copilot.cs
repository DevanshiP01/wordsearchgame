@code {
    private void TestCanPlaceWord()
    {
        // Test case 1: Word fits in the grid horizontally
        bool result1 = CanPlaceWord("WORD", 0, 0, 0);
        // Expected: true
        Console.WriteLine($"Test case 1: {result1}");

        // Test case 2: Word fits in the grid vertically
        bool result2 = CanPlaceWord("WORD", 0, 0, 1);
        // Expected: true
        Console.WriteLine($"Test case 2: {result2}");

        // Test case 3: Word fits in the grid diagonally
        bool result3 = CanPlaceWord("WORD", 0, 0, 2);
        // Expected: true
        Console.WriteLine($"Test case 3: {result3}");

        // Test case 4: Word does not fit in the grid horizontally
        bool result4 = CanPlaceWord("LONGWORD", 8, 8, 0);
        // Expected: false
        Console.WriteLine($"Test case 4: {result4}");

        // Test case 5: Word does not fit in the grid vertically
        bool result5 = CanPlaceWord("LONGWORD", 8, 8, 1);
        // Expected: false
        Console.WriteLine($"Test case 5: {result5}");

        // Test case 6: Word does not fit in the grid diagonally
        bool result6 = CanPlaceWord("LONGWORD", 8, 8, 2);
        // Expected: false
        Console.WriteLine($"Test case 6: {result6}");
    }

    private void TestPlaceWord()
    {
        // Test case 1: Place word horizontally
        PlaceWord("WORD", 0, 0, 0);
        // Expected: board[0, 0] = 'W', board[0, 1] = 'O', board[0, 2] = 'R', board[0, 3] = 'D'

        // Test case 2: Place word vertically
        PlaceWord("WORD", 0, 0, 1);
        // Expected: board[0, 0] = 'W', board[1, 0] = 'O', board[2, 0] = 'R', board[3, 0] = 'D'

        // Test case 3: Place word diagonally
        PlaceWord("WORD", 0, 0, 2);
        // Expected: board[0, 0] = 'W', board[1, 1] = 'O', board[2, 2] = 'R', board[3, 3] = 'D'
    }

    private void TestSelectCell()
    {
        // Test case 1: Select a cell that is not already selected
        selectedCells.Clear();
        SelectCell(0, 0);
        // Expected: selectedCells contains (0, 0), currentWord = "W"

        // Test case 2: Select a cell that is already selected
        SelectCell(0, 0);
        // Expected: selectedCells remains unchanged, currentWord remains unchanged

        // Test case 3: Select multiple cells to form a word
        selectedCells.Clear();
        SelectCell(0, 0);
        SelectCell(0, 1);
        SelectCell(0, 2);
        SelectCell(0, 3);
        // Expected: selectedCells contains (0, 0), (0, 1), (0, 2), (0, 3), currentWord = "WORD"

        // Test case 4: Select a word that is in the list of words
        words = new List<string> { "WORD" };
        guessedCells.Clear();
        selectedCells.Clear();
        SelectCell(0, 0);
        SelectCell(0, 1);
        SelectCell(0, 2);
        SelectCell(0, 3);
        // Expected: words does not contain "WORD", guessedCells contains (0, 0), (0, 1), (0, 2), (0, 3), selectedCells is cleared

        // Test case 5: Select a word that is not in the list of words
        words = new List<string> { "WORD" };
        guessedCells.Clear();
        selectedCells.Clear();
        SelectCell(0, 0);
        SelectCell(0, 1);
        SelectCell(0, 2);
        SelectCell(0, 4);
        // Expected: words remains unchanged, guessedCells remains unchanged, selectedCells is cleared
    }

    private void TestClearSelection()
    {
        // Test case 1: Clear selection when selectedCells is not empty
        selectedCells = new List<(int, int)> { (0, 0), (0, 1), (0, 2) };
        ClearSelection();
        // Expected: selectedCells is cleared

        // Test case 2: Clear selection when selectedCells is already empty
        selectedCells.Clear();
        ClearSelection();
        // Expected: selectedCells remains empty
    }
}