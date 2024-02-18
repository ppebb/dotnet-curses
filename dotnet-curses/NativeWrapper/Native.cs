using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// internal support, curses functions are referenced in the other partial classes

// ncurses export list
// http://invisible-island.net/ncurses/man/ncurses.3x.html#h3-Routine-Name-Index

// depends upon a modified version of this project until .NET adds this capability
// https://github.com/mellinoe/nativelibraryloader
// https://github.com/dotnet/corefx/issues/17135

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        private static D NativeToDelegate<D>(string exportedFunctionName)
        {
            if (NCursesLibraryHandle.lib.LoadFunction<D>(exportedFunctionName, out D function))
            {
                return function;
            }
            else if (PanelLibraryHandle.lib.LoadFunction<D>(exportedFunctionName, out D function1))
            {
                return function1;
            }

            throw new InvalidOperationException($"No function was found with the name {exportedFunctionName}.");
        }

        private static int MarshalInt(string exportedSymbolName)
        {
            IntPtr address = NCursesLibraryHandle.lib.LoadFunction(exportedSymbolName);
            return (int)Marshal.PtrToStructure(address, typeof(int));
        }

    }
}
