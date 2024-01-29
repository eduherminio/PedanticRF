﻿using System.Runtime.CompilerServices;

namespace Pedantic.Chess
{
    public readonly struct KingBuckets
    {
        public readonly sbyte Friendly;
        public readonly sbyte Enemy;

        public KingBuckets(Board board)
        {
            SquareIndex friendlyKingSq = (SquareIndex)board.Pieces(board.SideToMove, Piece.King).TzCount;
            Friendly = friendlyKingSq.Normalize(board.SideToMove).Bucket();
            SquareIndex enemyKingSq = (SquareIndex)board.Pieces(board.Opponent, Piece.King).TzCount;
            Enemy = enemyKingSq.Normalize(board.Opponent).Bucket();
        }

        public KingBuckets(Color friendlyColor, SquareIndex friendlySq, SquareIndex enemySq)
        {
            Friendly = friendlySq.Normalize(friendlyColor).Bucket();
            Enemy = enemySq.Normalize(friendlyColor.Flip()).Bucket();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public KingBuckets(sbyte friendly, sbyte enemy)
        {
            Friendly = friendly;
            Enemy = enemy;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public KingBuckets Flip()
        {
            return new(Enemy, Friendly);
        }
    }
}
