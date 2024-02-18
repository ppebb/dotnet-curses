using NativeLibraryLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

// The library handle is retrieved here instead of in Native because
// a constructor in Native would not run until the static fields are
// initialized, and the static fields reference the library handle,
// which causes a TypeInitializer null reference error.

namespace Mindmagma.Curses.Interop
{
    internal static class PanelLibraryHandle
    {
        internal static NativeLibrary lib = FindLibrary();

        private static NativeLibrary FindLibrary()
        {
            var defaults = new PanelLibraryNames();
            var custom = GetCustomLibraryNames();
            List<string> names;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                names = defaults.NamesWindows;
                if (custom != null)
                {
                    if (custom.ReplaceWindowsDefaults)
                    {
                        names = custom.NamesWindows;
                    }
                    else
                    {
                        names.AddRange(custom.NamesWindows);
                    }
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                names = defaults.NamesLinux;
                if (custom != null)
                {
                    if (custom.ReplaceLinuxDefaults)
                    {
                        names = custom.NamesLinux;
                    }
                    else
                    {
                        names.AddRange(custom.NamesLinux);
                    }
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                names = defaults.NamesOSX;
                if (custom != null)
                {
                    if (custom.ReplaceOSXDefaults)
                    {
                        names = custom.NamesOSX;
                    }
                    else
                    {
                        names.AddRange(custom.NamesOSX);
                    }
                }
            }
            else
            {
                throw new Exception("Unsupported OSPlatform, can't locate ncurses panel library.");
            }

            return new NativeLibrary(names.ToArray());
        }

        private static PanelLibraryNames GetCustomLibraryNames()
        {
            string cname = nameof(PanelLibraryNames).ToString();
            Type t_names = AppDomain.CurrentDomain.GetAssemblies()
                                    .SelectMany(t => t.GetTypes())
                                    .FirstOrDefault(t =>
                                        t.IsClass
                                        && !t.Name.Equals(cname)
                                        && typeof(PanelLibraryNames).IsAssignableFrom(t)
                                        && t.GetConstructor(Type.EmptyTypes) != null);

            return (t_names == null) ? null : (PanelLibraryNames)Activator.CreateInstance(t_names);
        }

    }
}
