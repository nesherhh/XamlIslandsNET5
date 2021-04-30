// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using windows = Windows;

namespace Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT
{
    /// <summary>
    /// <see cref="windows.UI.Xaml.Controls.Maps.MapCustomExperience"/>
    /// </summary>
    public class MapCustomExperience
    {
        internal windows.UI.Xaml.Controls.Maps.MapCustomExperience UwpInstance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapCustomExperience"/> class, a
        /// Wpf-enabled wrapper for <see cref="windows.UI.Xaml.Controls.Maps.MapCustomExperience"/>
        /// </summary>
        public MapCustomExperience(windows.UI.Xaml.Controls.Maps.MapCustomExperience instance)
        {
            this.UwpInstance = instance;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="windows.UI.Xaml.Controls.Maps.MapCustomExperience"/> to <see cref="MapCustomExperience"/>.
        /// </summary>
        /// <param name="args">The <see cref="windows.UI.Xaml.Controls.Maps.MapCustomExperience"/> instance containing the event data.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator MapCustomExperience(
            windows.UI.Xaml.Controls.Maps.MapCustomExperience args)
        {
            return FromMapCustomExperience(args);
        }

        /// <summary>
        /// Creates a <see cref="MapCustomExperience"/> from <see cref="windows.UI.Xaml.Controls.Maps.MapCustomExperience"/>.
        /// </summary>
        /// <param name="args">The <see cref="windows.UI.Xaml.Controls.Maps.MapCustomExperience"/> instance containing the event data.</param>
        /// <returns><see cref="MapCustomExperience"/></returns>
        public static MapCustomExperience FromMapCustomExperience(windows.UI.Xaml.Controls.Maps.MapCustomExperience args)
        {
            return new MapCustomExperience(args);
        }
    }
}