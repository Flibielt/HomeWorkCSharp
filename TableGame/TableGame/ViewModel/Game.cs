using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableGame.Model;

namespace TableGame.ViewModel
{
    class Game
    {
        private Table table;
        private PlayerState playerState;

        public Game()
        {
            table = new Table();
            playerState = new PlayerState();
        }

        public bool IsGoal()
        {
            return (playerState.GetRow() == 7) && (playerState.GetCol() == 7);
        }

        public void Step(Direction direction)
        {
            int distance = GetTableElement(GetCurrentRow(), GetCurrentCol());
            if (!playerState.ForbiddenDirection.Equals(direction))
            {
                playerState.UpdateState(direction, distance);
            }
        }

        public string Name
        {
            get
            {
                return playerState.Name;
            }

            set
            {
                playerState.Name = value;
            }
        }

        public int GetTableElement(int row, int col)
        {
            return table.GetElement(row, col);
        }

        public int GetCurrentRow()
        {
            return playerState.GetRow();
        }

        public int GetCurrentCol()
        {
            return playerState.GetCol();
        }
    }
}
