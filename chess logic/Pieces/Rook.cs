﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_logic
{
    public class Knight : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Color { get; }

        public Knight(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Knight copy = new Rook(Color);
            copy HasMoved = HasMoved;
            return copy;

        }
    }
}