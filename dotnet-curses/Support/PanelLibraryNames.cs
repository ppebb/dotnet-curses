using System.Collections.Generic;

namespace Mindmagma.Curses
{
    /// <summary>
    /// A library client can implement this interface to expand or
    /// replace the default Ncurses panel library names on each target OS.
    /// </summary>
    public class PanelLibraryNames
    {
        /// <summary>
        /// Defaults to false, override this to set it to true which ignores
        /// the default Ncurses panel library names built into dotnet-curses for
        /// OSPlatform.Windows.
        /// </summary>
        public virtual bool ReplaceWindowsDefaults => false;

        /// <summary>
        /// The list of default Ncurses panel library names built into dotnet-curses
        /// for OSPlatform.Windows. Override this to add to the defaults, or
        /// also override the Replace property to replace the defaults.
        /// </summary>
        public virtual List<string> NamesWindows => new List<string> { "libpanelw6" };

        /// <summary>
        /// Defaults to false, override this to set it to true which ignores
        /// the default Ncurses panel library names built into dotnet-curses for
        /// OSPlatform.Linux.
        /// </summary>
        public virtual bool ReplaceLinuxDefaults => false;

        /// <summary>
        /// The list of default Ncurses panel library names built into dotnet-curses
        /// for OSPlatform.Linux. Override this to add to the defaults, or
        /// also override the Replace property to replace the defaults.
        /// </summary>
        public virtual List<string> NamesLinux => new List<string> { "libpanel.so" };

        /// <summary>
        /// Defaults to false, override this to set it to true which ignores
        /// the default Ncurses panel library names built into dotnet-curses for
        /// OSPlatform.OSX.
        /// </summary>
        public virtual bool ReplaceOSXDefaults => false;

        /// <summary>
        /// The list of default Ncurses panel library names built into dotnet-curses
        /// for OSPlatform.OSX. Override this to add to the defaults, or
        /// also override the Replace property to replace the defaults.
        /// </summary>
        public virtual List<string> NamesOSX => new List<string> { "libpanel.dylib" };
    }
}
