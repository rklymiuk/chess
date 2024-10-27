using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_logic
{
    public abstract class Piece
    { 
        public abstract PieceType Name { get; }
        public abstract PieceType Color { get; }
        public abstract HasMoved Type { get; set; } = false;

        public abstract Piece Copy();
    }
    
}
