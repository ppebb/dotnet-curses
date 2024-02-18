using System;
using Mindmagma.Curses.Interop;

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {
        public static void BottomPanel(IntPtr panel)
        {
            int result = Native.bottom_panel(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(BottomPanel));
        }

        public static IntPtr CeilingPanel(IntPtr screen)
        {
            IntPtr result = Native.ceiling_panel(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(CeilingPanel));
            return result;
        }

        public static void DeletePanel(IntPtr panel)
        {
            int result = Native.del_panel(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeletePanel));
        }

        public static IntPtr GroundPanel(IntPtr screen)
        {
            IntPtr result = Native.ground_panel(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(GroundPanel));
            return result;
        }

        public static void HidePanel(IntPtr panel)
        {
            int result = Native.hide_panel(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(HidePanel));
        }

        public static void MovePanel(IntPtr panel, int starty, int startx)
        {
            int result = Native.move_panel(panel, starty, startx);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MovePanel));
        }

        public static IntPtr NewPanel(IntPtr win)
        {
            IntPtr result = Native.new_panel(win);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NewPanel));
            return result;
        }

        public static IntPtr PanelAbove(IntPtr panel)
        {
            IntPtr result = Native.panel_above(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PanelAbove));
            return result;
        }

        public static IntPtr PanelBelow(IntPtr panel)
        {
            IntPtr result = Native.panel_below(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PanelBelow));
            return result;
        }

        public static bool PanelHidden(IntPtr panel)
        {
            bool result = Native.panel_hidden(panel);
            return result;
        }

        public static IntPtr PanelUserPointer(IntPtr panel)
        {
            IntPtr result = Native.panel_userptr(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PanelUserPointer));
            return result;
        }

        public static IntPtr PanelWindow(IntPtr panel)
        {
            IntPtr result = Native.panel_window(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PanelWindow));
            return result;
        }

        public static void ReplacePanel(IntPtr panel, IntPtr window)
        {
            int result = Native.replace_panel(panel, window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ReplacePanel));
        }

        public static void SetPanelUserPointer(IntPtr panel, IntPtr userPointer)
        {
            int result = Native.replace_panel(panel, userPointer);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SetPanelUserPointer));
        }

        public static void ShowPanel(IntPtr panel)
        {
            int result = Native.show_panel(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ShowPanel));
        }

        public static void TopPanel(IntPtr panel)
        {
            int result = Native.top_panel(panel);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(TopPanel));
        }

        public static void UpdatePanels()
        {
            int result = Native.update_panels();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(HidePanel));
        }
    }
}
