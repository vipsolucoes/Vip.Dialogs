// Copyright � Sven Groot (Ookii.org) 2009
// BSD license; see license.txt for details.

using System;

namespace Vip.Dialogs
{
    /// <summary>
    ///     Provides data for the <see cref="TaskDialog.ExpandButtonClicked" /> event.
    /// </summary>
    /// <threadsafety instance="false" static="true" />
    public class ExpandButtonClickedEventArgs : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ExpandButtonClickedEventArgs" /> class with the specified expanded
        ///     state.
        /// </summary>
        /// <param name="expanded">
        ///     <see langword="true" /> if the the expanded content on the dialog is shown; otherwise,
        ///     <see langword="false" />.
        /// </param>
        public ExpandButtonClickedEventArgs(bool expanded)
        {
            Expanded = expanded;
        }

        /// <summary>
        ///     Gets a value that indicates if the expanded content on the dialog is shown.
        /// </summary>
        /// <value><see langword="true" /> if the expanded content on the dialog is shown; otherwise, <see langword="false" />.</value>
        public bool Expanded { get; }
    }
}