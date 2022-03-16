
using TicTacToe.Utils;

namespace TicTacToe {
  public class Game {
    bool _hasAWinner = false;
    bool _isDrawMatch = false;
    PlayerType _currentPlayer;

    readonly SlotType[][] _grid = new SlotType[3][] {
      new SlotType[3] { SlotType.Unchecked, SlotType.Unchecked, SlotType.Unchecked },
      new SlotType[3] { SlotType.Unchecked, SlotType.Unchecked, SlotType.Unchecked },
      new SlotType[3] { SlotType.Unchecked, SlotType.Unchecked, SlotType.Unchecked },
    };

    public bool HasAWinner { get => _hasAWinner; }
    public bool IsDrawMatch { get => _isDrawMatch; }
    public char CurrentPlayer {
      get {
        return (char) _currentPlayer;
      }
    }

    public Game() {
      _currentPlayer = PlayerType.Circle;
    }

    public Game(PlayerType currentPlayer) {
      _currentPlayer = currentPlayer;
    }

    public void DisplayGrid() {
      Console.WriteLine($"{(char) _currentPlayer} player turn");
      foreach (var rows in _grid) {
        for (int columnIndex = 0; columnIndex < rows.Length; columnIndex++) {
          var columnContent = rows[columnIndex];
          var dynamicVerticalBar = columnIndex != 2 ? '|' : '\n';

          Console.Write($"{(char) columnContent}{dynamicVerticalBar}");
        }
      }
    }

    public void ChangeCurrentPlayer() {
      _currentPlayer = (_currentPlayer == PlayerType.Circle)
        ? PlayerType.Cross
        : PlayerType.Circle;
    }

    public void SelectSlotForCurrentPlayer() {
      var rowIndex = _promptRowIndex();
      var columnIndex = _promptColumnIndex();

      if (_grid[columnIndex][rowIndex] == SlotType.Unchecked) {
        _grid[columnIndex][rowIndex] = (SlotType) _currentPlayer;
        ChangeCurrentPlayer();
      } else {
        Console.WriteLine("Slot already selected !");
        DisplayGrid();
        SelectSlotForCurrentPlayer();
      }
    }

    bool _hasAlignedLines() {
      var hasVerticalLine = false;
      var hasHorizontalLine = false;

      foreach (var rows in _grid) {
        hasHorizontalLine = rows[0] == rows[1] && rows[1] == rows[2] && rows[0] != SlotType.Unchecked;
        Console.WriteLine(hasHorizontalLine);
        if (hasHorizontalLine) return true;
      }

      for (int i = 0; i < 3; i++) {
        hasVerticalLine = _grid[0][i] == _grid[1][i] && _grid[1][i] == _grid[2][i] && _grid[0][i] != SlotType.Unchecked;
        Console.WriteLine(hasVerticalLine);
        if (hasVerticalLine) return true;
      }

      var hasDiagonalUpToDownLine = _grid[0][0] == _grid[1][1] && _grid[1][1] == _grid[2][2] && _grid[1][1] != SlotType.Unchecked;
      var hasDiagonalDownToUpLine = _grid[0][2] == _grid[1][1] && _grid[1][1] == _grid[2][0] && _grid[1][1] != SlotType.Unchecked;

      return hasDiagonalUpToDownLine || hasDiagonalDownToUpLine;
    }

    public void DetectEndOfGame() {
      var isFilledGrid = _detectGridIsFilled();
      if (isFilledGrid) {
        _isDrawMatch = true;
      }

      _hasAWinner = _hasAlignedLines();
    }

    bool _detectGridIsFilled() {
      foreach (var rows in _grid) {
        foreach (var slot in rows) {
          if (slot == SlotType.Unchecked) return false;
        }
      }
      return true;
    }

    int _inputPlayerValue(String text) {
      Console.WriteLine(text);
      var inputValue = Console.ReadLine();

      try {
        if (inputValue is null) throw new FormatException();

        var index = Int32.Parse(inputValue);
        var indexInGridRange = index - 1 < 0 && index - 1 > 2;

        if (indexInGridRange) return _inputPlayerValue(text);
        return index;
      } catch (FormatException) {
        Console.WriteLine("Wrong input...");
        return _inputPlayerValue(text);
      }
    }

    int _promptRowIndex() {
      var rowIndex = _inputPlayerValue("Enter the line number");
      return rowIndex - 1;
    }

    int _promptColumnIndex() {
      var columnIndex = _inputPlayerValue("Enter the row number");
      return columnIndex - 1;
    }
  }
}