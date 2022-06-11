using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeEngine
    {
        private int _currentPlayer = 1;
        private int[] _grid = new int[9];

        public void NewGame()
        {
            // Initialize board
            for (int i = 0; i < 9; i++)
            {
                _grid[i] = 0;
            }

            // Set current player to 1
            _currentPlayer = 1;
        }

        public void Place(int gridId)
        {
            // Mark the current player's entry in the grid ID
            _grid[gridId] = _currentPlayer;
            _currentPlayer++;
            if (_currentPlayer == 3)
            {
                _currentPlayer = 1;
            }
        }

        public int IsVictory()
        {
            // Returns -1 if draw
            // Returns 0 if still playing
            // Returns 1 if player 1 wins
            // Returns 2 if player 2 wins
        }
    }
}
