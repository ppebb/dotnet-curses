using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// functions for working with curses windows

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_bottom_panel(IntPtr pan);
        private static dt_bottom_panel call_bottom_panel = NativeToDelegate<dt_bottom_panel>("bottom_panel");
        internal static int bottom_panel(IntPtr pan) => call_bottom_panel(pan);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_ceiling_panel(IntPtr screen);
        private static dt_ceiling_panel call_ceiling_panel = NativeToDelegate<dt_ceiling_panel>("ceiling_panel");
        internal static IntPtr ceiling_panel(IntPtr screen) => call_ceiling_panel(screen);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_del_panel(IntPtr panel);
        private static dt_del_panel call_del_panel = NativeToDelegate<dt_del_panel>("del_panel");
        internal static int del_panel(IntPtr panel) => call_del_panel(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_ground_panel(IntPtr screen);
        private static dt_ground_panel call_ground_panel = NativeToDelegate<dt_ground_panel>("ground_panel");
        internal static IntPtr ground_panel(IntPtr screen) => call_ground_panel(screen);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_hide_panel(IntPtr panel);
        private static dt_hide_panel call_hide_panel = NativeToDelegate<dt_hide_panel>("hide_panel");
        internal static int hide_panel(IntPtr panel) => call_hide_panel(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_move_panel(IntPtr panel, int starty, int startx);
        private static dt_move_panel call_move_panel = NativeToDelegate<dt_move_panel>("move_panel");
        internal static int move_panel(IntPtr panel, int starty, int startx) => call_move_panel(panel, starty, startx);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_new_panel(IntPtr win);
        private static dt_new_panel call_new_panel = NativeToDelegate<dt_new_panel>("new_panel");
        internal static IntPtr new_panel(IntPtr win) => call_new_panel(win);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_panel_above(IntPtr panel);
        private static dt_panel_above call_panel_above = NativeToDelegate<dt_panel_above>("panel_above");
        internal static IntPtr panel_above(IntPtr panel) => call_panel_above(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_panel_below(IntPtr panel);
        private static dt_panel_below call_panel_below = NativeToDelegate<dt_panel_below>("panel_below");
        internal static IntPtr panel_below(IntPtr panel) => call_panel_below(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_panel_hidden(IntPtr panel);
        private static dt_panel_hidden call_panel_hidden = NativeToDelegate<dt_panel_hidden>("panel_hidden");
        internal static bool panel_hidden(IntPtr panel) => call_panel_hidden(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_panel_userptr(IntPtr panel);
        private static dt_panel_userptr call_panel_userptr = NativeToDelegate<dt_panel_userptr>("panel_userptr");
        internal static IntPtr panel_userptr(IntPtr panel) => call_panel_userptr(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_panel_window(IntPtr panel);
        private static dt_panel_window call_panel_window = NativeToDelegate<dt_panel_window>("panel_window");
        internal static IntPtr panel_window(IntPtr panel) => call_panel_window(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_replace_panel(IntPtr panel, IntPtr window);
        private static dt_replace_panel call_replace_panel = NativeToDelegate<dt_replace_panel>("replace_panel");
        internal static int replace_panel(IntPtr panel, IntPtr window) => call_replace_panel(panel, window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_set_panel_userptr(IntPtr panel, IntPtr userptr);
        private static dt_set_panel_userptr call_set_panel_userptr = NativeToDelegate<dt_set_panel_userptr>("set_panel_userptr");
        internal static int set_panel_userptr(IntPtr panel, IntPtr userptr) => call_set_panel_userptr(panel, userptr);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_show_panel(IntPtr panel);
        private static dt_show_panel call_show_panel = NativeToDelegate<dt_show_panel>("show_panel");
        internal static int show_panel(IntPtr panel) => call_show_panel(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_top_panel(IntPtr panel);
        private static dt_top_panel call_top_panel = NativeToDelegate<dt_top_panel>("top_panel");
        internal static int top_panel(IntPtr panel) => call_top_panel(panel);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_update_panels();
        private static dt_update_panels call_update_panels = NativeToDelegate<dt_update_panels>("update_panels");
        internal static int update_panels() => call_update_panels();
    }
}
