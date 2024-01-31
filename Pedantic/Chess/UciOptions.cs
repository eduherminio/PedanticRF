﻿using System.Runtime.CompilerServices;

namespace Pedantic.Chess
{
    public static class UciOptions
    {
        // Prefix UCI_T_ is for tunable paramters
        internal const string OPT_CLEAR_HASH = "Clear Hash";
        internal const string OPT_CONTEMPT = "Contempt";
        internal const string OPT_HASH_TABLE_SIZE = "Hash";
        internal const string OPT_MOVE_OVERHEAD = "Move Overhead";
        internal const string OPT_OWN_BOOK = "OwnBook";
        internal const string OPT_PONDER = "Ponder";
        internal const string OPT_RANDOM_SEARCH = "RandomSearch";
        internal const string OPT_SYZYGY_PATH = "SyzygyPath";
        internal const string OPT_SYZYGY_PROBE_ROOT = "SyzygyProbeRoot";
        internal const string OPT_SYZYGY_PROBE_DEPTH = "SyzygyProbeDepth";
        internal const string OPT_THREADS = "Threads";
        internal const string OPT_ANALYSE_MODE = "UCI_AnalyseMode";
        internal const string OPT_ENGINE_ABOUT = "UCI_EngineAbout";
        internal const string OPT_OPPONENT = "UCI_Opponent";
        internal const string OPT_TM_BRANCH_FACTOR = "UCI_T_TM_BranchFactor";
        internal const string OPT_TM_DEF_MOVES_TO_GO = "UCI_T_TM_DefaultMovesToGo";
        internal const string OPT_TM_DEF_MOVES_TO_GO_PONDER = "UCI_T_TM_DefaultMovesToGo_Ponder";
        internal const string OPT_TM_DEF_MOVES_TO_GO_SUDDEN_DEATH = "UCI_T_TM_DefaultMovesToGo_SuddenDeath";
        internal const string OPT_TM_ABSOLUTE_LIMIT = "UCI_T_TM_AbsoluteLimit";
        internal const string OPT_TM_DIFFICULTY_MIN = "UCI_T_TM_DifficultyMin";
        internal const string OPT_TM_DIFFICULTY_MAX = "UCI_T_TM_DifficultyMax";

        static UciOptions()
        {
            options = new(initialOptions.Length);
            foreach (var opt in initialOptions)
            {
                options.Add(opt.Name, opt);
            }
        }

        public static int Contempt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_CONTEMPT];
                return opt.CurrentValue;
            }
        }

        public static int HashTableSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_HASH_TABLE_SIZE];
                return opt.CurrentValue;
            }
        }

        public static int MoveOverhead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_MOVE_OVERHEAD];
                return opt.CurrentValue;
            }
        }

        public static bool OwnBook
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionCheck opt = (UciOptionCheck)options[OPT_OWN_BOOK];
                return opt.CurrentValue;
            }
        }

        public static bool Ponder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionCheck opt = (UciOptionCheck)options[OPT_PONDER];
                return opt.CurrentValue;
            }
        }

        public static bool RandomSearch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionCheck opt = (UciOptionCheck)options[OPT_RANDOM_SEARCH];
                return opt.CurrentValue;
            }
        }

        public static string SyzygyPath
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionString opt = (UciOptionString)options[OPT_SYZYGY_PATH];
                return opt.CurrentValue;
            }
        }

        public static bool SyzygyProbeRoot
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionCheck opt = (UciOptionCheck)options[OPT_SYZYGY_PROBE_ROOT];
                return opt.CurrentValue;
            }
        }

        public static int SyzygyProbeDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_SYZYGY_PROBE_DEPTH];
                return opt.CurrentValue;
            }
        }

        public static int Threads
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_THREADS];
                return opt.CurrentValue;
            }
        }

        public static bool AnalyseMode
        {
            get
            {
                UciOptionCheck opt = (UciOptionCheck)options[OPT_ANALYSE_MODE];
                return opt.CurrentValue;
            }
        }

        public static int TmBranchFactor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_BRANCH_FACTOR];
                return opt.CurrentValue;
            }
        }

        public static int TmDefMovesToGo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_DEF_MOVES_TO_GO];
                return opt.CurrentValue;
            }
        }

        public static int TmDefMovesToGoPonder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_DEF_MOVES_TO_GO_PONDER];
                return opt.CurrentValue;
            }
        }

        public static int TmDefMovesToGoSuddenDeath
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_DEF_MOVES_TO_GO_SUDDEN_DEATH];
                return opt.CurrentValue;
            }
        }

        public static int TmAbsoluteLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_ABSOLUTE_LIMIT];
                return opt.CurrentValue;
            }
        }

        public static int TmDifficultyMin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_DIFFICULTY_MIN];
                return opt.CurrentValue;
            }
        }

        public static int TmDifficultyMax
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                UciOptionSpin opt = (UciOptionSpin)options[OPT_TM_DIFFICULTY_MAX];
                return opt.CurrentValue;
            }
        }

        public static void WriteLine()
        {
            foreach (var opt in Options)
            {
                Console.WriteLine(opt);
            }
        }

        public static IList<UciOptionBase> Options => options.Values;

        private static readonly SortedList<string, UciOptionBase> options;

        // UCI Options
        private static readonly UciOptionBase[] initialOptions =
        [
            new UciOptionButton(OPT_CLEAR_HASH),
            new UciOptionSpin(OPT_CONTEMPT, 0, -50, 50),
            new UciOptionSpin(OPT_HASH_TABLE_SIZE, 64, 16, 2048),
            new UciOptionSpin(OPT_MOVE_OVERHEAD, 25, 0, 1000),
            new UciOptionCheck(OPT_OWN_BOOK, false),
            new UciOptionCheck(OPT_PONDER, false),
            new UciOptionCheck(OPT_RANDOM_SEARCH, false),
            new UciOptionString(OPT_SYZYGY_PATH, string.Empty),
            new UciOptionCheck(OPT_SYZYGY_PROBE_ROOT, true),
            new UciOptionSpin(OPT_SYZYGY_PROBE_DEPTH, 2, 1, MAX_PLY - 1),
            new UciOptionSpin(OPT_THREADS, 1, 1, Environment.ProcessorCount),
            new UciOptionCheck(OPT_ANALYSE_MODE, false),
            new UciOptionString(OPT_ENGINE_ABOUT, $"{APP_NAME_VER} by {APP_AUTHOR}, see {PROGRAM_URL}"),
            new UciOptionString(OPT_OPPONENT, "none none computer generic engine"),
            new UciOptionSpin(OPT_TM_BRANCH_FACTOR, 30, 20, 40),
            new UciOptionSpin(OPT_TM_DEF_MOVES_TO_GO, 30, 20, 40),
            new UciOptionSpin(OPT_TM_DEF_MOVES_TO_GO_PONDER, 35, 20, 40),
            new UciOptionSpin(OPT_TM_DEF_MOVES_TO_GO_SUDDEN_DEATH, 40, 20, 40),
            new UciOptionSpin(OPT_TM_ABSOLUTE_LIMIT, 5, 2, 8),
            new UciOptionSpin(OPT_TM_DIFFICULTY_MIN, 60, 0, 60),
            new UciOptionSpin(OPT_TM_DIFFICULTY_MAX, 200, 100, 300)
        ];
    }
}
