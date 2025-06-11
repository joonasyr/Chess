﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace ChessUI
{
    public static class ChessCursors
    {
        public static readonly Cursor WhiteCursor = LoadCursor("assets/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("assets/CursorB.cur");
        private static Cursor LoadCursor(string filepath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filepath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
